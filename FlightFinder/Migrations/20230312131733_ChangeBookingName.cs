using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightFinder.Migrations
{
    public partial class ChangeBookingName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Bookings");
        }
    }
}
