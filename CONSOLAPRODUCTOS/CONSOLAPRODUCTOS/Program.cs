using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLAPRODUCTOS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear el objeto producto
            var almacen = new List<producto>();
            int indice = 0;

            //declaramos resp para leer lo que se desea 
            string resp = "";
            String C1, C3 = "";
            double C2 = 0;
            double Total = 0; 
            do
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("1.- Alta de producto");
                Console.WriteLine("2.- Realizar Pedido");
                Console.WriteLine("3.- Mostrar el Total + IVA");
                Console.WriteLine("4.- Salir");
                Console.WriteLine("INTRODUZCA OPCION:");
                resp = Console.ReadLine();

            switch(resp)
             {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Introduzca nombre Producto");
                        C1 = Console.ReadLine();
                        Console.WriteLine("Introduzca Precio Producto");
                        C2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca Categoria Producto");
                        C3 = Console.ReadLine();
                        //Crea
                        producto p3 = new producto(C1, C2, C3);

                        // meter esto en una lista de de objetos general (Meter en el almacen cada uno de los productos)
                        almacen.Add(p3);
                        p3.mostrar();
                        break;

                    case "2":
                        // Array que recorre cada producto del almacen y va pidiendo cantidades

                        Console.Clear();
                        int num = 0;

                        foreach (var x in almacen)
                        {
                            x.mostrar();
                            Console.WriteLine();
                            Console.WriteLine("Introduzca cantidad Producto: ");
                            num = int.Parse(Console.ReadLine());
                            Total = (x.Precio * num) + Total;
                            Console.WriteLine();

                        }
                        break;

                    case "3":
                        Console.WriteLine("El total es:" + Total.ToString());
                        Console.WriteLine("El IVA es:" + (Total * 0.21).ToString());
                        Console.WriteLine("El Total con IVA es:" + (Total * 1.21).ToString());
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        break;

                    default:
                        Console.WriteLine("Has introducido una opcion erronea");
                        Console.ReadLine();
                        break;

                }


            } while (resp != "4");
        }
    }
}
