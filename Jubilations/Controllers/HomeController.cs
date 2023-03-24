using Jubilations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace Jubilations.Controllers
{
    [Authorize(Roles = "1")]
    [Authorize(Roles = "3")]
    [Authorize(Roles = "2")]
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
