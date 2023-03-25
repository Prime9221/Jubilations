using Jubilations.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Jubilations.Controllers
{
    [Authorize(Roles = "3")]
    //[Authorize(Roles = "1")]
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









        //Catelog start-----------------------------------------------------------------------------------------------------------------------------------------


        public ActionResult V_Catelog()
        {
            var model = new Vender_CatalogModel();

            model.CatalogList = db.vender_catalog.ToList();
            model.UserNameList = db.user.ToList();
            model.CategoryList = db.category.ToList();
            model.ServicesList = db.services.ToList();
            return View(model);
        }

        public ActionResult V_Catelog_Create()
        {
            var UserNameList = db.user.ToList();
            ViewBag.UserId = new SelectList(UserNameList, "User_Id", "User_Name");
            var categoryList = db.category.ToList();
            ViewBag.CategoryId = new SelectList(categoryList, "Category_Id", "Category_Name");
            var servicesList = db.services.ToList();
            ViewBag.ServiceList = new SelectList(servicesList, "Services_Id", "Services_Title");

            return View("V_Catelog_Create");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult V_Catelog_Create(Vender_Catalog model, Vender_CatalogModel S)
        {
           
            

                var userList = db.user.ToList();
                ViewBag.UserId = new SelectList(userList, "User_Id", "User_Name");
                var categoryList = db.category.ToList();
                ViewBag.CategoryId = new SelectList(categoryList, "Category_Id", "Category_Name");
                var servicesList = db.services.ToList();
                ViewBag.ServiceList = new SelectList(servicesList, "Services_Id", "Services_Title");
                var fileName = S.files.Select(x => x.FileName);
                model.ImagePath = ("https://localhost:44330/webdata/UploadedFiles/") + fileName.FirstOrDefault();

                model.Description = model.Description;
                model.Price = model.Price;
                model.Status = model.Status;
                model.Create_Date = DateTime.Now.ToShortDateString();
                db.vender_catalog.Add(model);
                db.SaveChanges();

                foreach (HttpPostedFileBase file in S.files)
                {
                    //Checking file is available to save.  
                    if (file != null)
                    {
                        var InputFileName = Path.GetFileName(file.FileName);
                        var ServerSavePath = Path.Combine(Server.MapPath("~/webdata/UploadedFiles/") + InputFileName);
                        //Save file to server folder  
                        file.SaveAs(ServerSavePath);
                    }
                }
                TempData["DataInserted"] = "true";
                return RedirectToAction("V_Catelog");
        }



        public ActionResult V_Catelog_Edit(int Catalog_id)
        {
            var cata = db.vender_catalog.Where(x => x.Catalog_Id == Catalog_id).First();
            return View(cata);
        }
        [HttpPost]
        public ActionResult V_Catelog_Edit(Vender_Catalog s)
        {
            db.Entry(s).State = EntityState.Modified;
            //s.Category_Create_Date = DateTime.Now.ToShortDateString();
            s.Update_Date = DateTime.Now.ToShortDateString();
            int a = db.SaveChanges();
            if (a > 0)
            {
                ViewBag.UpdateMessage = "<script>alret('Data Updated !!')</script>";
                return RedirectToAction("V_Catelog");
            }
            else
            {
                ViewBag.UpdateMessage = "<script>alret('Data Not Updated !!')</script>";
            }

            return View();
        }


        public ActionResult V_Catelog_delete(int Catalog_id)
        {
            var Cate = db.vender_catalog.Where(x => x.Catalog_Id == Catalog_id).First();
            return View(Cate);
        }
        [HttpPost]
        public ActionResult V_Catelog_delete(Vender_Catalog s)
        {
            db.Entry(s).State = EntityState.Deleted;
            int a = db.SaveChanges();
            if (a > 0)
            {
                ViewBag.UpdateMessage = "<script>alret('Data Updated !!')</script>";
                return RedirectToAction("V_Catelog");
            }
            else
            {
                ViewBag.UpdateMessage = "<script>alret('Data Not Updated !!')</script>";
            }

            return View("V_Catelog");
        }










        //Catelog End----------------------------------------------------------------------------------------------------------------------------------------------
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