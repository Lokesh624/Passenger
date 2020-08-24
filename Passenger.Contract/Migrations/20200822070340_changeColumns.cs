using Microsoft.EntityFrameworkCore.Migrations;

namespace Passenger.Contract.Migrations
{
    public partial class changeColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Passenger_Registrations");

            migrationBuilder.DropColumn(
                name: "CountryID",
                table: "Passenger_Registrations");

            migrationBuilder.DropColumn(
                name: "DistrictID",
                table: "Passenger_Registrations");

            migrationBuilder.DropColumn(
                name: "StateID",
                table: "Passenger_Registrations");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Driver_Registrations");

            migrationBuilder.DropColumn(
                name: "CountryID",
                table: "Driver_Registrations");

            migrationBuilder.DropColumn(
                name: "DistrictID",
                table: "Driver_Registrations");

            migrationBuilder.DropColumn(
                name: "StateID",
                table: "Driver_Registrations");

            migrationBuilder.AlterColumn<int>(
                name: "PinCode",
                table: "Passenger_Registrations",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Passenger_Registrations",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Passenger_Registrations",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Passenger_Registrations",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Passenger_Registrations",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Driver_Registrations",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Driver_Registrations",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Driver_Registrations",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Driver_Registrations",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Passenger_Registrations");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Passenger_Registrations");

            migrationBuilder.DropColumn(
                name: "District",
                table: "Passenger_Registrations");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Passenger_Registrations");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Driver_Registrations");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Driver_Registrations");

            migrationBuilder.DropColumn(
                name: "District",
                table: "Driver_Registrations");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Driver_Registrations");

            migrationBuilder.AlterColumn<int>(
                name: "PinCode",
                table: "Passenger_Registrations",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "Passenger_Registrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryID",
                table: "Passenger_Registrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DistrictID",
                table: "Passenger_Registrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StateID",
                table: "Passenger_Registrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "Driver_Registrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryID",
                table: "Driver_Registrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DistrictID",
                table: "Driver_Registrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StateID",
                table: "Driver_Registrations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
