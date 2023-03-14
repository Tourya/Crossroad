using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BMG_Schedule.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecordTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPersonal = table.Column<bool>(type: "bit", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    WorkingDayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exits_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkingDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecordTypeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ExitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkingDays_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "Info", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "fd6ea293-a998-4ebe-95b7-d461b496d113", "Employee", "migleva@abv.bg", false, "Миглена", null, "Велева", false, null, "MIGLEVA@ABV.BG", "MIGLEVA@ABV.BG", "AQAAAAEAACcQAAAAECx+W0xAtXhCwI20246cBfyXDDFpwlO68Hfr8ixHuA+9hozHqv6oFsgWObsxqWh8XQ==", null, false, "ccd2fb39-d30b-4d7f-b934-c200765238e0", false, "migleva@abv.bg" },
                    { 2, 0, "4da2e120-8c64-4015-91df-8a340478f407", "Employee", "ivan_petrov@abv.bg", false, "Иван", null, "Петров", false, null, "IVAN_PETROV@ABV.BG", "IVAN_PETROV@ABV.BG", "AQAAAAEAACcQAAAAEDinJTt4Df1H5sDwle7aXnRA+eSiL2PzqZggXubOwRD34Uacvl9JhKyhaS/WlTAd4g==", null, false, "a136071e-7822-492f-a01a-36f0fe5c0cda", false, "ivan_petrov@abv.bg" },
                    { 3, 0, "be76688d-d614-478b-9de0-5d12d4ab2982", "Employee", "n.popov@gmail.com", false, "Никола", null, "Попов", false, null, "N.POPOV@GMAIL.COM", "N.POPOV@GMAIL.COM", "AQAAAAEAACcQAAAAEN5vBGZzP/qtXU50g2x43FGmCWyuHLVOqIegJv73elq0gTXj6sdplH1gL2iRMuB4qw==", null, false, "42043327-88e2-4a01-b193-8f5f0765d872", false, "n.popov@gmail.com" },
                    { 4, 0, "2d95b945-6098-490d-a6dc-d6b76a6f9a35", "Employee", "stevka_52@gmail.com", false, "Стефка", null, "Стоянова", false, null, "STEFKA_52@GMAIL.COM", "STEFKA_52@GMAIL.COM", "AQAAAAEAACcQAAAAEBbhbTw4nybJQk8WuyAXxTDccdrZEGcpJcyNfvVaTJS0UoNtKMMFu/mDuSH9qLtLXA==", null, false, "39c6b4c6-b7cc-426f-937e-9fedcd0370a7", false, "stevka_52@gmail.com" },
                    { 5, 0, "ec10e17c-bf61-43cc-8b79-c7a30e5609d1", "Employee", "maria_doneva@yahoo.com", false, "Мария", null, "Донева", false, null, "MARIA_DONEVA@YAHOO.COM", "MARIA_DONEVA@YAHOO.COM", "AQAAAAEAACcQAAAAEOSefydUjjksC2i2ZH5u+FrOlXcElXopS9cmcslwzakdscq8j0G9ZDC8cM9NdFSQjg==", null, false, "31eb589d-28b4-45f2-9853-1d846d29cbc9", false, "maria_doneva@yahoo.com" },
                    { 6, 0, "6e0c6632-e64e-4c6f-b55c-476c2fecfc43", "Employee", "georgi_mitev@abv.bg", false, "Георги", null, "Митев", false, null, "GEORGI_MITEV@ABV.BG", "GEORGI_MITEV@ABV.BG", "AQAAAAEAACcQAAAAEJwJr338bzfNTejibgIlp+60UCScsnLjB5JbrIyQRZvHajvYzhFr9MWaA5RmCW9Xdg==", null, false, "7f997aab-3c36-4b41-afd4-5799a3ba11a0", false, "georgi_mitev@abv.bg" },
                    { 7, 0, "0a946072-8ea7-4e9a-bd9a-ee2ad8768358", "Employee", "pnikolov@gmail.com", false, "Петър", null, "Николов", false, null, "PNIKOLOV@GMAIL.COM", "PNIKOLOV@GMAIL.COM", "AQAAAAEAACcQAAAAEBR22NNahlNeKrcJef07r13/4PRo+N0rJGAYsE8yN8ZRH3K9tCaSQTyEXbVRNTR1Eg==", null, false, "ea67c1fa-cb18-417e-86b6-e9e60baf60a2", false, "pnikolov@gmail.com" },
                    { 8, 0, "89eedea6-54ca-487f-a9ee-27e82c58a77e", "Employee", "pavel_popov@yahoo.com", false, "Павел", null, "Попов", false, null, "PAVEL_POPOV@YAHOO.COM", "PAVEL_POPOV@YAHOO.COM", "AQAAAAEAACcQAAAAELvWQRcnY7W66WRDhGmkrMBzq56S5lbEypgaYSop30go6DRhNkO6qpK+XeoOGmJHXg==", null, false, "7439cced-b615-4051-b50e-e2c8f230f3b4", false, "pavel_popov@yahoo.com" },
                    { 9, 0, "02fe2043-a385-46f7-9eba-72dc5b169516", "Employee", "s_konstantinov@gmail.com", false, "Стоян", null, "Константинов", false, null, "S_KONSTANTINOV@GMAIL.COM", "S_KONSTANTINOV@GMAIL.COM", "AQAAAAEAACcQAAAAEERlpu+WDvtfV5FckXclhW42YqG6pt02afCoqlq+0ptnA+iicUSBD/k5IVOKXHvjBw==", null, false, "4f30b13e-96fd-4497-aa8f-245e73031c0b", false, "s_konstantinov@gmail.com" },
                    { 10, 0, "d084e6d4-a4a2-46bd-80ca-f878a1755dfe", "Employee", "gg_stoyanova@gbg.bg", false, "Галя", null, "Стоянова", false, null, "GG_STOYANOVA@GBG.BG", "GG_STOYANOVA@GBG.BG", "AQAAAAEAACcQAAAAEEzm7xnn+iC99aZgFFN5EvqHQpJsVTfieyrR5w2p8hGn7dwK0Jji60KeSuvPM0YP8Q==", null, false, "ea0f18ea-5ad5-4c15-90b2-564bedd98757", false, "gg_stoyanova@gbg.bg" }
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
                table: "Exits",
                columns: new[] { "Id", "EmployeeId", "End", "IsPersonal", "Reason", "Start", "WorkingDayId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 2, 1, 12, 30, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 2, 1, new DateTime(2023, 2, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 3, 1, new DateTime(2023, 2, 3, 12, 30, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 4, 1, new DateTime(2023, 2, 6, 11, 30, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 6, 10, 30, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 5, 1, new DateTime(2023, 2, 7, 13, 45, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 7, 13, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 6, 2, new DateTime(2023, 1, 31, 12, 30, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 1, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 7, 2, new DateTime(2023, 2, 1, 10, 45, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 8, 2, new DateTime(2023, 2, 2, 15, 52, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 9, 2, new DateTime(2023, 2, 3, 12, 43, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 3, 10, 30, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 10, 2, new DateTime(2023, 2, 8, 15, 28, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 8, 10, 15, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 11, 3, new DateTime(2022, 12, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2022, 12, 20, 9, 40, 0, 0, DateTimeKind.Unspecified), 33 },
                    { 12, 3, new DateTime(2022, 12, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2022, 12, 21, 12, 15, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 13, 3, new DateTime(2022, 12, 19, 14, 15, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2022, 12, 19, 13, 10, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 14, 3, new DateTime(2022, 12, 22, 16, 10, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2022, 12, 22, 15, 30, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 15, 3, new DateTime(2023, 1, 26, 11, 48, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 1, 26, 10, 20, 0, 0, DateTimeKind.Unspecified), 37 },
                    { 16, 4, new DateTime(2023, 2, 1, 10, 45, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 1, 9, 30, 0, 0, DateTimeKind.Unspecified), 57 },
                    { 17, 4, new DateTime(2023, 2, 2, 13, 30, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 2, 12, 15, 0, 0, DateTimeKind.Unspecified), 58 },
                    { 18, 4, new DateTime(2023, 2, 3, 14, 23, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 3, 13, 5, 0, 0, DateTimeKind.Unspecified), 59 },
                    { 19, 4, new DateTime(2023, 2, 6, 12, 32, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 6, 11, 8, 0, 0, DateTimeKind.Unspecified), 60 },
                    { 20, 4, new DateTime(2023, 2, 7, 11, 30, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), 61 },
                    { 21, 5, new DateTime(2023, 2, 1, 13, 45, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 1, 12, 20, 0, 0, DateTimeKind.Unspecified), 73 },
                    { 22, 5, new DateTime(2023, 2, 2, 11, 20, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 74 },
                    { 23, 5, new DateTime(2023, 2, 3, 11, 15, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 3, 10, 5, 0, 0, DateTimeKind.Unspecified), 75 },
                    { 24, 5, new DateTime(2023, 2, 6, 12, 48, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 6, 11, 32, 0, 0, DateTimeKind.Unspecified), 76 },
                    { 25, 5, new DateTime(2023, 2, 7, 15, 30, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 7, 14, 15, 0, 0, DateTimeKind.Unspecified), 77 },
                    { 26, 6, new DateTime(2023, 2, 1, 11, 25, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 1, 10, 17, 0, 0, DateTimeKind.Unspecified), 89 },
                    { 27, 6, new DateTime(2023, 2, 2, 14, 32, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 2, 11, 13, 0, 0, DateTimeKind.Unspecified), 90 },
                    { 28, 6, new DateTime(2023, 2, 3, 12, 48, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 3, 11, 30, 0, 0, DateTimeKind.Unspecified), 91 },
                    { 29, 6, new DateTime(2023, 2, 6, 15, 15, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 92 },
                    { 30, 6, new DateTime(2023, 2, 8, 15, 32, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), 94 },
                    { 31, 7, new DateTime(2023, 2, 2, 12, 23, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), 106 },
                    { 32, 7, new DateTime(2023, 2, 3, 11, 46, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 3, 10, 30, 0, 0, DateTimeKind.Unspecified), 107 },
                    { 33, 7, new DateTime(2023, 2, 6, 14, 47, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 6, 13, 23, 0, 0, DateTimeKind.Unspecified), 108 },
                    { 34, 7, new DateTime(2023, 2, 7, 12, 30, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), 109 },
                    { 35, 7, new DateTime(2023, 2, 9, 13, 30, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 9, 11, 30, 0, 0, DateTimeKind.Unspecified), 111 },
                    { 36, 8, new DateTime(2023, 1, 30, 10, 45, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 1, 30, 9, 52, 0, 0, DateTimeKind.Unspecified), 119 },
                    { 37, 8, new DateTime(2023, 1, 31, 13, 36, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 1, 31, 11, 20, 0, 0, DateTimeKind.Unspecified), 120 },
                    { 38, 8, new DateTime(2023, 2, 1, 13, 54, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 1, 11, 43, 0, 0, DateTimeKind.Unspecified), 121 },
                    { 39, 8, new DateTime(2023, 2, 2, 10, 47, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 122 },
                    { 40, 8, new DateTime(2023, 2, 3, 12, 23, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 3, 10, 30, 0, 0, DateTimeKind.Unspecified), 123 },
                    { 41, 9, new DateTime(2023, 2, 2, 12, 20, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 138 },
                    { 42, 9, new DateTime(2023, 2, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 3, 11, 30, 0, 0, DateTimeKind.Unspecified), 139 },
                    { 43, 9, new DateTime(2023, 2, 6, 13, 45, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), 140 },
                    { 44, 9, new DateTime(2023, 2, 7, 15, 30, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 7, 14, 15, 0, 0, DateTimeKind.Unspecified), 141 },
                    { 45, 9, new DateTime(2023, 2, 8, 12, 40, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), 142 },
                    { 46, 10, new DateTime(2023, 2, 6, 11, 15, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), 156 },
                    { 47, 10, new DateTime(2023, 2, 7, 12, 40, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 7, 11, 15, 0, 0, DateTimeKind.Unspecified), 157 },
                    { 48, 10, new DateTime(2023, 2, 8, 15, 15, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 8, 14, 2, 0, 0, DateTimeKind.Unspecified), 158 },
                    { 49, 10, new DateTime(2023, 2, 9, 15, 30, 0, 0, DateTimeKind.Unspecified), false, "", new DateTime(2023, 2, 9, 13, 10, 0, 0, DateTimeKind.Unspecified), 159 },
                    { 50, 10, new DateTime(2023, 2, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), true, "", new DateTime(2023, 2, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 160 }
                });

            migrationBuilder.InsertData(
                table: "WorkingDays",
                columns: new[] { "Id", "EmployeeId", "End", "ExitId", "RecordTypeId", "Start" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 12, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2022, 12, 21, 17, 40, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2022, 12, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, new DateTime(2023, 1, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, new DateTime(2023, 1, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 5, new DateTime(2023, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, new DateTime(2023, 1, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 5, new DateTime(2023, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, new DateTime(2023, 1, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 5, new DateTime(2023, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, new DateTime(2023, 2, 1, 16, 50, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 1, new DateTime(2023, 2, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 1, new DateTime(2023, 2, 7, 18, 30, 0, 0, DateTimeKind.Unspecified), 5, 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 1, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 5, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 1, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 5, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 1, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 5, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 2, new DateTime(2022, 12, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 2, new DateTime(2022, 12, 21, 17, 30, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 2, new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 2, new DateTime(2022, 12, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, new DateTime(2022, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 2, new DateTime(2023, 1, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 2, new DateTime(2023, 1, 27, 16, 55, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 2, new DateTime(2023, 1, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, new DateTime(2023, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 2, new DateTime(2023, 1, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, new DateTime(2023, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 2, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 2, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 8, 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 2, new DateTime(2023, 2, 3, 18, 20, 0, 0, DateTimeKind.Unspecified), 9, 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 2, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 5, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 2, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 5, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 2, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 10, 1, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 2, new DateTime(2023, 2, 9, 15, 48, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 2, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 3, new DateTime(2022, 12, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), 11, 1, new DateTime(2022, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 3, new DateTime(2022, 12, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), 12, 1, new DateTime(2022, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 3, new DateTime(2022, 12, 19, 17, 45, 0, 0, DateTimeKind.Unspecified), 13, 1, new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 3, new DateTime(2022, 12, 22, 17, 55, 0, 0, DateTimeKind.Unspecified), 14, 1, new DateTime(2022, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 3, new DateTime(2023, 1, 26, 18, 30, 0, 0, DateTimeKind.Unspecified), 15, 1, new DateTime(2023, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 3, new DateTime(2023, 1, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 3, new DateTime(2023, 1, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 3, new DateTime(2023, 1, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 4, new DateTime(2023, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 3, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 4, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 3, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 3, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 3, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 3, new DateTime(2023, 2, 7, 16, 10, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 3, new DateTime(2023, 2, 8, 16, 38, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 3, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 5, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 3, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 4, new DateTime(2022, 12, 20, 16, 42, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 4, new DateTime(2022, 12, 21, 18, 5, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, 4, new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, 4, new DateTime(2022, 12, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, new DateTime(2022, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, 4, new DateTime(2023, 1, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, 4, new DateTime(2023, 1, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, 4, new DateTime(2023, 1, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, 4, new DateTime(2023, 1, 31, 17, 23, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, 4, new DateTime(2023, 2, 1, 17, 56, 0, 0, DateTimeKind.Unspecified), 16, 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, 4, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 17, 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, 4, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 18, 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, 4, new DateTime(2023, 2, 6, 18, 13, 0, 0, DateTimeKind.Unspecified), 19, 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, 4, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 20, 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, 4, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 5, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, 4, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, 4, new DateTime(2023, 2, 10, 16, 33, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, 5, new DateTime(2022, 12, 20, 18, 5, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, 5, new DateTime(2022, 12, 21, 17, 45, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, 5, new DateTime(2022, 12, 19, 17, 49, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, 5, new DateTime(2022, 12, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, 5, new DateTime(2023, 1, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, 5, new DateTime(2023, 1, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, new DateTime(2023, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, 5, new DateTime(2023, 1, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, new DateTime(2023, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, 5, new DateTime(2023, 1, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 4, new DateTime(2023, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, 5, new DateTime(2023, 2, 1, 18, 22, 0, 0, DateTimeKind.Unspecified), 21, 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, 5, new DateTime(2023, 2, 2, 18, 9, 0, 0, DateTimeKind.Unspecified), 22, 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, 5, new DateTime(2023, 2, 3, 17, 20, 0, 0, DateTimeKind.Unspecified), 23, 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, 5, new DateTime(2023, 2, 6, 16, 39, 0, 0, DateTimeKind.Unspecified), 24, 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, 5, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 25, 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, 5, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 5, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, 5, new DateTime(2023, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, 5, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, 6, new DateTime(2022, 12, 20, 18, 10, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, 6, new DateTime(2022, 12, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, new DateTime(2022, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, 6, new DateTime(2022, 12, 19, 17, 40, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, 6, new DateTime(2022, 12, 22, 17, 25, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, 6, new DateTime(2023, 1, 26, 18, 20, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, 6, new DateTime(2023, 1, 27, 17, 15, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, 6, new DateTime(2023, 1, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 5, new DateTime(2023, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, 6, new DateTime(2023, 1, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 5, new DateTime(2023, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, 6, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 26, 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, 6, new DateTime(2023, 2, 2, 17, 32, 0, 0, DateTimeKind.Unspecified), 27, 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, 6, new DateTime(2023, 2, 3, 17, 40, 0, 0, DateTimeKind.Unspecified), 28, 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, 6, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 29, 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, 6, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, 6, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 30, 1, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, 6, new DateTime(2023, 2, 9, 18, 9, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96, 6, new DateTime(2023, 2, 10, 17, 30, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, 7, new DateTime(2022, 12, 20, 18, 5, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, 7, new DateTime(2022, 12, 21, 17, 18, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99, 7, new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 5, new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, 7, new DateTime(2022, 12, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 5, new DateTime(2022, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 101, 7, new DateTime(2023, 1, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 102, 7, new DateTime(2023, 1, 27, 16, 20, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 103, 7, new DateTime(2023, 1, 30, 16, 45, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 104, 7, new DateTime(2023, 1, 31, 18, 10, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 105, 7, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 106, 7, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 31, 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 107, 7, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 32, 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 108, 7, new DateTime(2023, 2, 6, 17, 45, 0, 0, DateTimeKind.Unspecified), 33, 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 109, 7, new DateTime(2023, 2, 7, 17, 30, 0, 0, DateTimeKind.Unspecified), 34, 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 110, 7, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 111, 7, new DateTime(2023, 2, 9, 17, 30, 0, 0, DateTimeKind.Unspecified), 35, 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 112, 7, new DateTime(2023, 2, 10, 17, 15, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 113, 8, new DateTime(2022, 12, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 114, 8, new DateTime(2022, 12, 21, 17, 20, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 115, 8, new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 116, 8, new DateTime(2022, 12, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 117, 8, new DateTime(2023, 1, 26, 17, 45, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 118, 8, new DateTime(2023, 1, 27, 17, 55, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 119, 8, new DateTime(2023, 1, 30, 18, 10, 0, 0, DateTimeKind.Unspecified), 36, 1, new DateTime(2023, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 120, 8, new DateTime(2023, 1, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 37, 1, new DateTime(2023, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 121, 8, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 38, 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 122, 8, new DateTime(2023, 2, 2, 15, 47, 0, 0, DateTimeKind.Unspecified), 39, 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 123, 8, new DateTime(2023, 2, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 40, 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 124, 8, new DateTime(2023, 2, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 125, 8, new DateTime(2023, 2, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 126, 8, new DateTime(2023, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 4, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 127, 8, new DateTime(2023, 2, 9, 18, 20, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 128, 8, new DateTime(2023, 2, 10, 18, 10, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 129, 9, new DateTime(2022, 12, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 5, new DateTime(2022, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 130, 9, new DateTime(2022, 12, 21, 18, 2, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 131, 9, new DateTime(2022, 12, 19, 17, 50, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 132, 9, new DateTime(2022, 12, 22, 18, 30, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 133, 9, new DateTime(2023, 1, 26, 16, 20, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 134, 9, new DateTime(2023, 1, 27, 17, 45, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 135, 9, new DateTime(2023, 1, 30, 17, 55, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 136, 9, new DateTime(2023, 1, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, new DateTime(2023, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 137, 9, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 138, 9, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 41, 1, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 139, 9, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 42, 1, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 140, 9, new DateTime(2023, 2, 6, 18, 5, 0, 0, DateTimeKind.Unspecified), 43, 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 141, 9, new DateTime(2023, 2, 7, 18, 20, 0, 0, DateTimeKind.Unspecified), 44, 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 142, 9, new DateTime(2023, 2, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), 45, 1, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 143, 9, new DateTime(2023, 2, 9, 17, 18, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 144, 9, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 145, 10, new DateTime(2022, 12, 20, 16, 10, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 146, 10, new DateTime(2022, 12, 21, 16, 45, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 147, 10, new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 5, new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 148, 10, new DateTime(2022, 12, 22, 18, 10, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2022, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 149, 10, new DateTime(2023, 1, 26, 18, 22, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 150, 10, new DateTime(2023, 1, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, new DateTime(2023, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 151, 10, new DateTime(2023, 1, 30, 17, 45, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 152, 10, new DateTime(2023, 1, 31, 17, 55, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 1, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 153, 10, new DateTime(2023, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 154, 10, new DateTime(2023, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 4, new DateTime(2023, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 155, 10, new DateTime(2023, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 0, 4, new DateTime(2023, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 156, 10, new DateTime(2023, 2, 6, 17, 15, 0, 0, DateTimeKind.Unspecified), 46, 1, new DateTime(2023, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 157, 10, new DateTime(2023, 2, 7, 17, 30, 0, 0, DateTimeKind.Unspecified), 47, 1, new DateTime(2023, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 158, 10, new DateTime(2023, 2, 8, 17, 45, 0, 0, DateTimeKind.Unspecified), 48, 1, new DateTime(2023, 2, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 159, 10, new DateTime(2023, 2, 9, 18, 30, 0, 0, DateTimeKind.Unspecified), 49, 1, new DateTime(2023, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 160, 10, new DateTime(2023, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 50, 1, new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Exits_EmployeeId",
                table: "Exits",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkingDays_EmployeeId",
                table: "WorkingDays",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Exits");

            migrationBuilder.DropTable(
                name: "RecordTypes");

            migrationBuilder.DropTable(
                name: "WorkingDays");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
