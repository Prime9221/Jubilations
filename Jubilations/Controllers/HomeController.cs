using Jubilation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jubilations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        DBEntity db = new DBEntity();
        public ActionResult Index()
        {
            var data = db.aboutuss;
            return View(data);
        }
    }
}