using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_Gestion_de_un_zoologico
{
    class Insecto : Animal
    {
        private bool vuela;
        public Insecto(string especie, string nombre, double peso, int jaula,bool vuela) :base(especie, nombre, peso, jaula){
            this.vuela = vuela;
        
        }


    public override void ClaseDeAnimalEres()
    {
            if (vuela == true){
                Console.WriteLine("Soy un INSECTO llamado " + nombre + "\n" + "De la especie:" + especie+ "\n" + "Mi peso es:" + peso+ "\n" + "Mi jaula es: " + jaula+ "\n" + "Y VUELO\n");
            }
            else
            {
                Console.WriteLine("Soy un INSECTO llamado " + nombre + "\n" + "De la especie:" + especie + "\n" + "Mi peso es:" + peso+ "\n" + "Mi jaula es:" + jaula+ "\n" + "NO VUELO\n");
            }

            
        }
}
}
