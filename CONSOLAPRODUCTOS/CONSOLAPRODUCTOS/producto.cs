using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLAPRODUCTOS
{
    public class producto
    {
        private string nombre;
        private double precio;
        private string categoria;
        public producto() //constructor por defecto con mismo nombre de la clase
                          //nos sirve para acceder al objeto creado a través de sus propiedad
        {

        }
        //sobrecarga de constructor con parámetros que sobrecarga al anterior
        //tantos constructores como propiedades
        //crea el objeto producto pero con valores que les pasamos con argumento del constructor

        public producto(string nombre, double precio, string categoria)
        {
            this.nombre = nombre; //this es otra manera de invocar al propio objeto que se acaba de instanciar
            this.precio = precio;
            this.categoria = categoria;
        }
        //get y set son propiedades para cada uno de los campos que invocamos
        //get es la propiedad de lectura y set la de escritura
        //propiedades públicas para poder llamarlas desde cualquier parte del proyecto
        public string PNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double PPrecio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string PCategoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

   
    }

  
}
