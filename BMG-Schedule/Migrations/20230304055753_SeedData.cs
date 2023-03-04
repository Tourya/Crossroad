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
                    { 1, 1, new DateTime(2022, 12, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2022, 12, 21, 17, 40, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2022, 12, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, new DateTime(2023, 1, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, new DateTime(2023, 1, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, new DateTime(2023, 1, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, new DateTime(2023, 1, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, new DateTime(2023, 2, 1, 16, 50, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 1, new DateTime(2023, 2, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 1, new DateTime(2023, 2, 7, 18, 30, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 1, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 1, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 1, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 2, new DateTime(2022, 12, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 2, new DateTime(2022, 12, 21, 17, 30, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 2, new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 2, new DateTime(2022, 12, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2022, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 2, new DateTime(2023, 1, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 2, new DateTime(2023, 1, 27, 16, 55, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 2, new DateTime(2023, 1, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 2, new DateTime(2023, 1, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 2, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 2, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 2, new DateTime(2023, 2, 3, 18, 20, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 2, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 2, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 2, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 2, new DateTime(2023, 2, 9, 15, 48, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 2, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 3, new DateTime(2022, 12, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 3, new DateTime(2022, 12, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 3, new DateTime(2022, 12, 19, 17, 45, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 3, new DateTime(2022, 12, 22, 17, 55, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 3, new DateTime(2023, 1, 26, 18, 30, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 3, new DateTime(2023, 1, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 3, new DateTime(2023, 1, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 3, new DateTime(2023, 1, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 3, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 3, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 3, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 3, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 3, new DateTime(2023, 2, 7, 16, 10, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 3, new DateTime(2023, 2, 8, 16, 38, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 3, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 3, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 4, new DateTime(2022, 12, 20, 16, 42, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 4, new DateTime(2022, 12, 21, 18, 5, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, 4, new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, 4, new DateTime(2022, 12, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, 4, new DateTime(2023, 1, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, 4, new DateTime(2023, 1, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, 4, new DateTime(2023, 1, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, 4, new DateTime(2023, 1, 31, 17, 23, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, 4, new DateTime(2023, 2, 1, 17, 56, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, 4, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, 4, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, 4, new DateTime(2023, 2, 6, 18, 13, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, 4, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, 4, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, 4, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, 4, new DateTime(2023, 2, 10, 16, 33, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, 5, new DateTime(2022, 12, 20, 18, 5, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, 5, new DateTime(2022, 12, 21, 17, 45, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, 5, new DateTime(2022, 12, 19, 17, 49, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, 5, new DateTime(2022, 12, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, 5, new DateTime(2023, 1, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, 5, new DateTime(2023, 1, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, 5, new DateTime(2023, 1, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, 5, new DateTime(2023, 1, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, 5, new DateTime(2023, 2, 1, 18, 22, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, 5, new DateTime(2023, 2, 2, 18, 9, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, 5, new DateTime(2023, 2, 3, 17, 20, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, 5, new DateTime(2023, 2, 6, 16, 39, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, 5, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, 5, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, 5, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, 5, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, 6, new DateTime(2022, 12, 20, 18, 10, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, 6, new DateTime(2022, 12, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, 6, new DateTime(2022, 12, 19, 17, 40, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, 6, new DateTime(2022, 12, 22, 17, 25, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, 6, new DateTime(2023, 1, 26, 18, 20, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, 6, new DateTime(2023, 1, 27, 17, 15, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, 6, new DateTime(2023, 1, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, 6, new DateTime(2023, 1, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, 6, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, 6, new DateTime(2023, 2, 2, 17, 32, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, 6, new DateTime(2023, 2, 3, 17, 40, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, 6, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, 6, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, 6, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, 6, new DateTime(2023, 2, 9, 18, 9, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96, 6, new DateTime(2023, 2, 10, 17, 30, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, 7, new DateTime(2022, 12, 20, 18, 5, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, 7, new DateTime(2022, 12, 21, 17, 18, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99, 7, new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, 7, new DateTime(2022, 12, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2022, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 101, 7, new DateTime(2023, 1, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 102, 7, new DateTime(2023, 1, 27, 16, 20, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 103, 7, new DateTime(2023, 1, 30, 16, 45, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 104, 7, new DateTime(2023, 1, 31, 18, 10, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 105, 7, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 106, 7, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 107, 7, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 108, 7, new DateTime(2023, 2, 6, 17, 45, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 109, 7, new DateTime(2023, 2, 7, 17, 30, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 110, 7, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 111, 7, new DateTime(2023, 2, 9, 17, 30, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 112, 7, new DateTime(2023, 2, 10, 17, 15, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 113, 8, new DateTime(2022, 12, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 114, 8, new DateTime(2022, 12, 21, 17, 20, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 115, 8, new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 116, 8, new DateTime(2022, 12, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 117, 8, new DateTime(2023, 1, 26, 17, 45, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 118, 8, new DateTime(2023, 1, 27, 17, 55, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 119, 8, new DateTime(2023, 1, 30, 18, 10, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 120, 8, new DateTime(2023, 1, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 121, 8, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 122, 8, new DateTime(2023, 2, 2, 15, 47, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 123, 8, new DateTime(2023, 2, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 124, 8, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 125, 8, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 126, 8, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 127, 8, new DateTime(2023, 2, 9, 18, 20, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 128, 8, new DateTime(2023, 2, 10, 18, 10, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 129, 9, new DateTime(2022, 12, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2022, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 130, 9, new DateTime(2022, 12, 21, 18, 2, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 131, 9, new DateTime(2022, 12, 19, 17, 50, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 132, 9, new DateTime(2022, 12, 22, 18, 30, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 133, 9, new DateTime(2023, 1, 26, 16, 20, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 134, 9, new DateTime(2023, 1, 27, 17, 45, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 135, 9, new DateTime(2023, 1, 30, 17, 55, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 136, 9, new DateTime(2023, 1, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 137, 9, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 138, 9, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 139, 9, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 140, 9, new DateTime(2023, 2, 6, 18, 5, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 141, 9, new DateTime(2023, 2, 7, 18, 20, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 142, 9, new DateTime(2023, 2, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 143, 9, new DateTime(2023, 2, 9, 17, 18, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 144, 9, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 145, 10, new DateTime(2022, 12, 20, 16, 10, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 146, 10, new DateTime(2022, 12, 21, 16, 45, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 147, 10, new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 148, 10, new DateTime(2022, 12, 22, 18, 10, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 149, 10, new DateTime(2023, 1, 26, 18, 22, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 150, 10, new DateTime(2023, 1, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 151, 10, new DateTime(2023, 1, 30, 17, 45, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 152, 10, new DateTime(2023, 1, 31, 17, 55, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 153, 10, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 154, 10, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 155, 10, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 156, 10, new DateTime(2023, 2, 6, 17, 15, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 157, 10, new DateTime(2023, 2, 7, 17, 30, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 158, 10, new DateTime(2023, 2, 8, 17, 45, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 159, 10, new DateTime(2023, 2, 9, 18, 30, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 160, 10, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Exits",
                columns: new[] { "Id", "EmployeeId", "End", "IsPersonal", "Reason", "Start", "WorkingDayId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 2, 1, 12, 30, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 2, null, new DateTime(2023, 2, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 3, null, new DateTime(2023, 2, 3, 12, 30, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 4, null, new DateTime(2023, 2, 6, 11, 30, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 6, 10, 30, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 5, null, new DateTime(2023, 2, 7, 13, 45, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 7, 13, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 6, null, new DateTime(2023, 1, 31, 12, 30, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 1, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 7, null, new DateTime(2023, 2, 1, 10, 45, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 8, null, new DateTime(2023, 2, 2, 15, 52, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 9, null, new DateTime(2023, 2, 3, 12, 43, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 3, 10, 30, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 10, null, new DateTime(2023, 2, 8, 15, 28, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 8, 10, 15, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 11, null, new DateTime(2022, 12, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2022, 12, 20, 9, 40, 0, 0, DateTimeKind.Unspecified), 33 },
                    { 12, null, new DateTime(2022, 12, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2022, 12, 21, 12, 15, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 13, null, new DateTime(2022, 12, 19, 14, 15, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2022, 12, 19, 13, 10, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 14, null, new DateTime(2022, 12, 22, 16, 10, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2022, 12, 22, 15, 30, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 15, null, new DateTime(2023, 1, 26, 11, 48, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 1, 26, 10, 20, 0, 0, DateTimeKind.Unspecified), 37 },
                    { 16, null, new DateTime(2023, 2, 1, 10, 45, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 1, 9, 30, 0, 0, DateTimeKind.Unspecified), 57 },
                    { 17, null, new DateTime(2023, 2, 2, 13, 30, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 2, 12, 15, 0, 0, DateTimeKind.Unspecified), 58 },
                    { 18, null, new DateTime(2023, 2, 3, 14, 23, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 3, 13, 5, 0, 0, DateTimeKind.Unspecified), 59 },
                    { 19, null, new DateTime(2023, 2, 6, 12, 32, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 6, 11, 8, 0, 0, DateTimeKind.Unspecified), 60 },
                    { 20, null, new DateTime(2023, 2, 7, 11, 30, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), 61 },
                    { 21, null, new DateTime(2023, 2, 1, 13, 45, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 1, 12, 20, 0, 0, DateTimeKind.Unspecified), 73 },
                    { 22, null, new DateTime(2023, 2, 2, 11, 20, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 74 },
                    { 23, null, new DateTime(2023, 2, 3, 11, 15, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 3, 10, 5, 0, 0, DateTimeKind.Unspecified), 75 },
                    { 24, null, new DateTime(2023, 2, 6, 12, 48, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 6, 11, 32, 0, 0, DateTimeKind.Unspecified), 76 },
                    { 25, null, new DateTime(2023, 2, 7, 15, 30, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 7, 14, 15, 0, 0, DateTimeKind.Unspecified), 77 },
                    { 26, null, new DateTime(2023, 2, 1, 11, 25, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 1, 10, 17, 0, 0, DateTimeKind.Unspecified), 89 },
                    { 27, null, new DateTime(2023, 2, 2, 14, 32, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 2, 11, 13, 0, 0, DateTimeKind.Unspecified), 90 },
                    { 28, null, new DateTime(2023, 2, 3, 12, 48, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 3, 11, 30, 0, 0, DateTimeKind.Unspecified), 91 },
                    { 29, null, new DateTime(2023, 2, 6, 15, 15, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 92 },
                    { 30, null, new DateTime(2023, 2, 8, 15, 32, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), 94 },
                    { 31, null, new DateTime(2023, 2, 2, 12, 23, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), 106 },
                    { 32, null, new DateTime(2023, 2, 3, 11, 46, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 3, 10, 30, 0, 0, DateTimeKind.Unspecified), 107 },
                    { 33, null, new DateTime(2023, 2, 6, 14, 47, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 6, 13, 23, 0, 0, DateTimeKind.Unspecified), 108 },
                    { 34, null, new DateTime(2023, 2, 7, 12, 30, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), 109 },
                    { 35, null, new DateTime(2023, 2, 9, 13, 30, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 9, 11, 30, 0, 0, DateTimeKind.Unspecified), 111 },
                    { 36, null, new DateTime(2023, 1, 30, 10, 45, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 1, 30, 9, 52, 0, 0, DateTimeKind.Unspecified), 119 },
                    { 37, null, new DateTime(2023, 1, 31, 13, 36, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 1, 31, 11, 20, 0, 0, DateTimeKind.Unspecified), 120 },
                    { 38, null, new DateTime(2023, 2, 1, 13, 54, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 1, 11, 43, 0, 0, DateTimeKind.Unspecified), 121 },
                    { 39, null, new DateTime(2023, 2, 2, 10, 47, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 122 },
                    { 40, null, new DateTime(2023, 2, 3, 12, 23, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 3, 10, 30, 0, 0, DateTimeKind.Unspecified), 123 },
                    { 41, null, new DateTime(2023, 2, 2, 12, 20, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 138 },
                    { 42, null, new DateTime(2023, 2, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 3, 11, 30, 0, 0, DateTimeKind.Unspecified), 139 },
                    { 43, null, new DateTime(2023, 2, 6, 13, 45, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), 140 },
                    { 44, null, new DateTime(2023, 2, 7, 15, 30, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 7, 14, 15, 0, 0, DateTimeKind.Unspecified), 141 },
                    { 45, null, new DateTime(2023, 2, 8, 12, 40, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), 142 },
                    { 46, null, new DateTime(2023, 2, 6, 11, 15, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), 156 },
                    { 47, null, new DateTime(2023, 2, 7, 12, 40, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 7, 11, 15, 0, 0, DateTimeKind.Unspecified), 157 },
                    { 48, null, new DateTime(2023, 2, 8, 15, 15, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 8, 14, 2, 0, 0, DateTimeKind.Unspecified), 158 },
                    { 49, null, new DateTime(2023, 2, 9, 15, 30, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 9, 13, 10, 0, 0, DateTimeKind.Unspecified), 159 },
                    { 50, null, new DateTime(2023, 2, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 160 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Exits",
                keyColumn: "Id",
                keyValue: 50);

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
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 29);

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
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 155);

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
                keyValue: 30);

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
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "WorkingDays",
                keyColumn: "Id",
                keyValue: 160);

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
