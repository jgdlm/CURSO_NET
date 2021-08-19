using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasobjetos0821
{
    class Empleado:Persona
    {
       // atributos
        private string tipocontrato;
        private double sueldo;
        // propiedades

        public string Tipocontrato
        {
            get { return tipocontrato; }
            set { tipocontrato = value; }

        }

        public double Sueldo
        {
            get { return Sueldo; }
            set { Sueldo = value; }

        }


        // contructor

        public Empleado (string p1, string p2, string p3, string p4, string p5, double p6) : base(p1, p2, p3, p4)
        {
            this.tipocontrato = p5;
            this.sueldo = p6;

        }

        public Empleado()
        { }

        // metodos

        public void  CrearSueldo()
        {
            double entrada;

            Console.WriteLine("Introduzca importe:");
            entrada=double.Parse(Console.ReadLine());
            if (tipocontrato=="Fijo") { entrada += 300; }
            if (tipocontrato=="Temporal") { entrada += 250; }
            sueldo = entrada;


        }


        public void mostrar()

        {
            Console.WriteLine(Nombre + " " + Apellidos + " " + Documento + " " + this.tipocontrato + " " + this.sueldo.ToString() );


        }

        public void CargarDatos()
        {
            // tipo no lo pido porque no estaba muy claro donde deberia ir y sueldo sale con el metodo
            Console.WriteLine("Nombre:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Apellido:");
            Apellidos = Console.ReadLine();
            Console.WriteLine("Documento:");
            Documento = Console.ReadLine();
            Console.WriteLine("Tipo Contrato Fijo o Temporal:");
            tipocontrato = Console.ReadLine();
            


        }


    }
}
