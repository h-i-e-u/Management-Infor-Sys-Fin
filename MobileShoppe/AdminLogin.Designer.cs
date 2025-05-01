namespace MobileShoppe
{
    partial class AdminLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lnkBackToUserLogin = new LinkLabel();
            txtAdminUser = new TextBox();
            txtAdminPass = new TextBox();
            linkLabel2 = new LinkLabel();
            btnAdminLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 117);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 4;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 188);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // lnkBackToUserLogin
            // 
            lnkBackToUserLogin.AutoSize = true;
            lnkBackToUserLogin.Location = new Point(42, 44);
            lnkBackToUserLogin.Name = "lnkBackToUserLogin";
            lnkBackToUserLogin.Size = new Size(48, 25);
            lnkBackToUserLogin.TabIndex = 7;
            lnkBackToUserLogin.TabStop = true;
            lnkBackToUserLogin.Text = "Back";
            lnkBackToUserLogin.LinkClicked += lnkBackToUserLogin_LinkClicked;
            // 
            // txtAdminUser
            // 
            txtAdminUser.Location = new Point(291, 117);
            txtAdminUser.Name = "txtAdminUser";
            txtAdminUser.Size = new Size(376, 31);
            txtAdminUser.TabIndex = 8;
            // 
            // txtAdminPass
            // 
            txtAdminPass.Location = new Point(291, 188);
            txtAdminPass.Name = "txtAdminPass";
            txtAdminPass.Size = new Size(376, 31);
            txtAdminPass.TabIndex = 9;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(303, 327);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(146, 25);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot Password";
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.Location = new Point(555, 322);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(112, 34);
            btnAdminLogin.TabIndex = 11;
            btnAdminLogin.Text = "Login";
            btnAdminLogin.UseVisualStyleBackColor = true;
            btnAdminLogin.Click += btnAdminLogin_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdminLogin);
            Controls.Add(linkLabel2);
            Controls.Add(txtAdminPass);
            Controls.Add(txtAdminUser);
            Controls.Add(lnkBackToUserLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminLogin";
            Text = "Login (Admin)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private LinkLabel lnkBackToUserLogin;
        private TextBox txtAdminUser;
        private TextBox txtAdminPass;
        private LinkLabel linkLabel2;
        private Button btnAdminLogin;
    }
}