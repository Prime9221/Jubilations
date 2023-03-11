using Jubilations.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.IO;
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
            return View(model);
        }

        //public ActionResult A_Services_Create()
        //{
        //    var ServicesList = db.ser.ToList();
        //    ViewBag.CompanyId = new SelectList(ServicesList, "CompanyId", "CompanyName");
        //    var EmployeeList = db.Employee.ToList();
        //    ViewBag.EmployeeId = new SelectList(EmployeeList, "EmployeeId", "EmployeeName");

        //    return View("create");
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult A_Services_Create(Address model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var CompanyList = db.Company.ToList();
        //        ViewBag.CompanyId = new SelectList(CompanyList, "CompanyId", "CompanyName");
        //        var EmployeeList = db.Employee.ToList();
        //        ViewBag.EmployeeId = new SelectList(EmployeeList, "EmployeeId", "EmployeeName");
        //        Address Address = new Address();
        //        Address.CompanyId = model.CompanyId;
        //        Address.EmployeeId = model.EmployeeId;
        //        Address.City = model.City;
        //        Address.State = model.State;
        //        Address.Country = model.Country;
        //        Address.Pincode = model.Pincode;
        //        db.Address.Add(Address);
        //        db.SaveChanges();
        //        TempData["DataInserted"] = "true";
        //        return RedirectToAction("Index");

        //    }
        //    return RedirectToAction("create");
        //}

        //public ActionResult A_Services_Edit(int AddressId)
        //{

        //    var CompanyList = db.Company.ToList();
        //    ViewBag.CompanyId = new SelectList(CompanyList, "CompanyId", "CompanyName");
        //    var EmployeeList = db.Employee.ToList();
        //    ViewBag.EmployeeId = new SelectList(EmployeeList, "EmployeeId", "EmployeeName");
        //    var Address = db.Address.Where(x => x.AddressId == AddressId).First();
        //    return View(Address);
        //}

        //[HttpPost]
        //public ActionResult A_Services_Edit(Address s)
        //{
        //    var CompanyList = db.Company.ToList();
        //    ViewBag.CompanyId = new SelectList(CompanyList, "CompanyId", "CompanyName");
        //    var EmployeeList = db.Employee.ToList();
        //    ViewBag.EmployeeId = new SelectList(EmployeeList, "EmployeeId", "EmployeeName");
        //    db.Entry(s).State = EntityState.Modified;
        //    int a = db.SaveChanges();
        //    if (a > 0)
        //    {
        //        ViewBag.UpdateMessage = "<script>alret('Data Updated !!')</script>";
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        ViewBag.UpdateMessage = "<script>alret('Data Not Updated !!')</script>";
        //    }

        //    return View();
        //}

        //public ActionResult A_Services_Delete(int AddressId)
        //{
        //    var CompanyList = db.Company.ToList();
        //    ViewBag.CompanyId = new SelectList(CompanyList, "CompanyId", "CompanyName");
        //    var EmployeeList = db.Employee.ToList();
        //    ViewBag.EmployeeId = new SelectList(EmployeeList, "EmployeeId", "EmployeeName");
        //    var Address = db.Address.Where(x => x.AddressId == AddressId).First();
        //    return View(Address);
        //}

        //[HttpPost]
        //public ActionResult A_Services_Delete(Address s)
        //{
        //    var CompanyList = db.Company.ToList();
        //    ViewBag.CompanyId = new SelectList(CompanyList, "CompanyId", "CompanyName");
        //    var EmployeeList = db.Employee.ToList();
        //    ViewBag.EmployeeId = new SelectList(EmployeeList, "EmployeeId", "EmployeeName");
        //    db.Entry(s).State = EntityState.Deleted;
        //    int a = db.SaveChanges();
        //    if (a > 0)
        //    {
        //        ViewBag.UpdateMessage = "<script>alret('Data Updated !!')</script>";
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        ViewBag.UpdateMessage = "<script>alret('Data Not Updated !!')</script>";
        //    }
        //    return View();
        //}
















        ///Services methods End--------------------------------------------------------------------
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