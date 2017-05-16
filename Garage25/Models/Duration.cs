using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Garage25.Models
{
    public class Duration
    {
        [DisplayName("Member Id")]
        public int MemberId { get; set; }
        [DisplayName("Vehicle Type")]
        public int VehicleTypeId { get; set; }
        [DisplayName("Registration Number")]
        public string RegNr { get; set; }
        [DisplayName("Parking Duration")]
        public int ParkingDuration { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CurrentTime { get; set; }


    }
}