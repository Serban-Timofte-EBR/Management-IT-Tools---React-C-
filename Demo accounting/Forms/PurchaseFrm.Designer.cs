namespace Accounting_Project.Forms
{
    partial class PurchaseFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.In_bt = new MetroFramework.Controls.MetroButton();
            this.TotalAmt_tx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.Edit_bt = new MetroFramework.Controls.MetroButton();
            this.Remove_bt = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Sr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate_dt = new MetroFramework.Controls.MetroDateTime();
            this.Delete_bt = new MetroFramework.Controls.MetroButton();
            this.Close_bt = new MetroFramework.Controls.MetroButton();
            this.Save_bt = new MetroFramework.Controls.MetroButton();
            this.Update_bt = new MetroFramework.Controls.MetroButton();
            this.Amount_tx = new MetroFramework.Controls.MetroTextBox();
            this.Rate_tx = new MetroFramework.Controls.MetroTextBox();
            this.Qty_tx = new MetroFramework.Controls.MetroTextBox();
            this.ProductId_tx = new MetroFramework.Controls.MetroTextBox();
            this.Invoice_tx = new MetroFramework.Controls.MetroTextBox();
            this.View_bt = new MetroFramework.Controls.MetroButton();
            this.ProductName_cb = new System.Windows.Forms.ComboBox();
            this.VendorName_cb = new System.Windows.Forms.ComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.In_bt);
            this.metroPanel1.Controls.Add(this.TotalAmt_tx);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.Edit_bt);
            this.metroPanel1.Controls.Add(this.Remove_bt);
            this.metroPanel1.Controls.Add(this.metroGrid1);
            this.metroPanel1.Controls.Add(this.PurchaseDate_dt);
            this.metroPanel1.Controls.Add(this.Delete_bt);
            this.metroPanel1.Controls.Add(this.Close_bt);
            this.metroPanel1.Controls.Add(this.Save_bt);
            this.metroPanel1.Controls.Add(this.Update_bt);
            this.metroPanel1.Controls.Add(this.Amount_tx);
            this.metroPanel1.Controls.Add(this.Rate_tx);
            this.metroPanel1.Controls.Add(this.Qty_tx);
            this.metroPanel1.Controls.Add(this.ProductId_tx);
            this.metroPanel1.Controls.Add(this.Invoice_tx);
            this.metroPanel1.Controls.Add(this.View_bt);
            this.metroPanel1.Controls.Add(this.ProductName_cb);
            this.metroPanel1.Controls.Add(this.VendorName_cb);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(784, 465);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // In_bt
            // 
            this.In_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.In_bt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.In_bt.Location = new System.Drawing.Point(637, 320);
            this.In_bt.Name = "In_bt";
            this.In_bt.Size = new System.Drawing.Size(75, 23);
            this.In_bt.TabIndex = 28;
            this.In_bt.Text = "&In";
            this.In_bt.UseSelectable = true;
            this.In_bt.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // TotalAmt_tx
            // 
            // 
            // 
            // 
            this.TotalAmt_tx.CustomButton.Image = null;
            this.TotalAmt_tx.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.TotalAmt_tx.CustomButton.Name = "";
            this.TotalAmt_tx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TotalAmt_tx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TotalAmt_tx.CustomButton.TabIndex = 1;
            this.TotalAmt_tx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TotalAmt_tx.CustomButton.UseSelectable = true;
            this.TotalAmt_tx.CustomButton.Visible = false;
            this.TotalAmt_tx.Lines = new string[0];
            this.TotalAmt_tx.Location = new System.Drawing.Point(39, 419);
            this.TotalAmt_tx.MaxLength = 32767;
            this.TotalAmt_tx.Name = "TotalAmt_tx";
            this.TotalAmt_tx.PasswordChar = '\0';
            this.TotalAmt_tx.PromptText = "Total Amt";
            this.TotalAmt_tx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TotalAmt_tx.SelectedText = "";
            this.TotalAmt_tx.SelectionLength = 0;
            this.TotalAmt_tx.SelectionStart = 0;
            this.TotalAmt_tx.ShortcutsEnabled = true;
            this.TotalAmt_tx.Size = new System.Drawing.Size(98, 23);
            this.TotalAmt_tx.TabIndex = 27;
            this.TotalAmt_tx.UseSelectable = true;
            this.TotalAmt_tx.WaterMark = "Total Amt";
            this.TotalAmt_tx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TotalAmt_tx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(41, 397);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(87, 19);
            this.metroLabel9.TabIndex = 26;
            this.metroLabel9.Text = "Total Amount";
            // 
            // Edit_bt
            // 
            this.Edit_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Edit_bt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Edit_bt.Location = new System.Drawing.Point(637, 185);
            this.Edit_bt.Name = "Edit_bt";
            this.Edit_bt.Size = new System.Drawing.Size(75, 23);
            this.Edit_bt.TabIndex = 25;
            this.Edit_bt.Text = "&Edit";
            this.Edit_bt.UseSelectable = true;
            this.Edit_bt.Click += new System.EventHandler(this.Edit_bt_Click);
            // 
            // Remove_bt
            // 
            this.Remove_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Remove_bt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Remove_bt.Location = new System.Drawing.Point(637, 132);
            this.Remove_bt.Name = "Remove_bt";
            this.Remove_bt.Size = new System.Drawing.Size(75, 23);
            this.Remove_bt.TabIndex = 24;
            this.Remove_bt.Text = "&Remove";
            this.Remove_bt.UseSelectable = true;
            this.Remove_bt.Click += new System.EventHandler(this.Remove_bt_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sr,
            this.Pid,
            this.Product,
            this.Qty,
            this.Rate,
            this.Amount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(41, 96);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidth = 50;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(572, 181);
            this.metroGrid1.TabIndex = 23;
            // 
            // Sr
            // 
            this.Sr.FillWeight = 50F;
            this.Sr.HeaderText = "Sr No";
            this.Sr.Name = "Sr";
            this.Sr.ReadOnly = true;
            this.Sr.Width = 70;
            // 
            // Pid
            // 
            this.Pid.HeaderText = "Product Id";
            this.Pid.Name = "Pid";
            this.Pid.ReadOnly = true;
            this.Pid.Width = 90;
            // 
            // Product
            // 
            this.Product.FillWeight = 150F;
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 150;
            // 
            // Qty
            // 
            this.Qty.FillWeight = 50F;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 70;
            // 
            // Rate
            // 
            this.Rate.FillWeight = 50F;
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            this.Rate.Width = 70;
            // 
            // Amount
            // 
            this.Amount.FillWeight = 50F;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 70;
            // 
            // PurchaseDate_dt
            // 
            this.PurchaseDate_dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PurchaseDate_dt.Location = new System.Drawing.Point(562, 41);
            this.PurchaseDate_dt.MinimumSize = new System.Drawing.Size(0, 29);
            this.PurchaseDate_dt.Name = "PurchaseDate_dt";
            this.PurchaseDate_dt.Size = new System.Drawing.Size(116, 29);
            this.PurchaseDate_dt.TabIndex = 22;
            // 
            // Delete_bt
            // 
            this.Delete_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Delete_bt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Delete_bt.Location = new System.Drawing.Point(329, 419);
            this.Delete_bt.Name = "Delete_bt";
            this.Delete_bt.Size = new System.Drawing.Size(75, 23);
            this.Delete_bt.TabIndex = 21;
            this.Delete_bt.Text = "&Delete";
            this.Delete_bt.UseSelectable = true;
            this.Delete_bt.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Close_bt
            // 
            this.Close_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Close_bt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Close_bt.Location = new System.Drawing.Point(693, 419);
            this.Close_bt.Name = "Close_bt";
            this.Close_bt.Size = new System.Drawing.Size(75, 23);
            this.Close_bt.TabIndex = 20;
            this.Close_bt.Text = "&Close";
            this.Close_bt.UseSelectable = true;
            this.Close_bt.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // Save_bt
            // 
            this.Save_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Save_bt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Save_bt.Location = new System.Drawing.Point(538, 419);
            this.Save_bt.Name = "Save_bt";
            this.Save_bt.Size = new System.Drawing.Size(128, 23);
            this.Save_bt.TabIndex = 19;
            this.Save_bt.Text = "&Save and Print";
            this.Save_bt.UseSelectable = true;
            this.Save_bt.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Update_bt
            // 
            this.Update_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Update_bt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Update_bt.Location = new System.Drawing.Point(420, 419);
            this.Update_bt.Name = "Update_bt";
            this.Update_bt.Size = new System.Drawing.Size(75, 23);
            this.Update_bt.TabIndex = 18;
            this.Update_bt.Text = "&Update";
            this.Update_bt.UseSelectable = true;
            this.Update_bt.Click += new System.EventHandler(this.Update_bt_Click);
            // 
            // Amount_tx
            // 
            // 
            // 
            // 
            this.Amount_tx.CustomButton.Image = null;
            this.Amount_tx.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.Amount_tx.CustomButton.Name = "";
            this.Amount_tx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Amount_tx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Amount_tx.CustomButton.TabIndex = 1;
            this.Amount_tx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Amount_tx.CustomButton.UseSelectable = true;
            this.Amount_tx.CustomButton.Visible = false;
            this.Amount_tx.Lines = new string[0];
            this.Amount_tx.Location = new System.Drawing.Point(515, 320);
            this.Amount_tx.MaxLength = 32767;
            this.Amount_tx.Name = "Amount_tx";
            this.Amount_tx.PasswordChar = '\0';
            this.Amount_tx.PromptText = "Amount";
            this.Amount_tx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Amount_tx.SelectedText = "";
            this.Amount_tx.SelectionLength = 0;
            this.Amount_tx.SelectionStart = 0;
            this.Amount_tx.ShortcutsEnabled = true;
            this.Amount_tx.Size = new System.Drawing.Size(98, 23);
            this.Amount_tx.TabIndex = 17;
            this.Amount_tx.UseSelectable = true;
            this.Amount_tx.WaterMark = "Amount";
            this.Amount_tx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Amount_tx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Rate_tx
            // 
            // 
            // 
            // 
            this.Rate_tx.CustomButton.Image = null;
            this.Rate_tx.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.Rate_tx.CustomButton.Name = "";
            this.Rate_tx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Rate_tx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Rate_tx.CustomButton.TabIndex = 1;
            this.Rate_tx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Rate_tx.CustomButton.UseSelectable = true;
            this.Rate_tx.CustomButton.Visible = false;
            this.Rate_tx.Lines = new string[] {
        "0"};
            this.Rate_tx.Location = new System.Drawing.Point(418, 320);
            this.Rate_tx.MaxLength = 32767;
            this.Rate_tx.Name = "Rate_tx";
            this.Rate_tx.PasswordChar = '\0';
            this.Rate_tx.PromptText = "Rate";
            this.Rate_tx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Rate_tx.SelectedText = "";
            this.Rate_tx.SelectionLength = 0;
            this.Rate_tx.SelectionStart = 0;
            this.Rate_tx.ShortcutsEnabled = true;
            this.Rate_tx.Size = new System.Drawing.Size(75, 23);
            this.Rate_tx.TabIndex = 16;
            this.Rate_tx.Text = "0";
            this.Rate_tx.UseSelectable = true;
            this.Rate_tx.WaterMark = "Rate";
            this.Rate_tx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Rate_tx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Rate_tx.TextChanged += new System.EventHandler(this.Rate_tx_TextChanged);
            this.Rate_tx.Click += new System.EventHandler(this.Rate_tx_Click);
            this.Rate_tx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rate_tx_KeyPress);
            // 
            // Qty_tx
            // 
            // 
            // 
            // 
            this.Qty_tx.CustomButton.Image = null;
            this.Qty_tx.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.Qty_tx.CustomButton.Name = "";
            this.Qty_tx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Qty_tx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Qty_tx.CustomButton.TabIndex = 1;
            this.Qty_tx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Qty_tx.CustomButton.UseSelectable = true;
            this.Qty_tx.CustomButton.Visible = false;
            this.Qty_tx.Lines = new string[] {
        "0"};
            this.Qty_tx.Location = new System.Drawing.Point(329, 320);
            this.Qty_tx.MaxLength = 32767;
            this.Qty_tx.Name = "Qty_tx";
            this.Qty_tx.PasswordChar = '\0';
            this.Qty_tx.PromptText = "Qty";
            this.Qty_tx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Qty_tx.SelectedText = "";
            this.Qty_tx.SelectionLength = 0;
            this.Qty_tx.SelectionStart = 0;
            this.Qty_tx.ShortcutsEnabled = true;
            this.Qty_tx.Size = new System.Drawing.Size(75, 23);
            this.Qty_tx.TabIndex = 15;
            this.Qty_tx.Text = "0";
            this.Qty_tx.UseSelectable = true;
            this.Qty_tx.WaterMark = "Qty";
            this.Qty_tx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Qty_tx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Qty_tx.TextChanged += new System.EventHandler(this.Qty_tx_TextChanged);
            this.Qty_tx.Click += new System.EventHandler(this.Qty_tx_Click);
            this.Qty_tx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Qty_tx_KeyPress);
            // 
            // ProductId_tx
            // 
            // 
            // 
            // 
            this.ProductId_tx.CustomButton.Image = null;
            this.ProductId_tx.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.ProductId_tx.CustomButton.Name = "";
            this.ProductId_tx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ProductId_tx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductId_tx.CustomButton.TabIndex = 1;
            this.ProductId_tx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductId_tx.CustomButton.UseSelectable = true;
            this.ProductId_tx.CustomButton.Visible = false;
            this.ProductId_tx.Lines = new string[0];
            this.ProductId_tx.Location = new System.Drawing.Point(239, 320);
            this.ProductId_tx.MaxLength = 32767;
            this.ProductId_tx.Name = "ProductId_tx";
            this.ProductId_tx.PasswordChar = '\0';
            this.ProductId_tx.PromptText = "Product Id";
            this.ProductId_tx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductId_tx.SelectedText = "";
            this.ProductId_tx.SelectionLength = 0;
            this.ProductId_tx.SelectionStart = 0;
            this.ProductId_tx.ShortcutsEnabled = true;
            this.ProductId_tx.Size = new System.Drawing.Size(75, 23);
            this.ProductId_tx.TabIndex = 14;
            this.ProductId_tx.UseSelectable = true;
            this.ProductId_tx.WaterMark = "Product Id";
            this.ProductId_tx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductId_tx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ProductId_tx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductId_tx_KeyPress);
            // 
            // Invoice_tx
            // 
            // 
            // 
            // 
            this.Invoice_tx.CustomButton.Image = null;
            this.Invoice_tx.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.Invoice_tx.CustomButton.Name = "";
            this.Invoice_tx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Invoice_tx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Invoice_tx.CustomButton.TabIndex = 1;
            this.Invoice_tx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Invoice_tx.CustomButton.UseSelectable = true;
            this.Invoice_tx.CustomButton.Visible = false;
            this.Invoice_tx.Lines = new string[0];
            this.Invoice_tx.Location = new System.Drawing.Point(39, 47);
            this.Invoice_tx.MaxLength = 32767;
            this.Invoice_tx.Name = "Invoice_tx";
            this.Invoice_tx.PasswordChar = '\0';
            this.Invoice_tx.PromptText = "Invoice No";
            this.Invoice_tx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Invoice_tx.SelectedText = "";
            this.Invoice_tx.SelectionLength = 0;
            this.Invoice_tx.SelectionStart = 0;
            this.Invoice_tx.ShortcutsEnabled = true;
            this.Invoice_tx.Size = new System.Drawing.Size(75, 23);
            this.Invoice_tx.TabIndex = 13;
            this.Invoice_tx.UseSelectable = true;
            this.Invoice_tx.WaterMark = "Invoice No";
            this.Invoice_tx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Invoice_tx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // View_bt
            // 
            this.View_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.View_bt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.View_bt.Location = new System.Drawing.Point(134, 47);
            this.View_bt.Name = "View_bt";
            this.View_bt.Size = new System.Drawing.Size(75, 23);
            this.View_bt.TabIndex = 12;
            this.View_bt.Text = "&View";
            this.View_bt.UseSelectable = true;
            this.View_bt.Click += new System.EventHandler(this.View_bt_Click);
            // 
            // ProductName_cb
            // 
            this.ProductName_cb.DropDownHeight = 120;
            this.ProductName_cb.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName_cb.FormattingEnabled = true;
            this.ProductName_cb.IntegralHeight = false;
            this.ProductName_cb.Location = new System.Drawing.Point(39, 318);
            this.ProductName_cb.Name = "ProductName_cb";
            this.ProductName_cb.Size = new System.Drawing.Size(194, 25);
            this.ProductName_cb.TabIndex = 11;
            this.ProductName_cb.SelectedIndexChanged += new System.EventHandler(this.ProductName_cb_SelectedIndexChanged);
            this.ProductName_cb.Enter += new System.EventHandler(this.ProductName_cb_Enter);
            this.ProductName_cb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductName_cb_KeyPress);
            // 
            // VendorName_cb
            // 
            this.VendorName_cb.DropDownHeight = 120;
            this.VendorName_cb.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorName_cb.FormattingEnabled = true;
            this.VendorName_cb.IntegralHeight = false;
            this.VendorName_cb.Location = new System.Drawing.Point(239, 45);
            this.VendorName_cb.Name = "VendorName_cb";
            this.VendorName_cb.Size = new System.Drawing.Size(294, 25);
            this.VendorName_cb.TabIndex = 10;
            this.VendorName_cb.Enter += new System.EventHandler(this.VendorName_cb_Enter);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(528, 298);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(56, 19);
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "Amount";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(239, 296);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(70, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Product Id";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(241, 19);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(45, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Name";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(39, 298);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Product";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(344, 296);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(30, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Qty";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(418, 298);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(35, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Rate";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(564, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Date";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Invoice No";
            // 
            // PurchaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 545);
            this.Controls.Add(this.metroPanel1);
            this.Name = "PurchaseFrm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Purchase Frm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PurchaseFrm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TotalAmt_tx;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton Edit_bt;
        private MetroFramework.Controls.MetroButton Remove_bt;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private MetroFramework.Controls.MetroDateTime PurchaseDate_dt;
        private MetroFramework.Controls.MetroButton Delete_bt;
        private MetroFramework.Controls.MetroButton Close_bt;
        private MetroFramework.Controls.MetroButton Save_bt;
        private MetroFramework.Controls.MetroButton Update_bt;
        private MetroFramework.Controls.MetroTextBox Amount_tx;
        private MetroFramework.Controls.MetroTextBox Rate_tx;
        private MetroFramework.Controls.MetroTextBox Qty_tx;
        private MetroFramework.Controls.MetroTextBox ProductId_tx;
        private MetroFramework.Controls.MetroTextBox Invoice_tx;
        private MetroFramework.Controls.MetroButton View_bt;
        private System.Windows.Forms.ComboBox ProductName_cb;
        private System.Windows.Forms.ComboBox VendorName_cb;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton In_bt;
    }
}