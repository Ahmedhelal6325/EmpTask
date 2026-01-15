using EmpTask.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EmpTask.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
    }
}
