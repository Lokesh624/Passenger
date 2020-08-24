using Microsoft.EntityFrameworkCore;
using Passenger.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Contract.Seeder
{
    public class CountryName
    {
        public void CountryNameData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CountryDetails>().HasData(
                new CountryDetails { CountryID = 1, CountryName = "India"}
                );
        }
    }
}
