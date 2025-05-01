using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Text.RegularExpressions;
//using ExcelInterop = Microsoft.Office.Interop.Excel;
using ClosedXML;
using ClosedXML.Excel;


namespace MobileShoppe
{
    public partial class AdminHomepage : Form
    {
        public AdminHomepage()
        {
            InitializeComponent();
            this.Icon = new Icon("Resources\\app_icon.ico");

        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MobileShoppeCon"].ToString());

        private void AdminHomepage_Load(object sender, EventArgs e)
        {
            LoadCompanies();
            AutoGenerateModelID();
            AutoGenerateTransID();
            LoadStockCompanies();
            dtpTransDate.Value = DateTime.Today;
            // add mobile
            LoadMobileCompanies();
            dtpWarranty.Value = DateTime.Today.AddYears(1); // Default 1 year warranty
            // daily sale report load
            dtpDailyDate.Value = DateTime.Today;
            LoadDailySales();
            // range report
            DateRange_Load();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        // Auto-generate Company ID on form load
        private void AddCompany_Load(object sender, EventArgs e)
        {
            AutoGenerateCompID();
        }

        private void AutoGenerateCompID()
        {
            SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(CompID),0)+1 FROM tbl_Company", conn);
            conn.Open();
            txtCompID.Text = cmd.ExecuteScalar().ToString();
            conn.Close();
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCompName.Text))
            {
                MessageBox.Show("Company name cannot be empty!");
                return;
            }


            // Check for duplicate company
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tbl_Company WHERE CompName = @name", conn);
            checkCmd.Parameters.AddWithValue("@name", txtCompName.Text);

            conn.Open();
            int exists = (int)checkCmd.ExecuteScalar();

            if (exists > 0)
            {
                MessageBox.Show("Company already exists!");
                return;
            }

            // Insert new company
            SqlCommand insertCmd = new SqlCommand("INSERT INTO tbl_Company (CompName) VALUES (@name)", conn);
            insertCmd.Parameters.AddWithValue("@name", txtCompName.Text);
            insertCmd.ExecuteNonQuery();
            conn.Close();

            lblMsg.Text = "Company added successfully!";
            txtCompName.Clear();
            AutoGenerateCompID(); // Refresh ID

        }


        // model

