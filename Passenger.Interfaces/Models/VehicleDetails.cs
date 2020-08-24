using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Passenger.Entities.Models
{
    public class VehicleDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "The Vehicle Number is required")]
        public int VehicleNumber { get; set; }
        public int? SeatsInVehicle { get; set; }
        [Required]
        public bool IsVehicleUnderInsurance { get; set; }
        public DateTime? InsuranceStartDate { get; set; }
        public DateTime? InsuranceEndDate { get; set; }
    }
}
