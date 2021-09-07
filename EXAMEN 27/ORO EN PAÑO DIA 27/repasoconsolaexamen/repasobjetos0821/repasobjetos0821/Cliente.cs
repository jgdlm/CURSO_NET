using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasobjetos0821
{
    public class Cliente: Persona
    {
        // atributos
        private string categoria;
        private string codigo;
        // propiedades
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        // constructores
        public Cliente(string p1, string p2, string p3, string p4,string p5, string p6) : base (p1,p2,p3,p4)
        {
            this.categoria = p5;
            this.codigo = p6;  
        }

        public Cliente()
        { }
        // metodos
        
       public void  GenerarCodigo()
        {
            codigo = "C" + Nombre.Substring(0, 3) + Documento.Substring(0, 2);
        }
        public void mostrar()
        {
            Console.WriteLine(Nombre + " " + Apellidos + " " + Documento + " " + this.categoria + " " + this.codigo);
        }

        public void CargarDatos()
        {
           // tipo no lo pido porque no estaba muy claro donde deberia ir y codigo sale con el metodo
            Console.WriteLine("Nombre:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Apellido:");
            Apellidos = Console.ReadLine();
            Console.WriteLine("Documento:");
            Documento = Console.ReadLine();
            Console.WriteLine("categoria:");
            categoria = Console.ReadLine();
            codigo = "";
        }
    }
}
