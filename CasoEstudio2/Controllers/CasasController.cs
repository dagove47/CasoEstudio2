using CasoEstudio2.Models;
using CasoEstudio2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasoEstudio2.Controllers
{
    public class CasasController : Controller
    {
        CasasModel casaModel = new CasasModel();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Consulta()
        {
            var consultas = casaModel.ConsultarCasas();
            ViewBag.msj = "";
            return View(consultas);
        }
        [HttpGet]
        public ActionResult Alquiler()
        {
            var casasDisponibles = casaModel.ObtenerCasasDisponibles();
            ViewBag.CasasDisponibles = new SelectList(casasDisponibles, "IdCasa", "Descripcion");
            ViewBag.msj = "";
            return View();
        }

        [HttpPost]
        public ActionResult Alquiler(Alquiler alquiler)
        {
            var respuesta = casaModel.AlquilarCasa(alquiler.IdCasa, alquiler.UsuarioAlquiler);

            if (respuesta)
            {
                ViewBag.msj = "La casa ha sido alquilada con éxito!";
                return RedirectToAction("Consulta"); // Redirige a la vista de consulta
            }
            else
            {
                // Recargar la lista de casas disponibles en caso de error
                var casasDisponibles = casaModel.ObtenerCasasDisponibles();
                ViewBag.CasasDisponibles = new SelectList(casasDisponibles, "IdCasa", "Descripcion");

                ViewBag.msj = "Error al alquilar la casa. Intente nuevamente.";
                return View();
            }
        }

        [HttpGet]
        public JsonResult ConsultarPrecio(long id)
        {
            var casa = casaModel.ConsultarCasas().FirstOrDefault(c => c.IdCasa == id);
            if (casa != null)
            {
                return Json(new { precio = casa.Precio }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { precio = 0 }, JsonRequestBehavior.AllowGet);
        }
    }
}

