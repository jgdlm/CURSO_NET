using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EntiyFrameworkMigrations.Models
{
    public class ContextoEmpleados:DbContext
    {
        public ContextoEmpleados() : base("cadenaempleados") { }
        public DbSet<Empleado> Empleados { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }



    }
}