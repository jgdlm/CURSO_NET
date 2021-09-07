using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repasando_en_agosto_Consola
{
    /// <summary>
    /// CLASE CLIENTE QUE HEREDA DE PERSONA
    /// </summary>
    /// nombre, apellido, documento, tipo, añadiendo categoría y código
    class Cliente : Persona
    {
        //ATRIBUTOS O CAMPOS O CARACTERÍSTICAS DE CLIENTE
        private string categoria;
        private string codigo;

        //PROPIEDADES DEL CLIENTE
        public string Pcategoria
        {
            set { categoria = value; }
            get { return categoria; }
        }
        public string Pcodigo
        {
            set { codigo = value; }
            get { return codigo; }
        }

        /// <summary>
        /// Método para generar el código
        /// </summary>
        /// <param name="Generacodigo"></param>
        public void generarCodigo()
        {
            this.Pcodigo = "C" + this.Pnombre.Substring(0, 3) + this.Pdocumento.Substring(0, 2);
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre :" + Pnombre + "\n" + "Apellido: " + Papellido + "\n" + "Documento: " + Pdocumento + "\n" + "Tipo: " + Ptipo + "\n" + "Categoria: " + Pcategoria + "\n" + "Codigo: " + Pcodigo);
            Console.ReadKey();
        }
    }
}
