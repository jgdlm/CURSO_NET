using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConsolaClasesHerencia
{
    class FiestaDeCumpleaños:Fiesta
    {
        //ATRIBUTOS
        private int TamanoPastel;
        private String TextoPastel;

        //PROPIEDADES
        public int Tamanopastel
        {
            get { return TamanoPastel; }
            set { TamanoPastel = value; }
        }
        public String textopastel
        {
            get { return TextoPastel; }
            set { TextoPastel = value; }
        }

        // constructores
        public FiestaDeCumpleaños(int F1, double F2, double F3, double F4, bool F5, int F6,String F7) : base(F1, F2, F3, F4, F5)
        {
            this.TamanoPastel = F6;
            this.TextoPastel = F7;
        }

        public FiestaDeCumpleaños()
        { }

        //METODOS
        //METODO PARA CALCULAR EL COSTO DE DECORACIÓN
        public void CalcularCostoDeDecoracion()
        {

        }
        //METODO CALCULAR COSTO FIESTA CUMPLEAÑOS
        public void CalcularCosto()
        {

        }
    }
}
