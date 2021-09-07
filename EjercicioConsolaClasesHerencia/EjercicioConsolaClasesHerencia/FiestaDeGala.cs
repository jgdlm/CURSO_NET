using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConsolaClasesHerencia
{
    class FiestaDeGala:Fiesta
    {
        //ATRIBUTOS
        private double CostoPromedioPorPersona;
        private bool OpcionEXTRA;

        //PROPIEDADES
        public double CostoPromedioPersona
        {
            get { return CostoPromedioPorPersona; }
            set { CostoPromedioPorPersona = value; }
        }
        public bool opcionExtra
        {
            get { return OpcionEXTRA; }
            set { OpcionEXTRA = value; }
        }



        // CONSTRUCTOR

        public FiestaDeGala(int F1, double F2, double F3, double F4, bool F5, double F6, bool F7) : base(F1, F2, F3, F4, F5)
        {
            this.CostoPromedioPorPersona = F6;
            this.OpcionEXTRA = F7;

        }

        public FiestaDeGala()
        { }

        //METODOS
        //METODO PARA CALCULAR EL COSTO DE DECORACIÓN
        public void CalcularCostoDeDecoracion()
        {

        }

        //METODO CALCULAR COSTO FIESTA GALA

        public void CalcularCosto()
        {
           
        }


        //METODO SetOpcionExtra
        public void SetOpcionEXRA()
        {

        }
    }
}
