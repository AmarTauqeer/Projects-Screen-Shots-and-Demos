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
using CrystalDecisions.CrystalReports.Engine;

namespace Gentry
{
    public partial class SaleOrder : MetroFramework.Forms.MetroForm
    {
        //Parameters initialization
        public static string param_ordid = "";

        public SaleOrder()
        {
            InitializeComponent();
        }

        private void SaleOrder_Load(object sender, EventArgs e)
        {
            //Find procedure
            if (FindOrder.param_ordid != 0 && FindOrder.param_custid != 0)
            {
                btnNew.Text = "Cancel";
                txtMasterOrderId.Text = FindOrder.param_ordid.ToString();

                // for customer and product default value
                FillCustomer();
                FillProduct();

                //parameters
                OrderDate.Text = FindOrder.param_date;
                cbxCustomer.SelectedItem = FindOrder.param_name;

                //product from database
                using (SqlConnection conn = DB.GetConnection())
                {
                    SqlCommand comd = new SqlCommand("select od.ProdId,Qty,od.ProductRate,Qty*od.ProductRate amt,Units,ProductName from OrderDetail od, tblProduct tp where OrderId=@ordid and od.ProdId=tp.ProdId", conn);
                    comd.Parameters.AddWithValue("@ordid", Convert.ToInt32(txtMasterOrderId.Text));
                    SqlDataReader MyReader;
                    try
                    {
                        MyReader = comd.ExecuteReader();

                        while (MyReader.Read())
                        {
                            cbxProductName.DisplayMember = MyReader.GetString(5).ToString();
                            dgvOrderDetail.Rows.Add(txtMasterOrderId.Text, MyReader.GetInt32(0), cbxProductName.DisplayMember.ToString(), MyReader.GetString(4), MyReader.GetInt32(1), MyReader.GetInt32(2), MyReader.GetInt32(3));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    DB.Dispose(conn);

                }

            }
            else //If not find then New record
            {
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
                // get maximum id number
                //GetMaximumId();

                //Customer and product data
                FillCustomer();
                FillProduct();
            }

        }
        void GetMaximumId()
        {
            using (SqlConnection conn = DB.GetConnection())
            {
                SqlCommand comd = new SqlCommand("select isnull(MAX(OrderId),0)+1 from OrderMaster", conn);
                SqlDataReader MyReader;
                try
                {
                    MyReader = comd.ExecuteReader();

                    while (MyReader.Read())
                    {
                        txtMasterOrderId.Text = MyReader.GetInt32(0).ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DB.Dispose(conn);
            }

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
        void FillProduct()
        {
            using (SqlConnection conn = DB.GetConnection())
            {
                string query = "select ProdId,ProductName from tblProduct";
                SqlCommand comd = new SqlCommand(query, conn);
                SqlDataReader MyReader;
                try
                {
                    MyReader = comd.ExecuteReader();

                    while (MyReader.Read())
                    {
                        Int32 prodid = MyReader.GetInt32(0);
                        string name = MyReader.GetString(1);
                        cbxProductName.Items.Add(name);
                        cbxProductName.DisplayMember = name;
                        cbxProductName.ValueMember = prodid.ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DB.Dispose(conn);
            }

        }


        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvOrderDetail.CurrentRow.Cells["txtDetailOrderId"].Value = txtMasterOrderId.Text;
        }

        private void cbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = DB.GetConnection())
            {
                string query = "select CustId from tblCustomer where Name=@name";
                SqlCommand comd = new SqlCommand(query, conn);
                comd.Parameters.AddWithValue("@name", cbxCustomer.SelectedItem);
                SqlDataReader MyReader;
                try
                {
                    MyReader = comd.ExecuteReader();

                    while (MyReader.Read())
                    {
                        txtCustId.Text = MyReader.GetInt32(0).ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DB.Dispose(conn);
            }


        }

        private void dgvOrderDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection conn = DB.GetConnection())
            {
                string query = "select ProdId,ProductRate,Units from tblProduct where ProductName=@prodname";
                SqlCommand comd = new SqlCommand(query, conn);
                //MessageBox.Show("aa"+ dgvOrderDetail.CurrentRow.Cells["cbxProductName"].Value);

                string a = dgvOrderDetail.CurrentRow.Cells["cbxProductName"].Value.ToString();
                comd.Parameters.AddWithValue("@prodname", a);
                SqlDataReader MyReader;
                try
                {
                    MyReader = comd.ExecuteReader();

                    while (MyReader.Read())
                    {
                        int prodid = MyReader.GetInt32(0);
                        int prodrate = MyReader.GetInt32(1);
                        string units = MyReader.GetString(2);
                        dgvOrderDetail.CurrentRow.Cells["txtDetailOrderId"].Value = txtMasterOrderId.Text;
                        dgvOrderDetail.CurrentRow.Cells["txtProdId"].Value = prodid.ToString();
                        dgvOrderDetail.CurrentRow.Cells["txtProductRate"].Value = prodrate.ToString();
                        dgvOrderDetail.CurrentRow.Cells["txtUnits"].Value = units;
                        dgvOrderDetail.CurrentRow.Cells["txtAmount"].Value = Convert.ToInt32(dgvOrderDetail.CurrentRow.Cells["txtQty"].Value) * Convert.ToInt32(dgvOrderDetail.CurrentRow.Cells["txtProductRate"].Value);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DB.Dispose(conn);
            }

        }

        private void dgvOrderDetail_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int sumQty = 0;
            int sumAmount = 0;
            for (int i = 0; i < dgvOrderDetail.Rows.Count; ++i)
            {
                sumQty += Convert.ToInt32(dgvOrderDetail.Rows[i].Cells["txtQty"].Value);
                sumAmount += Convert.ToInt32(dgvOrderDetail.Rows[i].Cells["txtAmount"].Value);
            }
            try
            {
                decimal totQty = 0;
                decimal totAmount = 0;
                for (int i = 0; i <= dgvOrderDetail.RowCount - 1; i++)
                {
                    totQty += Convert.ToDecimal(dgvOrderDetail.Rows[i].Cells["txtQty"].Value);
                    totAmount += Convert.ToDecimal(dgvOrderDetail.Rows[i].Cells["txtAmount"].Value);
                }
                if (totQty == 0)
                {

                }
                if (totAmount == 0)
                {

                }
                dgvOrderDetail.CurrentRow.Cells["txtDetailOrderId"].Value = txtMasterOrderId.Text;
                txtTotalQty.Text = totQty.ToString();
                txtTotalAmount.Text = totAmount.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void brnClearItems_Click(object sender, EventArgs e)
        {
            dgvOrderDetail.Rows.Clear();
            txtTotalAmount.Text = "";
            txtTotalQty.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FindOrder.param_ordid == 0 && FindOrder.param_custid == 0)
            {
                //Insert new record into database
                using (SqlConnection con = DB.GetConnection())
                {
                    //Insert master data
                    SqlCommand cmmd = new SqlCommand("insert into OrderMaster(OrderId,CustId,OrderDate) values(@ordid,@custid,@orddate)", con);
                    cmmd.Parameters.AddWithValue("ordid", Convert.ToInt32(txtMasterOrderId.Text));
                    cmmd.Parameters.AddWithValue("custid", Convert.ToInt32(txtCustId.Text));
                    cmmd.Parameters.AddWithValue("orddate", OrderDate.Text);
                    cmmd.ExecuteNonQuery();

                    //Insert details
                    for (int i = 0; i < dgvOrderDetail.Rows.Count - 1; i++)
                    {
                        //MessageBox.Show("test" + dgvCustomer.Rows[i].Cells["CustomerName"].Value);
                        SqlCommand cmd = new SqlCommand("insert into OrderDetail(OrderId,ProdId,Qty,ProductRate) values(@ordid,@prodid,@qty,@productrate)", con);
                        cmd.Parameters.AddWithValue("ordid", dgvOrderDetail.Rows[i].Cells["txtDetailOrderId"].Value);
                        cmd.Parameters.AddWithValue("@prodid", dgvOrderDetail.Rows[i].Cells["txtProdId"].Value);
                        cmd.Parameters.AddWithValue("@qty", dgvOrderDetail.Rows[i].Cells["txtQty"].Value);
                        cmd.Parameters.AddWithValue("@productrate", dgvOrderDetail.Rows[i].Cells["txtProductRate"].Value);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Order is created Successfully.");
                    //After creating record
                    btnSearch.Enabled = true;
                    //Get maximumb id
                    GetMaximumId();
                    dgvOrderDetail.Rows.Clear();
                    DB.Dispose(con);
                }
            }
            else //If not insert then Update 
            {
                using (SqlConnection con = DB.GetConnection())
                {
                    //Upate master data
                    SqlCommand cmmd = new SqlCommand("update OrderMaster set CustId=@custid,OrderDate=@orddate where OrderId=@ordid ", con);
                    cmmd.Parameters.AddWithValue("ordid", Convert.ToInt32(txtMasterOrderId.Text));
                    cmmd.Parameters.AddWithValue("custid", Convert.ToInt32(txtCustId.Text));
                    cmmd.Parameters.AddWithValue("orddate", OrderDate.Text);
                    cmmd.ExecuteNonQuery();
                    //MessageBox.Show("customer" + Convert.ToInt32(txtCustId.Text));
                    //for updation first delete detial data then insert
                    SqlCommand cmd = new SqlCommand("delete from OrderDetail where OrderId='" + txtMasterOrderId.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    //Insert details
                    for (int i = 0; i < dgvOrderDetail.Rows.Count - 1; i++)
                    {
                        SqlCommand comd = new SqlCommand("insert into OrderDetail(OrderId,ProdId,Qty,ProductRate) values(@ordid,@prodid,@qty,@productrate)", con);
                        comd.Parameters.AddWithValue("ordid", dgvOrderDetail.Rows[i].Cells["txtDetailOrderId"].Value);
                        comd.Parameters.AddWithValue("@prodid", dgvOrderDetail.Rows[i].Cells["txtProdId"].Value);
                        comd.Parameters.AddWithValue("@qty", dgvOrderDetail.Rows[i].Cells["txtQty"].Value);
                        comd.Parameters.AddWithValue("@productrate", dgvOrderDetail.Rows[i].Cells["txtProductRate"].Value);
                        comd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Order is Updated Successfully.");
                    //After Update
                    //Get maximumb id
                    GetMaximumId();
                    dgvOrderDetail.Rows.Clear();
                    DB.Dispose(con);
                }


            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            this.Hide();
            FindOrder frm = new FindOrder();
            frm.Show();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                GetMaximumId();
                dgvOrderDetail.Rows.Clear();
                btnDelete.Enabled = false;
                btnNew.Text = "Cancel";
                txtTotalQty.Text = "";
                txtTotalAmount.Text = "";
                btnSave.Enabled = true;
                btnSearch.Enabled = false;
            }
            else
            {
                btnNew.Text = "New";
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
                txtMasterOrderId.Text = "";
                cbxCustomer.DisplayMember = "";
                btnSearch.Enabled = true;
                dgvOrderDetail.Rows.Clear();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DB.GetConnection())
            {
                if (MessageBox.Show("Do you really want to delete data?", "Delete Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //delete detail data first
                    SqlCommand cmd = new SqlCommand("delete from OrderDetail where OrderId=@ordid", conn);
                    cmd.Parameters.AddWithValue("@ordid", Convert.ToInt32(txtMasterOrderId.Text));
                    cmd.ExecuteNonQuery();

                    //delete master data
                    SqlCommand comd = new SqlCommand("delete from OrderMaster where OrderId=@ordid",conn);
                    comd.Parameters.AddWithValue("@ordid", Convert.ToInt32(txtMasterOrderId.Text));

                    int a = comd.ExecuteNonQuery(); ;
                    if (a > 0)
                    {
                        MessageBox.Show("Data successfully deleted.");
                        btnSave.Enabled = false;
                        btnNew.Enabled = true;
                        btnNew.Text = "New";
                        btnSearch.Enabled = true;
                        btnDelete.Enabled = false;
                        txtMasterOrderId.Text = "";
                        dgvOrderDetail.Rows.Clear();
                        txtTotalAmount.Text = "";
                        txtTotalQty.Text = "";

                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            param_ordid= txtMasterOrderId.Text;
            frmCurrentOrder frm = new frmCurrentOrder();
            frm.Show();

        }

    }
}
