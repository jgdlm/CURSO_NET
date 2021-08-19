using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasobjetos0821
{
    class Program
    {
        //Método Principal MAIN
        static void Main(string[] args)
        {
            //Creamos empleado
            Empleado Myempleado = new Empleado();
            Myempleado.CargarDatos();
            Myempleado.CrearSueldo();
            Myempleado.mostrar();
            Console.WriteLine();

            Cliente MyCliente = new Cliente();
            MyCliente.CargarDatos();
            MyCliente.GenerarCodigo();
            MyCliente.mostrar();

            Console.ReadLine();

        }
    }
}
