using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage25.Models
{
    public class Vehicle
    {

        
        public int Id { get; set; }

        //[Display(Name = "Vehicle Type")]
        public VType VType { get; set; }

        //[Display(Name = "Registration Number")]
        //[RegularExpression(pattern: "^[A-Za-z]{3}[0-9]{3}", ErrorMessage = "Registration number should contain three letters followed by three digits.")]
        public string RegNr { get; set; }
        public string Color { get; set; }

        // [StringLength(50)]
        public string Brand { get; set; }

       // [Display(Name = "Model")]
        public string VName { get; set; }

        //[Display(Name = "Number of wheels")]
        public int WheelTally { get; set; }

        //[Display(Name = "Check-in time")]
        public DateTime CheckInTime { get; set; }

        public DateTime CheckOutTime { get; set; }

    }

    public enum VType
    {
        Car,
        Boat,
        Lorry,
        Bus,
        Motorcycle
    }
}