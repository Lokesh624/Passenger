using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Passenger.Entities.Models
{
    public class StateDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StateID { get; set; }
        public string StateName { get; set; }
        public int? CountryID { get; set; }
        //public ICollection<PassengerDetails> passengerDetails { get; set; }
    }
}
