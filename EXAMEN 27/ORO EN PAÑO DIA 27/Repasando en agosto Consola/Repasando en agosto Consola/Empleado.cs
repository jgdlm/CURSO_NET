using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repasando_en_agosto_Consola
{
    /// <summary>
    /// CLASE EMPLEADO HEREDADA
    /// </summary>
    /// nombre, apellido, documento, tipo añadidos tipocontrato y sueldo
    class Empleado :Persona
    {
        //ATRIBUTOS DE LA CLASE EMPLEADO
        private string tipoContrato;
        private double sueldo;

        //PROPIEDADES DE LA CLASE EMPLEADO
        public string PtipoContrato
        {
            set { tipoContrato = value; }
            get { return tipoContrato; }
        }
        public double Psueldo
        {
            set { sueldo = value; }
            get { return sueldo; }
        }

        /// <summary>
        /// Método calcular sueldo
        /// </summary>
        /// <param name="sueldoBase">De tipo Double el salario del objeto</param>

        public void calcularSueldo(double sueldoBase)
        { 
                if (this.PtipoContrato == "F" || this.PtipoContrato == "f")
                {
                    this.Psueldo = Psueldo + 300;
                }
                else
                {
                    this.Psueldo = Psueldo + 250;
                }   
        }//FIN DE METODO

        public void Imprimir()
        {

            Console.WriteLine("Nombre :" + Pnombre + "\n" + "Apellido: " + Papellido + "\n" +
   "Documento: " + Pdocumento + "\n" + "Tipo: " + Ptipo + "\n" + "Tipo Contrato: " +
   PtipoContrato + "\n" + "Sueldo: " + Psueldo);
            Console.ReadKey();
        }
    
    
    }//FIN DE CLASE
}//FIN DE NAMESAPACE
