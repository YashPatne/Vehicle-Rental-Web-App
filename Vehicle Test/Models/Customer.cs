using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vehicle_Test.Models
{
   public class Customer:IValidatableObject
   //       public class Customer
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Enter Customer Name")]
        [MaxLength(255)]
        [RegularExpression("[a-zA-Z][a-zA-Z ]+", ErrorMessage = "Please Enter Valid Name")] 
        public string Name { get; set; }
        [AgeCheck18]
        [Display(Name = "Enter Date of Birth")]
        public DateTime? BirthDate { get; set; }
        [Required]
        [MaxLength(50)]
        [Index("IX_LicenseNumber", Order = 1, IsUnique = true)]
        [Display(Name="Enter License Number")]
        public string LicenseNumber { get; set; }
        [Required]
        [Display(Name = "Enter Mobile Number")]
        [RegularExpression("[0-9]{10}",ErrorMessage ="Please Enter Valid Mobile Number")]
        [Index("IX_MobileNumber",Order =1,IsUnique =true)]
        public Nullable<long> MobileNumber { get; set; }

        public Gender Gender { get; set; }
        [Display(Name="Select Gender")]
        public int GenderId { get; set; }

        public bool IsActive { get; set; }
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            List<ValidationResult> validationResult = new List<ValidationResult>();
            var validateNumber = _context.Customers.FirstOrDefault(x => x.MobileNumber == MobileNumber && x.Id!=Id);
            if (validateNumber != null)
            {
                ValidationResult errorMessage = new ValidationResult
                ("Customer already exists.", new[] { "MobileNumber" });
                validationResult.Add(errorMessage);

            }

            var validateLicense = _context.Customers.FirstOrDefault(x => x.LicenseNumber == LicenseNumber && x.Id!=Id);
            if (validateLicense != null)
            {
                ValidationResult errorMessage = new ValidationResult
                ("Customer already exists.", new[] { "LicenseNumber" });
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }
      
        
    }
}