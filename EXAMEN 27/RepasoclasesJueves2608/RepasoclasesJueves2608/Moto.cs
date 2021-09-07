using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoclasesJueves2608
{
    public class Moto:Vehiculo
    {

        // atributos
        private bool Sidecar;

        // propiedades

        public bool PSidecar
        {

            get { return Sidecar; }
            set { Sidecar = value; }

        }


        // constructor

        public Moto() { }

        public Moto(int p1, string p2, string p3, int p4, double p5, bool p6) : base (p1,p2,p3,p4,p5)
        {
            Sidecar = p6;
                   
        }

        // metodo

        public void CalculaPrecio()


        {

            // incrementa el precio si tiene airbag en 200
            if (this.Sidecar == true) { PPrecio += 50; }

        }


        public void listar()
        {

            string x;

            if (Sidecar == true) { x = "Si lo tiene"; }
            else
            { x = "No lo tiene"; }

                // muestra los datos del objeto
                Console.Clear();
            Console.WriteLine("Datos de la Moto:");
            Console.WriteLine(PID);
            Console.WriteLine(PMarca);
            Console.WriteLine(PModelo);
            Console.WriteLine(PPrecio);
            Console.WriteLine("Sidecar: " + x);
            Console.ReadLine();


        }




    }
}
