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




    }
}
