using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Viernes.Models;

namespace MVC_Viernes.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            // var libro = new Libro { ISBN = "1122", Titulo = "El principito", TipoLibro = "Novela" };devuelve un libro
            //vamos a hacer una lista de libros
            var libros = new List<Libro>
           {
               new Libro{ISBN="1122",Titulo="El principito", TipoLibro = "Novela"}, new Libro{ISBN="1123",Titulo="Steve Jobs", TipoLibro="Biografía"}
               };
           
            return View(libros);
        }
    }
}