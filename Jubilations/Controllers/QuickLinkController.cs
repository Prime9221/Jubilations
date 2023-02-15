using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jubilations.Controllers
{
    public class QuickLinkController : Controller
    {
        // GET: QuickLink
        public ActionResult Terms()
        {
            return View();
        }
        public ActionResult Privacy_Policy()
        {
            return View();
        }

        public ActionResult Submit_Wedding()
        {
            return View();
        }

        public ActionResult why_choose_us()
        {
            return View();
        }

        public ActionResult Success_Story()
        {
            return View();
        }
    }
}