namespace EntiyFrameworkMigrations.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EntiyFrameworkMigrations.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EntiyFrameworkMigrations.Models.ContextoEmpleados>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EntiyFrameworkMigrations.Models.ContextoEmpleados context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Empleados.AddOrUpdate(z => z.Nombre, new Empleado
            {
                IdEmpleado = 1,
                Nombre = "David",
                Apellido = "FGernandez Huertas",
                Direccion = "calle Atletico",
                Email = "asdasd@jj.es"

            }
            );
        }
    }
}
