using Accounting_Project.Reports;
using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Accounting_Project.Forms
{
    public partial class PurchaseFrm : MetroFramework.Forms.MetroForm
    {
        //For connection string

        OleDbConnection con = new OleDbConnection(ConfigurationManager.AppSettings["Con"]);

        public PurchaseFrm()
        {
            InitializeComponent();
        }

        void NewInvoice()
        {
            try
            {
                OleDbDataAdapter da = new OleDbDataAdapter("Select [Invoice] from [Purchase] order by [Invoice] desc", con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                //Row value + 1 for increament 
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Invoice_tx.Text = (int.Parse(ds.Tables[0].Rows[0][0].ToString()) + 1).ToString();
                }
                else
                {
                    Invoice_tx.Text = "1";
                }

            }
            catch (Exception x)
            {
               // MetroFramework.MetroMessageBox.Show(this, "Error" + x, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void PurchaseFrm_Load(object sender, EventArgs e)
        {
            //For New Invoice
            NewInvoice();

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

        void TotalAmount()
        {
            double  totalAmt = 0;
            try
            {
                for (int i = 0; i < metroGrid1.Rows.Count; i++)
                {
                    // 5 is the array coloumn no of amount  or u can use coloumn name

                    totalAmt = totalAmt + double .Parse (   (metroGrid1.Rows[i].Cells["Amount"].Value.ToString()));

                }

                TotalAmt_tx.Text = totalAmt.ToString("00.00");

            }
            catch (Exception x)
            {

            }

        }

        private void metroButton4_Click(object sender, EventArgs e)
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

        private void Rate_tx_TextChanged(object sender, EventArgs e)
        {
            Rate_Qty_Calculation();
        }

        private void Qty_tx_TextChanged(object sender, EventArgs e)
        {
            Rate_Qty_Calculation();
        }

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
                    ProductName_cb.Items.Add(ds .Tables [0].Rows [i]["Product"].ToString ());
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
               


                OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Product] where [Product] ='"+ProductName_cb .SelectedItem .ToString ()+"' ", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                              
                //When u select product it will show id in PID textbox

                ProductId_tx .Text =ds.Tables [0].Rows [0]["PID"].ToString ();

            }
            catch (Exception x)
            {
                //MetroFramework.MetroMessageBox.Show(this, "Error" + x, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void ProductName_cb_KeyPress(object sender, KeyPressEventArgs e)
        {

            //This code for keypress 
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
               //It will allow only alphabet and number 
            }
            else
            {
                e.Handled = true;
            }


            //this is use for Enter button 
            int d = Convert.ToInt32(e.KeyChar);
            if (d == 13  && ProductName_cb .Text !="")
            {
                //It will focus on pid after selecting the item from Product combobox

                ProductId_tx.Focus();
               
            }
        }

        private void ProductId_tx_KeyPress(object sender, KeyPressEventArgs e)
        {
            //This code for disable id is already entered
           
                e.Handled = true;
           


            //this is use for Enter button 
            int d = Convert.ToInt32(e.KeyChar);
            if (d == 13 && ProductId_tx.Text != "")
            {
                //It will focus on pid after selecting the item from Product combobox

                Qty_tx .Focus();

            }
        }

        private void Qty_tx_KeyPress(object sender, KeyPressEventArgs e)
        {
            //This code for keypress 
            if (char.IsDigit (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                //It will allow only  number and decimal value
            }
            else
            {
                e.Handled = true;
            }


            //this is use for Enter button 
            int d = Convert.ToInt32(e.KeyChar);
            if (d == 13 && Qty_tx.Text != "")
            {
                //It will focus on Rate after selecting the item from Product combobox

                Rate_tx .Focus();

            }
        }

        private void Rate_tx_KeyPress(object sender, KeyPressEventArgs e)
        {
            //This code for keypress 
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                //It will allow only  number and decimal value
            }
            else
            {
                e.Handled = true;
            }


            //this is use for Enter button 
            int d = Convert.ToInt32(e.KeyChar);
            if (d == 13 && Rate_tx.Text != "")
            {
                //It will focus on amount after selecting the item from Product combobox

                In_bt  .Focus();

            }
        }

        private void Remove_bt_Click(object sender, EventArgs e)
        {

            //For Stock

            //here we will minus the item when we delete invoice 

            if (Update_bt.Enabled == true)
            {
               // for (int i = 0; i < metroGrid1.Rows.Count; i++)
                {
                    string insertPur = "Update  Stock set Qty= Qty - " + metroGrid1.SelectedRows[0].Cells["Qty"].Value.ToString() + " where Pid =" + metroGrid1.SelectedRows[0].Cells["Pid"].Value.ToString() + "  ";

                    OleDbDataAdapter da = new OleDbDataAdapter(insertPur, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }

                //for deleting purchase item
                {
                    string Delete = "Delete from PurchaseItem where Invoice=" + Invoice_tx.Text + " and pid=" + metroGrid1.SelectedRows[0].Cells["Pid"].Value.ToString() + " and invoice =" + Invoice_tx.Text + "  ";

                    OleDbDataAdapter da = new OleDbDataAdapter(Delete, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }


            }

            //FOR SERIAL NO




            //If datagrid having more then one record 

            if (metroGrid1.Rows.Count > 0)
            {
                metroGrid1.Rows.Remove(metroGrid1.SelectedRows[0]);

                //For calculating total amount when record is Deleted
                TotalAmount();

            }

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_bt_Click(object sender, EventArgs e)
        {
            // sr no =0

            if (Update_bt.Enabled == true)
            {
               // for (int i = 0; i < metroGrid1.Rows.Count; i++)
                {
                    string insertPur = "Update  Stock set Qty= Qty - " + metroGrid1.SelectedRows[0].Cells["Qty"].Value.ToString() + " where Pid =" + metroGrid1.Rows[0].Cells["Pid"].Value.ToString() + "   ";

                    OleDbDataAdapter da = new OleDbDataAdapter(insertPur, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }

                //for deleting purchase item
                {
                    string Delete = "Delete from PurchaseItem where Invoice=" + Invoice_tx.Text + " and pid=" + metroGrid1.SelectedRows[0].Cells["Pid"].Value.ToString() + "  ";

                    OleDbDataAdapter da = new OleDbDataAdapter(Delete, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }

            }


            ProductId_tx.Text = metroGrid1 .SelectedRows [0].Cells [1].Value .ToString ();
            ProductName_cb.Text = metroGrid1.SelectedRows[0].Cells[2].Value.ToString();
            Qty_tx.Text = metroGrid1.SelectedRows[0].Cells[3].Value.ToString();
            Rate_tx.Text = metroGrid1.SelectedRows[0].Cells[4].Value.ToString();
            Amount_tx.Text = metroGrid1.SelectedRows[0].Cells[5].Value.ToString();


            //It will remove the record which is selected

            metroGrid1.Rows.Remove(metroGrid1.SelectedRows[0]);

            //For calculating total amount when record is edited
            TotalAmount();


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            //Stock table

            //here we will minus the item when we delete invoice
            for (int i = 0; i < metroGrid1.Rows.Count; i++)
            {
                string insertPur = "Update  Stock set Qty= Qty - " + metroGrid1.Rows[i].Cells["Qty"].Value.ToString() + " where Pid =" + metroGrid1.Rows[i].Cells["Pid"].Value.ToString() + "   ";

                OleDbDataAdapter da = new OleDbDataAdapter(insertPur, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }



            //FOR invoice deleting
            //purchase table
            {
                string Delete = "Delete from Purchase where Invoice=" + Invoice_tx.Text + " ";

                OleDbDataAdapter da = new OleDbDataAdapter(Delete, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }

            //purchaseitem table
            {
                string Delete = "Delete from PurchaseItem where Invoice=" + Invoice_tx.Text + " ";

                OleDbDataAdapter da = new OleDbDataAdapter(Delete, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }

           
        }
        void PrintBill()
        { 
        

        
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            //Purchase Table
            {
                string insertPur = "Insert into Purchase (Invoice,VendorName,PurchaseDate,TotalAmt) values ( " + Invoice_tx.Text + "  , '" + VendorName_cb.Text + "' ,'" + PurchaseDate_dt.Value.Date.ToString() + "'," + TotalAmt_tx.Text + "   ) ";

                OleDbDataAdapter da = new OleDbDataAdapter(insertPur, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
            //PurchaseItem Table

            for (int i = 0; i < metroGrid1.Rows.Count; i++)
            {
                string insertPur = "Insert into PurchaseItem (Invoice,Pid,Product,Rate,Qty,Amount) values ( " + Invoice_tx.Text + "  ," + metroGrid1.Rows[i].Cells["Pid"].Value.ToString() + " , '" + metroGrid1.Rows[i].Cells["Product"].Value.ToString() + "'," + metroGrid1.Rows[i].Cells["Rate"].Value.ToString() + "," + metroGrid1.Rows[i].Cells["Qty"].Value.ToString() + " ," + metroGrid1.Rows[i].Cells["Amount"].Value.ToString() + "  ) ";

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


                        string insertPur = "Update  Stock set Qty= Qty + " + metroGrid1.Rows[i].Cells["Qty"].Value.ToString() + " where Pid =" + metroGrid1.Rows[i].Cells["Pid"].Value.ToString() + "   ";

                        OleDbDataAdapter da = new OleDbDataAdapter(insertPur, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);


                    }
                    else
                    {

                        //When Item does not exist in stock

                        string insertPur = "Insert into Stock (Pid,Product,Rate,Qty,Amount) values ( " + metroGrid1.Rows[i].Cells["Pid"].Value.ToString() + " , '" + metroGrid1.Rows[i].Cells["Product"].Value.ToString() + "'," + metroGrid1.Rows[i].Cells["Rate"].Value.ToString() + "," + metroGrid1.Rows[i].Cells["Qty"].Value.ToString() + " ," + metroGrid1.Rows[i].Cells["Amount"].Value.ToString() + "   ) ";

                        OleDbDataAdapter da = new OleDbDataAdapter(insertPur, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                    }

                }

            }

            //After saving Print Option 

            if (MessageBox.Show("Saved successfully ,Do you want to Print !","Print Box",MessageBoxButtons .OK ,MessageBoxIcon .Information ) == DialogResult.OK)
            {
                PurchaseBill f = new PurchaseBill();

                try
                {
                    f.invoice = Invoice_tx.Text;
                    f.Show();
                }
                catch { }

            }

        }

        private void View_bt_Click(object sender, EventArgs e)
        {
          
            //View button enable only delete and update button.
            
            Invoice_tx.Enabled = false;
            Save_bt.Enabled = false;

            //View data from purchase table

            {
                string insertPur = "SELECT * FROM Purchase where invoice=" + Invoice_tx.Text + " ";

                OleDbDataAdapter da = new OleDbDataAdapter(insertPur, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                VendorName_cb.Text = ds.Tables[0].Rows[0]["VendorName"].ToString();
                PurchaseDate_dt.Text = ds.Tables[0].Rows[0]["PurchaseDate"].ToString();
                TotalAmt_tx.Text = ds.Tables[0].Rows[0]["TotalAmt"].ToString(); ;
            }


            //View data from purchaseItem

            {



                string insertPur = "SELECT * FROM Purchaseitem where invoice=" + Invoice_tx.Text + " ";

                OleDbDataAdapter da = new OleDbDataAdapter(insertPur, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                metroGrid1.Rows.Clear();

              



                for (int i = 0; i < ds.Tables [0].Rows.Count; i++)
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

                    metroGrid1.Rows.Add(Srno, ds.Tables[0].Rows[i]["Pid"].ToString(), ds.Tables[0].Rows[i]["Pid"].ToString(), ds.Tables[0].Rows[i]["Product"].ToString(), ds.Tables[0].Rows[i]["Qty"].ToString(), ds.Tables[0].Rows[i]["Rate"].ToString(), ds.Tables[0].Rows[i]["Amount"].ToString());

                }
            }

        }

        private void Update_bt_Click(object sender, EventArgs e)
        {
            Invoice_tx.Enabled = true;


            //In update query everyting can be edited except Invoice no.

            //Purchase Table
            {
             
                string Update = "Update Purchase set  VendorName=  '" + VendorName_cb.Text + "'   ,PurchaseDate  = '" + PurchaseDate_dt.Value.Date.ToString() + "'   ,TotalAmt =  " + TotalAmt_tx.Text + "  where [Invoie]= " + Invoice_tx.Text + "  ";

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


            {
                for (int i = 0; i < metroGrid1.Rows.Count; i++)
                {

                    OleDbDataAdapter da1 = new OleDbDataAdapter("Select * from Stock where Pid= " + metroGrid1.Rows[i].Cells["Pid"].Value.ToString() + " and Product=  '" + metroGrid1.Rows[i].Cells["Product"].Value.ToString() + "'  ", con);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        //When Item  exist in stock


                        string insertPur = "Update  Stock set Qty= Qty + " + metroGrid1.Rows[i].Cells["Qty"].Value.ToString() + " where Pid =" + metroGrid1.Rows[i].Cells["Pid"].Value.ToString() + "   ";

                        OleDbDataAdapter da = new OleDbDataAdapter(insertPur, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);


                    }
                    else
                    {

                        //When Item does not exist in stock

                        string insertPur = "Insert into Stock (Pid,Product,Rate,Qty,Amount) values ( " + metroGrid1.Rows[i].Cells["Pid"].Value.ToString() + " , '" + metroGrid1.Rows[i].Cells["Product"].Value.ToString() + "'," + metroGrid1.Rows[i].Cells["Rate"].Value.ToString() + "," + metroGrid1.Rows[i].Cells["Qty"].Value.ToString() + " ," + metroGrid1.Rows[i].Cells["Amount"].Value.ToString() + "   ) ";

                        OleDbDataAdapter da = new OleDbDataAdapter(insertPur, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                    }

                }

            }

            MessageBox.Show("Saved successfully !");


        }

        private void VendorName_cb_Enter(object sender, EventArgs e)
        {

            // For Product list
            try
            {
                //For Clearing item 
                VendorName_cb.Items.Clear();

                //For Dropp down list

                VendorName_cb.DroppedDown = true;


                OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Person] order by [PersonName] Asc", con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    VendorName_cb.Items.Add(ds.Tables[0].Rows[i]["PersonName"].ToString());
                }


            }
            catch (Exception x)
            {
                //MetroFramework.MetroMessageBox.Show(this, "Error" + x, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
    }
}












