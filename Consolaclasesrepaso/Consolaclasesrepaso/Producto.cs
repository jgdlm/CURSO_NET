using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolaclasesrepaso
{
    class Producto
    {
        // atributos ---------------------------

        private string nombre;
        private double precio;
        private string categoria;
        

        // propiedades -------------------------


        public string Nombre
        { 
            get { return nombre; }
            set { nombre = value; }
      
        
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }

         }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }

        }

        // constructores con trs y dos parametros-----------------------

        public Producto (string p1, double p2, string p3)
        {
            this.Nombre = p1;
            this.Precio = p2;
            this.categoria = p3;

        }


        public Producto(string p1, double p2)
        {
            this.Nombre = p1;
            this.Precio = p2;
            
         }

        public Producto()
        { }

        // metodos ----------------------------------

        //metodo mostrar
        public void mostrar()
        {
            Console.WriteLine("EL PEDIDO ES:" + nombre + "\n");
            Console.WriteLine("EL PRECIO ES:" + precio + "\n");
            Console.WriteLine("lA CATEGORIA ES:" + categoria + "\n");
        }












}
}
