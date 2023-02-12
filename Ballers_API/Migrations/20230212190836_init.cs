using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BallersAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pitches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PitchType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PitchSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pitches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccessLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PitchId = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    AppointmentTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Players_UserId",
                        column: x => x.UserId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pitches",
                columns: new[] { "Id", "Address", "CreatedOn", "LastUpdatedBy", "LastUpdatedOn", "Note", "PitchSize", "PitchType", "PostCode" },
                values: new object[,]
                {
                    { 1, "University of Lincoln Sports Center, Brayford Way, Lincoln", new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3081), 0, new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3131), "Best for Hockey, but Good enough for Football", "_11v11", "ASTRO_TURF_2G", "LN67TS" },
                    { 2, "University of Lincoln Sports Center, Brayford Way, Lincoln", new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3137), 0, new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3139), "Best for Football", "_5v5", "ASTRO_TURF_3G", "LN67TS" },
                    { 3, "University of Lincoln Sports Center, Brayford Way, Lincoln", new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3208), 0, new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3210), "Best for Football", "_5v5", "ASTRO_TURF_3G", "LN67TS" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "AccessLevel", "DateOfBirth", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3981), "John", "Doe" },
                    { 2, 0, new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3988), "Thomas", "Jones" },
                    { 3, 0, new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3990), "Carrick", "Doe" },
                    { 4, 0, new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3993), "Derrick", "John" },
                    { 5, 0, new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3995), "Daniel", "Hogg" },
                    { 6, 0, new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3997), "Joe", "Oink" },
                    { 7, 0, new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(4000), "James", "Balmer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Pitches");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
