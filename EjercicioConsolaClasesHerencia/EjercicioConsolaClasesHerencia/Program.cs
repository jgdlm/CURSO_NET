using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConsolaClasesHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Método Principal MAIN
            //Selección para escoger si será cliente o empleado
            string opcion;
            //Switch para escoger entre cliente o empleado
            do
            {
                Console.WriteLine("1 para Fiesta de Gala");
                Console.WriteLine("2 Fiesta Cumpleaños");
                Console.WriteLine("3 Salir");
                opcion = Console.ReadLine();
                Console.Clear();
                switch (opcion)
                {
                    //Creación y entrada de datos de cliente
                    case "1":
                        FiestaDeGala FG = new FiestaDeGala();
                       
                       
                        Console.Clear();
                        break;
                    //Creación y entrada de datos de Empleado
                    case "2":
                        FiestaDeCumpleaños FC = new FiestaDeCumpleaños();
                       

               
                        break;

                    case "3":
                        Console.WriteLine("Salir");
                        break;
                }
            } while (opcion != "3");
        }
    }
}
