using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateRelationstables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Trips_customerId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Customers_ReservationId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Customers_customerId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "customerId",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "customerId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "ReservationId",
                table: "Reservations",
                newName: "ReservedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_ReservationId",
                table: "Reservations",
                newName: "IX_Reservations_ReservedBy");

            migrationBuilder.CreateTable(
                name: "CustomerTrip",
                columns: table => new
                {
                    CustTripID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    TripID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTrip", x => x.CustTripID);
                    table.ForeignKey(
                        name: "FK_CustomerTrip_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerTrip_Trips_TripID",
                        column: x => x.TripID,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTrip_CustomerID",
                table: "CustomerTrip",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTrip_TripID",
                table: "CustomerTrip",
                column: "TripID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_ReservedBy",
                table: "Reservations",
                column: "ReservedBy",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_ReservedBy",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "CustomerTrip");

            migrationBuilder.RenameColumn(
                name: "ReservedBy",
                table: "Reservations",
                newName: "ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_ReservedBy",
                table: "Reservations",
                newName: "IX_Reservations_ReservationId");

            migrationBuilder.AddColumn<int>(
                name: "customerId",
                table: "Trips",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "customerId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_customerId",
                table: "Customers",
                column: "customerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Trips_customerId",
                table: "Customers",
                column: "customerId",
                principalTable: "Trips",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Customers_ReservationId",
                table: "Reservations",
                column: "ReservationId",
                principalTable: "Customers",
                principalColumn: "Id");
        }
    }
}
