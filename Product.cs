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
    public partial class Product : MetroFramework.Forms.MetroForm
    {
        Boolean IsInsert;
        SqlCommand cmd = new SqlCommand();

        public Product()
        {
            InitializeComponent();
        }
        void FillCombo() 
        {
            //-- get connection
            SqlConnection con = DB.GetConnection();
            string query = "select *from tblCategory";
            SqlCommand comd = new SqlCommand(query,con);
            SqlDataReader MyReader;
            try 
            {
                MyReader = comd.ExecuteReader();

                while(MyReader.Read())
                {
                    string CatTitle = MyReader.GetString(1);
                    cmbCategory.Items.Add(CatTitle);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DB.Dispose(con);


        }

        private void Product_Load(object sender, EventArgs e)
        {
            FillCombo();
            Display();
            txtCatId.Visible = false;
            txtProdId.Visible = false;
            btnSearch.Visible = true;
            txtSearch.Visible = false;

        }
        void Clear()
        {
            btnSave.Enabled = true;
            btnSave.Text = "Save";
            txtProduct.Text = "";
            txtCatId.Text = "";
            txtProdId.Text = "";
            txtRate.Text = "";
            txtSearch.Text = "";
            txtSearch.Visible = false;
            btnSearch.Visible = true;
            btnDelete.Enabled = false;
            IsInsert = true;

        }
        void Display()
        {
            //-- get connection
            SqlConnection con = DB.GetConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select ProductName,ProductRate,Units,ProdId,CatId from tblProduct",con);
            adapt.Fill(dt);
            dgvProduct.DataSource = dt;
            DB.Dispose(con);
            IsInsert = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Clear();
            txtSearch.Visible = true;
            txtSearch.Focus();
            btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("IsInsert value=" + IsInsert);
            if (IsInsert == true)
            {
                if (txtProduct.Text != ""&& txtCatId.Text != "")
                {
                    SqlConnection con = DB.GetConnection();
                    cmd = new SqlCommand("insert into tblProduct values(@CatId,@ProductName,@ProductRate,@Units)", con);
                    cmd.Parameters.AddWithValue("@CatId", txtCatId.Text);
                    cmd.Parameters.AddWithValue("@ProductName", txtProduct.Text);
                    cmd.Parameters.AddWithValue("@ProductRate", txtRate.Text);
                    cmd.Parameters.AddWithValue("@Units", cmbUint.SelectedItem);
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
            else if (IsInsert == false)
            {
                if (txtProduct.Text != "" && txtCatId.Text != "")
                {
                    SqlConnection con = DB.GetConnection();
                    cmd = new SqlCommand("update tblProduct set ProductName=@ProductName, ProductRate=@ProductRate,Units=@Units where ProdId=@ProdId", con);
                    cmd.Parameters.AddWithValue("@ProdId", txtProdId.Text);
                    cmd.Parameters.AddWithValue("@ProductName", txtProduct.Text);
                    cmd.Parameters.AddWithValue("@ProductRate", txtRate.Text);
                    cmd.Parameters.AddWithValue("@Units", cmbUint.SelectedItem);
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
                cmd = new SqlCommand("delete from tblProduct where ProdId=@id", con);
                cmd.Parameters.AddWithValue("@id", txtProdId.Text);
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

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //-- get connection
            SqlConnection con = DB.GetConnection();
            SqlCommand cmd = new SqlCommand("select CatId from tblCategory where Category=@name",con);
            cmd.Parameters.AddWithValue("@name", cmbCategory.SelectedItem);
            cmd.ExecuteNonQuery();
            SqlDataReader MyReader;
            try
            {
                MyReader = cmd.ExecuteReader();

                while (MyReader.Read())
                {
                    int catid = MyReader.GetInt32(0);
                    txtCatId.Text = catid.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DB.Dispose(con);
        }

        private void dgvProduct_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtProduct.Text = dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtRate.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbUint.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtProdId.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCatId.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();

            btnDelete.Enabled = true;
            btnSave.Enabled = true;
            btnSave.Text = "Update";
            IsInsert = false;
            txtSearch.Visible = false;
            btnSearch.Visible = false;
            txtProduct.Focus();

            //fill combo
            SqlConnection con = DB.GetConnection();
            SqlCommand cmd = new SqlCommand("select Category from tblCategory where CatId=@catid", con);
            cmd.Parameters.AddWithValue("@catid", Convert.ToInt32(txtCatId.Text));
            cmd.ExecuteNonQuery();
            SqlDataReader MyReader;
            try
            {
                MyReader = cmd.ExecuteReader();
                while (MyReader.Read())
                {
                    string category = MyReader.GetString(0);
                    cmbCategory.Text = category;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DB.Dispose(con);




        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = DB.GetConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select ProductName,ProductRate,Units,ProdId,CatId from tblProduct where ProductName like '" + txtSearch.Text + "%'", con);
            adapt.Fill(dt);
            dgvProduct.DataSource = dt;
            DB.Dispose(con);

        }
    }
}
