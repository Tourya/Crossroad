using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BMG_Schedule.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "Info", "LastName" },
                values: new object[,]
                {
                    { 1, "Миглена", null, "Велева" },
                    { 2, "Иван", null, "Петров" },
                    { 3, "Никола", null, "Попов" },
                    { 4, "Стефка", null, "Стоянова" },
                    { 5, "Мария", null, "Донева" },
                    { 6, "Георги", null, "Митев" },
                    { 7, "Петър", null, "Николов" },
                    { 8, "Павел", null, "Попов" },
                    { 9, "Стоян", null, "Константинов" },
                    { 10, "Галя", null, "Стоянова" }
                });

            migrationBuilder.InsertData(
                table: "RecordTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Работен ден" },
                    { 2, "Командировка" },
                    { 3, "Отпуск - платен" },
                    { 4, "Отпуск - неплатен" },
                    { 5, "Болнични" }
                });

            migrationBuilder.InsertData(
                table: "WorkingDays",
                columns: new[] { "Id", "EmployeeId", "End", "RecordTypeId", "Start" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 2, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 2, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 2, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 2, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 2, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 2, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 2, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 2, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 3, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 3, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 3, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 3, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 3, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 3, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 3, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 3, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 4, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 4, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 4, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 4, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 4, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 4, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 4, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 4, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 5, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 5, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 5, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 5, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 5, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 5, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 5, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 5, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 6, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 6, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 6, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 6, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 6, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 6, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 6, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 6, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 7, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 7, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, 7, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, 7, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, 7, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, 7, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, 7, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, 7, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, 8, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, 8, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, 8, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, 8, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, 8, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, 8, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, 8, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, 8, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, 9, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, 9, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, 9, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, 9, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, 9, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, 9, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, 9, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, 9, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, 10, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, 10, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, 10, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, 10, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, 10, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, 10, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, 10, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, 10, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecordTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RecordTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RecordTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RecordTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RecordTypes",
                keyColumn: "Id",
                keyValue: 5);

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

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
