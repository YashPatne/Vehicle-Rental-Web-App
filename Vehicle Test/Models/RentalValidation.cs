using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Vehicle_Test.Models
{
    public class RentalValidation
    {
    //    [Required(ErrorMessage = "Please Select Customer")]
        public int SelectedCustomer { get; set; }
      //  [Required(ErrorMessage = "Please Select Vehicle")]
        public int SelectedVehicle { get; set; }

        
    }
}