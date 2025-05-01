using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShoppe
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            this.Icon = new Icon("Resources\\app_icon.ico");

        }

        private void lnkBackToUserLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Hide();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {

            if (txtAdminUser.Text == "admin" && txtAdminPass.Text == "admin")
            {
                AdminHomepage adminHome = new AdminHomepage();
                adminHome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Admin credentials incorrect!");
            }
        }
    }
}
