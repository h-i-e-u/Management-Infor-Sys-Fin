namespace MobileShoppe
{
    partial class UserLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            btnLogin = new Button();
            lnkAdminLogin = new LinkLabel();
            label1 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            lnkForgotPassword = new LinkLabel();
            lnkDeveloper = new LinkLabel();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(243, 89);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(429, 31);
            txtUsername.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(560, 262);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnkAdminLogin
            // 
            lnkAdminLogin.AutoSize = true;
            lnkAdminLogin.Location = new Point(607, 45);
            lnkAdminLogin.Name = "lnkAdminLogin";
            lnkAdminLogin.Size = new Size(65, 25);
            lnkAdminLogin.TabIndex = 3;
            lnkAdminLogin.TabStop = true;
            lnkAdminLogin.Text = "Admin";
            lnkAdminLogin.LinkClicked += lnkAdminLogin_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 89);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 7;
            label1.Text = "User Name";
            label1.Click += label1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(243, 176);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(429, 31);
            txtPassword.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 176);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 6;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.Location = new Point(539, 361);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(133, 25);
            lnkForgotPassword.TabIndex = 4;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot Passord";
            lnkForgotPassword.LinkClicked += lnkForgotPassword_LinkClicked;
            // 
            // lnkDeveloper
            // 
            lnkDeveloper.AutoSize = true;
            lnkDeveloper.Location = new Point(102, 361);
            lnkDeveloper.Name = "lnkDeveloper";
            lnkDeveloper.Size = new Size(83, 25);
            lnkDeveloper.TabIndex = 5;
            lnkDeveloper.TabStop = true;
            lnkDeveloper.Text = "About ⓘ";
            lnkDeveloper.LinkClicked += lnkDeveloper_LinkClicked;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lnkDeveloper);
            Controls.Add(lnkForgotPassword);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(lnkAdminLogin);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Name = "UserLogin";
            Text = "Login";
            FormClosed += UserLogin_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private Button btnLogin;
        private LinkLabel lnkAdminLogin;
        private Label label1;
        private TextBox txtPassword;
        private Label label2;
        private LinkLabel lnkForgotPassword;
        private LinkLabel lnkDeveloper;
    }
}
