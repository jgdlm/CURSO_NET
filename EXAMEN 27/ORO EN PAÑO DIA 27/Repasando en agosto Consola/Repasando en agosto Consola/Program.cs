using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repasando_en_agosto_Consola
{
    /// <summary>
    /// CLASE PRINCIPAL PROGRAM
    /// </summary>
    class Program
    {
        static void Main()  
        {
            //Selección para escoger si será cliente o empleado
            string seleccion;
            //Switch para escoger entre cliente o empleado
            do
            {
                Console.Clear();
                Console.WriteLine("1 para cliente \n , 2 para empleado \n, 3 salir");
                seleccion =Console.ReadLine();
                switch (seleccion)
                {
                    //Creación y entrada de datos de cliente
                    case "1":
                        Cliente cli = new Cliente();
                        Console.WriteLine("Introduce el nombre");
                        cli.Pnombre = Console.ReadLine();
                        Console.WriteLine("Introduce el apellido");
                        cli.Papellido = Console.ReadLine();
                        Console.WriteLine("Introduce el documento");
                        cli.Pdocumento = Console.ReadLine();
                        Console.WriteLine("Introduce el tipo");
                        cli.Ptipo = Console.ReadLine();
                        Console.WriteLine("introduce la categoria");
                        cli.Pcategoria = Console.ReadLine();
                        cli.generarCodigo();
                        cli.Imprimir();
                        Console.Clear();
                        break;
                    //Creación y entrada de datos de Empleado
                    case "2":
                        Empleado emp = new Empleado();
                        Console.WriteLine("Introduce el nombre");
                        emp.Pnombre = Console.ReadLine();
                        Console.WriteLine("Introduce el apellido");
                        emp.Papellido = Console.ReadLine();
                        Console.WriteLine("Introduce el documento");
                        emp.Pdocumento = Console.ReadLine();
                        Console.WriteLine("Introduce el tipo");
                        emp.Ptipo = Console.ReadLine();
                        
                        do
                        {
                            Console.WriteLine("Introduce el tipo de contrato F o T");
                            emp.PtipoContrato = Console.ReadLine();
                        } while (emp.PtipoContrato != "F" && emp.PtipoContrato != "f" && emp.PtipoContrato != "T"
                        && emp.PtipoContrato != "t");

                        try
                        {
                            Console.WriteLine("introduce el sueldo");
                            emp.Psueldo = double.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("El valor introducido no es un numero");
                        }
                        emp.calcularSueldo(emp.Psueldo);
                        emp.Imprimir();
                        Console.Clear();
                        break;
                        
                        case "3":
                        Console.WriteLine("Saliendo");
                        break;
                }
            } while (seleccion !="3");
        }//FIN VOID MAIN
    }//FIN CLASE
}//FIN NAMESPACE
