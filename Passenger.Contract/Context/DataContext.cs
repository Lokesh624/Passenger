using Microsoft.EntityFrameworkCore;
using Passenger.Contract.Seeder;
using Passenger.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Contract.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<PassengerRegistration> Passenger_Registrations {get;set;}
        public DbSet<DriverRegistration> Driver_Registrations { get; set; }
        public DbSet<CountryDetails> Country_Details { get; set; }
        public DbSet<StateDetails> State_Details { get; set; }
        public DbSet<DistrictDetails> District_Details { get; set; }
        public DbSet<CityDetails> City_Details { get; set; }
        public DbSet<VehicleDetails> Vehicle_Details { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Composite Key
            modelBuilder.Entity<PassengerRegistration>()
            .HasKey(o => new { o.ID, o.PassengerID });

            modelBuilder.Entity<DriverRegistration>()
            .HasKey(o => new { o.ID, o.DriverID });

            CountryName countryName = new CountryName();
            countryName.CountryNameData(modelBuilder);

            StateName stateName = new StateName();
            stateName.StateNameData(modelBuilder);

            DistrictName districtName = new DistrictName();
            districtName.DistrictNameData(modelBuilder);
        }
    }
}
