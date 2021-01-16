using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vehicle_Test.Models
{
    public class ActiveRental
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }

        public int CustomerId { get; set; }
        public DateTime IssueTime { get; set; }
       

        public string VehicleNumber { get; set; }

        public string VehicleName { get; set; }
        public int VehicleId { get; set; }
        public int VehicleTypeId { get; set; }
    }
}