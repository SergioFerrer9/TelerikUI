using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Models;

namespace Telerik.Controllers
{
    public class ConsultasController : Controller
    {
        

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarExtra()
        {
            try
            {
                Model2 modelo = new Model2();
                List<Carro> generos = modelo.Database.SqlQuery<Carro>("spr_consultaExtra").ToList();

                return Json(generos, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
        }

    }
}
