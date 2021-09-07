using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Opc,Np;
            double bono=0, CPP=0,CCP=0,TaPas;
            bool BoolDecora = false;
            String TexPasl;


            //Menú de elección si es fiesta de gala o de Cumple
            do
            {
                Console.WriteLine("Introduce el tipo de Fiesta:\n 1:DE GALA \n 2:DE CUMPLEAÑOS");
                Opc = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (Opc != 3 && Opc != 1 && Opc != 2);


            //SI el usuario escoge 1 o 2
            if (Opc != 3)
            {
                Console.WriteLine("Introduce el NúmeroDePersonas...");
                Np = int.Parse(Console.ReadLine());

                //El si el número es superior a 12
                if (Np > 12)
                {
                    Console.WriteLine("Introduce el valor del bono:");
                    bono = double.Parse(Console.ReadLine());
                }

                //Se pide el costo por persona
                Console.WriteLine("Introduce el Costo por persona...");
                CPP = double.Parse(Console.ReadLine());

                //Se calcula el costo de decoración por persona
                Console.WriteLine("¿Deseas decoración por persona?");
                String RespDeco=(Console.ReadLine());
                if (RespDeco == "s")
                {
                    BoolDecora = true;
                    if (Np > 20) CCP = 200;
                    else CCP = 160;
                }


                if (Opc == 1)
                {
                    FiestaGala MiFiestaGala = new FiestaGala(Np, bono, CPP, CCP, BoolDecora);
                    Console.WriteLine("¿Deseas EXTRA por persona?");
                    String RespExt = (Console.ReadLine());
                    if (RespExt == "s") MiFiestaGala.SetOptionExtra(true);
                    else MiFiestaGala.SetOptionExtra(false);

                    MiFiestaGala.imprimir();
                    MiFiestaGala.SetOptionExtra(true);
                    MiFiestaGala.CalcularCostoDeDecoracion();
                    MiFiestaGala.CalcularCosto();
                }
                else
                {
                    if (Np < 4)
                    {
                        TaPas = 40 * Np;
                        TexPasl = "MEDIANO";
                    }
                    else
                    {
                        TaPas = 100 * Np;
                        TexPasl = "GRANDE";
                    }
                    FiestaCumple MiFiestaCumple = new FiestaCumple(Np, bono, CPP, CCP, BoolDecora, TaPas, TexPasl);
                    MiFiestaCumple.imprimirCumple();
                    MiFiestaCumple.CalcularCostoDeDecoracion();
                    MiFiestaCumple.CalcularCosto();
                    
                }

            }
           

            Console.ReadLine();
        }
    }
}
