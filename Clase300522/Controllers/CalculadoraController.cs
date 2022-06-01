using Clase300522.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clase300522.Controllers
{
    public class CalculadoraController : Controller
    {
        // GET: Calculadora
        public ActionResult Index()
        {
            return View(new cCalculadora());
        }
        [HttpPost]
        public ActionResult Calcular(cCalculadora objCalculadora)
        {
            if ("+".Equals(objCalculadora.Accion))
            {
                objCalculadora.Respuesta = objCalculadora.Operador1 + objCalculadora.Operador2;
            }
            if ("-".Equals(objCalculadora.Accion))
            {
                objCalculadora.Respuesta = objCalculadora.Operador1 - objCalculadora.Operador2;
            }
            if ("*".Equals(objCalculadora.Accion))
            {
                objCalculadora.Respuesta = objCalculadora.Operador1 * objCalculadora.Operador2;
            }
            if ("/".Equals(objCalculadora.Accion))
            {
                objCalculadora.Respuesta = objCalculadora.Operador1 / objCalculadora.Operador2;
            }
            return View("index", objCalculadora);
        }
    }
}