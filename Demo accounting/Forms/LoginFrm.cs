using System;
using System.Data;
using System.Windows.Forms;

using System.Data.OleDb;
using System.Configuration;
using Maharashtra;

namespace Accounting_Project.Project
{
    public partial class LoginFrm : MetroFramework .Forms .MetroForm
    {
        OleDbConnection conn = new OleDbConnection(ConfigurationManager.AppSettings["Con"]);
    
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Users] where [User] ='"+User_tx .Text +"' and [Pwd]='"+Pwd_tx .Text +"' ",conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                FormMain F = new FormMain();
                F.Show();
                F.ProjectName_MB.Text = User_tx.Text;
                this.Hide();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Wrong User Name and Password !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                User_tx.Clear();
                Pwd_tx.Clear();
                User_tx.Focus();
            }

        }

        private void Exit_bt_Click(object sender, EventArgs e)
        {
            //For existing from Project
            Application.Exit();
        }

        private void User_tx_Click(object sender, EventArgs e)
        {

        }

        private void User_tx_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
