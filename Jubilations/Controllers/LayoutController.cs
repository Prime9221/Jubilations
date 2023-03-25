using Jubilations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jubilations.Controllers
{
    public class LayoutController : Controller
    {
        // GET: Layout
        DBEntity db = new DBEntity();
        public ActionResult Search(string empsearch)
        {
            //var companylist = db.Company.ToList();
            //ViewBag.companyid = new SelectList(companylist, "companyid", "companyname");
            ViewData["getemployeedetails"] = empsearch;

            if (!string.IsNullOrEmpty(empsearch))
            {
                var employee = db.category.Where(x => x.Category_Name.Contains(empsearch) || x.Category_Status.Contains(empsearch))
                .ToList();

                return View("Index", employee);
            }
            else
            {
                return View("Index");
            }
        }
    }
}