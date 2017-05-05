using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Garage25.Models
{
    public class Receipt
    {
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        [DisplayName("Registration Number")]
        public string RegNo { get; set; }
        [DisplayName("Parking duration in minutes")]
        public double ParkingDuration { get; set; }
        [DisplayName("Parking Cost")]
        public int ParkingCost { get; set; }
        
    }
}