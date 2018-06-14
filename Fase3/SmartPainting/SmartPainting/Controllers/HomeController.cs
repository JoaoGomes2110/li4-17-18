using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartPainting.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Home()
        {
            return View();
        }
        public ActionResult ServiceHistory()
        {
            return View();
        }

        public ActionResult PainterList()
        {
            return View();
        }

        public ActionResult ClientList()
        {
            return View();
        }

        public ActionResult Interiors()
        {
            return View();
        }

        public ActionResult Exteriors()
        {
            return View();
        }

        public ActionResult Paints()
        {
            return View();
        }
    }
}