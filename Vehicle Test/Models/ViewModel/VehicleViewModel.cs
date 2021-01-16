using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vehicle_Test.Models.ViewModel
{
    public class VehicleViewModel
    {
        public Vehicle Vehicle { get; set; }
        public List<VehicleType> VehicleType { get; set; }
    }
}