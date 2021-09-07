using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class FiestaGala:Fiesta
    {
        private double CostoPromedioPorPersona;
        private double OpcionEXTRA;


        public FiestaGala(int NumPer, double CosteDec, double BonExt, double CostPorPer,bool Decora) : base(NumPer, CosteDec, BonExt, CostPorPer,Decora)
        {
            CostoPromedioPorPersona = CostPorPer;
        }


        public void CalcularCosto()
        {
            Console.WriteLine(this.PNumeroPersonas *  this.CostoPromedioPorPersona +  this.PBonoExtra + this.PCosteDecoracion +this.PCosteComidaPersona+OpcionEXTRA);
        }


        public void CalcularCostoDeDecoracion()
        {
            if (PNumeroPersonas > 20) CostoPromedioPorPersona = 200 * PNumeroPersonas;
            else CostoPromedioPorPersona = 160 * PNumeroPersonas;
        }

        public void SetOptionExtra(bool opt)
        {
            if (opt == true) OpcionEXTRA = 40 * PNumeroPersonas;
        }

        public void imprimir()
        {
            Console.WriteLine("EL NUMERO DE PERSONAS HAN SIDO:" + PNumeroPersonas + " Y SU COSTE DE DECORACIÓN " + CostoPromedioPorPersona + "\n" + " TAMBIÉN SU BONO HA SIDO DE " + PBonoExtra + " SU COMIDA POR PERSONA" + PCosteComidaPersona + " Y SU DECORACIÓN " + PDecora);
            //Console.WriteLine(this.PNumeroPersonas + "\n" + this.OpcionEXTRA + "\n" + this.CostoPromedioPorPersona + "\n" + this.PBonoExtra + "\n" + this.CostoPromedioPorPersona + "\n" + this.PDecora + "\n" + this.PCosteComidaPersona);
        }

    }
}
