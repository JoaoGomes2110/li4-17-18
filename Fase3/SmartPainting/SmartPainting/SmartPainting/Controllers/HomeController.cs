using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartPainting.Models;

namespace SmartPainting.Controllers
{
    public class HomeController : Controller
    {
        ServicosContext db = new ServicosContext();
        // GET: Home

        public ActionResult Home()
        {
            DateTime today = DateTime.Today;
            List<Serviço> serviçosDeHoje = new List<Serviço>();
            foreach(Serviço s in db.Serviço)
            {
                if (s.data.Equals(today))
                {
                    serviçosDeHoje.Add(s);
                }
            }

            return View(serviçosDeHoje);
        }
    }
}