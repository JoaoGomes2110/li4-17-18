using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SmartPainting.Models;

namespace SmartPainting.Controllers
{
    public class LoginController : Controller
    {
        ProprietarioContext db = new ProprietarioContext();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult successAction()
        {
            return View("sucessView", "Shared");
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            if (ModelState.IsValid)
            {
                var proprietarios = (from m in db.proprietarios
                                     where m.email == email
                                     select m);

                if (proprietarios.ToList<Proprietario>().Count > 0)
                {
                    Proprietario proprietario = proprietarios.ToList<Proprietario>().ElementAt<Proprietario>(0);
                    using (MD5 md5Hash = MD5.Create())
                    {
                        if (MyHelpers.VerifyMd5Hash(md5Hash, password, proprietario.password))
                        {
                            HttpCookie cookie = MyHelpers.CreateAuthorizeTicket(proprietario.email, "Proprietario");
                            Response.Cookies.Add(cookie);

                        }
                        else
                        {
                            ModelState.AddModelError("password", "Password incorreta!");
                            return View("Index");
                        }
                    }

                }
                else
                {
                    ModelState.AddModelError("", "Login data is incorrect!");
                    return View("Index");

                }
            }
            else
            {
                ModelState.AddModelError("", "Invalid Request");
                return View("Index");

            }
            return RedirectToAction("sucessAction", "Login");
        }

        [HttpPost]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}