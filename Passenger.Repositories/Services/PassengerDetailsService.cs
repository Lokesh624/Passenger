using Passenger.Entities.Interfaces;
using Passenger.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Passenger.Repositories.Services
{
    public class PassengerDetailsService : IPassengerDetailsService
    {
        private readonly IGenericRepository<PassengerRegistration> _passengerGenericRepository;
        public PassengerDetailsService(IGenericRepository<PassengerRegistration> passengerGenericRepository)
        {
            _passengerGenericRepository = passengerGenericRepository;
        }
        public async Task RegisterPassenger(PassengerRegistration passengerRegistration)
        {
            try
            {
                if (passengerRegistration != null)
                {
                    passengerRegistration.CreatedDTTM = DateTime.Now;
                    passengerRegistration.UpdatedDTTM = DateTime.Now;
                    var result = await _passengerGenericRepository.AddAsync(passengerRegistration);
                }
            }
            catch (Exception ex)
            { }
        }

        public async Task UpdatePassenger(PassengerRegistration passengerRegistration)
        {
            try
            {
                if (passengerRegistration != null)
                {
                    var passenger = await _passengerGenericRepository.FindByConditionAsync(x => x.ID.Equals(passengerRegistration.ID));
                    passenger.UpdatedDTTM = DateTime.Now;
                    passenger.PassengerContact = passengerRegistration.PassengerContact;
                    passenger.PassengerEmail = passengerRegistration.PassengerEmail;
                    passenger.PassengerAge = passengerRegistration.PassengerAge;

                    await _passengerGenericRepository.UpdateAsync(passenger, passenger.ID);
                }
            }
            catch (Exception ex)
            { }
        }

        public async Task<List<PassengerRegistration>> ViewPassenger()
        {
            List<PassengerRegistration> passengerDetails = new List<PassengerRegistration>();
            try
            {
                var passengerDetailsFromDb = await _passengerGenericRepository.GetAllAsync();
                foreach (var details in passengerDetailsFromDb)
                {
                    passengerDetails.Add(details);
                }
            }
            catch (Exception ex)
            {   
                throw ex;
            }
            return passengerDetails;
        }

        public async Task<PassengerRegistration> ViewPassengerById(int ID)
        {
            PassengerRegistration passenger = null;
            try
            {
                passenger = await _passengerGenericRepository.FindByConditionAsync(x => x.ID.Equals(ID));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return passenger;
        }
        public async Task DeletePassenger(PassengerRegistration passengerRegistration)
        {
            try
            {
                await _passengerGenericRepository.DeleteAsync(passengerRegistration);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
