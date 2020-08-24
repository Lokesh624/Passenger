using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Passenger.Entities.Models
{
    public class DistrictDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DistrictID { get; set; }
        public string DistrictName { get; set; }
        public int? StateID { get; set; }
        //public ICollection<PassengerDetails> passengerDetails { get; set; }
    }
}
