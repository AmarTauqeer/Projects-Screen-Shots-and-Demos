using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderManagement.Models;

namespace OrderManagement.Models
{
    public class UserController : Controller
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
                    string query = "select *from tblUsers";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.Fill(dt);
                }
            }
            return View(dt);
        }

        //
        // GET: /User/Create
        public ActionResult Create()
        {
            return View(new UserModel());
        }

        //
        // POST: /User/Create
        [HttpPost]
        public ActionResult Create(UserModel userModel)
        {
            //validation
            if (ModelState.IsValid)
            {

                using (SqlConnection sqlCon = new SqlConnection(conStr))
                {
                    sqlCon.Open();
                    string query = "INSERT INTO tblUsers VALUES(@userName,@password,@confirmPassword,@fullName,@city,@address,@email)";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@userName", userModel.UserName);
                    sqlCmd.Parameters.AddWithValue("@password", userModel.Password);
                    sqlCmd.Parameters.AddWithValue("@confirmPassword", userModel.ConfirmPassword);
                    sqlCmd.Parameters.AddWithValue("@fullName", userModel.FullName);
                    sqlCmd.Parameters.AddWithValue("@city", userModel.City);
                    sqlCmd.Parameters.AddWithValue("@address", userModel.Address);
                    sqlCmd.Parameters.AddWithValue("@email", userModel.Email);
                    sqlCmd.ExecuteNonQuery();
                }
            }
            else 
            {
                //back to model
                return View();
            }
            //after success redirect to index page
            return RedirectToAction("Index", "User");
        }

        public ActionResult Edit(int id)
        {
            UserModel userModel = new UserModel();
            DataTable user = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();
                string query = "SELECT * FROM tblUsers Where UserId = @userid";
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.SelectCommand.Parameters.AddWithValue("@userid", id);
                sqlDa.Fill(user);
            }
            if (user.Rows.Count == 1)
            {
                userModel.UserId = Convert.ToInt32(user.Rows[0][0].ToString());
                userModel.UserName = user.Rows[0][1].ToString();
                userModel.Password = user.Rows[0][2].ToString();
                userModel.ConfirmPassword = user.Rows[0][3].ToString();
                userModel.FullName = user.Rows[0][4].ToString();
                userModel.City = user.Rows[0][5].ToString();
                userModel.Address = user.Rows[0][6].ToString();
                userModel.Email = user.Rows[0][7].ToString();
                return View(userModel);
            }
            else
                return RedirectToAction("Index", "User");
        }

        //
        // POST: /User/Edit/5
        [HttpPost]
        public ActionResult Edit(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                using (SqlConnection sqlCon = new SqlConnection(conStr))
                {
                    sqlCon.Open();
                    string query = "UPDATE tblUsers SET UserName = @username,Password=@password,ConfirmPassword=@confirmpass,FullName=@fullname,City=@city,Address=@address,Email=@email WHere UserId = @userid";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@userid", userModel.UserId);
                    sqlCmd.Parameters.AddWithValue("@username", userModel.UserName);
                    sqlCmd.Parameters.AddWithValue("@password", userModel.Password);
                    sqlCmd.Parameters.AddWithValue("@confirmpass", userModel.ConfirmPassword);
                    sqlCmd.Parameters.AddWithValue("@fullname", userModel.FullName);
                    sqlCmd.Parameters.AddWithValue("@city", userModel.City);
                    sqlCmd.Parameters.AddWithValue("@address", userModel.Address);
                    sqlCmd.Parameters.AddWithValue("@email", userModel.Email);
                    sqlCmd.ExecuteNonQuery();
                }
            }
            else 
            {
                return View();
            }
            return RedirectToAction("Index", "User");
        }

        //
        // GET: /User/Delete/5
        public ActionResult Delete(int id)
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();
                string query = "DELETE FROM tblUsers WHere UserId = @userid";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@userid", id);
                sqlCmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index", "User");
        }
    }
}
