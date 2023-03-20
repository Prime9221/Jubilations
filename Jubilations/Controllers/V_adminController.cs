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
    public class V_adminController : Controller
    {
        // dashboards-analytics
        DBEntity db = new DBEntity();
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult app_access_permission() {
            return View();
        }

        public ActionResult app_access_roles() {
            return View();
        }

        public ActionResult app_calendar() {
            return View();
        }

        public ActionResult app_chat() {
            return View();
        }

        public ActionResult app_email() {
            return View();
        }

        public ActionResult app_invoice_add() {
            return View();
        }

        public ActionResult app_invoice_edit() {
            return View();
        }

        public ActionResult app_invoice_list() {
            return View();
        }

        public ActionResult app_invoice_preview() {
            return View();
        }

        public ActionResult app_invoice_print() {
            return View();
        }


        //Services start----------------------------------------------------------------------------------



        public ActionResult V_Services() {
            var model = new ServicesModel();

            model.ServicesList = db.services.ToList();
            model.UserNameList = db.user.ToList();
            model.CategoryList = db.category.ToList();
            return View(model);
        }

        public ActionResult V_Services_Create()
        {
            var userList = db.user.ToList();
            ViewBag.UserId = new SelectList(userList, "User_Id", "User_Name");
            var categoryList = db.category.ToList();
            ViewBag.CategoryId = new SelectList(categoryList, "Category_Id", "Category_Name");

            return View("V_Services_Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult V_Services_Create(Services model , ServicesModel S)
        {
            if (ModelState.IsValid)
            {

                var userList = db.user.ToList();
                ViewBag.UserId = new SelectList(userList, "User_Id", "User_Name");
                var categoryList = db.category.ToList();
                ViewBag.CategoryId = new SelectList(categoryList, "Category_Id", "Category_Name");
                Services s = new Services();
                model.Services_Create_Date = DateTime.Now.ToShortDateString();
              //  s.Services_Title = model.Services_Title;
                db.services.Add(model);
                db.SaveChanges();
                TempData["DataInserted"] = "true";
                return RedirectToAction("V_Services");

            }
            return RedirectToAction("V_Services_Create");
        }
       

        public ActionResult V_Services_Edit(int Service_id)
        {
            var ca = db.services.Where(x => x.Services_Id == Service_id).First();
            return View(ca);
        }
        [HttpPost]
        public ActionResult V_Services_Edit(Services s)
        {
            db.Entry(s).State = EntityState.Modified;
            //s.Category_Create_Date = DateTime.Now.ToShortDateString();
            s.Services_Update_Date = DateTime.Now.ToShortDateString();
            int a = db.SaveChanges();
            if (a > 0)
            {
                ViewBag.UpdateMessage = "<script>alret('Data Updated !!')</script>";
                return RedirectToAction("V_Services");
            }
            else
            {
                ViewBag.UpdateMessage = "<script>alret('Data Not Updated !!')</script>";
            }

            return View();
        }


        public ActionResult V_Service_delete(int Service_id)
        {
            var Ci = db.services.Where(x => x.Services_Id == Service_id).First();
            return View(Ci);
        }
        [HttpPost]
        public ActionResult V_Service_delete(Services s)
        {
            db.Entry(s).State = EntityState.Deleted;
            int a = db.SaveChanges();
            if (a > 0)
            {
                ViewBag.UpdateMessage = "<script>alret('Data Updated !!')</script>";
                return RedirectToAction("V_Services");
            }
            else
            {
                ViewBag.UpdateMessage = "<script>alret('Data Not Updated !!')</script>";
            }

            return View("V_Services");
        }


        //Services end----------------------------------------------------------------------------------
        public ActionResult app_user_view_account() {
            return View();
        }

        public ActionResult app_user_view_security() {
            return View();
        }

        public ActionResult dashboards_crm() {
            return View();
        }

        public ActionResult dashboards_ecommerce() {
            return View();
        }

        public ActionResult maps_leaflet() {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }
    }
}