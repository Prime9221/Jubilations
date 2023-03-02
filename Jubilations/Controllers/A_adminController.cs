using Jubilations.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Jubilations.Controllers
{
    public class A_adminController : Controller
    {
        // GET: A_admin
        DBEntity db = new DBEntity();
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Widgets()
        {
            return View();
        }

        public ActionResult ChartsJS()
        {
            return View();
        }

        public ActionResult Icons()
        {
            return View();
        }

        public ActionResult Buttons()
        {
            return View();
        }

        public ActionResult Validation()
        {
            return View();
        }

        public ActionResult DataTables()
        {
            return View();
        }

        public ActionResult Calendar()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }
        ///about us methods start--------------------------------------------------------------------
        public ActionResult A_Aboutus()
        {
            var data = db.aboutuss.ToList();
            return View(data);
        }

        public ActionResult A_Aboutus_Edit(int aboutId)
        {
            var AboutList = db.aboutuss.Where(x => x.aboutId == aboutId).First();
            return View(AboutList);
        }
        [HttpPost]
        public ActionResult A_Aboutus_Edit(Aboutus s)
        {
            
            db.Entry(s).State = EntityState.Modified;
            int a = db.SaveChanges();
            if (a > 0)
            {
                ViewBag.UpdateMessage = "<script>alret('Data Updated !!')</script>";
                return RedirectToAction("A_Aboutus");
            }
            else
            {
                ViewBag.UpdateMessage = "<script>alret('Data Not Updated !!')</script>";
            }

            return View();
        }
        ///about us methods end--------------------------------------------------------------------
        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult Project_Add()
        {
            return View();
        }
        public ActionResult Project_Edit()
        {
            return View();
        }
        public ActionResult Project_Detail()
        {
            return View();
        }
        public ActionResult Contacts()
        {
            return View();
        }
        public ActionResult FAQ()
        {
            return View();
        }
        public ActionResult Contact_us()
        {
            return View();
        }

        public ActionResult Login_v1()
        {
            return View();
        }

        public ActionResult Register_v1()
        {
            return View();
        }

        public ActionResult Forgot_Password_v1()
        {
            return View();
        }

        public ActionResult Recover_Password_v1()
        {
            return View();
        }

        public ActionResult Login_v2()
        {
            return View();
        }

        public ActionResult Register_v2()
        {
            return View();
        }

        public ActionResult Forgot_Password_v2()
        {
            return View();
        }

        public ActionResult Recover_Password_v2()
        {
            return View();
        }

        public ActionResult Error_404()
        {
            return View();
        }

        public ActionResult Error_500()
        {
            return View();
        }

        public ActionResult Simple_Search()
        {
            return View();
        }

        public ActionResult Enhanced()
        {
            return View();
        }
    }
}