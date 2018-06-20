using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gentry
{
    public partial class Customer : MetroFramework.Forms.MetroForm
    {
        public Customer()
        {
            InitializeComponent();
        }
        void PopulateComboBox() 
        {
            using(SqlConnection con = DB.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("select *from tblDesignation", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbDesignation.ValueMember = "DesignationId";
                cmbDesignation.DisplayMember = "Designation";
                DataRow topitems = dt.NewRow();
                topitems[0] = 0;
                topitems[1] = "-Select-";
                dt.Rows.InsertAt(topitems,0);
                cmbDesignation.DataSource = dt;
            }
        }

        void PopulateDataGridView()
        {
            using (SqlConnection con = DB.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("select Name,Address,DesignationId,Education,Phone,CustId from tblCustomer", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCustomer.DataSource = dt;
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
            PopulateDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = DB.GetConnection())
            {
                for (int i = 0; i < dgvCustomer.Rows.Count - 1; i++)
                {
                    //MessageBox.Show("test" + dgvCustomer.Rows[i].Cells["CustomerName"].Value);
                    SqlCommand cmd = new SqlCommand("insert into tblCustomer(Name,Address,DesignationId,Education,phone) values(@name,@address,@designationid,@education,@phone)", con);
                    cmd.Parameters.AddWithValue("@name", dgvCustomer.Rows[i].Cells["CustomerName"].Value);
                    cmd.Parameters.AddWithValue("@address", dgvCustomer.Rows[i].Cells["Address"].Value);
                    cmd.Parameters.AddWithValue("@designationid", dgvCustomer.Rows[i].Cells["cmbDesignation"].Value);
                    cmd.Parameters.AddWithValue("@education", dgvCustomer.Rows[i].Cells["Education"].Value);
                    cmd.Parameters.AddWithValue("@phone", dgvCustomer.Rows[i].Cells["Phone"].Value);
                    cmd.ExecuteNonQuery();
                    DB.Dispose(con);
                }
            }
        }

        private void dgvCustomer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCustomer.CurrentRow != null)
            {

                using (SqlConnection con = DB.GetConnection())
                {
                    DataGridViewRow dgvrow = dgvCustomer.CurrentRow;
                    SqlCommand cmd = new SqlCommand("CustomerAddorEdit",con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (dgvrow.Cells["txtCustomerId"].Value == DBNull.Value) // Insert
                    {
                        cmd.Parameters.AddWithValue("@CustId", 0);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@CustId", Convert.ToInt32(dgvrow.Cells["txtCustomerId"].Value));
                    }
                    cmd.Parameters.AddWithValue("@Name", dgvrow.Cells["txtCustomer"].Value==DBNull.Value ?"" :dgvrow.Cells["txtCustomer"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Phone", dgvrow.Cells["txtPhone"].Value == DBNull.Value ? "" : dgvrow.Cells["txtPhone"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Address", dgvrow.Cells["txtAddress"].Value == DBNull.Value ? "" : dgvrow.Cells["txtAddress"].Value.ToString());
                    cmd.Parameters.AddWithValue("@DesignationId", Convert.ToInt32(dgvrow.Cells["cmbDesignation"].Value == DBNull.Value ? "0" : dgvrow.Cells["cmbDesignation"].Value.ToString()));
                    cmd.Parameters.AddWithValue("@Education", dgvrow.Cells["txtEducation"].Value == DBNull.Value ? "" : dgvrow.Cells["txtEducation"].Value.ToString());
                    cmd.ExecuteNonQuery();
                    PopulateDataGridView();
                    DB.Dispose(con);
                }
            }


        }

    }
}
