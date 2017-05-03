using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Garage25.DataAccessLayer
{
    public class VehiclesContext : DbContext
    {
        public VehiclesContext()
        {
        }
        public DbSet<Models.Vehicle> Vehicles { get; set; }
        public DbSet<Models.Member> Members { get; set; }
        public DbSet<Models.VehicleType> VehicleType { get; set; }
    }
}