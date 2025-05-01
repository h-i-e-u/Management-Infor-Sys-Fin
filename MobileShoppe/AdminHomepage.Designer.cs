namespace MobileShoppe
{
    partial class AdminHomepage
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
            tabAddCompany = new TabPage();
            lblMsg = new Label();
            txtCompID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtCompName = new TextBox();
            btnAddCompany = new Button();
            tabAddModel = new TabPage();
            txtInitialQty = new TextBox();
            label6 = new Label();
            txtModelNum = new TextBox();
            btnAddModel = new Button();
            txtModelID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cmbCompany = new ComboBox();
            tabAddMobile = new TabPage();
            label17 = new Label();
            dtpWarranty = new DateTimePicker();
            txtPrice = new TextBox();
            cmbMobileModel = new ComboBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            btnAddMobile = new Button();
            cmbMobileCompany = new ComboBox();
            txtIMEI = new TextBox();
            label12 = new Label();
            tabUpdateStock = new TabPage();
            dtpTransDate = new DateTimePicker();
            txtAmount = new TextBox();
            txtQuantity = new TextBox();
            cmbStockModel = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            btnUpdateStock = new Button();
            cmbStockCompany = new ComboBox();
            txtTransID = new TextBox();
            label7 = new Label();
            tabAddEmployee = new TabPage();
            btnAddEmployee = new Button();
            txtHint = new TextBox();
            txtConfirmPass = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtMobile = new TextBox();
            txtAddress = new TextBox();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            txtEmpName = new TextBox();
            label18 = new Label();
            tabSalesReport = new TabPage();
            btnPrint = new Button();
            btnExportExcel = new Button();
            tabControl2 = new TabControl();
            tabPage1 = new TabPage();
            lblDailyTotal = new Label();
            dgvDailySales = new DataGridView();
            btnLoadDaily = new Button();
            label25 = new Label();
            dtpDailyDate = new DateTimePicker();
            tabPage2 = new TabPage();
            cmbGroupBy = new ComboBox();
            dgvRangeSales = new DataGridView();
            btnGenerateRange = new Button();
            dtpEndDate = new DateTimePicker();
            lblRangeTotal = new Label();
            label27 = new Label();
            label26 = new Label();
            dtpStartDate = new DateTimePicker();
            tabControl1.SuspendLayout();
            tabAddCompany.SuspendLayout();
            tabAddModel.SuspendLayout();
            tabAddMobile.SuspendLayout();
            tabUpdateStock.SuspendLayout();
            tabAddEmployee.SuspendLayout();
            tabSalesReport.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDailySales).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRangeSales).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabAddCompany);
            tabControl1.Controls.Add(tabAddModel);
            tabControl1.Controls.Add(tabAddMobile);
            tabControl1.Controls.Add(tabUpdateStock);
            tabControl1.Controls.Add(tabAddEmployee);
            tabControl1.Controls.Add(tabSalesReport);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(786, 440);
            tabControl1.TabIndex = 0;
            // 
            // tabAddCompany
            // 
            tabAddCompany.Controls.Add(lblMsg);
            tabAddCompany.Controls.Add(txtCompID);
            tabAddCompany.Controls.Add(label2);
            tabAddCompany.Controls.Add(label1);
            tabAddCompany.Controls.Add(txtCompName);
            tabAddCompany.Controls.Add(btnAddCompany);
            tabAddCompany.Location = new Point(4, 34);
            tabAddCompany.Name = "tabAddCompany";
            tabAddCompany.Padding = new Padding(3);
            tabAddCompany.Size = new Size(778, 402);
            tabAddCompany.TabIndex = 0;
            tabAddCompany.Text = "+Company";
            tabAddCompany.UseVisualStyleBackColor = true;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.BackColor = SystemColors.ActiveCaption;
            lblMsg.Location = new Point(266, 284);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(60, 25);
            lblMsg.TabIndex = 5;
            lblMsg.Text = "Status";
            // 
            // txtCompID
            // 
            txtCompID.Location = new Point(266, 73);
            txtCompID.Name = "txtCompID";
            txtCompID.ReadOnly = true;
            txtCompID.Size = new Size(303, 31);
            txtCompID.TabIndex = 4;
            txtCompID.Text = "auto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 73);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 3;
            label2.Text = "Company ID:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 142);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 2;
            label1.Text = "Company Name:";
            // 
            // txtCompName
            // 
            txtCompName.Location = new Point(266, 142);
            txtCompName.Name = "txtCompName";
            txtCompName.Size = new Size(303, 31);
            txtCompName.TabIndex = 1;
            // 
            // btnAddCompany
            // 
            btnAddCompany.Location = new Point(417, 207);
            btnAddCompany.Name = "btnAddCompany";
            btnAddCompany.Size = new Size(152, 34);
            btnAddCompany.TabIndex = 0;
            btnAddCompany.Text = "Add Company";
            btnAddCompany.UseVisualStyleBackColor = true;
            btnAddCompany.Click += btnAddCompany_Click;
            // 
            // tabAddModel
            // 
            tabAddModel.Controls.Add(txtInitialQty);
            tabAddModel.Controls.Add(label6);
            tabAddModel.Controls.Add(txtModelNum);
            tabAddModel.Controls.Add(btnAddModel);
            tabAddModel.Controls.Add(txtModelID);
            tabAddModel.Controls.Add(label5);
            tabAddModel.Controls.Add(label4);
            tabAddModel.Controls.Add(label3);
            tabAddModel.Controls.Add(cmbCompany);
            tabAddModel.Location = new Point(4, 34);
            tabAddModel.Name = "tabAddModel";
            tabAddModel.Padding = new Padding(3);
            tabAddModel.Size = new Size(778, 402);
            tabAddModel.TabIndex = 1;
            tabAddModel.Text = "+Model";
            tabAddModel.UseVisualStyleBackColor = true;
            // 
            // txtInitialQty
            // 
            txtInitialQty.Location = new Point(229, 263);
            txtInitialQty.Name = "txtInitialQty";
            txtInitialQty.Size = new Size(312, 31);
            txtInitialQty.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 266);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 7;
            label6.Text = "Quantity";
            // 
            // txtModelNum
            // 
            txtModelNum.Location = new Point(229, 194);
            txtModelNum.Name = "txtModelNum";
            txtModelNum.Size = new Size(312, 31);
            txtModelNum.TabIndex = 6;
            // 
            // btnAddModel
            // 
            btnAddModel.Location = new Point(403, 319);
            btnAddModel.Name = "btnAddModel";
            btnAddModel.Size = new Size(138, 34);
            btnAddModel.TabIndex = 5;
            btnAddModel.Text = "Add Model";
            btnAddModel.UseVisualStyleBackColor = true;
            btnAddModel.Click += btnAddModel_Click;
            // 
            // txtModelID
            // 
            txtModelID.Location = new Point(229, 56);
            txtModelID.Name = "txtModelID";
            txtModelID.ReadOnly = true;
            txtModelID.Size = new Size(312, 31);
            txtModelID.TabIndex = 4;
            txtModelID.Text = "auto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 200);
            label5.Name = "label5";
            label5.Size = new Size(133, 25);
            label5.TabIndex = 3;
            label5.Text = "Model Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 127);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 2;
            label4.Text = "Company Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 59);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 1;
            label3.Text = "Model Id";
            // 
            // cmbCompany
            // 
            cmbCompany.FormattingEnabled = true;
            cmbCompany.Location = new Point(229, 127);
            cmbCompany.Name = "cmbCompany";
            cmbCompany.Size = new Size(312, 33);
            cmbCompany.TabIndex = 0;
            // 
            // tabAddMobile
            // 
            tabAddMobile.Controls.Add(label17);
            tabAddMobile.Controls.Add(dtpWarranty);
            tabAddMobile.Controls.Add(txtPrice);
            tabAddMobile.Controls.Add(cmbMobileModel);
            tabAddMobile.Controls.Add(label16);
            tabAddMobile.Controls.Add(label15);
            tabAddMobile.Controls.Add(label14);
            tabAddMobile.Controls.Add(label13);
            tabAddMobile.Controls.Add(btnAddMobile);
            tabAddMobile.Controls.Add(cmbMobileCompany);
            tabAddMobile.Controls.Add(txtIMEI);
            tabAddMobile.Controls.Add(label12);
            tabAddMobile.Location = new Point(4, 34);
            tabAddMobile.Name = "tabAddMobile";
            tabAddMobile.Size = new Size(778, 402);
            tabAddMobile.TabIndex = 2;
            tabAddMobile.Text = "+Mobile";
            tabAddMobile.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.Info;
            label17.Location = new Point(264, 268);
            label17.Name = "label17";
            label17.Size = new Size(330, 25);
            label17.TabIndex = 11;
            label17.Text = "Default: warranty 1 year., status not sold";
            // 
            // dtpWarranty
            // 
            dtpWarranty.Location = new Point(264, 225);
            dtpWarranty.Name = "dtpWarranty";
            dtpWarranty.Size = new Size(300, 31);
            dtpWarranty.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(264, 177);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(300, 31);
            txtPrice.TabIndex = 9;
            // 
            // cmbMobileModel
            // 
            cmbMobileModel.FormattingEnabled = true;
            cmbMobileModel.Location = new Point(264, 87);
            cmbMobileModel.Name = "cmbMobileModel";
            cmbMobileModel.Size = new Size(300, 33);
            cmbMobileModel.TabIndex = 8;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(90, 225);
            label16.Name = "label16";
            label16.Size = new Size(125, 25);
            label16.TabIndex = 7;
            label16.Text = "Warranty Date";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(90, 177);
            label15.Name = "label15";
            label15.Size = new Size(49, 25);
            label15.TabIndex = 6;
            label15.Text = "Price";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(90, 133);
            label14.Name = "label14";
            label14.Size = new Size(117, 25);
            label14.TabIndex = 5;
            label14.Text = "IMEI Number";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(90, 87);
            label13.Name = "label13";
            label13.Size = new Size(133, 25);
            label13.TabIndex = 4;
            label13.Text = "Model Number";
            // 
            // btnAddMobile
            // 
            btnAddMobile.Location = new Point(407, 320);
            btnAddMobile.Name = "btnAddMobile";
            btnAddMobile.Size = new Size(157, 34);
            btnAddMobile.TabIndex = 3;
            btnAddMobile.Text = "Add Mobile";
            btnAddMobile.UseVisualStyleBackColor = true;
            btnAddMobile.Click += btnAddMobile_Click;
            // 
            // cmbMobileCompany
            // 
            cmbMobileCompany.FormattingEnabled = true;
            cmbMobileCompany.Location = new Point(264, 40);
            cmbMobileCompany.Name = "cmbMobileCompany";
            cmbMobileCompany.Size = new Size(300, 33);
            cmbMobileCompany.TabIndex = 2;
            cmbMobileCompany.SelectedIndexChanged += cmbMobileCompany_SelectedIndexChanged;
            // 
            // txtIMEI
            // 
            txtIMEI.Location = new Point(264, 133);
            txtIMEI.Name = "txtIMEI";
            txtIMEI.Size = new Size(300, 31);
            txtIMEI.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(90, 40);
            label12.Name = "label12";
            label12.Size = new Size(141, 25);
            label12.TabIndex = 0;
            label12.Text = "Company Name";
            // 
            // tabUpdateStock
            // 
            tabUpdateStock.Controls.Add(dtpTransDate);
            tabUpdateStock.Controls.Add(txtAmount);
            tabUpdateStock.Controls.Add(txtQuantity);
            tabUpdateStock.Controls.Add(cmbStockModel);
            tabUpdateStock.Controls.Add(label11);
            tabUpdateStock.Controls.Add(label10);
            tabUpdateStock.Controls.Add(label9);
            tabUpdateStock.Controls.Add(label8);
            tabUpdateStock.Controls.Add(btnUpdateStock);
            tabUpdateStock.Controls.Add(cmbStockCompany);
            tabUpdateStock.Controls.Add(txtTransID);
            tabUpdateStock.Controls.Add(label7);
            tabUpdateStock.Location = new Point(4, 34);
            tabUpdateStock.Name = "tabUpdateStock";
            tabUpdateStock.Size = new Size(778, 402);
            tabUpdateStock.TabIndex = 3;
            tabUpdateStock.Text = "Update Stock";
            tabUpdateStock.UseVisualStyleBackColor = true;
            // 
            // dtpTransDate
            // 
            dtpTransDate.Location = new Point(265, 280);
            dtpTransDate.Name = "dtpTransDate";
            dtpTransDate.Size = new Size(300, 31);
            dtpTransDate.TabIndex = 11;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(269, 223);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(296, 31);
            txtAmount.TabIndex = 10;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(269, 169);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(296, 31);
            txtQuantity.TabIndex = 9;
            // 
            // cmbStockModel
            // 
            cmbStockModel.FormattingEnabled = true;
            cmbStockModel.Location = new Point(269, 116);
            cmbStockModel.Name = "cmbStockModel";
            cmbStockModel.Size = new Size(296, 33);
            cmbStockModel.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(106, 223);
            label11.Name = "label11";
            label11.Size = new Size(77, 25);
            label11.TabIndex = 7;
            label11.Text = "Amount";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(106, 169);
            label10.Name = "label10";
            label10.Size = new Size(80, 25);
            label10.TabIndex = 6;
            label10.Text = "Quantity";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(106, 119);
            label9.Name = "label9";
            label9.Size = new Size(133, 25);
            label9.TabIndex = 5;
            label9.Text = "Model Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(106, 69);
            label8.Name = "label8";
            label8.Size = new Size(141, 25);
            label8.TabIndex = 4;
            label8.Text = "Company Name";
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.Location = new Point(453, 341);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(112, 34);
            btnUpdateStock.TabIndex = 3;
            btnUpdateStock.Text = "Update";
            btnUpdateStock.UseVisualStyleBackColor = true;
            btnUpdateStock.Click += btnUpdateStock_Click;
            // 
            // cmbStockCompany
            // 
            cmbStockCompany.FormattingEnabled = true;
            cmbStockCompany.Location = new Point(269, 66);
            cmbStockCompany.Name = "cmbStockCompany";
            cmbStockCompany.Size = new Size(296, 33);
            cmbStockCompany.TabIndex = 2;
            cmbStockCompany.SelectedIndexChanged += cmbStockCompany_SelectedIndexChanged;
            // 
            // txtTransID
            // 
            txtTransID.Location = new Point(269, 16);
            txtTransID.Name = "txtTransID";
            txtTransID.ReadOnly = true;
            txtTransID.Size = new Size(296, 31);
            txtTransID.TabIndex = 1;
            txtTransID.Text = "auto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(106, 22);
            label7.Name = "label7";
            label7.Size = new Size(75, 25);
            label7.TabIndex = 0;
            label7.Text = "Trans ID";
            // 
            // tabAddEmployee
            // 
            tabAddEmployee.Controls.Add(btnAddEmployee);
            tabAddEmployee.Controls.Add(txtHint);
            tabAddEmployee.Controls.Add(txtConfirmPass);
            tabAddEmployee.Controls.Add(txtPassword);
            tabAddEmployee.Controls.Add(txtUsername);
            tabAddEmployee.Controls.Add(txtMobile);
            tabAddEmployee.Controls.Add(txtAddress);
            tabAddEmployee.Controls.Add(label24);
            tabAddEmployee.Controls.Add(label23);
            tabAddEmployee.Controls.Add(label22);
            tabAddEmployee.Controls.Add(label21);
            tabAddEmployee.Controls.Add(label20);
            tabAddEmployee.Controls.Add(label19);
            tabAddEmployee.Controls.Add(txtEmpName);
            tabAddEmployee.Controls.Add(label18);
            tabAddEmployee.Location = new Point(4, 34);
            tabAddEmployee.Name = "tabAddEmployee";
            tabAddEmployee.Size = new Size(778, 402);
            tabAddEmployee.TabIndex = 4;
            tabAddEmployee.Text = "+Employee";
            tabAddEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(516, 297);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(227, 34);
            btnAddEmployee.TabIndex = 14;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // txtHint
            // 
            txtHint.Location = new Point(563, 216);
            txtHint.Name = "txtHint";
            txtHint.Size = new Size(180, 31);
            txtHint.TabIndex = 13;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(563, 159);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(180, 31);
            txtConfirmPass.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(563, 88);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(180, 31);
            txtPassword.TabIndex = 11;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(563, 39);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(180, 31);
            txtUsername.TabIndex = 10;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(171, 156);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(180, 31);
            txtMobile.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(171, 97);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(180, 31);
            txtAddress.TabIndex = 8;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(388, 159);
            label24.Name = "label24";
            label24.Size = new Size(156, 25);
            label24.TabIndex = 7;
            label24.Text = "Confirm Password";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(388, 94);
            label23.Name = "label23";
            label23.Size = new Size(87, 25);
            label23.TabIndex = 6;
            label23.Text = "Password";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(388, 39);
            label22.Name = "label22";
            label22.Size = new Size(99, 25);
            label22.TabIndex = 5;
            label22.Text = "User Name";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(388, 219);
            label21.Name = "label21";
            label21.Size = new Size(45, 25);
            label21.TabIndex = 4;
            label21.Text = "Hint";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(23, 159);
            label20.Name = "label20";
            label20.Size = new Size(67, 25);
            label20.TabIndex = 3;
            label20.Text = "Mobile";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(23, 94);
            label19.Name = "label19";
            label19.Size = new Size(77, 25);
            label19.TabIndex = 2;
            label19.Text = "Address";
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(171, 39);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(180, 31);
            txtEmpName.TabIndex = 1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(23, 36);
            label18.Name = "label18";
            label18.Size = new Size(142, 25);
            label18.TabIndex = 0;
            label18.Text = "Employee Name";
            // 
            // tabSalesReport
            // 
            tabSalesReport.Controls.Add(btnPrint);
            tabSalesReport.Controls.Add(btnExportExcel);
            tabSalesReport.Controls.Add(tabControl2);
            tabSalesReport.Location = new Point(4, 34);
            tabSalesReport.Name = "tabSalesReport";
            tabSalesReport.Size = new Size(778, 402);
            tabSalesReport.TabIndex = 5;
            tabSalesReport.Text = "Sale Report";
            tabSalesReport.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(252, 358);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(112, 34);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(53, 358);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(163, 34);
            btnExportExcel.TabIndex = 3;
            btnExportExcel.Text = "Export to Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Controls.Add(tabPage2);
            tabControl2.Location = new Point(3, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(769, 335);
            tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblDailyTotal);
            tabPage1.Controls.Add(dgvDailySales);
            tabPage1.Controls.Add(btnLoadDaily);
            tabPage1.Controls.Add(label25);
            tabPage1.Controls.Add(dtpDailyDate);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(761, 297);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Daily";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblDailyTotal
            // 
            lblDailyTotal.AutoSize = true;
            lblDailyTotal.Location = new Point(28, 258);
            lblDailyTotal.Name = "lblDailyTotal";
            lblDailyTotal.Size = new Size(33, 25);
            lblDailyTotal.TabIndex = 4;
            lblDailyTotal.Text = "---";
            // 
            // dgvDailySales
            // 
            dgvDailySales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDailySales.Location = new Point(22, 40);
            dgvDailySales.Name = "dgvDailySales";
            dgvDailySales.RowHeadersWidth = 62;
            dgvDailySales.Size = new Size(733, 200);
            dgvDailySales.TabIndex = 3;
            // 
            // btnLoadDaily
            // 
            btnLoadDaily.Location = new Point(454, 3);
            btnLoadDaily.Name = "btnLoadDaily";
            btnLoadDaily.Size = new Size(112, 34);
            btnLoadDaily.TabIndex = 2;
            btnLoadDaily.Text = "Load";
            btnLoadDaily.UseVisualStyleBackColor = true;
            btnLoadDaily.Click += btnLoadDaily_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(28, 12);
            label25.Name = "label25";
            label25.Size = new Size(100, 25);
            label25.TabIndex = 1;
            label25.Text = "Select Date";
            // 
            // dtpDailyDate
            // 
            dtpDailyDate.Location = new Point(137, 6);
            dtpDailyDate.Name = "dtpDailyDate";
            dtpDailyDate.Size = new Size(300, 31);
            dtpDailyDate.TabIndex = 0;
            dtpDailyDate.ValueChanged += dtpDailyDate_ValueChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cmbGroupBy);
            tabPage2.Controls.Add(dgvRangeSales);
            tabPage2.Controls.Add(btnGenerateRange);
            tabPage2.Controls.Add(dtpEndDate);
            tabPage2.Controls.Add(lblRangeTotal);
            tabPage2.Controls.Add(label27);
            tabPage2.Controls.Add(label26);
            tabPage2.Controls.Add(dtpStartDate);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(761, 297);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Date Range";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbGroupBy
            // 
            cmbGroupBy.FormattingEnabled = true;
            cmbGroupBy.Location = new Point(472, 40);
            cmbGroupBy.Name = "cmbGroupBy";
            cmbGroupBy.Size = new Size(229, 33);
            cmbGroupBy.TabIndex = 7;
            // 
            // dgvRangeSales
            // 
            dgvRangeSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRangeSales.Location = new Point(3, 79);
            dgvRangeSales.Name = "dgvRangeSales";
            dgvRangeSales.RowHeadersWidth = 62;
            dgvRangeSales.Size = new Size(752, 175);
            dgvRangeSales.TabIndex = 6;
            // 
            // btnGenerateRange
            // 
            btnGenerateRange.Location = new Point(472, 0);
            btnGenerateRange.Name = "btnGenerateRange";
            btnGenerateRange.Size = new Size(229, 34);
            btnGenerateRange.TabIndex = 5;
            btnGenerateRange.Text = "Search";
            btnGenerateRange.UseVisualStyleBackColor = true;
            btnGenerateRange.Click += btnGenerateRange_Click;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(125, 42);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(300, 31);
            dtpEndDate.TabIndex = 4;
            // 
            // lblRangeTotal
            // 
            lblRangeTotal.AutoSize = true;
            lblRangeTotal.Location = new Point(52, 257);
            lblRangeTotal.Name = "lblRangeTotal";
            lblRangeTotal.Size = new Size(33, 25);
            lblRangeTotal.TabIndex = 3;
            lblRangeTotal.Text = "---";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(52, 48);
            label27.Name = "label27";
            label27.Size = new Size(30, 25);
            label27.TabIndex = 2;
            label27.Text = "To";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(52, 9);
            label26.Name = "label26";
            label26.Size = new Size(54, 25);
            label26.TabIndex = 1;
            label26.Text = "From";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(125, 0);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(300, 31);
            dtpStartDate.TabIndex = 0;
            // 
            // AdminHomepage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "AdminHomepage";
            Text = "Home (Admin)";
            FormClosed += AdminHomepage_FormClosed;
            Load += AdminHomepage_Load;
            tabControl1.ResumeLayout(false);
            tabAddCompany.ResumeLayout(false);
            tabAddCompany.PerformLayout();
            tabAddModel.ResumeLayout(false);
            tabAddModel.PerformLayout();
            tabAddMobile.ResumeLayout(false);
            tabAddMobile.PerformLayout();
            tabUpdateStock.ResumeLayout(false);
            tabUpdateStock.PerformLayout();
            tabAddEmployee.ResumeLayout(false);
            tabAddEmployee.PerformLayout();
            tabSalesReport.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDailySales).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRangeSales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabAddCompany;
        private TabPage tabAddModel;
        private TabPage tabAddMobile;
        private TabPage tabUpdateStock;
        private TabPage tabAddEmployee;
        private TabPage tabSalesReport;
        private Label label1;
        private TextBox txtCompName;
        private Button btnAddCompany;
        private Label label2;
        private TextBox txtCompID;
        private ComboBox cmbCompany;
        private Label lblMsg;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtModelID;
        private TextBox txtModelNum;
        private Button btnAddModel;
        private Label label6;
        private TextBox txtInitialQty;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnUpdateStock;
        private ComboBox cmbStockCompany;
        private TextBox txtTransID;
        private Label label7;
        private TextBox txtAmount;
        private TextBox txtQuantity;
        private ComboBox cmbStockModel;
        private DateTimePicker dtpTransDate;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Button btnAddMobile;
        private ComboBox cmbMobileCompany;
        private TextBox txtIMEI;
        private Label label12;
        private DateTimePicker dtpWarranty;
        private TextBox txtPrice;
        private ComboBox cmbMobileModel;
        private Label label17;
        private Label label21;
        private Label label20;
        private Label label19;
        private TextBox txtEmpName;
        private Label label18;
        private TextBox txtMobile;
        private TextBox txtAddress;
        private Label label24;
        private Label label23;
        private Label label22;
        private Button btnAddEmployee;
        private TextBox txtHint;
        private TextBox txtConfirmPass;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnLoadDaily;
        private Label label25;
        private DateTimePicker dtpDailyDate;
        private DataGridView dgvDailySales;
        private Label lblDailyTotal;
        private DataGridView dgvRangeSales;
        private Button btnGenerateRange;
        private DateTimePicker dtpEndDate;
        private Label lblRangeTotal;
        private Label label27;
        private Label label26;
        private DateTimePicker dtpStartDate;
        private ComboBox cmbGroupBy;
        private Button btnExportExcel;
        private Button btnPrint;
    }
}