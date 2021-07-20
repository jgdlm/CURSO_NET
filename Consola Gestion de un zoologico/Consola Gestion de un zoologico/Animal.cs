using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_Gestion_de_un_zoologico
{
    abstract class Animal
    {
        protected string especie;
        protected string nombre;
        protected double peso;
        protected int jaula;

   
        public Animal(String especie, String nombre, double peso, int jaula)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.peso = peso;
            this.jaula = jaula;

        }
        public virtual void ClaseDeAnimalEres()
        {

        }
        

        
      





    }
}
