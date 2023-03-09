using Jubilations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jubilations.Controllers {
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
            var data = db.feedBacks;
            return View(data);
        }

        public ActionResult Testimonial() {
            return View();
        }
    }
}