﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherManagement.Models;

namespace ApiManagement.Api.Models
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int employeeId);
        Task<Employee> AddEmployoee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);

        void DeleteEmployee(int employeeId);
    }
}
