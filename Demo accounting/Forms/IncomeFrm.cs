using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;
using System.Configuration;

namespace Accounting_Project.Forms
{
    public partial class IncomeFrm : MetroFramework .Forms .MetroForm 
    {
        OleDbConnection conn = new OleDbConnection(ConfigurationManager.AppSettings["Con"]);
    
     
        public IncomeFrm()
        {
            InitializeComponent();
        }

        private void IncomeFrm_Load(object sender, EventArgs e)
        {

        }


        void showGridData()
        {
            try
            {


                string str = "SELECT * FROM [Income] WHERE [EDate] =#" + metroDateTime1.Value.Date.ToShortDateString() + "#   ";
                OleDbDataAdapter da = new OleDbDataAdapter(str, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;


            }
            catch (Exception x)
            {

            }
        }

        private void View_bt_Click(object sender, EventArgs e)
        {
            showGridData();
        }

        private void Delete_bt_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Do you want to Delete ?", "Delete Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                string str = " DELETE FROM [Income] WHERE [IncomeID] = " + dataGridView1.SelectedRows[0].Cells["IncomeID"].Value.ToString() + "  ";
                OleDbDataAdapter da = new OleDbDataAdapter(str, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                showGridData();
            }
        }
        void clear()
        {
            Type_cb.Text = "";
            Amount_tx.Text = "";
            Particulars_cb.Text = "";

            Type_cb.Focus();
        }
        private void Save_bt_Click(object sender, EventArgs e)
        {
            //Disconnected Query

            try
            {
                if (Type_cb.Text == "" || Amount_tx.Text == "")
                {
                    MessageBox.Show("Please Enter Type and Amount Value  ! ");
                    Type_cb.Focus();

                }
                else
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Do you want to Save ?", "Save Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        string str = "INSERT INTO [Income] (Type,Particular,Amount,EDate) Values ('" + Type_cb.Text.ToUpper() + "','" + Particulars_cb.Text.ToUpper() + "'," + Amount_tx.Text + ",'" + metroDateTime1.Text + "'  ) ";
                        OleDbDataAdapter da = new OleDbDataAdapter(str, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);


                        MessageBox.Show("Successfully Saved ! - " + Type_cb.Text);

                        clear();
                        showGridData();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

        }

        private void Close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Type_cb_Enter(object sender, EventArgs e)
        {
            Type_cb.Items.Clear();

            Type_cb.DroppedDown = true;


            try
            {
                string str = "SELECT Distinct [Type] FROM [Expense] ORDER BY [Type]  ";
                OleDbDataAdapter da = new OleDbDataAdapter(str, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Type_cb.Items.Add(dt.Rows[i][0].ToString());
                }

            }
            catch { }

        }

        private void Particulars_cb_Enter(object sender, EventArgs e)
        {
            Particulars_cb.Items.Clear();

            Particulars_cb.DroppedDown = true;


            try
            {
                string str = "SELECT Distinct [Particular] FROM [Expense] ORDER BY [Particular]  ";
                OleDbDataAdapter da = new OleDbDataAdapter(str, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);


                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    Particulars_cb.Items.Add(dt.Rows[i][0].ToString());
                //}

                foreach (DataRow dr in dt.Rows)
                {
                    Particulars_cb.Items.Add(dr[0].ToString());
                }


            }
            catch { }

        }
    }
}
