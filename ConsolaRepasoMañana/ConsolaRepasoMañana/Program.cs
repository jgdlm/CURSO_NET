using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaRepasoMañana
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            int i1,i4,i5;
            string Opc, i2, i3,i6;
            bool abg;
            bool sidec;
            // importante crear aqui objetos pero sin datos para que no de error
            Coche MiCoche = new Coche();
            Moto MiMoto = new Moto();


            //MENU DE ELECCIÓN SI ES UN COCHE(CON AIRBAG O SIN AIRBAG) O UNA MOTO(CON SIDECAR O SIN SIDECAR)
            do
            {
                Console.WriteLine("1:CREAR COCHE \n 2:CREAR MOTO \n 3:LISTAR DATOS DEL COCHE \n 4:LISTAR DATOS DE LA MOTO \n 5:SALIR");
                Opc = (Console.ReadLine());
                Console.Clear();
                switch (Opc)
                {
                    case "1":
                        //Crear el coche con el constructor y recojo los valores
                        Console.Clear();
                        Console.WriteLine("Introduce el ID del Coche");
                        i1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la Marca del Coche");
                        i2 = (Console.ReadLine());
                        Console.WriteLine("Introduce el Modelo del Coche");
                        i3 = (Console.ReadLine());
                        Console.WriteLine("Introduce los KM del Coche");
                        i4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el Precio del Coche");
                        i5 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce si tiene Airbag (S/N):");
                        i6 = (Console.ReadLine());
                        if((i6 == "S") || (i6 == "s"))
                        { abg = true; }
                        else
                        { abg = false; }

                        //YA OBTUVE LOS DATOS AHORA CREO EL OBJETO
                       MiCoche = new Coche(i1, i2, i3, i4, i5, abg);

                        //CALCULO SU PRECIO
                        MiCoche.CalcularPrecio();
                        break;


                    case "2":
                        //Crear el coche con el constructor y recojo los valores
                        Console.Clear();
                        Console.WriteLine("Introduce el ID de la Moto");
                        i1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la Marca de la Moto");
                        i2 = (Console.ReadLine());
                        Console.WriteLine("Introduce el Modelo de la Moto");
                        i3 = (Console.ReadLine());
                        Console.WriteLine("Introduce los KM de la Moto");
                        i4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el Precio de la Moto");
                        i5 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce si tiene Sidecar (S/N):");
                        i6 = (Console.ReadLine());
                        if ((i6 == "S") || (i6 == "s"))
                        { sidec = true; }
                        else
                        { sidec = false; }

                        //YA OBTUVE LOS DATOS AHORA CREO EL OBJETO
                       MiMoto = new Moto(i1, i2, i3, i4, i5, sidec);

                        //CALCULO SU PRECIO
                        MiMoto.CalcularPrecio();
                        break;


                    case "3":
                       MiCoche. ListarCoche();
                        break;


                    case "4":
                        MiMoto.ListarMoto();
                        break;


                    case "5":
                        Console.WriteLine("SALIR");
                        break;

                }
            }
            while (Opc != "5");
        }
    }
}
