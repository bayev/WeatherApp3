using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherManagement.Models;
using WEManagement.Models;

namespace WeatherApp.Pages
{
    public class BaseEmployeeList : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; private set; }

        // //calling method a razor component life cycle method which gets called during component initialization
        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
            
        }
        // Hard voded data - trying out the list output
        private void LoadEmployees()
        {
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Marry",
                LastName = "Dundy",
                Email = "marry.dandy@gmail.com",
                DateOfBirth = new DateTime(1990, 01, 01),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 3, DepartmentName = "IT"}
            };
            Employee e2 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Bert",
                LastName = "Doe",
                Email = "bert.doe@gmail.com",
                DateOfBirth = new DateTime(1990, 01, 01),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 3, DepartmentName = "IT" }
            };
            Employee e3 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Deep",
                Email = "john.deep@gmail.com",
                DateOfBirth = new DateTime(1990, 01, 01),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 3, DepartmentName = "IT" }
            };
            Employees = new List<Employee> { e1, e2, e3 };
        }
    }
}
