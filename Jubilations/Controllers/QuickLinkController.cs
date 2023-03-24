using Jubilations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Jubilations.Controllers {
    [Authorize(Roles = "1")]
    [Authorize(Roles = "3")]
    [Authorize(Roles = "2")]
    public class QuickLinkController : Controller {

        DBEntity db = new DBEntity();
        public ActionResult Terms() {
            return View();
        }
        public ActionResult Privacy_Policy() {
            return View();
        }

        public ActionResult Submit_Wedding() {
            return View();
        }

        public ActionResult Gallery() {
            return View();
        }

        public ActionResult why_choose_us() {
            return View();
        }

        public ActionResult Success_Story() {
            return View();
        }

        public ActionResult yomesh_mansi() {
            return View();
        }

        public ActionResult Feedback()
        {
            //var data = db.feedBacks;
            return View("Feedback");
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Feedback(FeedBack model)
        {
            if (ModelState.IsValid)
            {
                
                
                FeedBack FeedBack = new FeedBack();
                
                FeedBack.Name = model.Name;
                FeedBack.FeedBack_Email = model.FeedBack_Email;
                FeedBack.FeedBack_Message = model.FeedBack_Message;
                FeedBack.SuccessStory_Create_Date = DateTime.Now.ToShortDateString();
                FeedBack.SuccessStory_Update_Date = DateTime.Now.ToShortDateString();
                db.feedBacks.Add(FeedBack);
                db.SaveChanges();
                TempData["DataInserted"] = "true";
                return RedirectToAction("Feedback");

            }
            return RedirectToAction("Feedback");
        }

        public ActionResult Testimonial() {
            var data = db.feedBacks.ToList();
            return View(data);
        }
    }
}