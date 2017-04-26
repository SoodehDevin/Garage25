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
            : base("DefaultAttempt")
        {
        }
        public DbSet<Models.Vehicle> Vehicles { get; set; }
    }
}