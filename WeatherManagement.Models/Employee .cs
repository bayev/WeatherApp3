using System;
using WEManagement.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherManagement.Models
{
    public class Employee

    {
        public int EmployeeId { get; set; }
        [MinLength(3,ErrorMessage ="Error!")]
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }
        public string PhotoPath { get; set; }
        public int DepartmentId { get; set; }
    }
}
