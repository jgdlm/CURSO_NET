using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoclasesJueves2608
{
    class Program


    {
        static void Main(string[] args)
        {
          
            string op;
            
            int i1;
            string i2, i3,i6;
            int i4;
            double i5;
            bool abg;
            
            // importante crear aqui objetos pero sin datos para que no de error
            Coche MyCoche = new Coche();
            Moto MyMoto = new Moto();
            

            do
            {
                Console.Clear();
                Console.WriteLine("1-Crear Coche");
                Console.WriteLine("2-Crear Moto");
                Console.WriteLine("3-Listar  datos de Coche");
                Console.WriteLine("4-Listar datos de Moto");
                Console.WriteLine("5-Salir");
                Console.WriteLine("Introduzca Opcion:");
                op = Console.ReadLine();
               

                switch (op)
                {

                    case "1":
                        // crear coche con el contructor pillo valores
                        Console.Clear();
                        Console.WriteLine("Introduzca ID coche:");
                        i1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca Marca coche:");
                        i2 = Console.ReadLine();
                        Console.WriteLine("Introduzca Modelo coche:");
                        i3 = Console.ReadLine();
                        Console.WriteLine("Introduzca KM coche:");
                        i4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca Precio coche:");
                        i5 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca si tiene Airbag (S/N):");
                        i6 = Console.ReadLine();
                        if ((i6 == "S") || (i6 == "s"))
                            abg = true;
                        else
                            abg = false;
                        // ya tengo tengo los datos, creo el objeto con constructor

                        MyCoche = new Coche(i1, i2, i3, i4, i5, abg);

                        // calculo su precio
                        MyCoche.CalculaPrecio();
                        break;


                    case "2":
                        // crear moto con el contructor
                        Console.Clear();
                        Console.WriteLine("Introduzca ID Moto:");
                        i1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca Marca moto:");
                        i2 = Console.ReadLine();
                        Console.WriteLine("Introduzca Modelo moto:");
                        i3 = Console.ReadLine();
                        Console.WriteLine("Introduzca KM moto:");
                        i4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca Precio moto:");
                        i5 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca si tiene Sidecar (S/N):");
                        i6 = Console.ReadLine();
                        if ((i6 == "S") || (i6 == "s"))
                            abg = true;
                        else
                            abg = false;
                        // ya tengo tengo los datos, creo el objeto pero ya al principio inicializado

                        MyMoto = new Moto(i1, i2, i3, i4, i5, abg);

                        // calculo su precio
                        MyMoto.CalculaPrecio();

                        break;


                    case "3":
                        // listar datos de un coche
                        MyCoche.listar();
                    

                        break;


                    case "4":
                        // listar datos de una moto

                        MyMoto.listar();
                        
                        break;

                }


            } while (op != "5");

        }
    }
}
