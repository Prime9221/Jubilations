using Jubilations.Models;
using System.Data.Entity;
using System.IO;
using System.Linq;
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
                    file.SaveAs(ServerSavePath);
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

            return View(aboutUsModel);
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