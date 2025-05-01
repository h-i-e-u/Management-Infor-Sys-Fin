namespace MobileShoppe
{
    partial class UserHomepage
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblPrice = new Label();
            btnSubmitSale = new Button();
            cmbIMEI = new ComboBox();
            cmbSalesModel = new ComboBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtMobileNo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbSalesCompany = new ComboBox();
            txtCustomerName = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            txtAvailableQty = new TextBox();
            cmbStockModel = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            cmbStockCompany = new ComboBox();
            tabPage3 = new TabPage();
            txtSearchIMEI = new TextBox();
            label12 = new Label();
            btnSearch = new Button();
            dgvCustomerResults = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerResults).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(790, 436);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblPrice);
            tabPage1.Controls.Add(btnSubmitSale);
            tabPage1.Controls.Add(cmbIMEI);
            tabPage1.Controls.Add(cmbSalesModel);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtAddress);
            tabPage1.Controls.Add(txtMobileNo);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(cmbSalesCompany);
            tabPage1.Controls.Add(txtCustomerName);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(782, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sale";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = SystemColors.Info;
            lblPrice.Cursor = Cursors.No;
            lblPrice.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(566, 237);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(173, 25);
            lblPrice.TabIndex = 17;
            lblPrice.Text = "-----------------------";
            // 
            // btnSubmitSale
            // 
            btnSubmitSale.Location = new Point(636, 319);
            btnSubmitSale.Name = "btnSubmitSale";
            btnSubmitSale.Size = new Size(112, 34);
            btnSubmitSale.TabIndex = 16;
            btnSubmitSale.Text = "Submit";
            btnSubmitSale.UseVisualStyleBackColor = true;
            btnSubmitSale.Click += btnSubmitSale_Click;
            // 
            // cmbIMEI
            // 
            cmbIMEI.FormattingEnabled = true;
            cmbIMEI.Location = new Point(566, 159);
            cmbIMEI.Name = "cmbIMEI";
            cmbIMEI.Size = new Size(182, 33);
            cmbIMEI.TabIndex = 14;
            cmbIMEI.SelectedIndexChanged += cmbIMEI_SelectedIndexChanged;
            // 
            // cmbSalesModel
            // 
            cmbSalesModel.FormattingEnabled = true;
            cmbSalesModel.Location = new Point(566, 83);
            cmbSalesModel.Name = "cmbSalesModel";
            cmbSalesModel.Size = new Size(182, 33);
            cmbSalesModel.TabIndex = 13;
            cmbSalesModel.SelectedIndexChanged += cmbSalesModel_SelectedIndexChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(183, 231);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(187, 31);
            txtEmail.TabIndex = 12;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(183, 162);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(187, 31);
            txtAddress.TabIndex = 11;
            // 
            // txtMobileNo
            // 
            txtMobileNo.Location = new Point(183, 91);
            txtMobileNo.Name = "txtMobileNo";
            txtMobileNo.Size = new Size(187, 31);
            txtMobileNo.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(407, 237);
            label8.Name = "label8";
            label8.Size = new Size(49, 25);
            label8.TabIndex = 9;
            label8.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(407, 162);
            label7.Name = "label7";
            label7.Size = new Size(117, 25);
            label7.TabIndex = 8;
            label7.Text = "IMEI Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(407, 91);
            label6.Name = "label6";
            label6.Size = new Size(133, 25);
            label6.TabIndex = 7;
            label6.Text = "Model Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 27);
            label5.Name = "label5";
            label5.Size = new Size(141, 25);
            label5.TabIndex = 6;
            label5.Text = "Company Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 231);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 162);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 4;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 94);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 3;
            label2.Text = "Mobile Number";
            // 
            // cmbSalesCompany
            // 
            cmbSalesCompany.FormattingEnabled = true;
            cmbSalesCompany.Location = new Point(566, 24);
            cmbSalesCompany.Name = "cmbSalesCompany";
            cmbSalesCompany.Size = new Size(182, 33);
            cmbSalesCompany.TabIndex = 2;
            cmbSalesCompany.SelectedIndexChanged += cmbSalesCompany_SelectedIndexChanged;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(183, 27);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(187, 31);
            txtCustomerName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 27);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtAvailableQty);
            tabPage2.Controls.Add(cmbStockModel);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(cmbStockCompany);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(782, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "View Stock";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtAvailableQty
            // 
            txtAvailableQty.BackColor = SystemColors.ActiveCaption;
            txtAvailableQty.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAvailableQty.Location = new Point(297, 190);
            txtAvailableQty.Name = "txtAvailableQty";
            txtAvailableQty.ReadOnly = true;
            txtAvailableQty.Size = new Size(182, 32);
            txtAvailableQty.TabIndex = 5;
            txtAvailableQty.Text = "---";
            // 
            // cmbStockModel
            // 
            cmbStockModel.FormattingEnabled = true;
            cmbStockModel.Location = new Point(297, 119);
            cmbStockModel.Name = "cmbStockModel";
            cmbStockModel.Size = new Size(182, 33);
            cmbStockModel.TabIndex = 4;
            cmbStockModel.SelectedIndexChanged += cmbStockModel_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(99, 196);
            label11.Name = "label11";
            label11.Size = new Size(131, 25);
            label11.TabIndex = 3;
            label11.Text = "Stock Available";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(99, 119);
            label10.Name = "label10";
            label10.Size = new Size(184, 25);
            label10.TabIndex = 2;
            label10.Text = "Select Model Number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(99, 37);
            label9.Name = "label9";
            label9.Size = new Size(192, 25);
            label9.TabIndex = 1;
            label9.Text = "Select Company Name";
            // 
            // cmbStockCompany
            // 
            cmbStockCompany.FormattingEnabled = true;
            cmbStockCompany.Location = new Point(297, 34);
            cmbStockCompany.Name = "cmbStockCompany";
            cmbStockCompany.Size = new Size(182, 33);
            cmbStockCompany.TabIndex = 0;
            cmbStockCompany.SelectedIndexChanged += cmbStockCompany_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvCustomerResults);
            tabPage3.Controls.Add(btnSearch);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(txtSearchIMEI);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(782, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Search Customer by IMEI";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtSearchIMEI
            // 
            txtSearchIMEI.Location = new Point(262, 16);
            txtSearchIMEI.Name = "txtSearchIMEI";
            txtSearchIMEI.Size = new Size(257, 31);
            txtSearchIMEI.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(94, 16);
            label12.Name = "label12";
            label12.Size = new Size(162, 25);
            label12.TabIndex = 1;
            label12.Text = "Enter IMEI Number";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(525, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvCustomerResults
            // 
            dgvCustomerResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerResults.Location = new Point(12, 64);
            dgvCustomerResults.Name = "dgvCustomerResults";
            dgvCustomerResults.RowHeadersWidth = 62;
            dgvCustomerResults.Size = new Size(760, 225);
            dgvCustomerResults.TabIndex = 3;
            // 
            // UserHomepage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "UserHomepage";
            Text = "Home";
            FormClosed += UserHomepage_FormClosed;
            Load += UserHomepage_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbSalesCompany;
        private TextBox txtCustomerName;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtMobileNo;
        private Button btnSubmitSale;
        private ComboBox cmbIMEI;
        private ComboBox cmbSalesModel;
        private Label lblPrice;
        private Label label11;
        private Label label10;
        private Label label9;
        private ComboBox cmbStockCompany;
        private ComboBox cmbStockModel;
        private TextBox txtAvailableQty;
        private DataGridView dgvCustomerResults;
        private Button btnSearch;
        private Label label12;
        private TextBox txtSearchIMEI;
    }
}