using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Viernes.Models
{
    public class Biblioteca
    {
        public List<Libro> Libros { get; set; }
        public Biblioteca()
        {
            Libros = new List<Libro>
            {
                new Libro{ISBN="11122", Titulo="Los Piratas del Caribe", TipoLibro="Novela"},
                new Libro{ISBN="22211", Titulo="Los Pilares de la Tierra", TipoLibro="Novela"},
                new Libro {ISBN = "12121", Titulo = "Steve Jobs", TipoLibro = "Biografía" }
            };

        }
        public int NumeroLibros()
        {
            return Libros.Count();
        }

        public Libro ObtenerPorIsbn(string isbn)
        {
            foreach (var libroBuscar in Libros)
            {
                if (libroBuscar.ISBN == isbn)
                {
                    return libroBuscar;
                }
            }

            return null;
        }

        
    }
}