using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_Gestion_de_un_zoologico
{
    class Program
    {
        static void Main(string[] args)
        {

            Mamifero mam = new Mamifero("paquidermo", "elefante", 8000, 12);
            Insecto ins = new Insecto("no se", "escarabajo pelotero", 1, 2,false);
            Insecto ins2 = new Insecto("no se DOS", "mariposa", 1, 3, true);
            Ave av = new Ave("desconocido", "mirlo", 2, 4, "blanco", 1000);
            mam.ClaseDeAnimalEres();
            ins.ClaseDeAnimalEres();
            ins2.ClaseDeAnimalEres();
            av.ClaseDeAnimalEres();
            Console.ReadKey();
        }
    }
}
