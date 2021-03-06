using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaBanco
{
    //Hacemos la clase cuenta
    class Cuenta //public class Libro es igual, si no pones public, actua como public por defecto
    {
        //se establecen los campos que se necesitan
        //todos sus campos son privados, accesibles desde su propia clase

        //campos o atributos. privados. protected si hay herencia
        private int NumCuenta;
        private string NombreCliente;
        private decimal Saldo;

       public Cuenta() //constructor por defecto con mismo nombre de la clase
                       //nos sirve para acceder al objeto creado a través de sus propiedades
        {

        }

       
        //get y set son propiedades para cada uno de los campos que invocamos
        //get es la propiedad de lectura y set la de escritura
        //propiedades públicas para poder llamarlas desde cualquier parte del proyecto

        public int CNumCuenta
        {
            get { return NumCuenta; }
            set { NumCuenta = value; }
        }

        public string CNombreCliente
        {
            get { return NombreCliente; }
            set { NombreCliente = value; }
        }

        public decimal CSaldo
        {
            get { return Saldo; }
            set { Saldo = value; }
        }


        //Método Consultar datos: A través de sus propiedades. 
        public void Consultar()
        {
            Console.WriteLine("El Saldo total es:"+ CSaldo);
           
        }

       
    }
}
