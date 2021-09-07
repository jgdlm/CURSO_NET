using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class FiestaCumple:Fiesta
    {
        private double CostoPromedioPorPersona;
        private double TamanoPastel;
        private string TextoPastel;

        public FiestaCumple(int NumPer, double CosteDec, double BonExt, double CostPorPer, bool Decora,double Tampastel, String TeXPastel) : base(NumPer, CosteDec, BonExt, CostPorPer, Decora)
        {
            CostoPromedioPorPersona = CostPorPer;
            TamanoPastel = Tampastel;
              TextoPastel = TeXPastel;
        }

        public void CalcularCosto()
        {
            Console.WriteLine(this.PNumeroPersonas * this.CostoPromedioPorPersona + this.PBonoExtra + this.PCosteDecoracion + this.PCosteComidaPersona+ TamanoPastel);
        }

        public void CalcularCostoDeDecoracion()
        {
            if (PNumeroPersonas > 20) CostoPromedioPorPersona = 200 * PNumeroPersonas;
            else CostoPromedioPorPersona = 160 * PNumeroPersonas;
        }


        public void imprimirCumple()
        {
            Console.WriteLine("EL NUMERO DE PERSONAS HAN SIDO:" + PNumeroPersonas + " Y SU COSTE DE DECORACIÓN " + CostoPromedioPorPersona + "\n" + "TAMBIÉN SU BONO HA SIDO DE " + PBonoExtra + " SU COMIDA POR PERSONA" + PCosteComidaPersona + " Y SU DECORACIÓN " + PDecora+"\nEL TAMAÑO DE TARTA HA SIDO "+TextoPastel+" Y SU IMPORTE:"+TamanoPastel);
            //Console.WriteLine(this.PNumeroPersonas + "\n" + this.OpcionEXTRA + "\n" + this.CostoPromedioPorPersona + "\n" + this.PBonoExtra + "\n" + this.CostoPromedioPorPersona + "\n" + this.PDecora + "\n" + this.PCosteComidaPersona);
        }

    }
}
