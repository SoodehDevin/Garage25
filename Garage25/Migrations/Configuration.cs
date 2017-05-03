namespace Garage25.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

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

            
            Member member1 = new Member { FirstName = "Bob", LastName = "Sacamano" };
            context.Members.AddOrUpdate(
                p => p.LastName,
                member1
                );

            VehicleType vehicleType1 = new VehicleType { Name = "Car" };
            VehicleType vehicleType2 = new VehicleType { Name = "Bus" };
            VehicleType vehicleType3 = new VehicleType { Name = "Bike" };
            VehicleType vehicleType4 = new VehicleType { Name = "Boat" };
            VehicleType vehicleType5 = new VehicleType { Name = "Truck" };
            VehicleType vehicleType6 = new VehicleType { Name = "Hovercraft" };
            VehicleType vehicleType7 = new VehicleType { Name = "Airplane" };
            context.VehicleType.AddOrUpdate(
                p => p.Name,
                vehicleType1,
                vehicleType2,
                vehicleType3,
                vehicleType4,
                vehicleType5,
                vehicleType6,
                vehicleType7
                );
            context.Vehicles.AddOrUpdate(
              p => p.RegNr,
              new Vehicle { VehicleType = vehicleType1, Member = member1, RegNr = "eee111", Color = "Blue", Make = "Toyota", VName = "Prius", CheckInTime = DateTime.Now, CheckOutTime = DateTime.Now }
            );


        }
    }
}
