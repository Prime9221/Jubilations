using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jubilations.Controllers
{
    public class V_adminController : Controller
    {
        // dashboards-analytics
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult app_access_permission() {
            return View();
        }

        public ActionResult app_access_roles() {
            return View();
        }

        public ActionResult app_calendar() {
            return View();
        }

        public ActionResult app_chat() {
            return View();
        }

        public ActionResult app_email() {
            return View();
        }

        public ActionResult app_invoice_add() {
            return View();
        }

        public ActionResult app_invoice_edit() {
            return View();
        }

        public ActionResult app_invoice_list() {
            return View();
        }

        public ActionResult app_invoice_preview() {
            return View();
        }

        public ActionResult app_invoice_print() {
            return View();
        }

        public ActionResult app_use_list() {
            return View();
        }

        public ActionResult app_user_view_account() {
            return View();
        }

        public ActionResult app_user_view_security() {
            return View();
        }

        public ActionResult dashboards_crm() {
            return View();
        }

        public ActionResult dashboards_ecommerce() {
            return View();
        }

        public ActionResult maps_leaflet() {
            return View();
        }
    }
}