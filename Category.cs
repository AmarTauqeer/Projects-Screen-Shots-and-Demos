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
    public partial class Category : MetroFramework.Forms.MetroForm
    {
        Boolean IsInsert;
        SqlCommand cmd = new SqlCommand();
        public Category()
        {
            InitializeComponent();
        }
        private void Category_Load(object sender, EventArgs e)
        {
            Display();
            txtCatId.Visible = false;

        }

        void Clear() 
        {
            btnSave.Enabled = true;
            btnSave.Text = "Save";
            txtCategory.Text = "";
            txtSearch.Text = "";
            txtSearch.Visible = false;
            btnDelete.Enabled = false;
            IsInsert = true;

        }
        void Display()
        {
            //-- get connection
            SqlConnection con = DB.GetConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select *from tblCategory",con);
            adapt.Fill(dt);
            dgvCategory.DataSource = dt;
            DB.Dispose(con);
            IsInsert = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("IsInsert value=" + IsInsert);
            if (IsInsert == true)
            {
                if (txtCategory.Text != "")
                {
                    SqlConnection con = DB.GetConnection();
                    cmd = new SqlCommand("insert into tblCategory values(@name)", con);
                    cmd.Parameters.AddWithValue("@name", txtCategory.Text);
                    cmd.ExecuteNonQuery();
                    DB.Dispose(con);
                    MessageBox.Show("Record Inserted Successfully");
                    Display();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Please Provide Details!");
                }

            }
            else if(IsInsert==false) 
            {
                if (txtCategory.Text != "")
                {
                    SqlConnection con = DB.GetConnection();
                    cmd = new SqlCommand("update tblCategory set Category=@name where CatID=@id", con);
                    cmd.Parameters.AddWithValue("@id", txtCatId.Text);
                    cmd.Parameters.AddWithValue("@name", txtCategory.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    DB.Dispose(con);
                    Display();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Please Select Record to Update");
                }  

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record ?", "Delete Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                    SqlConnection con = DB.GetConnection();
                    cmd = new SqlCommand("delete from tblCategory where CatID=@id and Category=@name", con);
                    cmd.Parameters.AddWithValue("@id", txtCatId.Text);
                    cmd.Parameters.AddWithValue("@name", txtCategory.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted Successfully");
                    DB.Dispose(con);
                    Display();
                    Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Clear();
            txtSearch.Visible = true;
            txtSearch.Focus();
            btnSave.Enabled = false;
        }
        //dataGridView1 RowHeaderMouseClick Event  
        private void dgvCategory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtCatId.Text = dgvCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCategory.Text = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
            btnSave.Text = "Update";
            IsInsert = false;
            txtSearch.Visible = false;
            txtCategory.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = DB.GetConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from tblCategory where Category like '" + txtSearch.Text + "%'", con);
            adapt.Fill(dt);
            dgvCategory.DataSource = dt;
            DB.Dispose(con);
        }


    }
}
