using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaRepasoMañana
{
    class Coche:Vehiculo
    {
        private bool airbag;
        public Coche(int Id, string marca, string Model, int Km, double precio, bool air): base(Id, marca, Model, Km, precio)
        {
            airbag = air;
        }

        //METODO CALCULAR PRECIO DEL COCHE SI TIENE AIRBAG MODIFCA EL PRECIO + 200
        public void CalcularPrecio()
        {
            if (airbag == true)
            { 
                VPrecio = 200 + VPrecio; 
            }
           
        }

        public void ListarCoche()
        {
            Console.WriteLine("EL IDENTIFICADOR DEL COCHE ES:" + VID + " MARCA " + VMarca + "\n" + " MODELO " + VModelo + " KM " + VKM + " Y EL PRECIO ES: " + VPrecio);
                    
        }
    }
}
