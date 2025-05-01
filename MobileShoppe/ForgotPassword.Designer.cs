namespace MobileShoppe
{
    partial class ForgotPassword
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
            txtUsername = new TextBox();
            txtHint = new TextBox();
            btnRetrieve = new Button();
            lblPassword = new Label();
            lnkBackToLogin = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 73);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 0;
            label1.Text = "User Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 136);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 1;
            label2.Text = "Hint:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(225, 73);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(349, 31);
            txtUsername.TabIndex = 2;
            // 
            // txtHint
            // 
            txtHint.Location = new Point(225, 136);
            txtHint.Name = "txtHint";
            txtHint.Size = new Size(349, 31);
            txtHint.TabIndex = 3;
            // 
            // btnRetrieve
            // 
            btnRetrieve.Location = new Point(462, 220);
            btnRetrieve.Name = "btnRetrieve";
            btnRetrieve.Size = new Size(112, 34);
            btnRetrieve.TabIndex = 4;
            btnRetrieve.Text = "Submit";
            btnRetrieve.UseVisualStyleBackColor = true;
            btnRetrieve.Click += btnRetrieve_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = SystemColors.ActiveCaption;
            lblPassword.Location = new Point(225, 310);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(169, 25);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Your Password Here";
            // 
            // lnkBackToLogin
            // 
            lnkBackToLogin.AutoSize = true;
            lnkBackToLogin.Location = new Point(34, 27);
            lnkBackToLogin.Name = "lnkBackToLogin";
            lnkBackToLogin.Size = new Size(119, 25);
            lnkBackToLogin.TabIndex = 6;
            lnkBackToLogin.TabStop = true;
            lnkBackToLogin.Text = "Back to Login";
            lnkBackToLogin.LinkClicked += lnkBackToLogin_LinkClicked;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lnkBackToLogin);
            Controls.Add(lblPassword);
            Controls.Add(btnRetrieve);
            Controls.Add(txtHint);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ForgotPassword";
            Text = "Forget";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtHint;
        private Button btnRetrieve;
        private Label lblPassword;
        private LinkLabel lnkBackToLogin;
    }
}