using OrderManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
namespace OrderManagement.Controllers
{
    public class ProductController : Controller
    {
        string conStr = @"data source=(local);initial catalog=MvcTutorial;integrated security=True";
        public ActionResult Index()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    string query = "select ProdId,ProductName,Category,ProductRate,Units from tblProduct,tblCategory where tblProduct.CatId = tblCategory.CatId";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.Fill(dt);
                }
            }
            return View(dt);
        }

        //
        // GET: /Product/Create
        public ActionResult Create()
        {
            tblProduct prod = new tblProduct();
            using(SqlConnection con= new SqlConnection(conStr))
            {
                
                using(dbEntities db = new dbEntities())
                {
                    prod.CategoryList = PopulateCategory();

                }
            }
            return View(prod);
        }
        private static List<SelectListItem> PopulateCategory()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            string constr = "data source=(local);initial catalog=MvcTutorial;integrated security=True";
            
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = " SELECT Category, CatId FROM tblCategory";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = sdr["Category"].ToString(),
                                Value = sdr["CatId"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }

            return items;
        }
        //
        // POST: /Product/Create
        [HttpPost]
        public ActionResult Create(tblProduct product)
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                product.CategoryList = PopulateCategory();
                
                //var selectedItem = product.CategoryList.Find(p => p.Value == product.CatId.ToString());
                //if (selectedItem != null)
                //{
                //    selectedItem.Selected = true;
                //    ViewBag.Message = "Fruit: " + selectedItem.Text;
                //    ViewBag.Message += "\\nQuantity: " + product.ProductName;
                //}


                sqlCon.Open();
                string query = "INSERT INTO tblProduct(CatId,ProductName,ProductRate,Units) VALUES(@catid,@catname,@rate,@unit)";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@catid", product.CatId);
                sqlCmd.Parameters.AddWithValue("@catname", product.ProductName);
                sqlCmd.Parameters.AddWithValue("@rate", product.ProductRate);
                sqlCmd.Parameters.AddWithValue("@unit", product.Units);
                sqlCmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index", "Product");
        }
 

        //
        // GET: /Product/Edit/5
        public ActionResult Edit(int id)
        {
            tblProduct product = new tblProduct();
            DataTable dtblProduct = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();
                string query = "SELECT * FROM tblProduct Where ProdId = @prodid";
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.SelectCommand.Parameters.AddWithValue("@prodid", id);
                sqlDa.Fill(dtblProduct);
            }
            if (dtblProduct.Rows.Count == 1)
            {
                product.ProdId = Convert.ToInt32(dtblProduct.Rows[0][0].ToString());
                product.CatId = Convert.ToInt32(dtblProduct.Rows[0][1].ToString());
                product.ProductName = dtblProduct.Rows[0][2].ToString();
                product.ProductRate = Convert.ToInt32(dtblProduct.Rows[0][3].ToString());
                product.Units = dtblProduct.Rows[0][4].ToString();
                //category
                product.CategoryList = PopulateCategory();
                return View(product);
            }
            else
                return RedirectToAction("Edit", "Product");
        }

        //
        // POST: /Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,tblProduct product)
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                product.CategoryList = PopulateCategory();

                //var selectedItem = product.CategoryList.Find(p => p.Value == product.CatId.ToString());
                //if (selectedItem != null)
                //{
                //    selectedItem.Selected = true;
                //    ViewBag.Message = "Fruit: " + selectedItem.Text;
                //    ViewBag.Message += "\\nQuantity: " + product.ProductName;
                //}


                sqlCon.Open();
                string query = "update tblProduct set CatId=@catid,ProductName=@prod,ProductRate=@prodrate,Units=@units where ProdId=@prodid";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@prodid", id);
                sqlCmd.Parameters.AddWithValue("@catid", product.CatId);
                sqlCmd.Parameters.AddWithValue("@prod", product.ProductName);
                sqlCmd.Parameters.AddWithValue("@prodrate", product.ProductRate);
                sqlCmd.Parameters.AddWithValue("@units", product.Units);
                sqlCmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index", "Product");
        }

        //
        // GET: /Product/Delete/5
        public ActionResult Delete(int id)
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();
                string query = "DELETE FROM tblProduct WHere ProdId = @prodid";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@Prodid", id);
                sqlCmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index", "Product");
        }

       
    }
}
