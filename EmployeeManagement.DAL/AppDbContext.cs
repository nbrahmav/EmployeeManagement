using System;
using EmployeeManagement.BL;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.DAL
{
    public class AppDbContext: DbContext
    {   
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Employee> Employees { get; set;  }
    }
}
