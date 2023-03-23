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
    public class LoginController : Controller
    {
        DBEntity db = new DBEntity();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User model, string returnUrl)
        {
            var user = db.user.Where(x => x.User_Email == model.User_Email).FirstOrDefault();
            if (user != null)
            {
                var roll = db.user_role_Maps.Where(x => x.User_Id == user.User_Id).Select(x => x.UserRole_Id).FirstOrDefault().ToString();
                var dataItem = db.user.Where(x => x.User_Email == model.User_Email && x.User_Password == model.User_Password).FirstOrDefault();
                if (dataItem != null)
                {
                    FormsAuthentication.SetAuthCookie(dataItem.User_Email, false);
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/") && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                    {
                        return Redirect(returnUrl);
                    }

                    else
                    {
                        if (!string.IsNullOrEmpty(roll))
                        {
                            if (roll == "1")
                            {
                                return RedirectToAction("Dashboard", "A_admin");
                            }
                            else
                            {
                                //return RedirectToAcBtion("Index2");
                                if (roll == "3")
                                {
                                    return RedirectToAction("Dashboard", "V_admin");
                                }
                                else
                                {
                                    return RedirectToAction("Index", "Home");
                                }
                            }
                        }
                        else
                        {
                            return Content(null);
                        }

                    }

                }
            }
            else
            {
                ModelState.AddModelError("", "Invalid User/pass");
                return View();
            }
            return View();
        }
        [Authorize]

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");

        }

        public ActionResult Forgot_password()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View("Register");
        }
        [HttpPost]
        public ActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {


                User a = new User();

                a.User_Name = model.User_Name;
                a.User_Email = model.User_Email;
                a.User_PhoneNo = model.User_PhoneNo;
                a.User_DOB = model.User_DOB;
                a.User_Password = model.User_Password;
                a.User_Create_Date = DateTime.Now.ToShortDateString();
                //a.Category_Update_Date = DateTime.Now.ToShortDateString();
                db.user.Add(a);
                db.SaveChanges();
                TempData["DataInserted"] = "true";
                return RedirectToAction("Login");

            }
            return RedirectToAction("Login");
        }
        public ActionResult Otp()
        {
            return View();
        }

        public ActionResult FNewPass()
        {
            return View();
        }

        public ActionResult businessForm()
        {
            return View("businessForm");
        }
        [HttpPost]
        public ActionResult businessForm(User model)
        {
            if (ModelState.IsValid)
            {


                User a = new User();

                a.User_Name = model.User_Name;
                a.User_ShopName= model.User_ShopName;
                a.User_Address = model.User_Address;
                a.User_GSTNO = model.User_GSTNO;
                a.User_Email = model.User_Email;
                a.User_PhoneNo = model.User_PhoneNo;
                a.User_Password = model.User_Password;
                a.User_Create_Date = DateTime.Now.ToShortDateString();
                //a.Category_Update_Date = DateTime.Now.ToShortDateString();
                db.user.Add(a);
                db.SaveChanges();
                TempData["DataInserted"] = "true";
                return RedirectToAction("Login");

            }
            return RedirectToAction("Login");
        }
        public ActionResult verifyotp()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }
    }
}