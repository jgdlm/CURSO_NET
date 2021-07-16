using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaZoo
{
    class Animal
    { 
        //Creamos la clase Animal

        //Defino las vaariables
        string especie, nombre;
        double peso;
        int jaula;

        //Definimos un constructor
        public Animal()
        {

        }

        //GET y SET
        public string Aespecie
        {
            get { return especie; }
            set { especie = value; }
        }


        public string Anombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Apeso
        {
            get { return peso; }
            set { peso = value; }
        }

        public int Ajaula
        {
            get { return jaula; }
            set { jaula = value; }
        }



        //Metodo ClaseDeAnimalEres()


        public virtual void ClaseDeAnimalEres()
        {
            Console.WriteLine("La Clase de Animal que eres es:");
        }

    }
}
