namespace Accounting_Project.Forms
{
    partial class IncomeFrm
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
            this.Amount_tx = new System.Windows.Forms.TextBox();
            this.Particulars_cb = new System.Windows.Forms.ComboBox();
            this.Type_cb = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // View_bt
            // 
            this.View_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.View_bt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.View_bt.Location = new System.Drawing.Point(251, 62);
            this.View_bt.Name = "View_bt";
            this.View_bt.Size = new System.Drawing.Size(75, 23);
            this.View_bt.TabIndex = 25;
            this.View_bt.Text = "View";
            this.View_bt.UseSelectable = true;
            this.View_bt.Click += new System.EventHandler(this.View_bt_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 66);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(81, 19);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Select Date :";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime1.Location = new System.Drawing.Point(110, 60);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(132, 29);
            this.metroDateTime1.TabIndex = 23;
            // 
            // Delete_bt
            // 
            this.Delete_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Delete_bt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Delete_bt.Location = new System.Drawing.Point(586, 176);
            this.Delete_bt.Name = "Delete_bt";
            this.Delete_bt.Size = new System.Drawing.Size(75, 23);
            this.Delete_bt.TabIndex = 22;
            this.Delete_bt.Text = "Delete";
            this.Delete_bt.UseSelectable = true;
            this.Delete_bt.Click += new System.EventHandler(this.Delete_bt_Click);
            // 
            // Close_bt
            // 
            this.Close_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Close_bt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Close_bt.Location = new System.Drawing.Point(549, 378);
            this.Close_bt.Name = "Close_bt";
            this.Close_bt.Size = new System.Drawing.Size(75, 23);
            this.Close_bt.TabIndex = 21;
            this.Close_bt.Text = "Close";
            this.Close_bt.UseSelectable = true;
            this.Close_bt.Click += new System.EventHandler(this.Close_bt_Click);
            // 
            // Save_bt
            // 
            this.Save_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Save_bt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Save_bt.Location = new System.Drawing.Point(468, 378);
            this.Save_bt.Name = "Save_bt";
            this.Save_bt.Size = new System.Drawing.Size(75, 23);
            this.Save_bt.TabIndex = 20;
            this.Save_bt.Text = "Save";
            this.Save_bt.UseSelectable = true;
            this.Save_bt.Click += new System.EventHandler(this.Save_bt_Click);
            // 
            // Amount_tx
            // 
            this.Amount_tx.Location = new System.Drawing.Point(480, 309);
            this.Amount_tx.Name = "Amount_tx";
            this.Amount_tx.Size = new System.Drawing.Size(144, 20);
            this.Amount_tx.TabIndex = 19;
            // 
            // Particulars_cb
            // 
            this.Particulars_cb.DropDownHeight = 150;
            this.Particulars_cb.FormattingEnabled = true;
            this.Particulars_cb.IntegralHeight = false;
            this.Particulars_cb.Location = new System.Drawing.Point(251, 309);
            this.Particulars_cb.Name = "Particulars_cb";
            this.Particulars_cb.Size = new System.Drawing.Size(206, 21);
            this.Particulars_cb.TabIndex = 18;
            this.Particulars_cb.Enter += new System.EventHandler(this.Particulars_cb_Enter);
            // 
            // Type_cb
            // 
            this.Type_cb.DropDownHeight = 150;
            this.Type_cb.FormattingEnabled = true;
            this.Type_cb.IntegralHeight = false;
            this.Type_cb.Location = new System.Drawing.Point(23, 309);
            this.Type_cb.Name = "Type_cb";
            this.Type_cb.Size = new System.Drawing.Size(206, 21);
            this.Type_cb.TabIndex = 17;
            this.Type_cb.Enter += new System.EventHandler(this.Type_cb_Enter);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(544, 287);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Amount";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(276, 287);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Particulars";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 287);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Type";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 103);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(558, 175);
            this.dataGridView1.TabIndex = 13;
            // 
            // IncomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(682, 430);
            this.Controls.Add(this.View_bt);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.Delete_bt);
            this.Controls.Add(this.Close_bt);
            this.Controls.Add(this.Save_bt);
            this.Controls.Add(this.Amount_tx);
            this.Controls.Add(this.Particulars_cb);
            this.Controls.Add(this.Type_cb);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Name = "IncomeFrm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Income Frm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.IncomeFrm_Load);
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
        private System.Windows.Forms.TextBox Amount_tx;
        private System.Windows.Forms.ComboBox Particulars_cb;
        private System.Windows.Forms.ComboBox Type_cb;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}