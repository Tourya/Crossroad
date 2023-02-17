using BMG_Schedule.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMG_Schedule.Data
{
    public class EmployeeManagerDbContext : DbContext
    {
        public EmployeeManagerDbContext(DbContextOptions<EmployeeManagerDbContext> options) : base(options) { }

        public DbSet<Employee> Employees => Set<Employee>();

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
        }

    }
}
