using Jubilations.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace Jubilations.Controllers
{
    [Authorize(Roles = "1")]
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
            var model = new AboutUsModel();
            model.aboutusList = db.aboutuss.ToList();
            return View(model);
        }

        public ActionResult A_Aboutus_Edit(int aboutId)
        {
            var model = new AboutUsModel();
            model.aboutus = db.aboutuss.Where(x => x.aboutId == aboutId).First();
            return View(model);
        }
        [HttpPost]
        public ActionResult A_Aboutus_Edit(AboutUsModel aboutUsModel,  Aboutus aboutus)
        {
            aboutus.title = aboutUsModel.aboutus.title;
            aboutus.description = aboutUsModel.aboutus.description;
            aboutus.Pictures = aboutUsModel.aboutus.Pictures;
            var fileName = aboutUsModel.files.Select(x => x.FileName);
            aboutus.ImagePath = ("https://localhost:44330/webdata/UploadedFiles/") + fileName.FirstOrDefault();
            db.Entry(aboutus).State = EntityState.Modified;
            int a = db.SaveChanges();

            foreach (HttpPostedFileBase file in aboutUsModel.files)
            {
                //Checking file is available to save.  
                if (file != null)
                {
                    var InputFileName = Path.GetFileName(file.FileName);
                    var ServerSavePath = Path.Combine(Server.MapPath("~/webdata/UploadedFiles/") + InputFileName);
                    //Save file to server folder  
                    file.SaveAs(ServerSavePath) ;
                   

                }
            }
            if (a > 0)
            {
                ViewBag.UpdateMessage = "<script>alret('Data Updated !!')</script>";
                return RedirectToAction("A_Aboutus");
            }
            else
            {
                ViewBag.UpdateMessage = "<script>alret('Data Not Updated !!')</script>";
            }

            return View("A_Aboutus");
        }


        ///about us methods end--------------------------------------------------------------------

        ///Feedback methods start--------------------------------------------------------------------
        public ActionResult A_Feedback()
        {
            var model = new FeedBackModel();
            model.feedbackList = db.feedBacks.ToList();
            return View(model);
        }

        public ActionResult A_Feedback_delete(int Feedback_ID)
        {
            var Feedback = db.feedBacks.Where(x => x.FeedBack_Id == Feedback_ID).First();
            return View(Feedback);
        }
        [HttpPost]
        public ActionResult A_Feedback_delete(FeedBack s)
        {
           db.Entry(s).State = EntityState.Deleted;
            int a = db.SaveChanges();
            if (a > 0)
            {
                ViewBag.UpdateMessage = "<script>alret('Data Updated !!')</script>";
                return RedirectToAction("A_Feedback");
            }
            else
            {
                ViewBag.UpdateMessage = "<script>alret('Data Not Updated !!')</script>";
            }

            return View("A_Feedback");
        }


        ///Feedback methods end--------------------------------------------------------------------

        ///Category methods start--------------------------------------------------------------------
        public ActionResult A_Category()
        {
            var model = new CategoryModel();
            model.CategoryList = db.category.ToList();
            return View(model);
        }


        public ActionResult A_Category_Create()
        {
            return View("A_Category_Create");
        }

        [HttpPost]
        public ActionResult A_Category_Create(Category model)
        {
            if (ModelState.IsValid)
            {


                Category a = new Category();

                a.Category_Name = model.Category_Name;
                a.Category_Status = model.Category_Status;
                a.Category_Create_Date = DateTime.Now.ToShortDateString();
                //a.Category_Update_Date = DateTime.Now.ToShortDateString();
                db.category.Add(a);
                db.SaveChanges();
                TempData["DataInserted"] = "true";
                return RedirectToAction("A_Category");

            }
            return RedirectToAction("A_Category");
        }


        public ActionResult A_Category_Edit(int Category_id)
        {
            var ca = db.category.Where(x => x.Category_Id == Category_id).First();
            return View(ca);
        }
        [HttpPost]
        public ActionResult A_Category_Edit(Category s)
        {
            db.Entry(s).State = EntityState.Modified;
            //s.Category_Create_Date = DateTime.Now.ToShortDateString();
            s.Category_Update_Date = DateTime.Now.ToShortDateString();
            int a = db.SaveChanges();
            if (a > 0)
            {
                ViewBag.UpdateMessage = "<script>alret('Data Updated !!')</script>";
                return RedirectToAction("A_Category");
            }
            else
            {
                ViewBag.UpdateMessage = "<script>alret('Data Not Updated !!')</script>";
            }

            return View();
        }

        public ActionResult A_Category_delete(int Category_ID)
        {
            var Ci = db.category.Where(x => x.Category_Id == Category_ID).First();
            return View(Ci);
        }
        [HttpPost]
        public ActionResult A_Category_delete(Category s)
        {
            db.Entry(s).State = EntityState.Deleted;
            int a = db.SaveChanges();
            if (a > 0)
            {
                ViewBag.UpdateMessage = "<script>alret('Data Updated !!')</script>";
                return RedirectToAction("A_Category");
            }
            else
            {
                ViewBag.UpdateMessage = "<script>alret('Data Not Updated !!')</script>";
            }

            return View("A_Category");
        }


        ///Category methods end--------------------------------------------------------------------

        ///Services methods Start--------------------------------------------------------------------

        public ActionResult A_Services()
        {
            var model = new ServicesModel();

            model.ServicesList = db.services.ToList();
            model.UserNameList = db.user.ToList();
            model.CategoryList = db.category.ToList();
            return View(model);
        }

        public ActionResult A_Services_Delete(int Service_Id)
        {
            var si = db.services.Where(x => x.Services_Id == Service_Id).First();
            return View(si);
        }

        [HttpPost]
        public ActionResult A_Services_Delete( Services s)
        {
            db.Entry(s).State = EntityState.Deleted;
            int a = db.SaveChanges();
            if (a > 0)
            {
                ViewBag.UpdateMessage = "<script>alret('Data Updated !!')</script>";
                return RedirectToAction("A_Services");
            }
            else
            {
                ViewBag.UpdateMessage = "<script>alret('Data Not Updated !!')</script>";
            }

            return View("A_Services");
        }

        ///Services methods End--------------------------------------------------------------------


        //Catelog start--------------------------------------------------------------------------------------------------

        public ActionResult A_Catelog()
        {
            var model = new Vender_CatalogModel();

            model.CatalogList = db.vender_catalog.ToList();
            model.UserNameList = db.user.ToList();
            model.CategoryList = db.category.ToList();
            model.ServicesList = db.services.ToList();
            return View(model);
        }


        public ActionResult A_Catelog_delete(int Catalog_id)
        {
            var Cate = db.vender_catalog.Where(x => x.Catalog_Id == Catalog_id).First();
            return View(Cate);
        }
        [HttpPost]
        public ActionResult A_Catelog_delete(Vender_Catalog s)
        {
            db.Entry(s).State = EntityState.Deleted;
            int a = db.SaveChanges();
            if (a > 0)
            {
                ViewBag.UpdateMessage = "<script>alret('Data Updated !!')</script>";
                return RedirectToAction("A_Catelog");
            }
            else
            {
                ViewBag.UpdateMessage = "<script>alret('Data Not Updated !!')</script>";
            }

            return View("A_Catelog");
        }

        //Catelog end--------------------------------------------------------------------------------------------------


        //Profile start----------------------------
        public ActionResult ProFiles()
        {
            return View();
        }
        //Profile End----------------------------

        //User start----------------------------
        public ActionResult A_User()
        {
            var model = new UserModel();
            model.UserList = db.user.ToList();

            return View(model);
        }

        public ActionResult A_User_delete(int User_ID)
        {
            var Ui = db.user.Where(x => x.User_Id == User_ID).First();
            return View(Ui);
        }
        [HttpPost]
        public ActionResult A_User_delete(User u)
        {
            int a = 0;
            var existingRecord = db.user.Find(u.User_Id);
            if (existingRecord != null)
            {
                db.user.Remove(existingRecord);
                 a = db.SaveChanges();
            }
            if (a > 0)
            {
                ViewBag.UpdateMessage = "<script>alret('Data Updated !!')</script>";
                return RedirectToAction("A_User");
            }
            else
            {
                ViewBag.UpdateMessage = "<script>alret('Data Not Updated !!')</script>";
            }

            return View("A_User");
        }
        public ActionResult A_Role()
        {
            var model = new User_RoleModel();
            model.User_RoleList = db.user_role.ToList();

            return View(model);
        }

        public ActionResult A_Role_Create()
        {
            return View("A_Role_Create");
        }

        [HttpPost]
        public ActionResult A_Role_Create(User_Role model)
        {
            if (ModelState.IsValid)
            {


                User_Role a = new User_Role();

                a.UserRole_Name = model.UserRole_Name;
                db.user_role.Add(a);
                db.SaveChanges();
                TempData["DataInserted"] = "true";
                return RedirectToAction("A_Role");

            }
            return RedirectToAction("A_Role");
        }


        public ActionResult A_Role_delete(int UserRole_Id)
        {
            var URi = db.user_role.Where(x => x.UserRole_Id == UserRole_Id).First();
            return View(URi);
        }
        [HttpPost]
        public ActionResult A_Role_delete(User_Role s)
        {
            db.Entry(s).State = EntityState.Deleted;
            int a = db.SaveChanges();
            if (a > 0)
            {
                ViewBag.UpdateMessage = "<script>alret('Data Updated !!')</script>";
                return RedirectToAction("A_Role");
            }
            else
            {
                ViewBag.UpdateMessage = "<script>alret('Data Not Updated !!')</script>";
            }

            return View("A_Role");
        }

        public ActionResult A_User_Role()
        {
            var model = new User_Role_MapModel();
            model.User_RoleList = db.user_role.ToList();
            model.User_IdList = db.user.ToList();
            model.User_Role_MapList = db.user_role_Maps.ToList();
            return View(model);
        }

        public ActionResult A_DRole_Delete(int Role_Id)
        {
            var si = db.user_role_Maps.Where(x => x.Id == Role_Id).First();
            return View(si);
        }

        [HttpPost]
        public ActionResult A_DRole_Delete(User_Role_Map u, int Role_Id)
        {
            int a = 0;
            var existingRecord = db.user_role_Maps.Find(Role_Id);
            if (existingRecord != null)
            {
                db.user_role_Maps.Remove(existingRecord);
                a = db.SaveChanges();
            }
            if (a > 0)
            {
                ViewBag.UpdateMessage = "<script>alret('Data Updated !!')</script>";
                return RedirectToAction("A_User_Role");
            }
            else
            {
                ViewBag.UpdateMessage = "<script>alret('Data Not Updated !!')</script>";
            }

            return View("A_User_Role");
        }

        public ActionResult A_Role_Define()
        {
            var userList = db.user.ToList();
            ViewBag.UserId = new SelectList(userList, "User_Id", "User_Name");
            var RoleList = db.user_role.ToList();
            ViewBag.RoleId = new SelectList(RoleList, "UserRole_Id", "UserRole_Name");

            return View("A_Role_Define");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult A_Role_Define(User_Role_Map model, User_Role_MapModel S)
        {
            if (ModelState.IsValid)
            {

                var userList = db.user.ToList();
                ViewBag.UserId = new SelectList(userList, "User_Id", "User_Name");
                var RoleList = db.user_role.ToList();
                ViewBag.RoleId = new SelectList(RoleList, "UserRole_Id", "UserRole_Name");
                User_Role_Map s = new User_Role_Map();
                db.user_role_Maps.Add(model);
                db.SaveChanges();
                TempData["DataInserted"] = "true";
                return RedirectToAction("A_User_Role");

            }
            return RedirectToAction("A_Role_Define");
        }


        //User End----------------------------



        //Blog start--------------------------------------------------------------------------------------------

        public ActionResult A_Blog()
        {
            var model = new BlogModel();
            model.BlogList = db.blog.ToList();
            return View(model);
        }
        public ActionResult A_Blog_Create()
        {
            return View("A_Blog_Create");
        }

        [HttpPost]
        public ActionResult A_Blog_Create(Blog model)
        {
            if (ModelState.IsValid)
            {


                Blog a = new Blog();

                a.Blog_Name = model.Blog_Name;
                a.Blog_Title = model.Blog_Title;
                a.Blog_Description = model.Blog_Description;
                a.Blog_Image = model.Blog_Image;
                a.Blog_Create_Date = DateTime.Now.ToShortDateString();
                //a.Category_Update_Date = DateTime.Now.ToShortDateString();
                db.blog.Add(a);
                db.SaveChanges();
                TempData["DataInserted"] = "true";
                return RedirectToAction("A_Blog");

            }
            return RedirectToAction("A_Blog");
        }
        public ActionResult A_Blog_Edit(int Blog_Id)
        {
            var ca = db.blog.Where(x => x.Blog_Id == Blog_Id).First();
            return View(ca);
        }
        [HttpPost]
        public ActionResult A_Blog_Edit(Blog s)
        {
            db.Entry(s).State = EntityState.Modified;
            //s.Category_Create_Date = DateTime.Now.ToShortDateString();
            s.Blog_Update_Date = DateTime.Now.ToShortDateString();
            int a = db.SaveChanges();
            if (a > 0)
            {
                ViewBag.UpdateMessage = "<script>alret('Data Updated !!')</script>";
                return RedirectToAction("A_Blog");
            }
            else
            {
                ViewBag.UpdateMessage = "<script>alret('Data Not Updated !!')</script>";
            }

            return View();
        }
        public ActionResult A_Blog_delete(int Blog_Id)
        {
            var Ci = db.blog.Where(x => x.Blog_Id == Blog_Id).First();
            return View(Ci);
        }
        [HttpPost]
        public ActionResult A_Blog_delete(Blog s)
        {
            db.Entry(s).State = EntityState.Deleted;
            int a = db.SaveChanges();
            if (a > 0)
            {
                ViewBag.UpdateMessage = "<script>alret('Data Updated !!')</script>";
                return RedirectToAction("A_Blog");
            }
            else
            {
                ViewBag.UpdateMessage = "<script>alret('Data Not Updated !!')</script>";
            }

            return View("A_Blog");
        }




        //Blog End--------------------------------------------------------------------------------------------

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