using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MODELO_VISTA_CONTROLADOR.Models; //meter el using con el nombre del proyecto.Models

namespace MODELO_VISTA_CONTROLADOR.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            // esto es un solo libro var libro = new Libro { Isbn = "1122", Titulo = "El principito", TipoLibro = "Novela" };
            //return View(libro);
            var libros = new List<Libro>
            {
               new Libro { Isbn = "1122", Titulo = "El principito", TipoLibro = "Novela" },new Libro { Isbn = "1122", Titulo = "Steve Jobs", TipoLibro = "Biografia" }
            };
            return View(libros);
        }
    }
}