using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clase300522.Controllers
{
    public class NameController : Controller
    {
        // GET: Name
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string firstname, string lastname)
        {
            ViewBag.Name = string.Format("Nombre: {0} {1}", firstname, lastname);
            return View();
        }
    }
}