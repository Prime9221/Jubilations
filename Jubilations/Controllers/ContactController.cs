using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jubilations.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Contact_us()
        {
            return View();
        }
        public ActionResult About_us()
        {
            return View();
        }
    }
}