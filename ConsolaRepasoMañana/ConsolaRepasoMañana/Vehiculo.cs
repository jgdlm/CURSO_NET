using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaRepasoMañana
{
    class Vehiculo
    {
        private int ID;
        private string Marca;
        private string Modelo;
        private int KM;
        private double Precio;

        //CONSTRCUTOR PARA PODER GENERAR UNA CLASE POR DEFECTO Y ACCEDER A SUS PROPIEDADES
        public Vehiculo()
        {

        }

        //CONSTRUCTOR SOBRECARGADO PARA PASARLE PARÁMETROS
        public Vehiculo(int Id, string marca, string Model, int Km, double precio)
        {
            this.ID = Id;
            this.Marca = marca;
            this.Modelo = Model;
            this.KM = Km;
            this.Precio = precio;
        }

       
        public int VID
        {
            get{ return ID; }
            set { ID = value; }
        }

        public string VMarca
        {
            get { return Marca; }
            set { Marca = value; }
        }

        public string VModelo
        {
            get { return Modelo; }
            set { Modelo = value; }
        }

        public int VKM
        {
            get { return KM; }
            set { KM = value; }
        }

        public double VPrecio
        {
            get { return Precio; }
            set { Precio = value; }
        }
    }
}
