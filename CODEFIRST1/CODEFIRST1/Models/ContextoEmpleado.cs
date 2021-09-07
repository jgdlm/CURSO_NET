using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CODEFIRST1.Models
{
    public class ContextoEmpleado : DbContext
    { 
        public ContextoEmpleado() : base("cadenaempleados") { }
        public DbSet<Empleado> Empleado { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();  
        }
    }
}