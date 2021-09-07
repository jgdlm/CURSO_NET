using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoclasesJueves2608
{
    public class Vehiculo
    {
        // atributos
        private int ID;
        private string Marca;
        private string Modelo;
        private int KM;
        private double Precio;

        // propiedades
         public int PID
        {
            get { return ID; }
            set { ID = value; } 
        }

        public string PMarca
        {
            get { return Marca; }
            set { Marca = value; }
        }

        public string PModelo
        {
            get { return Modelo; }
            set {Modelo = value; }
        }

        public int PKM
        {
            get { return KM; }
            set {KM = value; }
        }

        public double PPrecio
        {
            get { return Precio; }
            set { Precio = value; }
        }
        //constructores 

        public Vehiculo(int p1, string p2, string p3, int p4, double p5) 
        
        {
            ID = p1;
            Marca = p2;
            Modelo = p3;
            KM = p4;
            Precio = p5;

        }


       public  Vehiculo()   { }


        //metodos




    }
}
