using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BMG_Schedule.Migrations
{
    /// <inheritdoc />
    public partial class SeedWorkingDay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WorkingDays",
                columns: new[] { "Id", "EmployeeId", "End", "RecordTypeId", "Start" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 7, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 2, 8, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 2, 9, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 2, 10, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 2, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 2, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 2, 2, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 2, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 2, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 2, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 7, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 2, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 8, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 2, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 9, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 2, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 10, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 3, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 3, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 3, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 3, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 3, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 2, 7, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 3, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 2, 8, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 3, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 9, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 3, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 10, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 4, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 4, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 4, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 4, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 4, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 7, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 4, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 8, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 4, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 2, 9, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 4, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 10, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 5, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 5, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 5, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 5, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 5, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 7, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 5, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 8, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 5, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 9, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 5, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 10, 8, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 40);
        }
    }
}
