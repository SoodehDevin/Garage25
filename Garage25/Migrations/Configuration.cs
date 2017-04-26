
namespace Garage25.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Garage25.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Garage25.DataAccessLayer.VehiclesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Garage25.DataAccessLayer.VehiclesContext context)
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

            context.Vehicles.AddOrUpdate(
                p => p.RegNr,
                new Vehicle { VType = VType.Car, RegNr = "FRL-111", Color = "Blue", Brand = "Toyota", VName = "Prius", CheckInTime = DateTime.Now },
                new Vehicle { VType = VType.Motorcycle, RegNr = "FRL-222", Color = "Black", Brand = "Kawasaki", VName = "Jet", CheckInTime = DateTime.Now});
        }
    }
}
