using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherManagement.Models;
using WEManagement.Models;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Departament Data
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
               new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
               new Department { DepartmentId = 3, DepartmentName = "ADMIN" });

            //Employee Data
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "Mark",
                    LastName = "Jacob",
                    Email = "mark.jacob@wa.se",
                    DateOfBirth = new DateTime(1986, 01, 01),
                    Gender = Gender.Male,
                    DepartmentId = 1
                });
            modelBuilder.Entity<Employee>().HasData(
              new Employee
              {
                  EmployeeId = 2,
                  FirstName = "John",
                  LastName = "Doe",
                  Email = "john.doe@wa.se",
                  DateOfBirth = new DateTime(1986, 01, 01),
                  Gender = Gender.Male,
                  DepartmentId = 2
              });
            modelBuilder.Entity<Employee>().HasData(
             new Employee
             {
                 EmployeeId = 3,
                 FirstName = "A",
                 LastName = "B",
                 Email = "a.b@wa.se",
                 DateOfBirth = new DateTime(1986, 01, 01),
                 Gender = Gender.Male,
                 DepartmentId = 3
             });

           
        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departaments { get; set; }
        public DbSet<Weather> Weather { get; set; }


    }
}
