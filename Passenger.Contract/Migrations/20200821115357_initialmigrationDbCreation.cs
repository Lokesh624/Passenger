using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Passenger.Contract.Migrations
{
    public partial class initialmigrationDbCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City_Details",
                columns: table => new
                {
                    CityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<int>(nullable: false),
                    DistrictID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City_Details", x => x.CityID);
                });

            migrationBuilder.CreateTable(
                name: "Country_Details",
                columns: table => new
                {
                    CountryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country_Details", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "District_Details",
                columns: table => new
                {
                    DistrictID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(nullable: true),
                    StateID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District_Details", x => x.DistrictID);
                });

            migrationBuilder.CreateTable(
                name: "Driver_Registrations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverID = table.Column<string>(type: "varchar(10)", nullable: false),
                    DriverName = table.Column<string>(type: "varchar(20)", nullable: false),
                    DriverEmail = table.Column<string>(type: "varchar(50)", nullable: false),
                    DriverAge = table.Column<int>(nullable: true),
                    DriverContact = table.Column<long>(nullable: false),
                    AddressLine1 = table.Column<string>(type: "varchar(50)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "varchar(50)", nullable: true),
                    PinCode = table.Column<int>(nullable: true),
                    CreatePassword = table.Column<string>(maxLength: 16, nullable: false),
                    ConfirmPassword = table.Column<string>(maxLength: 16, nullable: false),
                    CreatedDTTM = table.Column<DateTime>(nullable: false),
                    UpdatedDTTM = table.Column<DateTime>(nullable: false),
                    CityID = table.Column<int>(nullable: false),
                    DistrictID = table.Column<int>(nullable: false),
                    StateID = table.Column<int>(nullable: false),
                    CountryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver_Registrations", x => new { x.ID, x.DriverID });
                });

            migrationBuilder.CreateTable(
                name: "Passenger_Registrations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassengerID = table.Column<string>(type: "varchar(10)", nullable: false),
                    PassengerName = table.Column<string>(type: "varchar(20)", nullable: false),
                    PassengerEmail = table.Column<string>(type: "varchar(50)", nullable: false),
                    PassengerAge = table.Column<int>(nullable: true),
                    PassengerContact = table.Column<long>(nullable: false),
                    AddressLine1 = table.Column<string>(type: "varchar(50)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "varchar(50)", nullable: true),
                    PinCode = table.Column<int>(nullable: false),
                    CreatePassword = table.Column<string>(maxLength: 16, nullable: false),
                    ConfirmPassword = table.Column<string>(maxLength: 16, nullable: false),
                    CreatedDTTM = table.Column<DateTime>(nullable: false),
                    UpdatedDTTM = table.Column<DateTime>(nullable: false),
                    CityID = table.Column<int>(nullable: false),
                    DistrictID = table.Column<int>(nullable: false),
                    StateID = table.Column<int>(nullable: false),
                    CountryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passenger_Registrations", x => new { x.ID, x.PassengerID });
                });

            migrationBuilder.CreateTable(
                name: "State_Details",
                columns: table => new
                {
                    StateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(nullable: true),
                    CountryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State_Details", x => x.StateID);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle_Details",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleNumber = table.Column<int>(nullable: false),
                    SeatsInVehicle = table.Column<int>(nullable: true),
                    IsVehicleUnderInsurance = table.Column<bool>(nullable: false),
                    InsuranceStartDate = table.Column<DateTime>(nullable: true),
                    InsuranceEndDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle_Details", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City_Details");

            migrationBuilder.DropTable(
                name: "Country_Details");

            migrationBuilder.DropTable(
                name: "District_Details");

            migrationBuilder.DropTable(
                name: "Driver_Registrations");

            migrationBuilder.DropTable(
                name: "Passenger_Registrations");

            migrationBuilder.DropTable(
                name: "State_Details");

            migrationBuilder.DropTable(
                name: "Vehicle_Details");
        }
    }
}
