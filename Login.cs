using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Gentry
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public SqlCommand cmd = new SqlCommand();


        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Reset();

        }
        void Reset() 
        {
            txtUser.Text = "";
            txtPassword.Text = "";
        }

        private void tblLogin_Click(object sender, EventArgs e)
        {
            //-- get connection
            SqlConnection con = DB.GetConnection();
            // check connection if closed
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("select count(*) as ct from tblUsers where UserName =@name and Password =@pass", con);
            cmd.Parameters.AddWithValue("@name", txtUser.Text);
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
            cmd.ExecuteNonQuery();
            DB.Dispose(con);
            //calling menu form
            MDIParent mainform = new MDIParent();
            mainform.FormClosed += new FormClosedEventHandler(mainform_FormClosed);
            mainform.Show();
            this.Hide();
        }

        private void tblReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

    }
}
