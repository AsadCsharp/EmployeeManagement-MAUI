using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EmployeeMAUIApp.API.Model
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }

    public class Employee
    {
        [Key]
        [JsonIgnore]
        public int EmployeeId { get; set; } 
        public string EmployeeName { get; set; }
        public DateTime Joindate { get; set; }
        public int Salary { get; set; }
        public bool IsActive { get; set; }
        public string? ImageUrl { get; set; }
    }
}
