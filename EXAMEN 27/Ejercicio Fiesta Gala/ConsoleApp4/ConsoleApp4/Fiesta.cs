using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Fiesta
    {
        private int NumeroDePersonas;
        private double CosteDecoracion;
        private double Bonoextra;
        private double CosteComidaPersona;
        private bool Decora;

        public Fiesta()
        {
        }
        public Fiesta(int NumPer, double CosteDec, double BonExt, double CostComPer,bool deco)
        {
            if (NumPer > 12) this.Bonoextra = BonExt;
            this.NumeroDePersonas = NumPer;
            this.CosteDecoracion = CosteDec;
            this.Bonoextra = BonExt;
            this.CosteComidaPersona = CostComPer;
            this.Decora = deco;
        }

        public int PNumeroPersonas
        {
            set { NumeroDePersonas = value; }
            get { return NumeroDePersonas; }
        }

        public Double PCosteDecoracion
        {
            set { CosteDecoracion = value; }
            get { return CosteDecoracion; }
        }
        public Double PBonoExtra
        {
            set { Bonoextra = value; }
            get { return Bonoextra; }
        }

        public Double PCosteComidaPersona
        {
            set { CosteComidaPersona = value; }
            get { return CosteComidaPersona; }
        }

        public bool PDecora
        {
            set { Decora = value; }
            get { return Decora; }
        }
    }
}
