using Jubilations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jubilations.Controllers
{
    //[Authorize(Roles = "1")]
    //[Authorize(Roles = "3")]
    [Authorize(Roles = "2")]
    // GET: Services
    public class ServicesController : Controller
    {

        DBEntity db = new DBEntity();
        public ActionResult Services1()
        {
            var data = db.category.ToList();
            return View(data);
        }

        public ActionResult venue()
        {
            return View();
        }

        public ActionResult venue1()
        {
            return View();
        }
        public ActionResult Bridal_Makeup_Artists()
        {
            return View();
        }
        public ActionResult Cloth_Studio()
        {
            return View();
        }
        public ActionResult DJ_Rocks()
        {
            return View();
        }
        public ActionResult Transport()
        {
            return View();
        }
        public ActionResult Wedding_Decorator()
        {
            return View();
        }
        public ActionResult Wedding_Photographers()
        {
            return View();
        }
        public ActionResult Wedding_Catering()
        {
            return View();
        }
        public ActionResult Invitation_Cards()
        {
            return View();
        }
        public ActionResult Mehendi_Artists()
        {
            return View();
        }

        public ActionResult ViewCatelog()
        {
            return View();
        }
    }
}