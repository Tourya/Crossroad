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
                new Employee { Id = 1, FirstName = "Anna", LastName = "Rockstar" },
                new Employee { Id = 2, FirstName = "Julia", LastName = "Developer" },
                new Employee { Id = 3, FirstName = "Thomas", LastName = "Huber" },
                new Employee { Id = 4, FirstName = "Sara", LastName = "Metroid" },
                new Employee { Id = 5, FirstName = "Ben", LastName = "Rockstar" },
                new Employee { Id = 6, FirstName = "Alex", LastName = "Rider" },
                new Employee { Id = 7, FirstName = "Sophie", LastName = "Ramos"},
                new Employee { Id = 8, FirstName = "Julien", LastName = "Russell" },
                new Employee { Id = 9, FirstName = "Yvonne", LastName = "Snider"},
                new Employee { Id = 10, FirstName = "Jasmin", LastName = "Curtis" }
                );
        }

    }
}
