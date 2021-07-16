using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaBanco
{
    class Program
    { 
        //Ejercicio para gestionar las cuentas de un banco
        //Se pide crear una clase tipo cuenta para gestionar ingresos y gastos
        
        static void Main(string[] args)
        {
            // se cea un onjeto cuenta
            Cuenta MiCuenta = new Cuenta();

            string opcion = ""; int C1 = 0; decimal C2= 0;

            do
            {
                Console.WriteLine("1. Crear cuenta");
                Console.WriteLine("2. Depositar una cantidad");
                Console.WriteLine("3. Retirar Dinero");
                Console.WriteLine("4. Consultar Saldo");
                Console.WriteLine("5. Salir");

                opcion = Console.ReadLine();


                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Inserte su Nombre");
                        MiCuenta.CNombreCliente = Console.ReadLine();
                        Console.WriteLine("Inserte el Número de Cuenta");
                        MiCuenta.CNumCuenta =int.Parse (Console.ReadLine());
                        Console.WriteLine("Introduzca el Saldo");
                        MiCuenta.CSaldo =int.Parse (Console.ReadLine());
                        break;


                    case "2":
                        Console.WriteLine("Inserte Cantidad a depositar");
                        C1 = int.Parse(Console.ReadLine());
                        MiCuenta.CSaldo = (MiCuenta.CSaldo) + C1;
                        break;


                    case "3":
                        Console.WriteLine("Inserte Cantidad a Retirar");
                        C2 = int.Parse(Console.ReadLine());
                        if (C2>MiCuenta.CSaldo)
                        {
                            Console.WriteLine("No hay Suficiente Saldo a Retirar");
                        }
                        else 
                        {
                            Console.WriteLine((MiCuenta.CSaldo)-C2);
                        }
                        break;


                    case "4":
                        MiCuenta.Consultar();
                        Console.ReadLine();
                        Console.Clear();
                        break;


                    case "5":
                        Console.WriteLine("Salir");
                        break;
                }

            } while (opcion != "5");

        }
    }
}
