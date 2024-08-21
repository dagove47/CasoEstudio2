using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasoEstudio2.Controllers
{
    public class CasasController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Consulta()
        {
            ViewBag.msj = "";
            return View();
        }


        [HttpGet]
        public ActionResult Alquiler()
        {
            ViewBag.msj = "";
            return View();
        }

        // [HttpPost]
        // public ActionResult Alquiler()
        // {
        //     return View();
        // }
    }
}