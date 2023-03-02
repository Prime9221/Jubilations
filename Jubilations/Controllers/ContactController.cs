using Jubilations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jubilations.Controllers
{
    public class ContactController : Controller
    {
        DBEntity db = new DBEntity();
        public ActionResult Contact_us()
        {
            return View();
        }
        public ActionResult About_us()
        {
            var data = db.aboutuss;
            return View(data);
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult Blog1()
        {
            return View();
        }

        public ActionResult View_Blog1()
        {
            return View();
        }

    }
}