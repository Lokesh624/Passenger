using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Passenger.Entities.Models
{
    public class DriverRegistration
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required(ErrorMessage = "The Passenger Name is required")]
        [Column(TypeName = "varchar(20)")]
        public string DriverName { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Column(TypeName = "varchar(50)")]
        public string DriverEmail { get; set; }

        [Required(ErrorMessage = "Driver ID number is required")]
        [Column(TypeName = "varchar(10)")]
        public string DriverID { get; set; }
        public int? DriverAge { get; set; }

        [Required(ErrorMessage = "Passenger Contact number is required")]
        public long DriverContact { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [Column(TypeName = "varchar(50)")]
        public string AddressLine1 { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string AddressLine2 { get; set; }
        public int? PinCode { get; set; }
        [Required(ErrorMessage = "Country Name is required")]
        public string Country { get; set; }

        [Required(ErrorMessage = "State Name is required")]
        public string State { get; set; }

        [Required(ErrorMessage = "District Name is required")]
        public string District { get; set; }

        [Required(ErrorMessage = "City Name is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(16, ErrorMessage = "Must be between 5 and 16 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string CreatePassword { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(16, ErrorMessage = "Must be between 5 and 16 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("CreatePassword")]
        public string ConfirmPassword { get; set; }
        public DateTime CreatedDTTM { get; set; }
        public DateTime UpdatedDTTM { get; set; }
    }
}
