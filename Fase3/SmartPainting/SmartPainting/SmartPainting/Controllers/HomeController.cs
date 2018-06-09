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
            var servicosDeHoje = new ServicosHoje
            {
                servicosHoje = new List<Serviço>()
            };
            /*List<Serviço> serviçosDeHoje = new List<Serviço>();*/

            var servico = (from m in db.Serviço
                       select m);

            servicosDeHoje.servicosHoje = servico.ToList();

                

            return View(servicosDeHoje.servicosHoje);
        }
    }
}