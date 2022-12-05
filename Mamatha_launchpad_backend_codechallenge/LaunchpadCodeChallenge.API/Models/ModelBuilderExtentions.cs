using Microsoft.EntityFrameworkCore;

namespace LaunchpadCodeChallenge.API.Models
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departments>().HasData(
                new Departments { DepartmentsId = 30001, DepartmentsName = "Architect Group" },
                new Departments { DepartmentsId = 30002, DepartmentsName = "Software Group" },
                new Departments { DepartmentsId = 30003, DepartmentsName = "Design Team" },
                new Departments { DepartmentsId = 30004, DepartmentsName = "ProjectMan Group" });

            modelBuilder.Entity<Employees>().HasData(

              new Employees { Id = 1001, FirstName = "John", LastName = "Thomas", EmpAddress = "5631 Rice, OakPark,IL", JobTitle = "Architect", DepartmentId = 30001 },
              new Employees { Id = 1002, FirstName = "Alice", LastName = "James", EmpAddress = "980 Berry ln, Elgin,IL", JobTitle = "Developer", DepartmentId = 30002 },
              new Employees { Id = 1003, FirstName = "Steve", LastName = "Wells", EmpAddress = "291 Springs, Gary,IL", JobTitle = "Developer", DepartmentId = 30002 },
              new Employees { Id = 1004, FirstName = "Santosh", LastName = "Kumar", EmpAddress = "511 Aurora Av, Aurora,IL", JobTitle = "Manager", DepartmentId = 30004 },
              new Employees { Id = 1005, FirstName = "Ahmed", LastName = "Hussain", EmpAddress = "216 Oak Tree, Geneva,IL", JobTitle = "Architect", DepartmentId = 30001 },
              new Employees { Id = 1006, FirstName = "Nancy", LastName = "Allen", EmpAddress = "111 Green Pl, Elgin,IL", JobTitle = "Architect", DepartmentId = 30001 },
              new Employees { Id = 1007, FirstName = "Mary", LastName = "Thomas", EmpAddress = "100 Rose Pl, Gary,IL", JobTitle = "Designer", DepartmentId = 30003 },
              new Employees { Id = 1008, FirstName = "Bharath", LastName = "Gupta", EmpAddress = "145 Berry Ln, Naperville,IL", JobTitle = "Designer", DepartmentId = 30003 },
              new Employees { Id = 1009, FirstName = "Andrea", LastName = "Jones", EmpAddress = "120 Fall Creek, Gary,IL", JobTitle = "Designer", DepartmentId = 30003 },
              new Employees { Id = 1010, FirstName = "Ann", LastName = "Jacob", EmpAddress = "111 Britany Springs,Elgin,IL", JobTitle = "Manager", DepartmentId = 30004 });

        }

    }
}
