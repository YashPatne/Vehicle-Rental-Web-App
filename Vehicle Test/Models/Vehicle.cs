using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace Vehicle_Test.Models
{
   public class Vehicle:IValidatableObject
      //   public class Vehicle 
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        [Display(Name = "Enter Vehicle Name")]
        public string Name{ get; set; }
        [Required(ErrorMessage ="Enter Vehicle Number")]
        [StringLength(20)]
        [Index("IX_Number",Order =1,IsUnique =true)]
        [Display(Name = "Enter Vehicle Number (XX-XX-XX-XXXX)")]
        [RegularExpression("[A-Za-z]{2}-[0-9]{2}-[A-Za-z]{2}-[0-9]{4}", ErrorMessage ="Please Enter Valid Vehicle Number")]
        public string Number { get; set; }

        public VehicleType VehicleType { get; set; }
        [Required]
        [Display(Name = "Select Vehicle Type")]
        public int VehicleTypeId { get; set; }
        
        public bool IsAvailable { get; set; }


        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            List<ValidationResult> validationResult = new List<ValidationResult>();
            var validateName = _context.Vehicles.FirstOrDefault(x => x.Number == Number && x.Id!=Id);
            if (validateName != null)
            {
                 ValidationResult errorMessage = new ValidationResult
                ("Vehicle already exists.", new[] { "Number" });
                 yield return errorMessage;

            }
            else
            {
                yield return ValidationResult.Success;
            }
          
        }
      


    }
}