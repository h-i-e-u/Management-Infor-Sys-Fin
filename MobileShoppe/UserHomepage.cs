using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Data;


namespace MobileShoppe
{
    public partial class UserHomepage : Form
    {
        public UserHomepage()
        {
            InitializeComponent();
            this.Icon = new Icon("Resources\\app_icon.ico");

        }

        private void UserHomepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //Load data
        private void UserHomepage_Load(object sender, EventArgs e)
        {
            // sale
            SalesEntry_Load();
            // view stock 
            ViewStock_Load();
        }

        // sale
        private void SalesEntry_Load()
        {
            LoadSalesCompanies();
        }
        private void LoadSalesCompanies()
        {
            cmbSalesCompany.Items.Clear();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MobileShoppeCon"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("SELECT CompName FROM tbl_Company", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbSalesCompany.Items.Add(dr["CompName"].ToString());
                }
            }
        }

        private void cmbSalesCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSalesModel.Items.Clear();
            cmbIMEI.Items.Clear();

            if (cmbSalesCompany.SelectedIndex == -1) return;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MobileShoppeCon"].ToString()))
            {
                string query = @"
            SELECT ModelNum 
            FROM tbl_Model M 
            INNER JOIN tbl_Company C ON M.CompID = C.CompID 
            WHERE C.CompName = @name 
            AND M.AvailableQty > 0";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", cmbSalesCompany.Text);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbSalesModel.Items.Add(dr["ModelNum"].ToString());
                }
            }
        }

        private void cmbSalesModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIMEI.Items.Clear();
            lblPrice.Text = "0.00";

            if (cmbSalesModel.SelectedIndex == -1) return;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MobileShoppeCon"].ToString()))
            {
                string query = @"
            SELECT IMEINO, Price 
            FROM tbl_Mobile 
            WHERE ModelID = (
                SELECT ModelID FROM tbl_Model WHERE ModelNum = @model
            ) 
            AND Status = 'Not Sold'";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@model", cmbSalesModel.Text);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbIMEI.Items.Add(dr["IMEINO"].ToString());
                }
            }
        }

        private void cmbIMEI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIMEI.SelectedIndex == -1) return;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MobileShoppeCon"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("SELECT Price FROM tbl_Mobile WHERE IMEINO = @imei", conn);
                cmd.Parameters.AddWithValue("@imei", cmbIMEI.Text);

                conn.Open();
                object result = cmd.ExecuteScalar();
                lblPrice.Text = $"{result:C}";
            }
        }

        private void btnSubmitSale_Click(object sender, EventArgs e)
        {
            // Validate all fields
            if (cmbIMEI.SelectedIndex == -1 ||
                string.IsNullOrEmpty(txtCustomerName.Text) ||
                !Regex.IsMatch(txtMobileNo.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Customer name required! \nMobile No must be 10\nIMEI required!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MobileShoppeCon"].ToString()))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Insert customer
                    SqlCommand custCmd = new SqlCommand(
                        @"INSERT INTO tbl_Customer (CustName, MobileNo, Email, Address) 
                  VALUES (@name, @mobile, @email, @addr);
                  SELECT SCOPE_IDENTITY();",
                        conn, transaction);

                    custCmd.Parameters.AddWithValue("@name", txtCustomerName.Text);
                    custCmd.Parameters.AddWithValue("@mobile", txtMobileNo.Text);
                    custCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    custCmd.Parameters.AddWithValue("@addr", txtAddress.Text);

                    int custID = Convert.ToInt32(custCmd.ExecuteScalar());

                    // 2. Insert sale
                    SqlCommand saleCmd = new SqlCommand(
                        @"INSERT INTO tbl_Sales (IMEINO, Price, CustID) 
                  VALUES (@imei, @price, @cust)",
                        conn, transaction);

                    saleCmd.Parameters.AddWithValue("@imei", cmbIMEI.Text);
                    saleCmd.Parameters.AddWithValue("@price", decimal.Parse(lblPrice.Text, NumberStyles.Currency));
                    saleCmd.Parameters.AddWithValue("@cust", custID);
                    saleCmd.ExecuteNonQuery();

                    // 3. Update mobile status
                    SqlCommand mobileCmd = new SqlCommand(
                        "UPDATE tbl_Mobile SET Status = 'Sold' WHERE IMEINO = @imei",
                        conn, transaction);
                    mobileCmd.Parameters.AddWithValue("@imei", cmbIMEI.Text);
                    mobileCmd.ExecuteNonQuery();

                    // 4. Update stock quantity
                    SqlCommand stockCmd = new SqlCommand(
                        @"UPDATE tbl_Model 
                  SET AvailableQty = AvailableQty - 1 
                  WHERE ModelID = (
                      SELECT ModelID FROM tbl_Mobile WHERE IMEINO = @imei
                  )",
                        conn, transaction);
                    stockCmd.Parameters.AddWithValue("@imei", cmbIMEI.Text);
                    stockCmd.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Sale processed successfully!");

                    // Clear form
                    cmbIMEI.SelectedIndex = -1;
                    txtCustomerName.Clear();
                    txtMobileNo.Clear();
                    txtEmail.Clear();
                    txtAddress.Clear();
                    lblPrice.Text = "-------------";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error processing sale: {ex.Message}");
                }
            }
        }

        // Check Stock
        private void ViewStock_Load()
        {
            LoadStockCompanies();
        }

        private void LoadStockCompanies()
        {
            cmbStockCompany.Items.Clear();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MobileShoppeCon"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("SELECT CompName FROM tbl_Company", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbStockCompany.Items.Add(dr["CompName"].ToString());
                }
            }
        }

        private void cmbStockCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStockModel.Items.Clear();
            txtAvailableQty.Clear();

            if (cmbStockCompany.SelectedIndex == -1) return;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MobileShoppeCon"].ToString()))
            {
                string query = @"
            SELECT ModelNum 
            FROM tbl_Model M 
            INNER JOIN tbl_Company C ON M.CompID = C.CompID 
            WHERE C.CompName = @name";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", cmbStockCompany.Text);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbStockModel.Items.Add(dr["ModelNum"].ToString());
                }
            }
        }

        private void cmbStockModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStockModel.SelectedIndex == -1) return;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MobileShoppeCon"].ToString()))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT AvailableQty FROM tbl_Model WHERE ModelNum = @model",
                    conn);
                cmd.Parameters.AddWithValue("@model", cmbStockModel.Text);

                conn.Open();
                object result = cmd.ExecuteScalar();
                txtAvailableQty.Text = result?.ToString() ?? "0";
            }
        }


        // search customer by IMEI
        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(txtSearchIMEI.Text, @"^\d{16}$"))
            {
                MessageBox.Show("Please enter a valid 16 digit IMEI number");
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MobileShoppeCon"].ToString()))
            {
                string query = @"
            SELECT 
                C.CustName AS 'Customer Name',
                C.MobileNo AS 'Mobile',
                C.Email AS 'Email',
                S.PurchaseDate AS 'Purchase Date',
                FORMAT(S.Price, 'C') AS 'Amount',
                Co.CompName AS 'Company',
                M.ModelNum AS 'Model'
            FROM tbl_Sales S
            INNER JOIN tbl_Customer C ON S.CustID = C.CustID
            INNER JOIN tbl_Mobile Mb ON S.IMEINO = Mb.IMEINO
            INNER JOIN tbl_Model M ON Mb.ModelID = M.ModelID
            INNER JOIN tbl_Company Co ON M.CompID = Co.CompID
            WHERE S.IMEINO = @imei";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@imei", txtSearchIMEI.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCustomerResults.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No sales found for this IMEI");
                }
            }
        }
    }
}
