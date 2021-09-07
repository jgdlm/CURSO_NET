using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConsolaClasesHerencia
{
    public class Fiesta
    {
        //ATRIBUTOS QUE LA COMPONEN
        //DATO INRTODUCIDO
        private int NumeroDePersonas;
        private double CostoDeDecoracion;

        //DATOS CALCULADOS
        private double bonoExtra;
        private double CostodeComidaPorPersona;
        private bool Decora;

        // PROPIEDADES PUBLICAS
        public int NumeroPersonas
        {
            get { return NumeroDePersonas; }
            set { NumeroDePersonas = value; }
        }

        public double CostoDecoracion
        {
            get { return CostoDeDecoracion; }
            set { CostoDeDecoracion = value; }
        }


        public double BonoExtra
        {
            get { return bonoExtra; }
            set { bonoExtra = value; }
        }

        public double CostoComidaPrPersona
        {
            get { return CostodeComidaPorPersona; }
            set { CostodeComidaPorPersona = value; }
        }

        public bool DEcora
        {
            get { return Decora; }
            set { Decora = value; }
        }

        // CONSTRUCTORES
        public Fiesta(int F1, double F2, double F3, double F4, bool F5)
        {
            this.NumeroDePersonas = F1;
            this.CostoDeDecoracion = F2;
            this.bonoExtra = F3;
            this.CostodeComidaPorPersona = F4;
            this.Decora = F5;

        }

        public Fiesta()
        { }

       

        public void Imprimir()
        {

        }


    }
}
