using System.Configuration;
using System.Data.SqlClient;

namespace MobileShoppe
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
            this.Icon = new Icon("Resources\\app_icon.ico");

        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MobileShoppeCon"].ToString());

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtHint.Text))
            {
                MessageBox.Show("Both username and hint are required!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MobileShoppeCon"].ToString()))
            {
                string query = @"
                SELECT Password 
                FROM tbl_User 
                WHERE Username = @user 
                AND Hint = @hint";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@hint", txtHint.Text);

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    lblPassword.Text = $"Your password is: {result}";
                    lblPassword.ForeColor = Color.Green;
                }
                else
                {
                    lblPassword.Text = "Invalid username or hint answer!";
                    lblPassword.ForeColor = Color.Red;
                }
            }
        }

        private void lnkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
