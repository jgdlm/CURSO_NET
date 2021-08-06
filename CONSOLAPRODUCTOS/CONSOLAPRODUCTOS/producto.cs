using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLAPRODUCTOS
{
    public class producto
    {
        //ATRIBUTOS
        private string nombre;
        private double precio;
        private string categoria;
       
       
        //get y set son propiedades para cada uno de los campos que invocamos
        //get es la propiedad de lectura y set la de escritura
        //propiedades públicas para poder llamarlas desde cualquier parte del proyecto
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

        //sobrecarga de constructor con parámetros que sobrecarga al anterior
        //tantos constructores como propiedades
        //crea el objeto producto pero con valores que les pasamos con argumento del constructor

        public producto(string p1, double p2, string p3)
        {
            this.Nombre = p1; //this es otra manera de invocar al propio objeto que se acaba de instanciar
            this.Precio = p2;
            this.categoria = p3;
        }

        public producto(string p1, double p2) //constructor por defecto con mismo nombre de la clase
                          //nos sirve para acceder al objeto creado a través de sus propiedad
        {
            this.Nombre = p1; //this es otra manera de invocar al propio objeto que se acaba de instanciar
            this.Precio = p2;
        }

        public producto() //constructor por defecto con mismo nombre de la clase
                          //nos sirve para acceder al objeto creado a través de sus propiedad
        { }

        public void mostrar()
        {
            Console.WriteLine("EL PEDIDO ES:" + nombre + "\n");
            Console.WriteLine("EL PRECIO ES:" + precio + "\n");
            Console.WriteLine("LA CATEGORIA ES:" + categoria + "\n");
        }

    }


}
