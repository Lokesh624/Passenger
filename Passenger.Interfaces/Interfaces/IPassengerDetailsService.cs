using Passenger.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Passenger.Entities.Interfaces
{
    public interface IPassengerDetailsService
    {
        Task RegisterPassenger(PassengerRegistration passengerRegistration);
        Task UpdatePassenger(PassengerRegistration passengerRegistration);
        Task<List<PassengerRegistration>> ViewPassenger();
        Task<PassengerRegistration> ViewPassengerById(int ID);
        Task DeletePassenger(PassengerRegistration passengerRegistration);

    }
}
