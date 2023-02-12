using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BallersAPI.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Players_UserId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Players",
                table: "Players");

            migrationBuilder.DeleteData(
                table: "Pitches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pitches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pitches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "Players",
                newName: "Users");

            migrationBuilder.AddColumn<string>(
                name: "videoURL",
                table: "Pitches",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Duration",
                table: "Bookings",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "AppointmentTime", "CreatedOn", "Duration", "PitchId", "UserId" },
                values: new object[] { 1, new DateTime(2023, 2, 13, 2, 5, 55, 641, DateTimeKind.Local).AddTicks(7491), new DateTime(2023, 2, 12, 20, 5, 55, 641, DateTimeKind.Local).AddTicks(7498), 1.5f, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 12, 20, 5, 55, 641, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 12, 20, 5, 55, 641, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "LastName" },
                values: new object[] { new DateTime(2023, 2, 12, 20, 5, 55, 641, DateTimeKind.Local).AddTicks(7223), "Dean" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 12, 20, 5, 55, 641, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 12, 20, 5, 55, 641, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "FirstName" },
                values: new object[] { new DateTime(2023, 2, 12, 20, 5, 55, 641, DateTimeKind.Local).AddTicks(7236), "Joseph" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 12, 20, 5, 55, 641, DateTimeKind.Local).AddTicks(7240));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "videoURL",
                table: "Pitches");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Players");

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Bookings",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Players",
                table: "Players",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Pitches",
                columns: new[] { "Id", "Address", "CreatedOn", "LastUpdatedBy", "LastUpdatedOn", "Note", "PitchSize", "PitchType", "PostCode" },
                values: new object[,]
                {
                    { 1, "University of Lincoln Sports Center, Brayford Way, Lincoln", new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3081), 0, new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3131), "Best for Hockey, but Good enough for Football", "_11v11", "ASTRO_TURF_2G", "LN67TS" },
                    { 2, "University of Lincoln Sports Center, Brayford Way, Lincoln", new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3137), 0, new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3139), "Best for Football", "_5v5", "ASTRO_TURF_3G", "LN67TS" },
                    { 3, "University of Lincoln Sports Center, Brayford Way, Lincoln", new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3208), 0, new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3210), "Best for Football", "_5v5", "ASTRO_TURF_3G", "LN67TS" }
                });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "LastName" },
                values: new object[] { new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3990), "Doe" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "FirstName" },
                values: new object[] { new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(3997), "Joe" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 12, 19, 8, 36, 706, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Players_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
