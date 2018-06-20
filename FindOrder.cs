using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentry
{
    public partial class FindOrder : MetroFramework.Forms.MetroForm
    {
        //Parameters initialization
        public static Int32 param_ordid = 0;
        public static Int32 param_custid = 0;
        public static string param_date = "";
        public static string param_name = "";
        public FindOrder()
        {
            InitializeComponent();
        }
        void FillCustomer()
        {
            using (SqlConnection conn = DB.GetConnection())
            {
                string query = "select CustId,Name from tblCustomer order by CustId";
                SqlCommand comd = new SqlCommand(query, conn);
                SqlDataReader MyReader;
                try
                {
                    MyReader = comd.ExecuteReader();

                    while (MyReader.Read())
                    {
                        int custid = MyReader.GetInt32(0);
                        string name = MyReader.GetString(1);
                        cbxCustomer.Items.Add(name);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DB.Dispose(conn);
            }

       }

        void PopulateDataGridView()
        {
            using (SqlConnection con = DB.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("select OrderId,OrderDate from OrderMaster where CustId='"+txtCustId.Text+"'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOrder.DataSource = dt;
            }
        }

        private void FindOrder_Load(object sender, EventArgs e)
        {
            FillCustomer();
        }

        private void cbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = DB.GetConnection())
            {
                string query = "select CustId from tblCustomer where name='"+cbxCustomer.SelectedItem+"'";
                SqlCommand comd = new SqlCommand(query, conn);
                SqlDataReader MyReader;
                try
                {
                    MyReader = comd.ExecuteReader();

                    while (MyReader.Read())
                    {
                        int custid = MyReader.GetInt32(0);
                        txtCustId.Text = custid.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                PopulateDataGridView();
                DB.Dispose(conn);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // assign value to param
            param_ordid = Convert.ToInt32(dgvOrder.CurrentRow.Cells["OrderId"].Value.ToString());
            param_custid = Convert.ToInt32(txtCustId.Text);
            param_date = dgvOrder.CurrentRow.Cells["OrderDate"].Value.ToString();
            param_name = cbxCustomer.SelectedItem.ToString();
            this.Hide();
            //Show hidden form
            SaleOrder frm = new SaleOrder();
            frm.Show();

        }

    }
}
