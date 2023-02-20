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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(
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

            modelBuilder.Entity<WorkingDay>().HasData(
                new WorkingDay { Id = 1, Start = new DateTime(2023, 02, 01, 09, 00, 00), End = new DateTime(2023, 02, 01, 18, 00, 00), RecordTypeId = 1, EmployeeId = 1 },
                new WorkingDay { Id = 2, Start = new DateTime(2023, 02, 02, 09, 00, 00), End = new DateTime(2023, 02, 02, 18, 00, 00), RecordTypeId = 1, EmployeeId = 1 },
                new WorkingDay { Id = 3, Start = new DateTime(2023, 02, 03, 09, 00, 00), End = new DateTime(2023, 02, 03, 18, 00, 00), RecordTypeId = 1, EmployeeId = 1 },
                new WorkingDay { Id = 4, Start = new DateTime(2023, 02, 06, 09, 00, 00), End = new DateTime(2023, 02, 06, 18, 00, 00), RecordTypeId = 1, EmployeeId = 1 },
                new WorkingDay { Id = 5, Start = new DateTime(2023, 02, 07, 09, 00, 00), End = new DateTime(2023, 02, 07, 18, 00, 00), RecordTypeId = 1, EmployeeId = 1 },
                new WorkingDay { Id = 6, Start = new DateTime(2023, 02, 08, 09, 00, 00), End = new DateTime(2023, 02, 08, 18, 00, 00), RecordTypeId = 5, EmployeeId = 1 },
                new WorkingDay { Id = 7, Start = new DateTime(2023, 02, 09, 09, 00, 00), End = new DateTime(2023, 02, 09, 18, 00, 00), RecordTypeId = 5, EmployeeId = 1 },
                new WorkingDay { Id = 8, Start = new DateTime(2023, 02, 10, 09, 00, 00), End = new DateTime(2023, 02, 10, 18, 00, 00), RecordTypeId = 5, EmployeeId = 1 },

                new WorkingDay { Id = 9, Start = new DateTime(2023, 02, 01, 09, 00, 00), End = new DateTime(2023, 02, 01, 18, 00, 00), RecordTypeId = 3, EmployeeId = 2 },
                new WorkingDay { Id = 10, Start = new DateTime(2023, 02, 02, 09, 00, 00), End = new DateTime(2023, 02, 02, 18, 00, 00), RecordTypeId = 3, EmployeeId = 2 },
                new WorkingDay { Id = 11, Start = new DateTime(2023, 02, 03, 09, 00, 00), End = new DateTime(2023, 02, 03, 18, 00, 00), RecordTypeId = 1, EmployeeId = 2 },
                new WorkingDay { Id = 12, Start = new DateTime(2023, 02, 06, 09, 00, 00), End = new DateTime(2023, 02, 06, 18, 00, 00), RecordTypeId = 1, EmployeeId = 2 },
                new WorkingDay { Id = 13, Start = new DateTime(2023, 02, 07, 09, 00, 00), End = new DateTime(2023, 02, 07, 18, 00, 00), RecordTypeId = 1, EmployeeId = 2 },
                new WorkingDay { Id = 14, Start = new DateTime(2023, 02, 08, 09, 00, 00), End = new DateTime(2023, 02, 08, 18, 00, 00), RecordTypeId = 1, EmployeeId = 2 },
                new WorkingDay { Id = 15, Start = new DateTime(2023, 02, 09, 09, 00, 00), End = new DateTime(2023, 02, 09, 18, 00, 00), RecordTypeId = 1, EmployeeId = 2 },
                new WorkingDay { Id = 16, Start = new DateTime(2023, 02, 10, 09, 00, 00), End = new DateTime(2023, 02, 10, 18, 00, 00), RecordTypeId = 1, EmployeeId = 2 },

                new WorkingDay { Id = 17, Start = new DateTime(2023, 02, 01, 09, 00, 00), End = new DateTime(2023, 02, 01, 18, 00, 00), RecordTypeId = 1, EmployeeId = 3 },
                new WorkingDay { Id = 18, Start = new DateTime(2023, 02, 02, 09, 00, 00), End = new DateTime(2023, 02, 02, 18, 00, 00), RecordTypeId = 1, EmployeeId = 3 },
                new WorkingDay { Id = 19, Start = new DateTime(2023, 02, 03, 09, 00, 00), End = new DateTime(2023, 02, 03, 18, 00, 00), RecordTypeId = 1, EmployeeId = 3 },
                new WorkingDay { Id = 20, Start = new DateTime(2023, 02, 06, 09, 00, 00), End = new DateTime(2023, 02, 06, 18, 00, 00), RecordTypeId = 1, EmployeeId = 3 },
                new WorkingDay { Id = 21, Start = new DateTime(2023, 02, 07, 09, 00, 00), End = new DateTime(2023, 02, 07, 18, 00, 00), RecordTypeId = 4, EmployeeId = 3 },
                new WorkingDay { Id = 22, Start = new DateTime(2023, 02, 08, 09, 00, 00), End = new DateTime(2023, 02, 08, 18, 00, 00), RecordTypeId = 4, EmployeeId = 3 },
                new WorkingDay { Id = 23, Start = new DateTime(2023, 02, 09, 09, 00, 00), End = new DateTime(2023, 02, 09, 18, 00, 00), RecordTypeId = 1, EmployeeId = 3 },
                new WorkingDay { Id = 24, Start = new DateTime(2023, 02, 10, 09, 00, 00), End = new DateTime(2023, 02, 10, 18, 00, 00), RecordTypeId = 1, EmployeeId = 3 },

                new WorkingDay { Id = 25, Start = new DateTime(2023, 02, 01, 09, 00, 00), End = new DateTime(2023, 02, 01, 18, 00, 00), RecordTypeId = 1, EmployeeId = 4 },
                new WorkingDay { Id = 26, Start = new DateTime(2023, 02, 02, 09, 00, 00), End = new DateTime(2023, 02, 02, 18, 00, 00), RecordTypeId = 1, EmployeeId = 4 },
                new WorkingDay { Id = 27, Start = new DateTime(2023, 02, 03, 09, 00, 00), End = new DateTime(2023, 02, 03, 18, 00, 00), RecordTypeId = 1, EmployeeId = 4 },
                new WorkingDay { Id = 28, Start = new DateTime(2023, 02, 06, 09, 00, 00), End = new DateTime(2023, 02, 06, 18, 00, 00), RecordTypeId = 1, EmployeeId = 4 },
                new WorkingDay { Id = 29, Start = new DateTime(2023, 02, 07, 09, 00, 00), End = new DateTime(2023, 02, 07, 18, 00, 00), RecordTypeId = 1, EmployeeId = 4 },
                new WorkingDay { Id = 30, Start = new DateTime(2023, 02, 08, 09, 00, 00), End = new DateTime(2023, 02, 08, 18, 00, 00), RecordTypeId = 1, EmployeeId = 4 },
                new WorkingDay { Id = 31, Start = new DateTime(2023, 02, 09, 09, 00, 00), End = new DateTime(2023, 02, 09, 18, 00, 00), RecordTypeId = 2, EmployeeId = 4 },
                new WorkingDay { Id = 32, Start = new DateTime(2023, 02, 10, 09, 00, 00), End = new DateTime(2023, 02, 10, 18, 00, 00), RecordTypeId = 1, EmployeeId = 4 },

                new WorkingDay { Id = 33, Start = new DateTime(2023, 02, 01, 09, 00, 00), End = new DateTime(2023, 02, 01, 18, 00, 00), RecordTypeId = 1, EmployeeId = 5 },
                new WorkingDay { Id = 34, Start = new DateTime(2023, 02, 02, 09, 00, 00), End = new DateTime(2023, 02, 02, 18, 00, 00), RecordTypeId = 1, EmployeeId = 5 },
                new WorkingDay { Id = 35, Start = new DateTime(2023, 02, 03, 09, 00, 00), End = new DateTime(2023, 02, 03, 18, 00, 00), RecordTypeId = 1, EmployeeId = 5 },
                new WorkingDay { Id = 36, Start = new DateTime(2023, 02, 06, 09, 00, 00), End = new DateTime(2023, 02, 06, 18, 00, 00), RecordTypeId = 1, EmployeeId = 5 },
                new WorkingDay { Id = 37, Start = new DateTime(2023, 02, 07, 09, 00, 00), End = new DateTime(2023, 02, 07, 18, 00, 00), RecordTypeId = 1, EmployeeId = 5 },
                new WorkingDay { Id = 38, Start = new DateTime(2023, 02, 08, 09, 00, 00), End = new DateTime(2023, 02, 08, 18, 00, 00), RecordTypeId = 1, EmployeeId = 5 },
                new WorkingDay { Id = 39, Start = new DateTime(2023, 02, 09, 09, 00, 00), End = new DateTime(2023, 02, 09, 18, 00, 00), RecordTypeId = 1, EmployeeId = 5 },
                new WorkingDay { Id = 40, Start = new DateTime(2023, 02, 10, 09, 00, 00), End = new DateTime(2023, 02, 10, 18, 00, 00), RecordTypeId = 1, EmployeeId = 5 },

                new WorkingDay { Id = 41, Start = new DateTime(2023, 02, 01, 09, 00, 00), End = new DateTime(2023, 02, 01, 18, 00, 00), RecordTypeId = 1, EmployeeId = 6 },
                new WorkingDay { Id = 42, Start = new DateTime(2023, 02, 02, 09, 00, 00), End = new DateTime(2023, 02, 02, 18, 00, 00), RecordTypeId = 1, EmployeeId = 6 },
                new WorkingDay { Id = 43, Start = new DateTime(2023, 02, 03, 09, 00, 00), End = new DateTime(2023, 02, 03, 18, 00, 00), RecordTypeId = 1, EmployeeId = 6 },
                new WorkingDay { Id = 44, Start = new DateTime(2023, 02, 06, 09, 00, 00), End = new DateTime(2023, 02, 06, 18, 00, 00), RecordTypeId = 1, EmployeeId = 6 },
                new WorkingDay { Id = 45, Start = new DateTime(2023, 02, 07, 09, 00, 00), End = new DateTime(2023, 02, 07, 18, 00, 00), RecordTypeId = 1, EmployeeId = 6 },
                new WorkingDay { Id = 46, Start = new DateTime(2023, 02, 08, 09, 00, 00), End = new DateTime(2023, 02, 08, 18, 00, 00), RecordTypeId = 5, EmployeeId = 6 },
                new WorkingDay { Id = 47, Start = new DateTime(2023, 02, 09, 09, 00, 00), End = new DateTime(2023, 02, 09, 18, 00, 00), RecordTypeId = 5, EmployeeId = 6 },
                new WorkingDay { Id = 48, Start = new DateTime(2023, 02, 10, 09, 00, 00), End = new DateTime(2023, 02, 10, 18, 00, 00), RecordTypeId = 5, EmployeeId = 6 },

                new WorkingDay { Id = 49, Start = new DateTime(2023, 02, 01, 09, 00, 00), End = new DateTime(2023, 02, 01, 18, 00, 00), RecordTypeId = 3, EmployeeId = 7 },
                new WorkingDay { Id = 50, Start = new DateTime(2023, 02, 02, 09, 00, 00), End = new DateTime(2023, 02, 02, 18, 00, 00), RecordTypeId = 3, EmployeeId = 7 },
                new WorkingDay { Id = 51, Start = new DateTime(2023, 02, 03, 09, 00, 00), End = new DateTime(2023, 02, 03, 18, 00, 00), RecordTypeId = 1, EmployeeId = 7 },
                new WorkingDay { Id = 52, Start = new DateTime(2023, 02, 06, 09, 00, 00), End = new DateTime(2023, 02, 06, 18, 00, 00), RecordTypeId = 1, EmployeeId = 7 },
                new WorkingDay { Id = 53, Start = new DateTime(2023, 02, 07, 09, 00, 00), End = new DateTime(2023, 02, 07, 18, 00, 00), RecordTypeId = 1, EmployeeId = 7 },
                new WorkingDay { Id = 54, Start = new DateTime(2023, 02, 08, 09, 00, 00), End = new DateTime(2023, 02, 08, 18, 00, 00), RecordTypeId = 1, EmployeeId = 7 },
                new WorkingDay { Id = 55, Start = new DateTime(2023, 02, 09, 09, 00, 00), End = new DateTime(2023, 02, 09, 18, 00, 00), RecordTypeId = 1, EmployeeId = 7 },
                new WorkingDay { Id = 56, Start = new DateTime(2023, 02, 10, 09, 00, 00), End = new DateTime(2023, 02, 10, 18, 00, 00), RecordTypeId = 1, EmployeeId = 7 },

                new WorkingDay { Id = 57, Start = new DateTime(2023, 02, 01, 09, 00, 00), End = new DateTime(2023, 02, 01, 18, 00, 00), RecordTypeId = 1, EmployeeId = 8 },
                new WorkingDay { Id = 58, Start = new DateTime(2023, 02, 02, 09, 00, 00), End = new DateTime(2023, 02, 02, 18, 00, 00), RecordTypeId = 1, EmployeeId = 8 },
                new WorkingDay { Id = 59, Start = new DateTime(2023, 02, 03, 09, 00, 00), End = new DateTime(2023, 02, 03, 18, 00, 00), RecordTypeId = 1, EmployeeId = 8 },
                new WorkingDay { Id = 60, Start = new DateTime(2023, 02, 06, 09, 00, 00), End = new DateTime(2023, 02, 06, 18, 00, 00), RecordTypeId = 1, EmployeeId = 8 },
                new WorkingDay { Id = 61, Start = new DateTime(2023, 02, 07, 09, 00, 00), End = new DateTime(2023, 02, 07, 18, 00, 00), RecordTypeId = 4, EmployeeId = 8 },
                new WorkingDay { Id = 62, Start = new DateTime(2023, 02, 08, 09, 00, 00), End = new DateTime(2023, 02, 08, 18, 00, 00), RecordTypeId = 4, EmployeeId = 8 },
                new WorkingDay { Id = 63, Start = new DateTime(2023, 02, 09, 09, 00, 00), End = new DateTime(2023, 02, 09, 18, 00, 00), RecordTypeId = 1, EmployeeId = 8 },
                new WorkingDay { Id = 64, Start = new DateTime(2023, 02, 10, 09, 00, 00), End = new DateTime(2023, 02, 10, 18, 00, 00), RecordTypeId = 1, EmployeeId = 8 },

                new WorkingDay { Id = 65, Start = new DateTime(2023, 02, 01, 09, 00, 00), End = new DateTime(2023, 02, 01, 18, 00, 00), RecordTypeId = 1, EmployeeId = 9 },
                new WorkingDay { Id = 66, Start = new DateTime(2023, 02, 02, 09, 00, 00), End = new DateTime(2023, 02, 02, 18, 00, 00), RecordTypeId = 1, EmployeeId = 9 },
                new WorkingDay { Id = 67, Start = new DateTime(2023, 02, 03, 09, 00, 00), End = new DateTime(2023, 02, 03, 18, 00, 00), RecordTypeId = 1, EmployeeId = 9 },
                new WorkingDay { Id = 68, Start = new DateTime(2023, 02, 06, 09, 00, 00), End = new DateTime(2023, 02, 06, 18, 00, 00), RecordTypeId = 1, EmployeeId = 9 },
                new WorkingDay { Id = 69, Start = new DateTime(2023, 02, 07, 09, 00, 00), End = new DateTime(2023, 02, 07, 18, 00, 00), RecordTypeId = 1, EmployeeId = 9 },
                new WorkingDay { Id = 70, Start = new DateTime(2023, 02, 08, 09, 00, 00), End = new DateTime(2023, 02, 08, 18, 00, 00), RecordTypeId = 1, EmployeeId = 9 },
                new WorkingDay { Id = 71, Start = new DateTime(2023, 02, 09, 09, 00, 00), End = new DateTime(2023, 02, 09, 18, 00, 00), RecordTypeId = 2, EmployeeId = 9 },
                new WorkingDay { Id = 72, Start = new DateTime(2023, 02, 10, 09, 00, 00), End = new DateTime(2023, 02, 10, 18, 00, 00), RecordTypeId = 1, EmployeeId = 9 },

                new WorkingDay { Id = 73, Start = new DateTime(2023, 02, 01, 09, 00, 00), End = new DateTime(2023, 02, 01, 18, 00, 00), RecordTypeId = 1, EmployeeId = 10 },
                new WorkingDay { Id = 74, Start = new DateTime(2023, 02, 02, 09, 00, 00), End = new DateTime(2023, 02, 02, 18, 00, 00), RecordTypeId = 1, EmployeeId = 10 },
                new WorkingDay { Id = 75, Start = new DateTime(2023, 02, 03, 09, 00, 00), End = new DateTime(2023, 02, 03, 18, 00, 00), RecordTypeId = 1, EmployeeId = 10 },
                new WorkingDay { Id = 76, Start = new DateTime(2023, 02, 06, 09, 00, 00), End = new DateTime(2023, 02, 06, 18, 00, 00), RecordTypeId = 1, EmployeeId = 10 },
                new WorkingDay { Id = 77, Start = new DateTime(2023, 02, 07, 09, 00, 00), End = new DateTime(2023, 02, 07, 18, 00, 00), RecordTypeId = 1, EmployeeId = 10 },
                new WorkingDay { Id = 78, Start = new DateTime(2023, 02, 08, 09, 00, 00), End = new DateTime(2023, 02, 08, 18, 00, 00), RecordTypeId = 1, EmployeeId = 10 },
                new WorkingDay { Id = 79, Start = new DateTime(2023, 02, 09, 09, 00, 00), End = new DateTime(2023, 02, 09, 18, 00, 00), RecordTypeId = 1, EmployeeId = 10 },
                new WorkingDay { Id = 80, Start = new DateTime(2023, 02, 10, 09, 00, 00), End = new DateTime(2023, 02, 10, 18, 00, 00), RecordTypeId = 1, EmployeeId = 10 }
                );
        }

    }
}
