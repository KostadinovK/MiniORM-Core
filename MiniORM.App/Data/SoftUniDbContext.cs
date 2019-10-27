using System;
using System.Collections.Generic;
using System.Text;
using MiniORM.App.Data.Entities;

namespace MiniORM.App.Data
{
    public class SoftUniDbContext : DbContext
    {
        public DbSet<Department> Departments { get; }
        public DbSet<Employee> Employees { get; }
        public DbSet<Project> Projects { get; }
        public DbSet<EmployeeProject> EmployeesProjects { get; }

        public SoftUniDbContext(string connectionString) : base(connectionString)
        { 
        }
    }
}
