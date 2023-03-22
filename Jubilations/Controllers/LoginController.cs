﻿using Jubilations.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jubilations.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        DBEntity db = new DBEntity();
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Forgot_password()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Otp()
        {
            return View();
        }

        public ActionResult FNewPass()
        {
            return View();
        }
        public ActionResult businessForm()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult businessForm(Register reg)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Register a = new Register();

        //        a.Owner_Name = reg.Owner_Name;
        //        a.Business_Name = reg.Business_Name;
        //        a.Business_Addres = reg.Business_Addres;
        //        a.GST_NO = reg.GST_NO;
        //        a.Category = reg.Category;
        //        a.City = reg.City;
        //        a.Email_ID = reg.Email_ID;
        //        a.Phone_No = reg.Phone_No;
        //        a.Password = reg.Password;
        //        a.Confirm_Password = reg.Confirm_Password;
        //        a.Create_Date = DateTime.Now.ToShortDateString();
        //        //a.Category_Update_Date = DateTime.Now.ToShortDateString();
        //        db.registers.Add(a);
        //        db.SaveChanges();
        //        TempData["DataInserted"] = "true";
        //        return RedirectToAction("businessForm");

        //    }
        //    return RedirectToAction("businessForm");
        //}

        [HttpPost]
        public ActionResult businessForm(User e)
        {
            if (Request.HttpMethod == "POST")
            {
                User er = new User();
                using (SqlConnection con = new SqlConnection("Data Source=192.168.29.252,1434;Integrated Security=false;Initial Catalog=Jubilation; User Id=sa;password=Makm9221@"))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_EnrollDetail"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Owner Name", e.User_Name);
                        cmd.Parameters.AddWithValue("@Business Name", e.User_ShopName);
                        cmd.Parameters.AddWithValue("@Business Address", e.User_Address);
                        cmd.Parameters.AddWithValue("@GST NO", e.User_GSTNO);
                        cmd.Parameters.AddWithValue("@Category", e.User_DOB);
                        cmd.Parameters.AddWithValue("@City", e.User_Profile_Image);
                        cmd.Parameters.AddWithValue("@Email ID", e.User_Email);
                        cmd.Parameters.AddWithValue("@Phone No", e.User_PhoneNo);
                        cmd.Parameters.AddWithValue("@Password", e.User_Password );
                        cmd.Parameters.AddWithValue("@User_Name", "INSERT");
                        con.Open();
                        ViewData["result"] = cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            return View();
        }


        public ActionResult verifyotp()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }
    }
}