//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelFirst2
{
    using System;
    using System.Collections.Generic;
    
    public partial class REGISTRO_TRANSACCION_DEDUCCION
    {
        public int ID_TRANSACCION_DEDUCCION { get; set; }
        public int ID_EMPLEADO { get; set; }
        public int ID_TIPO_DEDUCCION { get; set; }
        public System.DateTime FECHA { get; set; }
        public double MONTO { get; set; }
    
        public virtual EMPLEADO EMPLEADO { get; set; }
        public virtual TIPO_DE_DEDUCCION TIPO_DE_DEDUCCION { get; set; }
    }
}
