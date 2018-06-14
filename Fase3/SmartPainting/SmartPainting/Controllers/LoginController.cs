using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SmartPainting.Controllers
{
    public class LoginController : Controller
    {

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult successAction()
        {
            return View("Home", "Home");
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            return RedirectToAction("Home", "Home");
        }

        [HttpPost]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}