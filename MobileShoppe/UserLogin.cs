using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace MobileShoppe
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
            this.Icon = new Icon("Resources\\app_icon.ico");
        }

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MobileShoppeCon"].ToString());

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lnkAdminLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPass = new ForgotPassword();
            forgotPass.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_User WHERE Username=@user AND Password=@pass", conn);
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);

            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();

            if (count == 1)
            {
                UserHomepage userHome = new UserHomepage();
                userHome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials!");
            }
        }



        private void UserLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lnkDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form aboutForm = new Form
            {
                Text = "About Developer",
                Size = new Size(500, 300),
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false,
            };

            //  a panel to hold the text and link
            Panel panel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(10)
            };

            TextBox txtInfo = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                WordWrap = true,
                ScrollBars = ScrollBars.Vertical,
                Height = 200,
                Dock = DockStyle.Top,
                Text =
                    "Mobile Shoppe v1.0.0" + Environment.NewLine + Environment.NewLine +
                    "Developed by 2251120415 Doan Cong Hieu (solo)" + Environment.NewLine +
                    "University of Transport Ho Chi Minh City – UTH" + Environment.NewLine +
                    "Contact 2251120415@ut.edu.vn" + Environment.NewLine + Environment.NewLine +
                    "© 2025 All Rights Reserved"
            };

            LinkLabel linkLabel = new LinkLabel
            {
                Text = "GitHub Repository",
                AutoSize = true,
                Dock = DockStyle.Bottom
            };

            linkLabel.LinkClicked += (s, args) =>
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/h-i-e-u/Management-Infor-Sys-Fin",
                    UseShellExecute = true
                });
            };

            panel.Controls.Add(linkLabel);
            panel.Controls.Add(txtInfo);

            aboutForm.Controls.Add(panel);
            aboutForm.ShowDialog();
        }


    }
}
