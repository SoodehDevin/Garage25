using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Garage25.Models
{
    public class VehicleType
    {
        public int Id { get; set; }
        [DisplayName("Vehicle Type")]
        public string Name { get; set; }
    }
}