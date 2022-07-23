namespace Accounting_Project.Forms
{
    partial class CustomerDeposit
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
            this.View_bt = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.Delete_bt = new MetroFramework.Controls.MetroButton();
            this.Close_bt = new MetroFramework.Controls.MetroButton();
            this.Save_bt = new MetroFramework.Controls.MetroButton();
            this.txtTotalAmt = new System.Windows.Forms.TextBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtOpeningAmt = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtSaleAmt = new System.Windows.Forms.TextBox();
            this.txtDepositAmt = new System.Windows.Forms.TextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.mbtnViewCustomer = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // View_bt
            // 
            this.View_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.View_bt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.View_bt.Location = new System.Drawing.Point(242, 61);
            this.View_bt.Name = "View_bt";
            this.View_bt.Size = new System.Drawing.Size(75, 23);
            this.View_bt.TabIndex = 38;
            this.View_bt.Text = "View";
            this.View_bt.UseSelectable = true;
            this.View_bt.Click += new System.EventHandler(this.View_bt_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(14, 65);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(81, 19);
            this.metroLabel4.TabIndex = 37;
            this.metroLabel4.Text = "Select Date :";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime1.Location = new System.Drawing.Point(101, 59);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(132, 29);
            this.metroDateTime1.TabIndex = 36;
            // 
            // Delete_bt
            // 
            this.Delete_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Delete_bt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Delete_bt.Location = new System.Drawing.Point(521, 187);
            this.Delete_bt.Name = "Delete_bt";
            this.Delete_bt.Size = new System.Drawing.Size(75, 23);
            this.Delete_bt.TabIndex = 35;
            this.Delete_bt.Text = "Delete";
            this.Delete_bt.UseSelectable = true;
            this.Delete_bt.Click += new System.EventHandler(this.Delete_bt_Click);
            // 
            // Close_bt
            // 
            this.Close_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Close_bt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Close_bt.Location = new System.Drawing.Point(521, 457);
            this.Close_bt.Name = "Close_bt";
            this.Close_bt.Size = new System.Drawing.Size(75, 23);
            this.Close_bt.TabIndex = 34;
            this.Close_bt.Text = "Close";
            this.Close_bt.UseSelectable = true;
            this.Close_bt.Click += new System.EventHandler(this.Close_bt_Click);
            // 
            // Save_bt
            // 
            this.Save_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Save_bt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Save_bt.Location = new System.Drawing.Point(440, 457);
            this.Save_bt.Name = "Save_bt";
            this.Save_bt.Size = new System.Drawing.Size(75, 23);
            this.Save_bt.TabIndex = 33;
            this.Save_bt.Text = "Save";
            this.Save_bt.UseSelectable = true;
            this.Save_bt.Click += new System.EventHandler(this.Save_bt_Click);
            // 
            // txtTotalAmt
            // 
            this.txtTotalAmt.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalAmt.Enabled = false;
            this.txtTotalAmt.Location = new System.Drawing.Point(154, 345);
            this.txtTotalAmt.Name = "txtTotalAmt";
            this.txtTotalAmt.Size = new System.Drawing.Size(266, 20);
            this.txtTotalAmt.TabIndex = 32;
            // 
            // cbCustomer
            // 
            this.cbCustomer.DropDownHeight = 150;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.IntegralHeight = false;
            this.cbCustomer.Location = new System.Drawing.Point(154, 309);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(197, 21);
            this.cbCustomer.TabIndex = 30;
            this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged);
            this.cbCustomer.Enter += new System.EventHandler(this.cbCustomer_Enter);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 344);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 19);
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Text = "Total Amt :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 308);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "Customer";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 102);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(502, 175);
            this.dataGridView1.TabIndex = 26;
            // 
            // txtOpeningAmt
            // 
            this.txtOpeningAmt.BackColor = System.Drawing.SystemColors.Control;
            this.txtOpeningAmt.Enabled = false;
            this.txtOpeningAmt.Location = new System.Drawing.Point(481, 321);
            this.txtOpeningAmt.Name = "txtOpeningAmt";
            this.txtOpeningAmt.Size = new System.Drawing.Size(113, 20);
            this.txtOpeningAmt.TabIndex = 40;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Enabled = false;
            this.metroLabel5.Location = new System.Drawing.Point(488, 299);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(89, 19);
            this.metroLabel5.TabIndex = 39;
            this.metroLabel5.Text = "Opening Amt";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Enabled = false;
            this.metroLabel6.Location = new System.Drawing.Point(497, 344);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 41;
            this.metroLabel6.Text = "Sale Amt";
            // 
            // txtSaleAmt
            // 
            this.txtSaleAmt.BackColor = System.Drawing.SystemColors.Control;
            this.txtSaleAmt.Enabled = false;
            this.txtSaleAmt.Location = new System.Drawing.Point(481, 366);
            this.txtSaleAmt.Name = "txtSaleAmt";
            this.txtSaleAmt.Size = new System.Drawing.Size(113, 20);
            this.txtSaleAmt.TabIndex = 42;
            // 
            // txtDepositAmt
            // 
            this.txtDepositAmt.BackColor = System.Drawing.SystemColors.Control;
            this.txtDepositAmt.Enabled = false;
            this.txtDepositAmt.Location = new System.Drawing.Point(483, 416);
            this.txtDepositAmt.Name = "txtDepositAmt";
            this.txtDepositAmt.Size = new System.Drawing.Size(113, 20);
            this.txtDepositAmt.TabIndex = 44;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Enabled = false;
            this.metroLabel7.Location = new System.Drawing.Point(491, 394);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(82, 19);
            this.metroLabel7.TabIndex = 43;
            this.metroLabel7.Text = "Deposit Amt";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 383);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 45;
            this.metroLabel2.Text = "Cash :";
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(154, 382);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(266, 20);
            this.txtCash.TabIndex = 46;
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.SystemColors.Control;
            this.txtBalance.Enabled = false;
            this.txtBalance.Location = new System.Drawing.Point(154, 419);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(266, 20);
            this.txtBalance.TabIndex = 47;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(26, 419);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(112, 19);
            this.metroLabel8.TabIndex = 48;
            this.metroLabel8.Text = "Balance Amount :";
            // 
            // mbtnViewCustomer
            // 
            this.mbtnViewCustomer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbtnViewCustomer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mbtnViewCustomer.Location = new System.Drawing.Point(357, 309);
            this.mbtnViewCustomer.Name = "mbtnViewCustomer";
            this.mbtnViewCustomer.Size = new System.Drawing.Size(63, 23);
            this.mbtnViewCustomer.TabIndex = 49;
            this.mbtnViewCustomer.Text = "View";
            this.mbtnViewCustomer.UseSelectable = true;
            this.mbtnViewCustomer.Click += new System.EventHandler(this.mbtnViewCustomer_Click);
            // 
            // CustomerDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(633, 499);
            this.Controls.Add(this.mbtnViewCustomer);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtDepositAmt);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtSaleAmt);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtOpeningAmt);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.View_bt);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.Delete_bt);
            this.Controls.Add(this.Close_bt);
            this.Controls.Add(this.Save_bt);
            this.Controls.Add(this.txtTotalAmt);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerDeposit";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "CustomerDeposit";
            this.Load += new System.EventHandler(this.CustomerDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton View_bt;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroButton Delete_bt;
        private MetroFramework.Controls.MetroButton Close_bt;
        private MetroFramework.Controls.MetroButton Save_bt;
        private System.Windows.Forms.TextBox txtTotalAmt;
        private System.Windows.Forms.ComboBox cbCustomer;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtOpeningAmt;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.TextBox txtSaleAmt;
        private System.Windows.Forms.TextBox txtDepositAmt;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.TextBox txtBalance;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton mbtnViewCustomer;
    }
}