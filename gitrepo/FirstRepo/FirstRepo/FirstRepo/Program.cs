using System;
namespace Fahim
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp1 = new Employee();
            Emp1.EmployeeID = 1001;
            Emp1.Name = "James";

            UpdateName(ref Emp1);
            Console.WriteLine($"Emp1 Name = {Emp1.Name}");
            Console.ReadKey();
        }

        public static void UpdateName(ref Employee Emp2)
        {
            Emp2 = null;
        }
    }
    public class Employee
    {
        public int EmployeeID;
        public string Name;
    }
}