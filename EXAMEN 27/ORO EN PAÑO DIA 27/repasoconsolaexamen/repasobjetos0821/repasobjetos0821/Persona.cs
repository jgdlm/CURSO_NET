using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasobjetos0821
{
    public class Persona
    {
        // atributos
        private string nombre;
        private string apellidos;
        private string documento;
        private string tipo;

        // propiedades PUBLICAS
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


        // constructores
        public Persona(string p1, string p2, string p3, string p4)
        {
            this.nombre = p1;
            this.apellidos = p2;
            this.documento = p3;
            this.tipo = p4;

        }

        public Persona()
        { }
        // metodos
    }
}
