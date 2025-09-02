
using Part__02_Inheritance.models;

namespace Part__02_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD =>Create, Read, Update, Delete
            using InheritanceDbContext dbContext = new InheritanceDbContext();
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            {
                Name = "Rana",
                Age = 23,
                Address = "Banha",
                Salary = 15_000,
                StartDate = DateTime.Now
            };
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            {
                Name = "Ahmed",
                Age = 25,
                Address = "Cairo",
                HourRate = 100,
                CountOfHours = 160
            };
            #region Add (Create)
            //dbContext.FullTimeEmployees.Add(fullTimeEmployee);
            //dbContext.PartTimeEmployees.Add(partTimeEmployee);
            // dbContext.SaveChanges();
            #endregion
            #region TPC Read
            //var FTEmployee =(from FTE in dbContext.FullTimeEmployees
            //                 select FTE).FirstOrDefault();

            //if(FTEmployee != null)
            //{
            //    Console.WriteLine($"FullTime Employee Name : {FTEmployee.Name}:::Salary={FTEmployee.Salary}");
            //}
            //var PTEmployee = dbContext.PartTimeEmployees.FirstOrDefault();
            //if(PTEmployee != null)
            //{
            //    Console.WriteLine($"PartTime Employee Name : {PTEmployee.Name}:::HourRate={PTEmployee.HourRate}");
            //}
            #endregion
            #region TPH
            //var Employees = from E in dbContext.Employees
            //                select E;
            //if (Employees is not null)
            //{
            //    foreach (var item in Employees.OfType<FullTimeEmployee>())
            //    {
            //        Console.WriteLine($"Name is :{item.Name}:: Age = {item.Age}::Salary : {item.Salary}");
            //    }
            //}
            #endregion
            #region Local
            #region Example 01
            //var Result = dbContext.Employees.Local.Any(E => E.Age != null);
            ////local => No Request Was Sent To DataBase
           // Console.WriteLine(Result);
            //Console.WriteLine("-----------------------");
            //Result = dbContext.Employees.Any(E => E.Age != null);
            //Console.WriteLine(Result); 
            #endregion
            #region Example 02
            //var Employee = dbContext.Employees.FirstOrDefault();
            // if(Employee is not null)
            //{
            //   // Console.WriteLine(Employee.Age);
            //   Employee.Age = null; //local
            //}
            //var Result = dbContext.Employees.Local.Any(E => E.Age == null);
            ////local => No Request Was Sent To DataBase
            //Console.WriteLine(Result);
            //Console.WriteLine("-----------------------");
            //Result = dbContext.Employees.Any(E => E.Age == null);
            //Console.WriteLine(Result);
            #endregion

            #endregion

        }
    }
}
