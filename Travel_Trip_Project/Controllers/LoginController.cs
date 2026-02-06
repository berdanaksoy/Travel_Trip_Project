using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Travel_Trip_Project.Models.Classes;

namespace Travel_Trip_Project.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(admin adm)
        {
            var info = c.admins.FirstOrDefault(x => x.user == adm.user && x.password == adm.password);
            if (info != null)
            {
                FormsAuthentication.SetAuthCookie(info.user, false);
                Session["user"] = info.user.ToString();

                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult LogOut()
            {
                FormsAuthentication.SignOut();
                Session.Abandon();
    
                return RedirectToAction("Login", "Login");
        }
    }
}