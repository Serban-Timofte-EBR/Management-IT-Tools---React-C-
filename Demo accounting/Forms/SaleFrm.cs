using Accounting_Project.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_Project.Forms
{
    public partial class SaleFrm : MetroFramework.Forms .MetroForm 
    {

        
        OleDbConnection con = new OleDbConnection(ConfigurationManager.AppSettings["Con"]);


      //DoASAP
        public SaleFrm()
        {
            InitializeComponent();
        }

        //Error
        void NewInvoice()
        {
            try
            {
                OleDbDataAdapter da = new OleDbDataAdapter("Select [Invoice] from [Sale] order by [Invoice] desc", con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                //Row value + 1 for increament 
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Invoice_tx.Text = (int.Parse(ds.Tables[0].Rows[0][0].ToString()) + 1).ToString();
                }
                else
                {
                    Invoice_tx.Text = "10001";
                }

            }
            catch (Exception x)
            {
                Invoice_tx.Text = "10001";
                // MetroFramework.MetroMessageBox.Show(this, "Error" + x, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

     // UNDONE - function is undone 
        private void SaleFrm_Load(object sender, EventArgs e)
        {
            NewInvoice();
        }

        
     // TODO - Do as soon as possible 
        private void Save_bt_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Do you want to Save ?", "Save Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                //Sale Table
                {
                    string insertPur = "Insert into Sale (Invoice,CustomerName,SaleDate,TotalAmt) values ( " + Invoice_tx.Text + "  , '" + CustomerName_cb.Text + "' ,'" + PurchaseDate_dt.Value.Date.ToString() + "'," + TotalAmt_tx.Text + "   ) ";

                    OleDbDataAdapter da = new OleDbDataAdapter(insertPur, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }
                //SaleItem Table

                for (int i = 0; i < metroGrid1.Rows.Count; i++)
                {
                    string insertPur = "Insert into SaleItem (Invoice,Pid,Product,Rate,Qty,Amount) values ( " + Invoice_tx.Text + "  ," + metroGrid1.Rows[i].Cells["Pid"].Value.ToString() + " , '" + metroGrid1.Rows[i].Cells["Product"].Value.ToString() + "'," + metroGrid1.Rows[i].Cells["Rate"].Value.ToString() + "," + metroGrid1.Rows[i].Cells["Qty"].Value.ToString() + " ," + metroGrid1.Rows[i].Cells["Amount"].Value.ToString() + "  ) ";

                    OleDbDataAdapter da = new OleDbDataAdapter(insertPur, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                }

                //Stock Table


                {
                    for (int i = 0; i < metroGrid1.Rows.Count; i++)
                    {

                        OleDbDataAdapter da1 = new OleDbDataAdapter("Select * from Stock where Pid= " + metroGrid1.Rows[i].Cells["Pid"].Value.ToString() + " and Product=  '" + metroGrid1.Rows[i].Cells["Product"].Value.ToString() + "'  ", con);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            //When Item  exist in stock


                            string insertPur = "Update  Stock set Qty= Qty - " + metroGrid1.Rows[i].Cells["Qty"].Value.ToString() + " where Pid =" + metroGrid1.Rows[i].Cells["Pid"].Value.ToString() + "   ";

                            OleDbDataAdapter da = new OleDbDataAdapter(insertPur, con);
                            DataSet ds = new DataSet();
                            da.Fill(ds);


                        }
                        //else
                        //{

                        //    //When Item does not exist in stock

                        //    string insertPur = "Insert into Stock (Pid,Product,Rate,Qty,Amount) values ( " + metroGrid1.Rows[i].Cells["Pid"].Value.ToString() + " , '" + metroGrid1.Rows[i].Cells["Product"].Value.ToString() + "'," + metroGrid1.Rows[i].Cells["Rate"].Value.ToString() + "," + metroGrid1.Rows[i].Cells["Qty"].Value.ToString() + " ," + metroGrid1.Rows[i].Cells["Amount"].Value.ToString() + "   ) ";

                        //    OleDbDataAdapter da = new OleDbDataAdapter(insertPur, con);
                        //    DataSet ds = new DataSet();
                        //    da.Fill(ds);

                        //}

                    }

                }

                //After saving Print Option 
                
               // this.Close();
                if (MessageBox.Show("Saved successfully ,Do you want to Print !", "Print Box", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    SaleBill f = new SaleBill();

                    try
                    {
                        f.invoice = Invoice_tx.Text;
                        f.Show();
                    }
                    catch { }

                }
                else 
                {
                    clearAll();
                }
            }
        }

        // TODO - Do as soon as possible 
        private void ProductName_cb_Enter(object sender, EventArgs e)
        {

            // For Product list
            try
            {
                //For Clearing item 
                ProductName_cb.Items.Clear();

                //For Dropp down list

                ProductName_cb.DroppedDown = true;


                OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Product] order by [Product] desc", con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ProductName_cb.Items.Add(ds.Tables[0].Rows[i]["Product"].ToString());
                }


            }
            catch (Exception x)
            {
                //MetroFramework.MetroMessageBox.Show(this, "Error" + x, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void ProductName_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {



                OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Product] where [Product] ='" + ProductName_cb.SelectedItem.ToString() + "' ", con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                //When u select product it will show id in PID textbox

                ProductId_tx.Text = ds.Tables[0].Rows[0]["PID"].ToString();

                Rate_tx .Text = ds.Tables[0].Rows[0]["Rate"].ToString();

            }
            catch (Exception x)
            {
                //MetroFramework.MetroMessageBox.Show(this, "Error" + x, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Rate_Qty_Calculation()
        {
            try
            {
                Amount_tx.Text = (double.Parse(Qty_tx.Text) * double.Parse(Rate_tx.Text)).ToString();
            }
            catch (Exception x)
            {
                //MetroFramework.MetroMessageBox.Show(this, "Error" + x, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void Qty_tx_Click(object sender, EventArgs e)
        {
           
        }

        private void Rate_tx_Click(object sender, EventArgs e)
        {
            
        }

        private void Qty_tx_TextChanged(object sender, EventArgs e)
        {
            Rate_Qty_Calculation();
        }

        private void Rate_tx_TextChanged(object sender, EventArgs e)
        {
            Rate_Qty_Calculation();
        }
        void clearItem()
        {
            //Clearing item after enter the value

            ProductId_tx.Text = "";
            ProductName_cb.Text = "";
            Qty_tx.Text = "0";
            Rate_tx.Text = "0";
            Amount_tx.Text = "0";
           
            

        }
        void clearAll()
        {
            Invoice_tx.Enabled = true;
            Save_bt.Enabled = true ;
            metroGrid1.Rows.Clear();

            TotalAmt_tx.Text = "0.0";

            CustomerName_cb.Text = "";

            NewInvoice();
        }

        void TotalAmount()
        {
            double totalAmt = 0;
            try
            {
                for (int i = 0; i < metroGrid1.Rows.Count; i++)
                {
                    // 5 is the array coloumn no of amount  or u can use coloumn name

                    totalAmt = totalAmt + double.Parse((metroGrid1.Rows[i].Cells["Amount"].Value.ToString()));

                }

                TotalAmt_tx.Text = totalAmt.ToString("00.00");

            }
            catch (Exception x)
            {

            }

        }

        private void In_bt_Click(object sender, EventArgs e)
        {

            //For Putting value of pid,product,rate,qty in datagrid


            //For serial no 
            int Srno = 1;
            int d = metroGrid1.Rows.Count;
            if (d == 0)
            {
            }
            else
            {
                Srno = d;
                string s = metroGrid1.Rows[d - 1].Cells[0].Value.ToString();
                Srno = int.Parse(s);
                Srno++;
            }


            {
                metroGrid1.Rows.Add(Srno, ProductId_tx.Text, ProductName_cb.Text, Qty_tx.Text, Rate_tx.Text, Amount_tx.Text);
               clearItem();

                ProductName_cb.Focus();

                //For Calculating total amount after value enter
                TotalAmount();
            }
            
        }

        private void Delete_bt_Click(object sender, EventArgs e)
        {

            //Stock table

            if (MetroFramework.MetroMessageBox.Show(this, "Do you want to Delete !", "Delete Box", MessageBoxButtons.OKCancel , MessageBoxIcon.Information) == DialogResult.OK)
            {
                
                //here we will minus the item when we delete invoice
                for (int i = 0; i < metroGrid1.Rows.Count; i++)
                {
                    string insertPur = "Update  Stock set Qty= Qty + " + metroGrid1.Rows[i].Cells["Qty"].Value.ToString() + " where Pid =" + metroGrid1.Rows[i].Cells["Pid"].Value.ToString() + "   ";

                    OleDbDataAdapter da = new OleDbDataAdapter(insertPur, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }



                //FOR invoice deleting
                //Sale table
                {
                    string Delete = "Delete from [Sale] where [Invoice]=" + Invoice_tx.Text + " ";

                    OleDbDataAdapter da = new OleDbDataAdapter(Delete, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }

                //Saleitem table
                {
                    string Delete = "Delete from [SaleItem] where [Invoice]=" + Invoice_tx.Text + " ";

                    OleDbDataAdapter da = new OleDbDataAdapter(Delete, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }
                clearAll ();

            }
            else 
            {


            }

        }

        private void Update_bt_Click(object sender, EventArgs e)
        {

            if (MetroFramework.MetroMessageBox.Show(this, "Do you want to Update !", "Update Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Invoice_tx.Enabled = true;


                //In update query everyting can be edited except Invoice no.

                //Sale Table
                {

                    string Update = "Update [Sale] set  CustomerName=  '" + CustomerName_cb.Text + "'   ,SaleDate  = '" + PurchaseDate_dt.Value.Date.ToString() + "'   ,TotalAmt =  " + TotalAmt_tx.Text + "  where [Invoice]= " + Invoice_tx.Text + "  ";

                    OleDbDataAdapter da = new OleDbDataAdapter(Update, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }



                //PurchaseItem Table

                //for (int i = 0; i < metroGrid1.Rows.Count; i++)
                //{
                //    string insertPur = "Insert into PurchaseItem (Invoice,Pid,Product,Rate,Qty,Amount) values ( " + Invoice_tx.Text + "  ," + metroGrid1.Rows[i].Cells["Pid"].Value.ToString() + " , '" + metroGrid1.Rows[i].Cells["Product"].Value.ToString() + "'," + metroGrid1.Rows[i].Cells["Rate"].Value.ToString() + "," + metroGrid1.Rows[i].Cells["Qty"].Value.ToString() + " ," + metroGrid1.Rows[i].Cells["Amount"].Value.ToString() + "  ) ";

                //    OleDbDataAdapter da = new OleDbDataAdapter(insertPur, con);
                //    DataSet ds = new DataSet();
                //    da.Fill(ds);

                //}

                //Stock Table


                //{
                //    for (int i = 0; i < metroGrid1.Rows.Count; i++)
                //    {

                //        OleDbDataAdapter da1 = new OleDbDataAdapter("Select * from Stock where Pid= " + metroGrid1.Rows[i].Cells["Pid"].Value.ToString() + " and Product=  '" + metroGrid1.Rows[i].Cells["Product"].Value.ToString() + "'  ", con);
                //        DataSet ds1 = new DataSet();
                //        da1.Fill(ds1);

                //        if (ds1.Tables[0].Rows.Count > 0)
                //        {
                //            //When Item  exist in stock


                //            string insertPur = "Update  Stock set Qty= Qty + " + metroGrid1.Rows[i].Cells["Qty"].Value.ToString() + " where Pid =" + metroGrid1.Rows[i].Cells["Pid"].Value.ToString() + "   ";

                //            OleDbDataAdapter da = new OleDbDataAdapter(insertPur, con);
                //            DataSet ds = new DataSet();
                //            da.Fill(ds);


                //        }
                //        else
                //        {

                //            //When Item does not exist in stock

                //            string insertPur = "Insert into Stock (Pid,Product,Rate,Qty,Amount) values ( " + metroGrid1.Rows[i].Cells["Pid"].Value.ToString() + " , '" + metroGrid1.Rows[i].Cells["Product"].Value.ToString() + "'," + metroGrid1.Rows[i].Cells["Rate"].Value.ToString() + "," + metroGrid1.Rows[i].Cells["Qty"].Value.ToString() + " ," + metroGrid1.Rows[i].Cells["Amount"].Value.ToString() + "   ) ";

                //            OleDbDataAdapter da = new OleDbDataAdapter(insertPur, con);
                //            DataSet ds = new DataSet();
                //            da.Fill(ds);

                //        }

                //    }

                //}
                MessageBox.Show("Updated successfully !");
                clearAll();
            }
           

        }

        private void Edit_bt_Click(object sender, EventArgs e)
        {
            ProductId_tx.Text = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
            ProductName_cb.Text = metroGrid1.SelectedRows[0].Cells[2].Value.ToString();
            Qty_tx.Text = metroGrid1.SelectedRows[0].Cells[3].Value.ToString();
            Rate_tx.Text = metroGrid1.SelectedRows[0].Cells[4].Value.ToString();
            Amount_tx.Text = metroGrid1.SelectedRows[0].Cells[5].Value.ToString();


            //It will remove the record which is selected

            metroGrid1.Rows.Remove(metroGrid1.SelectedRows[0]);

            //For calculating total amount when record is edited
            TotalAmount();

        }

        private void Remove_bt_Click(object sender, EventArgs e)
        {

            if (metroGrid1.Rows.Count > 0)
            {
                metroGrid1.Rows.Remove(metroGrid1.SelectedRows[0]);

                //For calculating total amount when record is Deleted
                TotalAmount();

            }
        }

        private void View_bt_Click(object sender, EventArgs e)
        {
            //View button enable only delete and update button.

           

            //View data from purchase table

            {
                string insertPur = "SELECT * FROM [Sale] where [Invoice]=" + Invoice_tx.Text + " ";

                OleDbDataAdapter da = new OleDbDataAdapter(insertPur, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
               
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Invoice_tx.Enabled = false;
                    Save_bt.Enabled = false;

                    CustomerName_cb.Text = ds.Tables[0].Rows[0]["CustomerName"].ToString();
                    PurchaseDate_dt.Text = ds.Tables[0].Rows[0]["SaleDate"].ToString();
                    TotalAmt_tx.Text = ds.Tables[0].Rows[0]["TotalAmt"].ToString(); ;
                }
                else
                {
                    MessageBox.Show("Invoice does not Exist !");
                    clearAll();
                }
            }


            //View data from purchaseItem

            {



                string insertPur = "SELECT * FROM [Saleitem] where [Invoice]=" + Invoice_tx.Text + " ";

                OleDbDataAdapter da = new OleDbDataAdapter(insertPur, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                metroGrid1.Rows.Clear();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    //For serial no 
                    int Srno = 1;
                    int d = metroGrid1.Rows.Count;
                    if (d == 0)
                    {
                    }
                    else
                    {
                        Srno = d;
                        string s = metroGrid1.Rows[d - 1].Cells[0].Value.ToString();
                        Srno = int.Parse(s);
                        Srno++;
                    }

                    metroGrid1.Rows.Add(Srno, ds.Tables[0].Rows[i]["Pid"].ToString(),  ds.Tables[0].Rows[i]["Product"].ToString(), ds.Tables[0].Rows[i]["Qty"].ToString(), ds.Tables[0].Rows[i]["Rate"].ToString(), ds.Tables[0].Rows[i]["Amount"].ToString());

                }
            }


        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerName_cb_Enter(object sender, EventArgs e)
        {

            // For  list
            try
            {
                //For Clearing item 
                CustomerName_cb.Items.Clear();

                //For Dropp down list

                CustomerName_cb.DroppedDown = true;


                OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Person] order by [PersonName] Asc", con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    CustomerName_cb.Items.Add(ds.Tables[0].Rows[i]["PersonName"].ToString());
                }


            }
            catch (Exception x)
            {
                //MetroFramework.MetroMessageBox.Show(this, "Error" + x, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
    }
}
