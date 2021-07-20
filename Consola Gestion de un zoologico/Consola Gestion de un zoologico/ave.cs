using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_Gestion_de_un_zoologico
{
    class Ave :Animal
    {   protected string colorPlumaje;
        protected float alturaMaximaVuelo;

        public Ave(String especie, String nombre, double peso, int jaula,string colorPlumaje,float alturaMaximaVuelo) : base(especie, nombre, peso, jaula)
        {
            this.colorPlumaje = colorPlumaje;
            this.alturaMaximaVuelo = alturaMaximaVuelo;
        }

        public  override void ClaseDeAnimalEres()
        {

            Console.WriteLine( "Soy un AVE llamado " + nombre+ "\n" + "De la especie:" + especie + "\n"+ "Mi peso es:" + peso + "\n" + "Mi jaula es: " + jaula + "\n" +
                "Mi plumaje es: " + this.colorPlumaje + "\n" + "Mi altura maxima de vuelo es: " + this.alturaMaximaVuelo+"\n");
        }
    }
}
