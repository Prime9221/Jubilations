using Jubilations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;
using Login = Jubilations.Models.Login;

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
       
           
            [Authorize(Roles = "Admin")]
            public ActionResult Index1() {
                return View();
            }

            [Authorize(Roles = "User")]
            public ActionResult Index2() {
                return View();
            }

            [Authorize(Roles = "Modrate")]
            public ActionResult Index3() {
                return View();
            }

            public ActionResult Login() {
                return View();
            }
            [HttpPost]
            public ActionResult Login(Login model, string returnUrl) {

                var roll = db.Login.Where(x => x.username == model.username).Select(x => x.rolls).FirstOrDefault();
                var dataItem = db.Login.Where(x => x.username == model.username && x.password == model.password).FirstOrDefault();
                if (dataItem != null) {
                    FormsAuthentication.SetAuthCookie(dataItem.username, false);
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/") && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\")) {
                        return Redirect(returnUrl);
                    }

                    else {
                        if (!string.IsNullOrEmpty(roll)) {
                            if (roll == "Admin") {
                                return RedirectToAction("Index");
                            }
                            else {
                                //return RedirectToAction("Index2");
                                if (roll == "Modrate") {
                                    return RedirectToAction("Index3");
                                }
                                else {
                                    return RedirectToAction("Index2");
                                }
                            }
                        }
                        else {
                            return Content(null);
                        }

                    }

                }
                else {
                    ModelState.AddModelError("", "Invalid User/pass");
                    return View();
                }
            }
            [Authorize]



            public ActionResult SignOut() {
                FormsAuthentication.SignOut();
                return RedirectToAction("Login", "Home");

            }
        }
    }
