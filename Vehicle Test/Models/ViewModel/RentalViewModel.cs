using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vehicle_Test.Models.ViewModel
{
    public class RentalViewModel
    {
        public List<Customer> Customers { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        [Required(ErrorMessage = "Please Select Customer")]
        public int SelectedCustomer { get; set; }
        [Required(ErrorMessage = "Please Select Vehicle")]
        public int SelectedVehicle { get; set; }
    }
}