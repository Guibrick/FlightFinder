using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightFinder.Migrations
{
    public partial class ChangeDepartureName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Destination",
                table: "Bookings",
                newName: "Departure");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Departure",
                table: "Bookings",
                newName: "Destination");
        }
    }
}
