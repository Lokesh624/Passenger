using Microsoft.EntityFrameworkCore;
using Passenger.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Contract.Seeder
{
    public class StateName
    {
        public void StateNameData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StateDetails>().HasData(
                new StateDetails { StateID = 1, StateName = "Andhra Pradesh", CountryID = 1 },
                new StateDetails { StateID = 2, StateName = "Arunachal Pradesh", CountryID = 1 },
                new StateDetails { StateID = 3, StateName = "Assam", CountryID = 1 },
                new StateDetails { StateID = 4, StateName = "Bihar", CountryID = 1 },
                new StateDetails { StateID = 5, StateName = "Chhattisgarh", CountryID = 1 },
                new StateDetails { StateID = 6, StateName = "Goa", CountryID = 1 },
                new StateDetails { StateID = 7, StateName = "Gujarat", CountryID = 1 },
                new StateDetails { StateID = 8, StateName = "Haryana", CountryID = 1 },
                new StateDetails { StateID = 9, StateName = "Himachal Pradesh", CountryID = 1 },
                new StateDetails { StateID = 10, StateName = "Jammu & Kashmir", CountryID = 1 },
                new StateDetails { StateID = 11, StateName = "Jharkhand", CountryID = 1 },
                new StateDetails { StateID = 12, StateName = "Karnataka", CountryID = 1 },
                new StateDetails { StateID = 13, StateName = "Kerala", CountryID = 1 },
                new StateDetails { StateID = 14, StateName = "Madhya Pradesh", CountryID = 1 },
                new StateDetails { StateID = 15, StateName = "Maharashtra", CountryID = 1 },
                new StateDetails { StateID = 16, StateName = "Manipur", CountryID = 1 },
                new StateDetails { StateID = 17, StateName = "Meghalaya", CountryID = 1 },
                new StateDetails { StateID = 18, StateName = "Mizoram", CountryID = 1 },
                new StateDetails { StateID = 19, StateName = "Nagaland", CountryID = 1 },
                new StateDetails { StateID = 20, StateName = "Orissa", CountryID = 1 },
                new StateDetails { StateID = 21, StateName = "Punjab", CountryID = 1 },
                new StateDetails { StateID = 22, StateName = "Rajasthan", CountryID = 1 },
                new StateDetails { StateID = 23, StateName = "Sikkim", CountryID = 1 },
                new StateDetails { StateID = 24, StateName = "Tamil Nadu", CountryID = 1 },
                new StateDetails { StateID = 25, StateName = "Telangana", CountryID = 1 },
                new StateDetails { StateID = 26, StateName = "Tripura", CountryID = 1 },
                new StateDetails { StateID = 27, StateName = "Uttar Pradesh", CountryID = 1 },
                new StateDetails { StateID = 28, StateName = "Uttarakhand", CountryID = 1 },
                new StateDetails { StateID = 29, StateName = "West Bengal", CountryID = 1 },

                new StateDetails { StateID = 30, StateName = "Delhi", CountryID = 1 },
                new StateDetails { StateID = 31, StateName = "Chandigarh", CountryID = 1 },
                new StateDetails { StateID = 32, StateName = "Andaman and Nicobar", CountryID = 1 },
                new StateDetails { StateID = 33, StateName = "Puducherry", CountryID = 1 },
                new StateDetails { StateID = 34, StateName = "Lakshadweep", CountryID = 1 },
                new StateDetails { StateID = 35, StateName = "Dadra and Nagar Haveli", CountryID = 1 },
                new StateDetails { StateID = 36, StateName = "Daman and Diu", CountryID = 1 },
                new StateDetails { StateID = 37, StateName = "Puducherry", CountryID = 1 }
                );
        }
    }
}
