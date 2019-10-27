using System;
using System.Linq;
using MiniORM.App.Data;
using MiniORM.App.Data.Entities;

namespace MiniORM.App
{
    public class StartUp
    {
        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=MiniORM;Integrated Security=True;";
        public static void Main()
        {
            var db = new SoftUniDbContext(ConnectionString);

            db.Employees.Add(new Employee
            {
                FirstName = "Gosho",
                LastName = "Inserted",
                DepartmentId = db.Departments.First().Id,
                IsEmployed = true,
            });

            var employee = db.Employees.Last();
            employee.FirstName = "Modified";

            db.SaveChanges();
        }
    }
}
