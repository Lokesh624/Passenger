using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Passenger.Entities.Models
{
    public class CityDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityID { get; set; }
        public int CityName { get; set; }
        public int? DistrictID { get; set; }
        //public ICollection<PassengerDetails> passengerDetails { get; set; }
    }
}
