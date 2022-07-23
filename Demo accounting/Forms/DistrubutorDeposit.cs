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
    public partial class DistrubutorDeposit : MetroFramework.Forms.MetroForm
    {

        OleDbConnection con = new OleDbConnection(ConfigurationManager.AppSettings["Con"]);

        public DistrubutorDeposit()
        {
            InitializeComponent();
        }

        private void CustomerDeposit_Load(object sender, EventArgs e)
        {

        }

        private void Close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void View_bt_Click(object sender, EventArgs e)
        {

            {
                try
                {


                    string str = "SELECT * FROM [DestributorDepositTbl] WHERE [DepositDate] =#" + metroDateTime1.Value.Date.ToShortDateString() + "#   ";
                    OleDbDataAdapter da = new OleDbDataAdapter(str, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;


                }
                catch (Exception x)
                {

                }
            }
        }

        private void Type_cb_Enter(object sender, EventArgs e)
        {

        }

        private void cbCustomer_Enter(object sender, EventArgs e)
        {

            // For Product list
            try
            {
                //For Clearing item 
                cbDistributor.Items.Clear();

                //For Dropp down list

                cbDistributor.DroppedDown = true;


                OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Person] order by [PersonName] Asc", con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cbDistributor.Items.Add(ds.Tables[0].Rows[i]["PersonName"].ToString());
                }


            }
            catch (Exception x)
            {
                //MetroFramework.MetroMessageBox.Show(this, "Error" + x, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void funOpening()
        {
            // For opening Amoount
            try
            {
                //For Clearing item 
                txtOpeningAmt.Clear();

                OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Person] where [PersonName]='" + cbDistributor.Text + "'  ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                    txtOpeningAmt.Text = dt.Rows[0]["OpeningAmt"].ToString();
                else
                    txtOpeningAmt.Text = "00.00";
            }
            catch (Exception x)
            {
                //MetroFramework.MetroMessageBox.Show(this, "Error" + x, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        void funPurchaseTotal()
        {
            // For opening Amoount
            try
            {
                //For Clearing item 
                txtSaleAmt.Clear();

                OleDbDataAdapter da = new OleDbDataAdapter("Select Sum(TotalAmt) from [Purchase] where [VendorName]='" + cbDistributor.Text + "'  ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //string 
                if (!string.IsNullOrEmpty(dt.Rows[0][0].ToString()))
                    txtSaleAmt.Text = dt.Rows[0][0].ToString();
                else
                    txtSaleAmt.Text = "00.00";
            }
            catch (Exception x)
            {
                //MetroFramework.MetroMessageBox.Show(this, "Error" + x, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        void funDepositTotal()
        {
            // For opening Amoount
            try
            {
                //For Clearing item 
                txtDepositAmt.Clear();

                OleDbDataAdapter da = new OleDbDataAdapter("Select Sum(CashAmt) from [DestributorDepositTbl] where [DistributorName]='" + cbDistributor.Text + "'  ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (!string.IsNullOrEmpty(dt.Rows[0][0].ToString()))
                    txtDepositAmt.Text = dt.Rows[0][0].ToString();
                else
                    txtDepositAmt.Text = "00.00";
            }
            catch (Exception x)
            {
                //MetroFramework.MetroMessageBox.Show(this, "Error" + x, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        void funAmount()
        {
            try
            {
                double amt = 0;
                amt = (Convert.ToDouble(txtOpeningAmt.Text) + Convert.ToDouble(txtSaleAmt.Text)) - Convert.ToDouble(txtDepositAmt.Text);
                txtTotalAmt.Text = amt.ToString("00.00");
            }
            catch
            {
                txtTotalAmt.Text = "00.00";
            }
        }


        private void mbtnViewCustomer_Click(object sender, EventArgs e)
        {
            funOpening();
            funPurchaseTotal();
            funDepositTotal();
            funAmount();
        }

        void funCash()
        {
            try
            {
                double amt = 0;
                amt = (Convert.ToDouble(txtTotalAmt.Text) - Convert.ToDouble(txtCash.Text));
                txtBalance.Text = amt.ToString("00.00");
            }
            catch
            {
                txtBalance.Text = "00.00";
            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            funCash();
        }

        void funClear()
        {
            cbDistributor.Text = "";
            txtTotalAmt.Text = "";
            txtCash.Text = "";
            txtBalance.Text = "";
            txtOpeningAmt.Text = "00.00";
            txtSaleAmt.Text = "00.00";
            txtDepositAmt.Text = "00.00";
        }
        private void Save_bt_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbDataAdapter da = new OleDbDataAdapter("Insert into [DestributorDepositTbl] (DistributorName,DepositDate,TotalAmt,CashAmt,BalanceAmt) values('" + cbDistributor.Text + "' ,'" + metroDateTime1.Value.ToShortDateString() + "' ," + txtTotalAmt.Text + "," + txtCash.Text + "," + txtBalance.Text + "  ) ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                MessageBox.Show("Saved Succussfully.." + cbDistributor.Text);
                funClear();//..for clearing after inserting values
                cbDistributor.Focus();
                cbDistributor.DroppedDown = true;

            }
            catch (Exception x)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error" + x, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Delete_bt_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbDataAdapter da = new OleDbDataAdapter("Delete from [DestributorDepositTbl] where [DistributorDepID]=  " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);  

                MessageBox.Show("Deleted Succussfully.." );
                View_bt_Click(null, null);

            }
            catch (Exception x)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error" + x, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
