using Jubilations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jubilations.Controllers
{
    [Authorize(Roles = "2")]
    public class ServicesController : Controller
    {
        //[Authorize(Roles = "1")]
        //[Authorize(Roles = "3")]
        
        // GET: Services
        DBEntity db = new DBEntity();

        public ActionResult Services1()
        {
            var data = db.category;
            return View(data);
        }

        public ActionResult venue(int categoryId)
        {
            var services = db.services.Where(x => x.Category_Id == categoryId).ToList();
            return View(services);
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
            var model = db.vender_catalog;
            return View(model);
        }
    }
}