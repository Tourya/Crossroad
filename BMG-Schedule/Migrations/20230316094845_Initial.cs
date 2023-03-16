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
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "3b0c4605-3cd7-46f4-9efd-5378317f938d", "Role", "User", "USER" },
                    { 2, "505d5152-6601-42e8-a6b9-e63316d21ee2", "Role", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "Info", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "8d40da25-f1fb-4017-8e8d-09972fe6c024", "Employee", "migleva@abv.bg", false, "Миглена", null, "Велева", false, null, "MIGLEVA@ABV.BG", "MIGLEVA@ABV.BG", "AQAAAAEAACcQAAAAEJtl8roIhH7G182nKySq/3fzJKiB9Tv560EGZMMu0YBXVJsAINu7UCtjLc+LRePF5Q==", null, false, "c1bce49d-dd20-4845-abd1-d8bbc2deb84a", false, "migleva@abv.bg" },
                    { 2, 0, "fe7a15ce-a9f7-48f0-aa2f-3d860b5b5918", "Employee", "ivan_petrov@abv.bg", false, "Иван", null, "Петров", false, null, "IVAN_PETROV@ABV.BG", "IVAN_PETROV@ABV.BG", "AQAAAAEAACcQAAAAEJQRyoEkDoGUjwkrqTzZe7ingto3fUnfOgvcZ/rp2FpD6IeJoJR27qypmHv37uqn4g==", null, false, "1b487067-9c5c-4f84-a800-b13f688b71aa", false, "ivan_petrov@abv.bg" },
                    { 3, 0, "8e6bd8b3-5dd9-4d47-9422-a9dcad7dd39f", "Employee", "n.popov@gmail.com", false, "Никола", null, "Попов", false, null, "N.POPOV@GMAIL.COM", "N.POPOV@GMAIL.COM", "AQAAAAEAACcQAAAAEA5bPc2idsWtk1vYYa9oOduqy900xOGO/9ZBVqVWWr1QwLhoZ0eeRDb7lZTUK9g/ng==", null, false, "30f4f320-7b19-4bb1-b41a-fc94646b40bc", false, "n.popov@gmail.com" },
                    { 4, 0, "1dbeae75-e8ac-4c9c-a56d-797d9ade7ff1", "Employee", "stevka_52@gmail.com", false, "Стефка", null, "Стоянова", false, null, "STEFKA_52@GMAIL.COM", "STEFKA_52@GMAIL.COM", "AQAAAAEAACcQAAAAEMFKxvfHpIsuWsxG24D8tSjx9twyjDroJp8TO2XMR5Cldn+wz5tMzcHmN7R3pQrpjQ==", null, false, "7d5e062f-b7ba-408c-93bd-9e67201c4026", false, "stevka_52@gmail.com" },
                    { 5, 0, "b8935528-a656-4a45-bcb4-5517f709d4cb", "Employee", "maria_doneva@yahoo.com", false, "Мария", null, "Донева", false, null, "MARIA_DONEVA@YAHOO.COM", "MARIA_DONEVA@YAHOO.COM", "AQAAAAEAACcQAAAAEHMJIVi4YNM2xIMdH6aZkFm8tS4OVp3dBkhujy8nejZr7hYFjNmrFPkR2pjavSp/SA==", null, false, "d6c3b359-e6c0-4e8c-96dc-e0d8589cedbd", false, "maria_doneva@yahoo.com" },
                    { 6, 0, "78befb7c-8cb5-4560-a104-522b74d2accf", "Employee", "georgi_mitev@abv.bg", false, "Георги", null, "Митев", false, null, "GEORGI_MITEV@ABV.BG", "GEORGI_MITEV@ABV.BG", "AQAAAAEAACcQAAAAEIx06K+7BR1BQr2OoBjXC153bvSBMTcnjB8nOAR3RTBI73OGs+iSQuR2u8+11ZB30g==", null, false, "cfb74e8b-e496-4ff2-8df1-cd54c17cfeed", false, "georgi_mitev@abv.bg" },
                    { 7, 0, "6cd7290a-d9de-4aae-8113-e19b91862969", "Employee", "pnikolov@gmail.com", false, "Петър", null, "Николов", false, null, "PNIKOLOV@GMAIL.COM", "PNIKOLOV@GMAIL.COM", "AQAAAAEAACcQAAAAEC8P8wIb/U+UvZUUcfZqSwpZNwbY4QcgV3vez+CiUZuL8Irp1ukGmzEB2p24YxQ7zw==", null, false, "c119fd12-ae96-4804-a879-65146c1abba4", false, "pnikolov@gmail.com" },
                    { 8, 0, "ca356097-f9d1-4619-8d16-4a98da6a4ebf", "Employee", "pavel_popov@yahoo.com", false, "Павел", null, "Попов", false, null, "PAVEL_POPOV@YAHOO.COM", "PAVEL_POPOV@YAHOO.COM", "AQAAAAEAACcQAAAAEMniDsdbyyF58aMaKZMNlBTwpUnuyLZ+TFKOTUKVUAiyipNyQ6up+R+MBVV8JdhJng==", null, false, "f759d1d2-fd79-4dbb-8acd-923874cc98e5", false, "pavel_popov@yahoo.com" },
                    { 9, 0, "f7836c52-773d-43d5-94e0-8c276d897ff3", "Employee", "s_konstantinov@gmail.com", false, "Стоян", null, "Константинов", false, null, "S_KONSTANTINOV@GMAIL.COM", "S_KONSTANTINOV@GMAIL.COM", "AQAAAAEAACcQAAAAEA6ZUiGBs4WKJzUak2UQjmHaaCgDKcsxO9SKhivfI6t1fDnYSl3q501bcmLzCurFqQ==", null, false, "78b95e8e-ccce-4aab-a36f-ed5cf299c224", false, "s_konstantinov@gmail.com" },
                    { 10, 0, "74b82b5f-0161-4b67-ae1f-aeaa505d7ecc", "Employee", "gg_stoyanova@gbg.bg", false, "Галя", null, "Стоянова", false, null, "GG_STOYANOVA@GBG.BG", "GG_STOYANOVA@GBG.BG", "AQAAAAEAACcQAAAAEGTdiDURuVByi0iv2Fj1aEjekpWRYYcLfXuGWbSA6wd1xklX2NTd3h2K5RhDANf+7A==", null, false, "ff7e17e8-494f-496e-896e-676d226e70f2", false, "gg_stoyanova@gbg.bg" }
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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 }
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
