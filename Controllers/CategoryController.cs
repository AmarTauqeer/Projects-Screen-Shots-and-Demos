using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using OrderManagement.Models;

namespace OrderManagement.Controllers
{
    public class CategoryController : Controller
    {
        string conStr = @"data source=(local);initial catalog=MvcTutorial;integrated security=True";

        public ActionResult Index()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                if (con.State== ConnectionState.Closed) 
                {
                    con.Open();
                    string query = "select *from tblCategory";
                    SqlDataAdapter sda = new SqlDataAdapter(query,con);
                    sda.Fill(dt);
                }
            }
            return View(dt);
        }

        //
        // GET: /Category/Create
        public ActionResult Create()
        {
            return View(new CategoryModel());
        }

        //
        // POST: /Category/Create
        [HttpPost]
        public ActionResult Create(CategoryModel categoryModel)
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();
                string query = "INSERT INTO tblCategory VALUES(@CategoryName)";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@CategoryName", categoryModel.Category);
                sqlCmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index","Category");
        }

        //
        // GET: /Product/Edit/5
        public ActionResult Edit(int id)
        {
            CategoryModel categoryModel = new CategoryModel();
            DataTable dtblProduct = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();
                string query = "SELECT * FROM tblCategory Where CatId = @catid";
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.SelectCommand.Parameters.AddWithValue("@catid", id);
                sqlDa.Fill(dtblProduct);
            }
            if (dtblProduct.Rows.Count == 1)
            {
                categoryModel.CatId = Convert.ToInt32(dtblProduct.Rows[0][0].ToString());
                categoryModel.Category = dtblProduct.Rows[0][1].ToString();
                return View(categoryModel);
            }
            else
                return RedirectToAction("Index","Category");
        }

        //
        // POST: /Product/Edit/5
        [HttpPost]
        public ActionResult Edit(CategoryModel categoryModel)
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();
                //string query = "UPDATE tblCategory SET Category = 'aaaaa' WHere CatId = 10";
                SqlCommand sqlCmd = new SqlCommand("UPDATE tblCategory SET Category = @CategoryName where CatId=@catid", sqlCon);
                sqlCmd.Parameters.AddWithValue("@catid", categoryModel.CatId);
                sqlCmd.Parameters.AddWithValue("@CategoryName", categoryModel.Category);
                sqlCmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index","Category");
        }

        //
        // GET: /Category/Delete/5
        public ActionResult Delete(int id)
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();
                string query = "DELETE FROM tblCategory WHere CatId = @Categoryid";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@Categoryid", id);
                sqlCmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index","Category");
        }

    }
}
