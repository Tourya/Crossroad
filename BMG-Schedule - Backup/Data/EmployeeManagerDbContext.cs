using BMG_Schedule.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BMG_Schedule.Data
{
    public class EmployeeManagerDbContext : DbContext
    {
        public EmployeeManagerDbContext(DbContextOptions<EmployeeManagerDbContext> options) : base(options) { }

        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<RecordType> RecordTypes => Set<RecordType>();
        public DbSet<WorkingDay> WorkingDays => Set<WorkingDay>();
        public DbSet<Exit> Exits => Set<Exit>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                .HasData(
                new Employee { Id = 1, FirstName = "Миглена", LastName = "Велева" },
                new Employee { Id = 2, FirstName = "Иван", LastName = "Петров" },
                new Employee { Id = 3, FirstName = "Никола", LastName = "Попов" },
                new Employee { Id = 4, FirstName = "Стефка", LastName = "Стоянова" },
                new Employee { Id = 5, FirstName = "Мария", LastName = "Донева" },
                new Employee { Id = 6, FirstName = "Георги", LastName = "Митев" },
                new Employee { Id = 7, FirstName = "Петър", LastName = "Николов" },
                new Employee { Id = 8, FirstName = "Павел", LastName = "Попов" },
                new Employee { Id = 9, FirstName = "Стоян", LastName = "Константинов" },
                new Employee { Id = 10, FirstName = "Галя", LastName = "Стоянова" }
                );

            modelBuilder.Entity<RecordType>().HasData(
                new RecordType { Id = 1, Name = "Работен ден" },
                new RecordType { Id = 2, Name = "Командировка" },
                new RecordType { Id = 3, Name = "Отпуск - платен" },
                new RecordType { Id = 4, Name = "Отпуск - неплатен" },
                new RecordType { Id = 5, Name = "Болнични" }
                );

            modelBuilder.Entity<WorkingDay>()
                .HasData(
                new WorkingDay { Id = 1, Start = new DateTime(2022, 12, 20, 09, 00, 00), End = new DateTime(2022, 12, 20, 18, 00, 00), RecordTypeId = 1, EmployeeId = 1 },
                new WorkingDay { Id = 2, Start = new DateTime(2022, 12, 21, 09, 00, 00), End = new DateTime(2022, 12, 21, 17, 40, 00), RecordTypeId = 1, EmployeeId = 1 },
                new WorkingDay { Id = 3, Start = new DateTime(2022, 12, 19, 09, 00, 00), End = new DateTime(2022, 12, 19, 18, 00, 00), RecordTypeId = 1, EmployeeId = 1 },
                new WorkingDay { Id = 4, Start = new DateTime(2022, 12, 22, 09, 00, 00), End = new DateTime(2022, 12, 22, 17, 00, 00), RecordTypeId = 1, EmployeeId = 1 },
                new WorkingDay { Id = 5, Start = new DateTime(2023, 01, 26, 09, 00, 00), End = new DateTime(2023, 01, 26, 18, 00, 00), RecordTypeId = 1, EmployeeId = 1 },
                new WorkingDay { Id = 6, Start = new DateTime(2023, 01, 27, 09, 00, 00), End = new DateTime(2023, 01, 27, 18, 00, 00), RecordTypeId = 5, EmployeeId = 1 },
                new WorkingDay { Id = 7, Start = new DateTime(2023, 01, 30, 09, 00, 00), End = new DateTime(2023, 01, 30, 18, 00, 00), RecordTypeId = 5, EmployeeId = 1 },
                new WorkingDay { Id = 8, Start = new DateTime(2023, 01, 31, 09, 00, 00), End = new DateTime(2023, 01, 31, 18, 00, 00), RecordTypeId = 5, EmployeeId = 1 },
                new WorkingDay { Id = 9, Start = new DateTime(2023, 02, 01, 09, 00, 00), End = new DateTime(2023, 02, 01, 16, 50, 00), RecordTypeId = 1, EmployeeId = 1, ExitId = 1 },
                new WorkingDay { Id = 10, Start = new DateTime(2023, 02, 02, 09, 00, 00), End = new DateTime(2023, 02, 02, 18, 00, 00), RecordTypeId = 1, EmployeeId = 1, ExitId = 2 },
                new WorkingDay { Id = 11, Start = new DateTime(2023, 02, 03, 09, 00, 00), End = new DateTime(2023, 02, 03, 18, 00, 00), RecordTypeId = 1, EmployeeId = 1, ExitId = 3 },
                new WorkingDay { Id = 12, Start = new DateTime(2023, 02, 06, 09, 00, 00), End = new DateTime(2023, 02, 06, 17, 00, 00), RecordTypeId = 1, EmployeeId = 1, ExitId = 4 },
                new WorkingDay { Id = 13, Start = new DateTime(2023, 02, 07, 09, 00, 00), End = new DateTime(2023, 02, 07, 18, 30, 00), RecordTypeId = 1, EmployeeId = 1, ExitId = 5 },
                new WorkingDay { Id = 14, Start = new DateTime(2023, 02, 08, 09, 00, 00), End = new DateTime(2023, 02, 08, 18, 00, 00), RecordTypeId = 5, EmployeeId = 1 },
                new WorkingDay { Id = 15, Start = new DateTime(2023, 02, 09, 09, 00, 00), End = new DateTime(2023, 02, 09, 18, 00, 00), RecordTypeId = 5, EmployeeId = 1 },
                new WorkingDay { Id = 16, Start = new DateTime(2023, 02, 10, 09, 00, 00), End = new DateTime(2023, 02, 10, 18, 00, 00), RecordTypeId = 5, EmployeeId = 1 },

                new WorkingDay { Id = 17, Start = new DateTime(2022, 12, 20, 09, 00, 00), End = new DateTime(2022, 12, 20, 18, 00, 00), RecordTypeId = 1, EmployeeId = 2 },
                new WorkingDay { Id = 18, Start = new DateTime(2022, 12, 21, 09, 00, 00), End = new DateTime(2022, 12, 21, 17, 30, 00), RecordTypeId = 1, EmployeeId = 2 },
                new WorkingDay { Id = 19, Start = new DateTime(2022, 12, 19, 09, 00, 00), End = new DateTime(2022, 12, 19, 18, 00, 00), RecordTypeId = 3, EmployeeId = 2 },
                new WorkingDay { Id = 20, Start = new DateTime(2022, 12, 22, 09, 00, 00), End = new DateTime(2022, 12, 22, 18, 00, 00), RecordTypeId = 3, EmployeeId = 2 },
                new WorkingDay { Id = 21, Start = new DateTime(2023, 01, 26, 09, 00, 00), End = new DateTime(2023, 01, 26, 18, 00, 00), RecordTypeId = 1, EmployeeId = 2 },
                new WorkingDay { Id = 22, Start = new DateTime(2023, 01, 27, 09, 00, 00), End = new DateTime(2023, 01, 27, 16, 55, 00), RecordTypeId = 1, EmployeeId = 2 },
                new WorkingDay { Id = 23, Start = new DateTime(2023, 01, 30, 09, 00, 00), End = new DateTime(2023, 01, 30, 18, 00, 00), RecordTypeId = 2, EmployeeId = 2 },
                new WorkingDay { Id = 24, Start = new DateTime(2023, 01, 31, 09, 00, 00), End = new DateTime(2023, 01, 31, 18, 00, 00), RecordTypeId = 1, EmployeeId = 2, ExitId = 6 },
                new WorkingDay { Id = 25, Start = new DateTime(2023, 02, 01, 09, 00, 00), End = new DateTime(2023, 02, 01, 18, 00, 00), RecordTypeId = 1, EmployeeId = 2, ExitId = 7 },
                new WorkingDay { Id = 26, Start = new DateTime(2023, 02, 02, 09, 00, 00), End = new DateTime(2023, 02, 02, 18, 00, 00), RecordTypeId = 1, EmployeeId = 2, ExitId = 8 },
                new WorkingDay { Id = 27, Start = new DateTime(2023, 02, 03, 09, 00, 00), End = new DateTime(2023, 02, 03, 18, 20, 00), RecordTypeId = 1, EmployeeId = 2, ExitId = 9 },
                new WorkingDay { Id = 28, Start = new DateTime(2023, 02, 06, 09, 00, 00), End = new DateTime(2023, 02, 06, 18, 00, 00), RecordTypeId = 5, EmployeeId = 2 },
                new WorkingDay { Id = 29, Start = new DateTime(2023, 02, 07, 09, 00, 00), End = new DateTime(2023, 02, 07, 18, 00, 00), RecordTypeId = 5, EmployeeId = 2 },
                new WorkingDay { Id = 30, Start = new DateTime(2023, 02, 08, 09, 00, 00), End = new DateTime(2023, 02, 08, 18, 00, 00), RecordTypeId = 1, EmployeeId = 2, ExitId = 10 },
                new WorkingDay { Id = 31, Start = new DateTime(2023, 02, 09, 09, 00, 00), End = new DateTime(2023, 02, 09, 15, 48, 00), RecordTypeId = 1, EmployeeId = 2 },
                new WorkingDay { Id = 32, Start = new DateTime(2023, 02, 10, 09, 00, 00), End = new DateTime(2023, 02, 10, 18, 00, 00), RecordTypeId = 1, EmployeeId = 2 },

                new WorkingDay { Id = 33, Start = new DateTime(2022, 12, 20, 09, 00, 00), End = new DateTime(2022, 12, 20, 18, 00, 00), RecordTypeId = 1, EmployeeId = 3, ExitId = 11 },
                new WorkingDay { Id = 34, Start = new DateTime(2022, 12, 21, 09, 00, 00), End = new DateTime(2022, 12, 21, 18, 00, 00), RecordTypeId = 1, EmployeeId = 3, ExitId = 12 },
                new WorkingDay { Id = 35, Start = new DateTime(2022, 12, 19, 09, 00, 00), End = new DateTime(2022, 12, 19, 17, 45, 00), RecordTypeId = 1, EmployeeId = 3, ExitId = 13 },
                new WorkingDay { Id = 36, Start = new DateTime(2022, 12, 22, 09, 00, 00), End = new DateTime(2022, 12, 22, 17, 55, 00), RecordTypeId = 1, EmployeeId = 3, ExitId = 14 },
                new WorkingDay { Id = 37, Start = new DateTime(2023, 01, 26, 09, 00, 00), End = new DateTime(2023, 01, 26, 18, 30, 00), RecordTypeId = 1, EmployeeId = 3, ExitId = 15 },
                new WorkingDay { Id = 38, Start = new DateTime(2023, 01, 27, 09, 00, 00), End = new DateTime(2023, 01, 27, 18, 00, 00), RecordTypeId = 1, EmployeeId = 3 },
                new WorkingDay { Id = 39, Start = new DateTime(2023, 01, 30, 09, 00, 00), End = new DateTime(2023, 01, 30, 18, 00, 00), RecordTypeId = 1, EmployeeId = 3 },
                new WorkingDay { Id = 40, Start = new DateTime(2023, 01, 31, 09, 00, 00), End = new DateTime(2023, 01, 31, 18, 00, 00), RecordTypeId = 4, EmployeeId = 3 },
                new WorkingDay { Id = 41, Start = new DateTime(2023, 02, 01, 09, 00, 00), End = new DateTime(2023, 02, 01, 18, 00, 00), RecordTypeId = 4, EmployeeId = 3 },
                new WorkingDay { Id = 42, Start = new DateTime(2023, 02, 02, 09, 00, 00), End = new DateTime(2023, 02, 02, 18, 00, 00), RecordTypeId = 1, EmployeeId = 3 },
                new WorkingDay { Id = 43, Start = new DateTime(2023, 02, 03, 09, 00, 00), End = new DateTime(2023, 02, 03, 18, 00, 00), RecordTypeId = 1, EmployeeId = 3 },
                new WorkingDay { Id = 44, Start = new DateTime(2023, 02, 06, 09, 00, 00), End = new DateTime(2023, 02, 06, 18, 00, 00), RecordTypeId = 1, EmployeeId = 3 },
                new WorkingDay { Id = 45, Start = new DateTime(2023, 02, 07, 09, 00, 00), End = new DateTime(2023, 02, 07, 16, 10, 00), RecordTypeId = 1, EmployeeId = 3 },
                new WorkingDay { Id = 46, Start = new DateTime(2023, 02, 08, 09, 00, 00), End = new DateTime(2023, 02, 08, 16, 38, 00), RecordTypeId = 1, EmployeeId = 3 },
                new WorkingDay { Id = 47, Start = new DateTime(2023, 02, 09, 09, 00, 00), End = new DateTime(2023, 02, 09, 18, 00, 00), RecordTypeId = 5, EmployeeId = 3 },
                new WorkingDay { Id = 48, Start = new DateTime(2023, 02, 10, 09, 00, 00), End = new DateTime(2023, 02, 10, 18, 00, 00), RecordTypeId = 1, EmployeeId = 3 },

                new WorkingDay { Id = 49, Start = new DateTime(2022, 12, 20, 09, 00, 00), End = new DateTime(2022, 12, 20, 16, 42, 00), RecordTypeId = 1, EmployeeId = 4 },
                new WorkingDay { Id = 50, Start = new DateTime(2022, 12, 21, 09, 00, 00), End = new DateTime(2022, 12, 21, 18, 05, 00), RecordTypeId = 1, EmployeeId = 4 },
                new WorkingDay { Id = 51, Start = new DateTime(2022, 12, 19, 09, 00, 00), End = new DateTime(2022, 12, 19, 18, 00, 00), RecordTypeId = 2, EmployeeId = 4 },
                new WorkingDay { Id = 52, Start = new DateTime(2022, 12, 22, 09, 00, 00), End = new DateTime(2022, 12, 22, 18, 00, 00), RecordTypeId = 2, EmployeeId = 4 },
                new WorkingDay { Id = 53, Start = new DateTime(2023, 01, 26, 09, 00, 00), End = new DateTime(2023, 01, 26, 18, 00, 00), RecordTypeId = 1, EmployeeId = 4 },
                new WorkingDay { Id = 54, Start = new DateTime(2023, 01, 27, 09, 00, 00), End = new DateTime(2023, 01, 27, 18, 00, 00), RecordTypeId = 1, EmployeeId = 4 },
                new WorkingDay { Id = 55, Start = new DateTime(2023, 01, 30, 09, 00, 00), End = new DateTime(2023, 01, 30, 18, 00, 00), RecordTypeId = 1, EmployeeId = 4 },
                new WorkingDay { Id = 56, Start = new DateTime(2023, 01, 31, 09, 00, 00), End = new DateTime(2023, 01, 31, 17, 23, 00), RecordTypeId = 1, EmployeeId = 4 },
                new WorkingDay { Id = 57, Start = new DateTime(2023, 02, 01, 09, 00, 00), End = new DateTime(2023, 02, 01, 17, 56, 00), RecordTypeId = 1, EmployeeId = 4, ExitId = 16 },
                new WorkingDay { Id = 58, Start = new DateTime(2023, 02, 02, 09, 00, 00), End = new DateTime(2023, 02, 02, 18, 00, 00), RecordTypeId = 1, EmployeeId = 4, ExitId = 17 },
                new WorkingDay { Id = 59, Start = new DateTime(2023, 02, 03, 09, 00, 00), End = new DateTime(2023, 02, 03, 18, 00, 00), RecordTypeId = 1, EmployeeId = 4, ExitId = 18 },
                new WorkingDay { Id = 60, Start = new DateTime(2023, 02, 06, 09, 00, 00), End = new DateTime(2023, 02, 06, 18, 13, 00), RecordTypeId = 1, EmployeeId = 4, ExitId = 19 },
                new WorkingDay { Id = 61, Start = new DateTime(2023, 02, 07, 09, 00, 00), End = new DateTime(2023, 02, 07, 18, 00, 00), RecordTypeId = 1, EmployeeId = 4, ExitId = 20 },
                new WorkingDay { Id = 62, Start = new DateTime(2023, 02, 08, 09, 00, 00), End = new DateTime(2023, 02, 08, 18, 00, 00), RecordTypeId = 5, EmployeeId = 4 },
                new WorkingDay { Id = 63, Start = new DateTime(2023, 02, 09, 09, 00, 00), End = new DateTime(2023, 02, 09, 18, 00, 00), RecordTypeId = 1, EmployeeId = 4 },
                new WorkingDay { Id = 64, Start = new DateTime(2023, 02, 10, 09, 00, 00), End = new DateTime(2023, 02, 10, 16, 33, 00), RecordTypeId = 1, EmployeeId = 4 },

                new WorkingDay { Id = 65, Start = new DateTime(2022, 12, 20, 09, 00, 00), End = new DateTime(2022, 12, 20, 18, 05, 00), RecordTypeId = 1, EmployeeId = 5 },
                new WorkingDay { Id = 66, Start = new DateTime(2022, 12, 21, 09, 00, 00), End = new DateTime(2022, 12, 21, 17, 45, 00), RecordTypeId = 1, EmployeeId = 5 },
                new WorkingDay { Id = 67, Start = new DateTime(2022, 12, 19, 09, 00, 00), End = new DateTime(2022, 12, 19, 17, 49, 00), RecordTypeId = 1, EmployeeId = 5 },
                new WorkingDay { Id = 68, Start = new DateTime(2022, 12, 22, 09, 00, 00), End = new DateTime(2022, 12, 22, 18, 00, 00), RecordTypeId = 1, EmployeeId = 5 },
                new WorkingDay { Id = 69, Start = new DateTime(2023, 01, 26, 09, 00, 00), End = new DateTime(2023, 01, 26, 18, 00, 00), RecordTypeId = 1, EmployeeId = 5 },
                new WorkingDay { Id = 70, Start = new DateTime(2023, 01, 27, 09, 00, 00), End = new DateTime(2023, 01, 27, 18, 00, 00), RecordTypeId = 3, EmployeeId = 5 },
                new WorkingDay { Id = 71, Start = new DateTime(2023, 01, 30, 09, 00, 00), End = new DateTime(2023, 01, 30, 18, 00, 00), RecordTypeId = 3, EmployeeId = 5 },
                new WorkingDay { Id = 72, Start = new DateTime(2023, 01, 31, 09, 00, 00), End = new DateTime(2023, 01, 31, 18, 00, 00), RecordTypeId = 4, EmployeeId = 5 },
                new WorkingDay { Id = 73, Start = new DateTime(2023, 02, 01, 09, 00, 00), End = new DateTime(2023, 02, 01, 18, 22, 00), RecordTypeId = 1, EmployeeId = 5, ExitId = 21 },
                new WorkingDay { Id = 74, Start = new DateTime(2023, 02, 02, 09, 00, 00), End = new DateTime(2023, 02, 02, 18, 09, 00), RecordTypeId = 1, EmployeeId = 5, ExitId = 22 },
                new WorkingDay { Id = 75, Start = new DateTime(2023, 02, 03, 09, 00, 00), End = new DateTime(2023, 02, 03, 17, 20, 00), RecordTypeId = 1, EmployeeId = 5, ExitId = 23 },
                new WorkingDay { Id = 76, Start = new DateTime(2023, 02, 06, 09, 00, 00), End = new DateTime(2023, 02, 06, 16, 39, 00), RecordTypeId = 1, EmployeeId = 5, ExitId = 24 },
                new WorkingDay { Id = 77, Start = new DateTime(2023, 02, 07, 09, 00, 00), End = new DateTime(2023, 02, 07, 18, 00, 00), RecordTypeId = 1, EmployeeId = 5, ExitId = 25 },
                new WorkingDay { Id = 78, Start = new DateTime(2023, 02, 08, 09, 00, 00), End = new DateTime(2023, 02, 08, 18, 00, 00), RecordTypeId = 5, EmployeeId = 5 },
                new WorkingDay { Id = 79, Start = new DateTime(2023, 02, 09, 09, 00, 00), End = new DateTime(2023, 02, 09, 18, 00, 00), RecordTypeId = 1, EmployeeId = 5 },
                new WorkingDay { Id = 80, Start = new DateTime(2023, 02, 10, 09, 00, 00), End = new DateTime(2023, 02, 10, 18, 00, 00), RecordTypeId = 1, EmployeeId = 5 },

                new WorkingDay { Id = 81, Start = new DateTime(2022, 12, 20, 09, 00, 00), End = new DateTime(2022, 12, 20, 18, 10, 00), RecordTypeId = 1, EmployeeId = 6 },
                new WorkingDay { Id = 82, Start = new DateTime(2022, 12, 21, 09, 00, 00), End = new DateTime(2022, 12, 21, 18, 00, 00), RecordTypeId = 2, EmployeeId = 6 },
                new WorkingDay { Id = 83, Start = new DateTime(2022, 12, 19, 09, 00, 00), End = new DateTime(2022, 12, 19, 17, 40, 00), RecordTypeId = 1, EmployeeId = 6 },
                new WorkingDay { Id = 84, Start = new DateTime(2022, 12, 22, 09, 00, 00), End = new DateTime(2022, 12, 22, 17, 25, 00), RecordTypeId = 1, EmployeeId = 6 },
                new WorkingDay { Id = 85, Start = new DateTime(2023, 01, 26, 09, 00, 00), End = new DateTime(2023, 01, 26, 18, 20, 00), RecordTypeId = 1, EmployeeId = 6 },
                new WorkingDay { Id = 86, Start = new DateTime(2023, 01, 27, 09, 00, 00), End = new DateTime(2023, 01, 27, 17, 15, 00), RecordTypeId = 1, EmployeeId = 6 },
                new WorkingDay { Id = 87, Start = new DateTime(2023, 01, 30, 09, 00, 00), End = new DateTime(2023, 01, 30, 18, 00, 00), RecordTypeId = 5, EmployeeId = 6 },
                new WorkingDay { Id = 88, Start = new DateTime(2023, 01, 31, 09, 00, 00), End = new DateTime(2023, 01, 31, 18, 00, 00), RecordTypeId = 5, EmployeeId = 6 },
                new WorkingDay { Id = 89, Start = new DateTime(2023, 02, 01, 09, 00, 00), End = new DateTime(2023, 02, 01, 18, 00, 00), RecordTypeId = 1, EmployeeId = 6, ExitId = 26 },
                new WorkingDay { Id = 90, Start = new DateTime(2023, 02, 02, 09, 00, 00), End = new DateTime(2023, 02, 02, 17, 32, 00), RecordTypeId = 1, EmployeeId = 6, ExitId = 27 },
                new WorkingDay { Id = 91, Start = new DateTime(2023, 02, 03, 09, 00, 00), End = new DateTime(2023, 02, 03, 17, 40, 00), RecordTypeId = 1, EmployeeId = 6, ExitId = 28 },
                new WorkingDay { Id = 92, Start = new DateTime(2023, 02, 06, 09, 00, 00), End = new DateTime(2023, 02, 06, 18, 00, 00), RecordTypeId = 1, EmployeeId = 6, ExitId = 29 },
                new WorkingDay { Id = 93, Start = new DateTime(2023, 02, 07, 09, 00, 00), End = new DateTime(2023, 02, 07, 18, 00, 00), RecordTypeId = 3, EmployeeId = 6 },
                new WorkingDay { Id = 94, Start = new DateTime(2023, 02, 08, 09, 00, 00), End = new DateTime(2023, 02, 08, 18, 00, 00), RecordTypeId = 1, EmployeeId = 6, ExitId = 30 },
                new WorkingDay { Id = 95, Start = new DateTime(2023, 02, 09, 09, 00, 00), End = new DateTime(2023, 02, 09, 18, 09, 00), RecordTypeId = 1, EmployeeId = 6 },
                new WorkingDay { Id = 96, Start = new DateTime(2023, 02, 10, 09, 00, 00), End = new DateTime(2023, 02, 10, 17, 30, 00), RecordTypeId = 1, EmployeeId = 6 },

                new WorkingDay { Id = 97, Start = new DateTime(2022, 12, 20, 09, 00, 00), End = new DateTime(2022, 12, 20, 18, 05, 00), RecordTypeId = 1, EmployeeId = 7 },
                new WorkingDay { Id = 98, Start = new DateTime(2022, 12, 21, 09, 00, 00), End = new DateTime(2022, 12, 21, 17, 18, 00), RecordTypeId = 1, EmployeeId = 7 },
                new WorkingDay { Id = 99, Start = new DateTime(2022, 12, 19, 09, 00, 00), End = new DateTime(2022, 12, 19, 18, 00, 00), RecordTypeId = 5, EmployeeId = 7 },
                new WorkingDay { Id = 100, Start = new DateTime(2022, 12, 22, 09, 00, 00), End = new DateTime(2022, 12, 22, 18, 00, 00), RecordTypeId = 5, EmployeeId = 7 },
                new WorkingDay { Id = 101, Start = new DateTime(2023, 01, 26, 09, 00, 00), End = new DateTime(2023, 01, 26, 18, 00, 00), RecordTypeId = 1, EmployeeId = 7 },
                new WorkingDay { Id = 102, Start = new DateTime(2023, 01, 27, 09, 00, 00), End = new DateTime(2023, 01, 27, 16, 20, 00), RecordTypeId = 1, EmployeeId = 7 },
                new WorkingDay { Id = 103, Start = new DateTime(2023, 01, 30, 09, 00, 00), End = new DateTime(2023, 01, 30, 16, 45, 00), RecordTypeId = 1, EmployeeId = 7 },
                new WorkingDay { Id = 104, Start = new DateTime(2023, 01, 31, 09, 00, 00), End = new DateTime(2023, 01, 31, 18, 10, 00), RecordTypeId = 1, EmployeeId = 7 },
                new WorkingDay { Id = 105, Start = new DateTime(2023, 02, 01, 09, 00, 00), End = new DateTime(2023, 02, 01, 18, 00, 00), RecordTypeId = 3, EmployeeId = 7 },
                new WorkingDay { Id = 106, Start = new DateTime(2023, 02, 02, 09, 00, 00), End = new DateTime(2023, 02, 02, 18, 00, 00), RecordTypeId = 1, EmployeeId = 7, ExitId = 31 },
                new WorkingDay { Id = 107, Start = new DateTime(2023, 02, 03, 09, 00, 00), End = new DateTime(2023, 02, 03, 18, 00, 00), RecordTypeId = 1, EmployeeId = 7, ExitId = 32 },
                new WorkingDay { Id = 108, Start = new DateTime(2023, 02, 06, 09, 00, 00), End = new DateTime(2023, 02, 06, 17, 45, 00), RecordTypeId = 1, EmployeeId = 7, ExitId = 33 },
                new WorkingDay { Id = 109, Start = new DateTime(2023, 02, 07, 09, 00, 00), End = new DateTime(2023, 02, 07, 17, 30, 00), RecordTypeId = 1, EmployeeId = 7, ExitId = 34 },
                new WorkingDay { Id = 110, Start = new DateTime(2023, 02, 08, 09, 00, 00), End = new DateTime(2023, 02, 08, 18, 00, 00), RecordTypeId = 2, EmployeeId = 7 },
                new WorkingDay { Id = 111, Start = new DateTime(2023, 02, 09, 09, 00, 00), End = new DateTime(2023, 02, 09, 17, 30, 00), RecordTypeId = 1, EmployeeId = 7, ExitId = 35 },
                new WorkingDay { Id = 112, Start = new DateTime(2023, 02, 10, 09, 00, 00), End = new DateTime(2023, 02, 10, 17, 15, 00), RecordTypeId = 1, EmployeeId = 7 },

                new WorkingDay { Id = 113, Start = new DateTime(2022, 12, 20, 09, 00, 00), End = new DateTime(2022, 12, 20, 16, 30, 00), RecordTypeId = 1, EmployeeId = 8 },
                new WorkingDay { Id = 114, Start = new DateTime(2022, 12, 21, 09, 00, 00), End = new DateTime(2022, 12, 21, 17, 20, 00), RecordTypeId = 1, EmployeeId = 8 },
                new WorkingDay { Id = 115, Start = new DateTime(2022, 12, 19, 09, 00, 00), End = new DateTime(2022, 12, 19, 18, 00, 00), RecordTypeId = 2, EmployeeId = 8 },
                new WorkingDay { Id = 116, Start = new DateTime(2022, 12, 22, 09, 00, 00), End = new DateTime(2022, 12, 22, 18, 00, 00), RecordTypeId = 1, EmployeeId = 8 },
                new WorkingDay { Id = 117, Start = new DateTime(2023, 01, 26, 09, 00, 00), End = new DateTime(2023, 01, 26, 17, 45, 00), RecordTypeId = 1, EmployeeId = 8 },
                new WorkingDay { Id = 118, Start = new DateTime(2023, 01, 27, 09, 00, 00), End = new DateTime(2023, 01, 27, 17, 55, 00), RecordTypeId = 1, EmployeeId = 8 },
                new WorkingDay { Id = 119, Start = new DateTime(2023, 01, 30, 09, 00, 00), End = new DateTime(2023, 01, 30, 18, 10, 00), RecordTypeId = 1, EmployeeId = 8, ExitId = 36 },
                new WorkingDay { Id = 120, Start = new DateTime(2023, 01, 31, 09, 00, 00), End = new DateTime(2023, 01, 31, 18, 00, 00), RecordTypeId = 1, EmployeeId = 8, ExitId = 37 },
                new WorkingDay { Id = 121, Start = new DateTime(2023, 02, 01, 09, 00, 00), End = new DateTime(2023, 02, 01, 18, 00, 00), RecordTypeId = 1, EmployeeId = 8, ExitId = 38 },
                new WorkingDay { Id = 122, Start = new DateTime(2023, 02, 02, 09, 00, 00), End = new DateTime(2023, 02, 02, 15, 47, 00), RecordTypeId = 1, EmployeeId = 8, ExitId = 39 },
                new WorkingDay { Id = 123, Start = new DateTime(2023, 02, 03, 09, 00, 00), End = new DateTime(2023, 02, 03, 16, 30, 00), RecordTypeId = 1, EmployeeId = 8, ExitId = 40 },
                new WorkingDay { Id = 124, Start = new DateTime(2023, 02, 06, 09, 00, 00), End = new DateTime(2023, 02, 06, 18, 00, 00), RecordTypeId = 3, EmployeeId = 8 },
                new WorkingDay { Id = 125, Start = new DateTime(2023, 02, 07, 09, 00, 00), End = new DateTime(2023, 02, 07, 18, 00, 00), RecordTypeId = 3, EmployeeId = 8 },
                new WorkingDay { Id = 126, Start = new DateTime(2023, 02, 08, 09, 00, 00), End = new DateTime(2023, 02, 08, 18, 00, 00), RecordTypeId = 4, EmployeeId = 8 },
                new WorkingDay { Id = 127, Start = new DateTime(2023, 02, 09, 09, 00, 00), End = new DateTime(2023, 02, 09, 18, 20, 00), RecordTypeId = 1, EmployeeId = 8 },
                new WorkingDay { Id = 128, Start = new DateTime(2023, 02, 10, 09, 00, 00), End = new DateTime(2023, 02, 10, 18, 10, 00), RecordTypeId = 1, EmployeeId = 8 },

                new WorkingDay { Id = 129, Start = new DateTime(2022, 12, 20, 09, 00, 00), End = new DateTime(2022, 12, 20, 18, 00, 00), RecordTypeId = 5, EmployeeId = 9 },
                new WorkingDay { Id = 130, Start = new DateTime(2022, 12, 21, 09, 00, 00), End = new DateTime(2022, 12, 21, 18, 02, 00), RecordTypeId = 1, EmployeeId = 9 },
                new WorkingDay { Id = 131, Start = new DateTime(2022, 12, 19, 09, 00, 00), End = new DateTime(2022, 12, 19, 17, 50, 00), RecordTypeId = 1, EmployeeId = 9 },
                new WorkingDay { Id = 132, Start = new DateTime(2022, 12, 22, 09, 00, 00), End = new DateTime(2022, 12, 22, 18, 30, 00), RecordTypeId = 1, EmployeeId = 9 },
                new WorkingDay { Id = 133, Start = new DateTime(2023, 01, 26, 09, 00, 00), End = new DateTime(2023, 01, 26, 16, 20, 00), RecordTypeId = 1, EmployeeId = 9 },
                new WorkingDay { Id = 134, Start = new DateTime(2023, 01, 27, 09, 00, 00), End = new DateTime(2023, 01, 27, 17, 45, 00), RecordTypeId = 1, EmployeeId = 9 },
                new WorkingDay { Id = 135, Start = new DateTime(2023, 01, 30, 09, 00, 00), End = new DateTime(2023, 01, 30, 17, 55, 00), RecordTypeId = 1, EmployeeId = 9 },
                new WorkingDay { Id = 136, Start = new DateTime(2023, 01, 31, 09, 00, 00), End = new DateTime(2023, 01, 31, 18, 00, 00), RecordTypeId = 2, EmployeeId = 9 },
                new WorkingDay { Id = 137, Start = new DateTime(2023, 02, 01, 09, 00, 00), End = new DateTime(2023, 02, 01, 18, 00, 00), RecordTypeId = 2, EmployeeId = 9 },
                new WorkingDay { Id = 138, Start = new DateTime(2023, 02, 02, 09, 00, 00), End = new DateTime(2023, 02, 02, 18, 00, 00), RecordTypeId = 1, EmployeeId = 9, ExitId = 41 },
                new WorkingDay { Id = 139, Start = new DateTime(2023, 02, 03, 09, 00, 00), End = new DateTime(2023, 02, 03, 18, 00, 00), RecordTypeId = 1, EmployeeId = 9, ExitId = 42 },
                new WorkingDay { Id = 140, Start = new DateTime(2023, 02, 06, 09, 00, 00), End = new DateTime(2023, 02, 06, 18, 05, 00), RecordTypeId = 1, EmployeeId = 9, ExitId = 43 },
                new WorkingDay { Id = 141, Start = new DateTime(2023, 02, 07, 09, 00, 00), End = new DateTime(2023, 02, 07, 18, 20, 00), RecordTypeId = 1, EmployeeId = 9, ExitId = 44 },
                new WorkingDay { Id = 142, Start = new DateTime(2023, 02, 08, 09, 00, 00), End = new DateTime(2023, 02, 08, 17, 00, 00), RecordTypeId = 1, EmployeeId = 9, ExitId = 45 },
                new WorkingDay { Id = 143, Start = new DateTime(2023, 02, 09, 09, 00, 00), End = new DateTime(2023, 02, 09, 17, 18, 00), RecordTypeId = 1, EmployeeId = 9 },
                new WorkingDay { Id = 144, Start = new DateTime(2023, 02, 10, 09, 00, 00), End = new DateTime(2023, 02, 10, 18, 00, 00), RecordTypeId = 3, EmployeeId = 9 },

                new WorkingDay { Id = 145, Start = new DateTime(2022, 12, 20, 09, 00, 00), End = new DateTime(2022, 12, 20, 16, 10, 00), RecordTypeId = 1, EmployeeId = 10 },
                new WorkingDay { Id = 146, Start = new DateTime(2022, 12, 21, 09, 00, 00), End = new DateTime(2022, 12, 21, 16, 45, 00), RecordTypeId = 1, EmployeeId = 10 },
                new WorkingDay { Id = 147, Start = new DateTime(2022, 12, 19, 09, 00, 00), End = new DateTime(2022, 12, 19, 18, 00, 00), RecordTypeId = 5, EmployeeId = 10 },
                new WorkingDay { Id = 148, Start = new DateTime(2022, 12, 22, 09, 00, 00), End = new DateTime(2022, 12, 22, 18, 10, 00), RecordTypeId = 1, EmployeeId = 10 },
                new WorkingDay { Id = 149, Start = new DateTime(2023, 01, 26, 09, 00, 00), End = new DateTime(2023, 01, 26, 18, 22, 00), RecordTypeId = 1, EmployeeId = 10 },
                new WorkingDay { Id = 150, Start = new DateTime(2023, 01, 27, 09, 00, 00), End = new DateTime(2023, 01, 27, 18, 00, 00), RecordTypeId = 3, EmployeeId = 10 },
                new WorkingDay { Id = 151, Start = new DateTime(2023, 01, 30, 09, 00, 00), End = new DateTime(2023, 01, 30, 17, 45, 00), RecordTypeId = 1, EmployeeId = 10 },
                new WorkingDay { Id = 152, Start = new DateTime(2023, 01, 31, 09, 00, 00), End = new DateTime(2023, 01, 31, 17, 55, 00), RecordTypeId = 1, EmployeeId = 10 },
                new WorkingDay { Id = 153, Start = new DateTime(2023, 02, 01, 09, 00, 00), End = new DateTime(2023, 02, 01, 18, 00, 00), RecordTypeId = 1, EmployeeId = 10 },
                new WorkingDay { Id = 154, Start = new DateTime(2023, 02, 02, 09, 00, 00), End = new DateTime(2023, 02, 02, 18, 00, 00), RecordTypeId = 4, EmployeeId = 10 },
                new WorkingDay { Id = 155, Start = new DateTime(2023, 02, 03, 09, 00, 00), End = new DateTime(2023, 02, 03, 18, 00, 00), RecordTypeId = 4, EmployeeId = 10 },
                new WorkingDay { Id = 156, Start = new DateTime(2023, 02, 06, 09, 00, 00), End = new DateTime(2023, 02, 06, 17, 15, 00), RecordTypeId = 1, EmployeeId = 10, ExitId = 46 },
                new WorkingDay { Id = 157, Start = new DateTime(2023, 02, 07, 09, 00, 00), End = new DateTime(2023, 02, 07, 17, 30, 00), RecordTypeId = 1, EmployeeId = 10, ExitId = 47 },
                new WorkingDay { Id = 158, Start = new DateTime(2023, 02, 08, 09, 00, 00), End = new DateTime(2023, 02, 08, 17, 45, 00), RecordTypeId = 1, EmployeeId = 10, ExitId = 48 },
                new WorkingDay { Id = 159, Start = new DateTime(2023, 02, 09, 09, 00, 00), End = new DateTime(2023, 02, 09, 18, 30, 00), RecordTypeId = 1, EmployeeId = 10, ExitId = 49 },
                new WorkingDay { Id = 160, Start = new DateTime(2023, 02, 10, 09, 00, 00), End = new DateTime(2023, 02, 10, 18, 00, 00), RecordTypeId = 1, EmployeeId = 10, ExitId = 50 }
                );

            modelBuilder.Entity<Exit>().HasData(
                new Exit { Id = 1, Start = new DateTime(2023, 02, 01, 12, 00, 00), End = new DateTime(2023, 02, 01, 12, 30, 00), IsPersonal = true, Reason = "", WorkingDayId = 9, EmployeeId = 1 },
                new Exit { Id = 2, Start = new DateTime(2023, 02, 02, 16, 00, 00), End = new DateTime(2023, 02, 02, 17, 00, 00), IsPersonal = false, Reason = "", WorkingDayId = 10, EmployeeId = 1 },
                new Exit { Id = 3, Start = new DateTime(2023, 02, 03, 12, 00, 00), End = new DateTime(2023, 02, 03, 12, 30, 00), IsPersonal = false, Reason = "", WorkingDayId = 11, EmployeeId = 1 },
                new Exit { Id = 4, Start = new DateTime(2023, 02, 06, 10, 30, 00), End = new DateTime(2023, 02, 06, 11, 30, 00), IsPersonal = false, Reason = "", WorkingDayId = 12, EmployeeId = 1 },
                new Exit { Id = 5, Start = new DateTime(2023, 02, 07, 13, 00, 00), End = new DateTime(2023, 02, 07, 13, 45, 00), IsPersonal = true, Reason = "", WorkingDayId = 13, EmployeeId = 1 },

                new Exit { Id = 6, Start = new DateTime(2023, 01, 31, 11, 00, 00), End = new DateTime(2023, 01, 31, 12, 30, 00), IsPersonal = false, Reason = "", WorkingDayId = 24, EmployeeId = 2 },
                new Exit { Id = 7, Start = new DateTime(2023, 02, 01, 10, 00, 00), End = new DateTime(2023, 02, 01, 10, 45, 00), IsPersonal = false, Reason = "", WorkingDayId = 25, EmployeeId = 2 },
                new Exit { Id = 8, Start = new DateTime(2023, 02, 02, 15, 00, 00), End = new DateTime(2023, 02, 02, 15, 52, 00), IsPersonal = true, Reason = "", WorkingDayId = 26, EmployeeId = 2 },
                new Exit { Id = 9, Start = new DateTime(2023, 02, 03, 10, 30, 00), End = new DateTime(2023, 02, 03, 12, 43, 00), IsPersonal = false, Reason = "", WorkingDayId = 27, EmployeeId = 2 },
                new Exit { Id = 10, Start = new DateTime(2023, 02, 08, 10, 15, 00), End = new DateTime(2023, 02, 08, 15, 28, 00), IsPersonal = false, Reason = "", WorkingDayId = 30, EmployeeId = 2 },

                new Exit { Id = 11, Start = new DateTime(2022, 12, 20, 09, 40, 00), End = new DateTime(2022, 12, 20, 12, 00, 00), IsPersonal = false, Reason = "", WorkingDayId = 33, EmployeeId = 3 },
                new Exit { Id = 12, Start = new DateTime(2022, 12, 21, 12, 15, 00), End = new DateTime(2022, 12, 21, 13, 00, 00), IsPersonal = true, Reason = "", WorkingDayId = 34, EmployeeId = 3 },
                new Exit { Id = 13, Start = new DateTime(2022, 12, 19, 13, 10, 00), End = new DateTime(2022, 12, 19, 14, 15, 00), IsPersonal = false, Reason = "", WorkingDayId = 35, EmployeeId = 3 },
                new Exit { Id = 14, Start = new DateTime(2022, 12, 22, 15, 30, 00), End = new DateTime(2022, 12, 22, 16, 10, 00), IsPersonal = false, Reason = "", WorkingDayId = 36, EmployeeId = 3 },
                new Exit { Id = 15, Start = new DateTime(2023, 01, 26, 10, 20, 00), End = new DateTime(2023, 01, 26, 11, 48, 00), IsPersonal = false, Reason = "", WorkingDayId = 37, EmployeeId = 3 },

                new Exit { Id = 16, Start = new DateTime(2023, 02, 01, 09, 30, 00), End = new DateTime(2023, 02, 01, 10, 45, 00), IsPersonal = true, Reason = "", WorkingDayId = 57, EmployeeId = 4 },
                new Exit { Id = 17, Start = new DateTime(2023, 02, 02, 12, 15, 00), End = new DateTime(2023, 02, 02, 13, 30, 00), IsPersonal = false, Reason = "", WorkingDayId = 58, EmployeeId = 4 },
                new Exit { Id = 18, Start = new DateTime(2023, 02, 03, 13, 05, 00), End = new DateTime(2023, 02, 03, 14, 23, 00), IsPersonal = false, Reason = "", WorkingDayId = 59, EmployeeId = 4 },
                new Exit { Id = 19, Start = new DateTime(2023, 02, 06, 11, 08, 00), End = new DateTime(2023, 02, 06, 12, 32, 00), IsPersonal = false, Reason = "", WorkingDayId = 60, EmployeeId = 4 },
                new Exit { Id = 20, Start = new DateTime(2023, 02, 07, 10, 00, 00), End = new DateTime(2023, 02, 07, 11, 30, 00), IsPersonal = true, Reason = "", WorkingDayId = 61, EmployeeId = 4 },

                new Exit { Id = 21, Start = new DateTime(2023, 02, 01, 12, 20, 00), End = new DateTime(2023, 02, 01, 13, 45, 00), IsPersonal = false, Reason = "", WorkingDayId = 73, EmployeeId = 5 },
                new Exit { Id = 22, Start = new DateTime(2023, 02, 02, 10, 00, 00), End = new DateTime(2023, 02, 02, 11, 20, 00), IsPersonal = true, Reason = "", WorkingDayId = 74, EmployeeId = 5 },
                new Exit { Id = 23, Start = new DateTime(2023, 02, 03, 10, 05, 00), End = new DateTime(2023, 02, 03, 11, 15, 00), IsPersonal = false, Reason = "", WorkingDayId = 75, EmployeeId = 5 },
                new Exit { Id = 24, Start = new DateTime(2023, 02, 06, 11, 32, 00), End = new DateTime(2023, 02, 06, 12, 48, 00), IsPersonal = false, Reason = "", WorkingDayId = 76, EmployeeId = 5 },
                new Exit { Id = 25, Start = new DateTime(2023, 02, 07, 14, 15, 00), End = new DateTime(2023, 02, 07, 15, 30, 00), IsPersonal = false, Reason = "", WorkingDayId = 77, EmployeeId = 5 },

                new Exit { Id = 26, Start = new DateTime(2023, 02, 01, 10, 17, 00), End = new DateTime(2023, 02, 01, 11, 25, 00), IsPersonal = false, Reason = "", WorkingDayId = 89, EmployeeId = 6 },
                new Exit { Id = 27, Start = new DateTime(2023, 02, 02, 11, 13, 00), End = new DateTime(2023, 02, 02, 14, 32, 00), IsPersonal = false, Reason = "", WorkingDayId = 90, EmployeeId = 6 },
                new Exit { Id = 28, Start = new DateTime(2023, 02, 03, 11, 30, 00), End = new DateTime(2023, 02, 03, 12, 48, 00), IsPersonal = false, Reason = "", WorkingDayId = 91, EmployeeId = 6 },
                new Exit { Id = 29, Start = new DateTime(2023, 02, 06, 14, 00, 00), End = new DateTime(2023, 02, 06, 15, 15, 00), IsPersonal = true, Reason = "", WorkingDayId = 92, EmployeeId = 6 },
                new Exit { Id = 30, Start = new DateTime(2023, 02, 08, 15, 00, 00), End = new DateTime(2023, 02, 08, 15, 32, 00), IsPersonal = false, Reason = "", WorkingDayId = 94, EmployeeId = 6 },

                new Exit { Id = 31, Start = new DateTime(2023, 02, 02, 09, 45, 00), End = new DateTime(2023, 02, 02, 12, 23, 00), IsPersonal = false, Reason = "", WorkingDayId = 106, EmployeeId = 7 },
                new Exit { Id = 32, Start = new DateTime(2023, 02, 03, 10, 30, 00), End = new DateTime(2023, 02, 03, 11, 46, 00), IsPersonal = false, Reason = "", WorkingDayId = 107, EmployeeId = 7 },
                new Exit { Id = 33, Start = new DateTime(2023, 02, 06, 13, 23, 00), End = new DateTime(2023, 02, 06, 14, 47, 00), IsPersonal = false, Reason = "", WorkingDayId = 108, EmployeeId = 7 },
                new Exit { Id = 34, Start = new DateTime(2023, 02, 07, 11, 00, 00), End = new DateTime(2023, 02, 07, 12, 30, 00), IsPersonal = true, Reason = "", WorkingDayId = 109, EmployeeId = 7 },
                new Exit { Id = 35, Start = new DateTime(2023, 02, 09, 11, 30, 00), End = new DateTime(2023, 02, 09, 13, 30, 00), IsPersonal = false, Reason = "", WorkingDayId = 111, EmployeeId = 7 },

                new Exit { Id = 36, Start = new DateTime(2023, 01, 30, 09, 52, 00), End = new DateTime(2023, 01, 30, 10, 45, 00), IsPersonal = false, Reason = "", WorkingDayId = 119, EmployeeId = 8 },
                new Exit { Id = 37, Start = new DateTime(2023, 01, 31, 11, 20, 00), End = new DateTime(2023, 01, 31, 13, 36, 00), IsPersonal = false, Reason = "", WorkingDayId = 120, EmployeeId = 8 },
                new Exit { Id = 38, Start = new DateTime(2023, 02, 01, 11, 43, 00), End = new DateTime(2023, 02, 01, 13, 54, 00), IsPersonal = false, Reason = "", WorkingDayId = 121, EmployeeId = 8 },
                new Exit { Id = 39, Start = new DateTime(2023, 02, 02, 10, 00, 00), End = new DateTime(2023, 02, 02, 10, 47, 00), IsPersonal = true, Reason = "", WorkingDayId = 122, EmployeeId = 8 },
                new Exit { Id = 40, Start = new DateTime(2023, 02, 03, 10, 30, 00), End = new DateTime(2023, 02, 03, 12, 23, 00), IsPersonal = false, Reason = "", WorkingDayId = 123, EmployeeId = 8 },

                new Exit { Id = 41, Start = new DateTime(2023, 02, 02, 11, 00, 00), End = new DateTime(2023, 02, 02, 12, 20, 00), IsPersonal = false, Reason = "", WorkingDayId = 138, EmployeeId = 9 },
                new Exit { Id = 42, Start = new DateTime(2023, 02, 03, 11, 30, 00), End = new DateTime(2023, 02, 03, 13, 00, 00), IsPersonal = true, Reason = "", WorkingDayId = 139, EmployeeId = 9 },
                new Exit { Id = 43, Start = new DateTime(2023, 02, 06, 13, 00, 00), End = new DateTime(2023, 02, 06, 13, 45, 00), IsPersonal = false, Reason = "", WorkingDayId = 140, EmployeeId = 9 },
                new Exit { Id = 44, Start = new DateTime(2023, 02, 07, 14, 15, 00), End = new DateTime(2023, 02, 07, 15, 30, 00), IsPersonal = false, Reason = "", WorkingDayId = 141, EmployeeId = 9 },
                new Exit { Id = 45, Start = new DateTime(2023, 02, 08, 12, 00, 00), End = new DateTime(2023, 02, 08, 12, 40, 00), IsPersonal = false, Reason = "", WorkingDayId = 142, EmployeeId = 9 },

                new Exit { Id = 46, Start = new DateTime(2023, 02, 06, 10, 00, 00), End = new DateTime(2023, 02, 06, 11, 15, 00), IsPersonal = false, Reason = "", WorkingDayId = 156, EmployeeId = 10 },
                new Exit { Id = 47, Start = new DateTime(2023, 02, 07, 11, 15, 00), End = new DateTime(2023, 02, 07, 12, 40, 00), IsPersonal = false, Reason = "", WorkingDayId = 157, EmployeeId = 10 },
                new Exit { Id = 48, Start = new DateTime(2023, 02, 08, 14, 02, 00), End = new DateTime(2023, 02, 08, 15, 15, 00), IsPersonal = false, Reason = "", WorkingDayId = 158, EmployeeId = 10 },
                new Exit { Id = 49, Start = new DateTime(2023, 02, 09, 13, 10, 00), End = new DateTime(2023, 02, 09, 15, 30, 00), IsPersonal = false, Reason = "", WorkingDayId = 159, EmployeeId = 10 },
                new Exit { Id = 50, Start = new DateTime(2023, 02, 10, 10, 00, 00), End = new DateTime(2023, 02, 10, 11, 30, 00), IsPersonal = true, Reason = "", WorkingDayId = 160, EmployeeId = 10 }
                );
        }

    }
}
