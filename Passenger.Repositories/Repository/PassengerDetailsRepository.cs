using Passenger.Contract.Context;
using Passenger.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Repositories.Repository
{
    public class PassengerDetailsRepository:GenericRepository<PassengerRegistration>
    {
        public PassengerDetailsRepository(DataContext context) : base(context)
        { }
    }
}
