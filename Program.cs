using System;

namespace employeeWageProblem
{
    class Program
    {  
        static void Main(string[] args) {
            //Welcome message
            Console.WriteLine("Welcome to employee wage computation problem!");
            EmployeeObject starBucks = new EmployeeObject("Starbucks", 20, 3, 25);
            starBucks.ComputingTheEmployeeSalary();
            Console.WriteLine(starBucks.toString());

            }
       
    }
}