        private void LoadCompanies()
        {
            cmbCompany.Items.Clear();

            SqlCommand cmd = new SqlCommand("SELECT CompName FROM tbl_Company", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbCompany.Items.Add(dr["CompName"].ToString());
            }
            conn.Close();

        }
        private void AutoGenerateModelID()
        {
            //using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MobileShoppeCon"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(ModelID), 0) + 1 FROM tbl_Model", conn);
                conn.Open();
                txtModelID.Text = cmd.ExecuteScalar().ToString();
                conn.Close();
            }
        }
        private void btnAddModel_Click(object sender, EventArgs e)
        {

            if (cmbCompany.SelectedIndex == -1 || string.IsNullOrEmpty(txtModelNum.Text))
            {
                MessageBox.Show("Please select company and enter model number");
                return;
            }

            if (!int.TryParse(txtInitialQty.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Invalid quantity value!");
                return;
            }

            //using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MobileShoppeCon"].ToString()))
            {
                // Get Company ID
                SqlCommand getCompCmd = new SqlCommand("SELECT CompID FROM tbl_Company WHERE CompName = @name", conn);
                getCompCmd.Parameters.AddWithValue("@name", cmbCompany.Text);

                conn.Open();
                int compID = (int)getCompCmd.ExecuteScalar();

                // Check for duplicate model
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tbl_Model WHERE ModelNum = @model", conn);
                checkCmd.Parameters.AddWithValue("@model", txtModelNum.Text);
                if ((int)checkCmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("Model number already exists!");
                    return;
                }

                // Insert model
                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO tbl_Model (CompID, ModelNum, AvailableQty) VALUES (@compID, @modelNum, @qty)",
                    conn);
                insertCmd.Parameters.AddWithValue("@compID", compID);
                insertCmd.Parameters.AddWithValue("@modelNum", txtModelNum.Text);
                insertCmd.Parameters.AddWithValue("@qty", qty);
                insertCmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Model added successfully!");
                txtModelNum.Clear();
                txtInitialQty.Clear();
                AutoGenerateModelID();
            }
        }

        // close all appplication
        private void AdminHomepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // tab control


        // update stock
        private void AutoGenerateTransID()
        {
            {
                SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(TransID), 0) + 1 FROM tbl_Transaction", conn);
                conn.Open();
                txtTransID.Text = cmd.ExecuteScalar().ToString();
                conn.Close();
            }
        }

        private void LoadStockCompanies()
        {
            cmbStockCompany.Items.Clear();
            {
                SqlCommand cmd = new SqlCommand("SELECT CompName FROM tbl_Company", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbStockCompany.Items.Add(dr["CompName"].ToString());
                }
                conn.Close();
            }
        }

        private void cmbStockCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStockModel.Items.Clear();
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT ModelNum FROM tbl_Model M INNER JOIN tbl_Company C ON M.CompID = C.CompID WHERE C.CompName = @name",
                    conn);
                cmd.Parameters.AddWithValue("@name", cmbStockCompany.Text);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbStockModel.Items.Add(dr["ModelNum"].ToString());
                }
                conn.Close();
            }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            if (cmbStockCompany.SelectedIndex == -1 || cmbStockModel.SelectedIndex == -1)
            {
                MessageBox.Show("Please select company and model");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Enter valid quantity (>0)");
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Enter valid amount (>0)");
                return;
            }



            SqlTransaction transaction = null;

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                // Get ModelID
                SqlCommand getModelCmd = new SqlCommand(
                    "SELECT ModelID FROM tbl_Model WHERE ModelNum = @modelNum",
                    conn, transaction);
                getModelCmd.Parameters.AddWithValue("@modelNum", cmbStockModel.Text);
                int modelID = (int)getModelCmd.ExecuteScalar();

                // Insert transaction
                SqlCommand transCmd = new SqlCommand(
                    "INSERT INTO tbl_Transaction (ModelID, Quantity, Amount, TransDate) VALUES (@modelID, @qty, @amt, @date)",
                    conn, transaction);
                transCmd.Parameters.AddWithValue("@modelID", modelID);
                transCmd.Parameters.AddWithValue("@qty", qty);
                transCmd.Parameters.AddWithValue("@amt", amount);
                transCmd.Parameters.AddWithValue("@date", dtpTransDate.Value);
                transCmd.ExecuteNonQuery();

                // Update stock
                SqlCommand updateCmd = new SqlCommand(
                    "UPDATE tbl_Model SET AvailableQty = AvailableQty + @qty WHERE ModelID = @modelID",
                    conn, transaction);
                updateCmd.Parameters.AddWithValue("@qty", qty);
                updateCmd.Parameters.AddWithValue("@modelID", modelID);
                updateCmd.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Stock updated successfully!");
                conn.Close();

                // Reset form
                txtQuantity.Clear();
                txtAmount.Clear();
                AutoGenerateTransID();
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch { }
                }
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        // add mobile section
        private void LoadMobileCompanies()
        {
            cmbMobileCompany.Items.Clear();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MobileShoppeCon"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("SELECT CompName FROM tbl_Company", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbMobileCompany.Items.Add(dr["CompName"].ToString());
                }
            }
        }


        private void btnAddMobile_Click(object sender, EventArgs e)
        {
            if (cmbMobileCompany.SelectedIndex == -1 || cmbMobileModel.SelectedIndex == -1)
            {
                MessageBox.Show("Select company and model");
                return;
            }

            if (!Regex.IsMatch(txtIMEI.Text, @"^\d{16}$"))
            {
                MessageBox.Show("IMEI must be 16 digits");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Enter valid price (>0)");
                return;
            }

            {
                // Check duplicate IMEI
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tbl_Mobile WHERE IMEINO = @imei", conn);
                checkCmd.Parameters.AddWithValue("@imei", txtIMEI.Text);

                conn.Open();
                if ((int)checkCmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("IMEI already exists!");
                    return;
                }

                // Get ModelID
                SqlCommand modelCmd = new SqlCommand(
                    "SELECT ModelID FROM tbl_Model WHERE ModelNum = @model",
                    conn);
                modelCmd.Parameters.AddWithValue("@model", cmbMobileModel.Text);
                int modelID = (int)modelCmd.ExecuteScalar();

                // Insert mobile
                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO tbl_Mobile (IMEINO, ModelID, Status, Warranty, Price) VALUES (@imei, @modelID, 'Not Sold', @warranty, @price)",
                    conn);
                insertCmd.Parameters.AddWithValue("@imei", txtIMEI.Text);
                insertCmd.Parameters.AddWithValue("@modelID", modelID);
                insertCmd.Parameters.AddWithValue("@warranty", dtpWarranty.Value);
                insertCmd.Parameters.AddWithValue("@price", price);
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Mobile added successfully!");
                txtIMEI.Clear();
                txtPrice.Clear();
                conn.Close();
            }
        }

        private void cmbMobileCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMobileModel.Items.Clear();
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT ModelNum FROM tbl_Model M INNER JOIN tbl_Company C ON M.CompID = C.CompID WHERE C.CompName = @name",
                    conn);
                cmd.Parameters.AddWithValue("@name", cmbMobileCompany.Text);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbMobileModel.Items.Add(dr["ModelNum"].ToString());
                }
                conn.Close();
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Validate all fields
            if (string.IsNullOrEmpty(txtEmpName.Text) ||
                string.IsNullOrEmpty(txtAddress.Text) ||
                string.IsNullOrEmpty(txtMobile.Text) ||
                string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtHint.Text))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            if (txtPassword.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Password and Confirm Password don't match!");
                return;
            }

            // check pass to have 6 character 
            if (!Regex.IsMatch(txtPassword.Text, @"^.{6}$"))
            {
                MessageBox.Show("Password must be exactly 6 characters long");
                return;
            }

            // Mobile number validation
            if (!Regex.IsMatch(txtMobile.Text, @"^.{10}$"))
            {
                MessageBox.Show("Mobile must be 10 digits");
                return;
            }

            {
                // Check duplicate username
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tbl_User WHERE Username = @user", conn);
                checkCmd.Parameters.AddWithValue("@user", txtUsername.Text);

                conn.Open();
                if ((int)checkCmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("Username already exists!");
                    return;
                }

                // Insert employee
                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO tbl_User (Username, Password, EmpName, Address, MobileNo, Hint) " +
                    "VALUES (@user, @pass, @name, @addr, @mobile, @hint)",
                    conn);
                insertCmd.Parameters.AddWithValue("@user", txtUsername.Text);
                insertCmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                insertCmd.Parameters.AddWithValue("@name", txtEmpName.Text);
                insertCmd.Parameters.AddWithValue("@addr", txtAddress.Text);
                insertCmd.Parameters.AddWithValue("@mobile", txtMobile.Text);
                insertCmd.Parameters.AddWithValue("@hint", txtHint.Text);
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Employee added successfully!");

                // Clear form
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox) ((TextBox)c).Clear();
                }
                conn.Close();
            }
        }



        // daily sale report

        private void LoadDailySales()
        {
            {
                string query = @"SELECT 
    s.SalesID,
    c.CompName AS CompanyName,
    m.ModelNum,
    s.IMEINO,
    s.Price,
    (SELECT SUM(s2.Price)
     FROM tbl_Sales s2
     WHERE s2.PurchaseDate = s.PurchaseDate) AS TotalSalesOnDate
FROM 
    tbl_Sales s
JOIN 
    tbl_Mobile mo ON s.IMEINO = mo.IMEINO
JOIN 
    tbl_Model m ON mo.ModelID = m.ModelID
JOIN 
    tbl_Company c ON m.CompID = c.CompID
WHERE 
    s.PurchaseDate = @date
GROUP BY 
    s.SalesID, c.CompName, m.ModelNum, s.IMEINO, s.Price, s.PurchaseDate
ORDER BY 
    s.SalesID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@date", dtpDailyDate.Value.Date);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDailySales.DataSource = dt;

                // Calculate daily total
                decimal total = dt.AsEnumerable().Sum(row => Convert.ToDecimal(row["Price"].ToString().Replace("$", "")));
                lblDailyTotal.Text = $"Daily Total: {total:C}";
            }
        }

        private void btnLoadDaily_Click(object sender, EventArgs e)
        {
            LoadDailySales();
        }

        private void dtpDailyDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDailyDate.Value > DateTime.Today)
            {
                MessageBox.Show("Future dates not allowed!");
                dtpDailyDate.Value = DateTime.Today;
            }
        }

        // range report
        private void DateRange_Load()
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Today;

            cmbGroupBy.Items.AddRange(new string[] { "None", "By Company", "By Model", "Daily Summary" });
            cmbGroupBy.SelectedIndex = 0;
        }
        private void GenerateRangeReport()
        {
            string groupByClause = "";
            string orderByClause = "ORDER BY S.PurchaseDate DESC";
            bool isGrouped = false;
            string selectColumns = @"
        S.SalesID, 
        C.CompName AS 'Company',
        M.ModelNum AS 'Model',
        S.Price,
        CAST(S.PurchaseDate AS DATE) AS 'Date',
        Cu.CustName AS 'Customer'";

            switch (cmbGroupBy.SelectedItem.ToString())
            {
                case "By Company":
                    groupByClause = "GROUP BY C.CompName";
                    selectColumns = @"
            C.CompName AS 'Company',
            COUNT(S.SalesID) AS 'SalesCount',
            SUM(S.Price) AS 'TotalSales'";
                    isGrouped = true;
                    orderByClause = "ORDER BY TotalSales DESC";
                    break;

                case "By Model":
                    groupByClause = "GROUP BY M.ModelNum, C.CompName";
                    selectColumns = @"
            C.CompName AS 'Company',
            M.ModelNum AS 'Model',
            COUNT(S.SalesID) AS 'SalesCount',
            SUM(S.Price) AS 'TotalSales'";
                    isGrouped = true;
                    orderByClause = "ORDER BY TotalSales DESC";
                    break;

                case "Daily Summary":
                    groupByClause = "GROUP BY CAST(S.PurchaseDate AS DATE)";
                    selectColumns = @"
            CAST(S.PurchaseDate AS DATE) AS 'Date',
            COUNT(S.SalesID) AS 'SalesCount',
            SUM(S.Price) AS 'DailyTotal'";
                    isGrouped = true;
                    orderByClause = "ORDER BY Date DESC";
                    break;
            }


            {
                string query = $@"
    SELECT {selectColumns}
    FROM tbl_Sales S
    INNER JOIN tbl_Mobile Mb ON S.IMEINO = Mb.IMEINO
    INNER JOIN tbl_Model M ON Mb.ModelID = M.ModelID
    INNER JOIN tbl_Company C ON M.CompID = C.CompID
    LEFT JOIN tbl_Customer Cu ON S.CustID = Cu.CustID
    WHERE S.PurchaseDate >= @start AND S.PurchaseDate <= @end
    {(isGrouped ? groupByClause : "")}
    {orderByClause}";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@start", dtpStartDate.Value.Date);
                cmd.Parameters.AddWithValue("@end", dtpEndDate.Value.Date);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //MessageBox.Show("Rows fetched: " + dt.Rows.Count);


                dgvRangeSales.DataSource = dt;

                // Calculate range total (only for non-grouped views)
                if (cmbGroupBy.SelectedIndex == 0)
                {
                    decimal total = dt.AsEnumerable()
                                    .Sum(row => Convert.ToDecimal(row["Price"].ToString().Replace("$", "")));
                    lblRangeTotal.Text = $"Period Total: {total:C}";
                }
                else
                {
                    lblRangeTotal.Text = $"Grouped by: {cmbGroupBy.SelectedItem}";
                }

            }
        }

        private void btnGenerateRange_Click(object sender, EventArgs e)
        {

            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("Start date cannot be after end date!");
                return;
            }

            if (dtpStartDate.Value < new DateTime(2013, 1, 1)) // Business establishment date
            {
                MessageBox.Show("Records only available from Jan 2013");
                dtpStartDate.Value = new DateTime(2013, 1, 1);
                return;
            }

            GenerateRangeReport();
        }


        // common feature export to excel and print
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            DataGridView dgv = tabControl2.SelectedIndex == 0 ? dgvDailySales : dgvRangeSales;

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Files|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Export");

                        // Add headers
                        for (int col = 0; col < dgv.Columns.Count; col++)
                        {
                            worksheet.Cell(1, col + 1).Value = dgv.Columns[col].HeaderText;
                        }

                        // Add data rows
                        for (int row = 0; row < dgv.Rows.Count; row++)
                        {
                            for (int col = 0; col < dgv.Columns.Count; col++)
                            {
                                object value = dgv.Rows[row].Cells[col].Value;
                                worksheet.Cell(row + 2, col + 1).Value = value?.ToString() ?? string.Empty;
                            }
                        }

                        // Save to file
                        workbook.SaveAs(sfd.FileName);
                    }

                    MessageBox.Show("Exported successfully!");
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();

            printDoc.PrintPage += (s, ev) =>
            {
                Bitmap bmp = new Bitmap(
                    tabControl2.SelectedIndex == 0 ?
                    dgvDailySales.Width : dgvRangeSales.Width,
                    tabControl2.SelectedIndex == 0 ?
                    dgvDailySales.Height : dgvRangeSales.Height);

                (tabControl2.SelectedIndex == 0 ? dgvDailySales : dgvRangeSales)
                    .DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                ev.Graphics.DrawImage(bmp, ev.MarginBounds);
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }
    }
}

