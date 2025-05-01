using System.Windows.Forms;

namespace MobileShoppe
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(400, 300);

            // Background
            this.BackColor = Color.WhiteSmoke;

            // Add developer info
            Label devLabel = new Label()
            {
                Text = "Developed by 2251120415 Doan Cong Hieu\nMobile Shoppe Version 1.0.0\nContact: 2251120415@ut.edu.vn\nUniversity of Transport Ho Chi Minh City – UTH\n© 2025 All Right Reserved",
                Font = new Font("Arial", 12),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            this.Controls.Add(devLabel);

            // Auto-close after few seconds
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer() { Interval = 3500 };
            timer.Tick += (s, e) => { timer.Stop(); this.Close(); };
            timer.Start();

            InitializeComponent();
            this.Icon = new Icon("Resources\\app_icon.ico");

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
