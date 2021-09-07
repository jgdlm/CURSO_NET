using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaRepasoMañana
{
    class Moto:Vehiculo
    {
        private bool sidecar;
        public Moto(int Id, string marca, string Model, int Km, double precio, bool side) : base(Id, marca, Model, Km, precio)
        {
            sidecar = side;
        }
        //METODO CALCULAR PRECIO DEL COCHE SI TIENE AIRBAG MODIFCA EL PRECIO + 200
        public void CalcularPrecio()
        {
            if (sidecar == true)
            {
                VPrecio = 50 + VPrecio;
            }
           
        }

        public void ListarMoto()
        {
            Console.WriteLine("EL IDENTIFICADOR DE LA MOTO ES:" + VID + " MARCA " + VMarca + "\n" + " MODELO " + VModelo + " KM " + VKM + " Y EL PRECIO ES: " + VPrecio);

        }
    }
}
