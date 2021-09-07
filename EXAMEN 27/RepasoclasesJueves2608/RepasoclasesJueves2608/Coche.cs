using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoclasesJueves2608
{
    public class Coche : Vehiculo
    {
        // atributos
        private bool Airbag;

        // propiedades

        public bool PAirbag{

            get { return Airbag;  }
            set { Airbag = value; }
              
         }


        // constructor

        public Coche() { }

        public Coche(int p1, string p2, string p3, int p4, double p5, bool p6) : base(p1, p2, p3, p4, p5)
        {
            Airbag = p6;

        }




        // metodos

        public void CalculaPrecio()


        {

            // incrementa el precio si tiene airbag en 200
            if (this.Airbag==true) { PPrecio += 200; }

        }


        public void listar()
        {
            string x;
            
            if (Airbag==true) { x = "Si lo tiene"; } else { x = "No lo tiene"; }
            // muestra los datos del objeto
            Console.Clear();
            Console.WriteLine("Datos del Coche:");
            Console.WriteLine(PID);
            Console.WriteLine(PMarca);
            Console.WriteLine(PModelo);
            Console.WriteLine(PPrecio);
            Console.WriteLine("Airbag: "+x);
            Console.ReadLine();


        }





    }
}
