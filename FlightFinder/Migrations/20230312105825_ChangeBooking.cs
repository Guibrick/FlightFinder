using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightFinder.Migrations
{
    public partial class ChangeBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Arrival",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Arrival",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Destination",
                table: "Bookings");
        }
    }
}
