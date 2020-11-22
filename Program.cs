using System;

namespace employeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //constant
            const int IS_PRESENT = 1;
            const int HOURLY_WAGE = 20;

            //variables
            int employeeHours = 0;
            int employeeWage = 0;

            //Welcome message
            Console.WriteLine("Welcome to employee wage computation problem!");

            //Random class reference
            Random random = new Random();
            int attendance = random.Next(0, 2);

            // using if else loop to check if employee is present or not
            //To check the employee hours
            if (attendance == IS_PRESENT)
            {
                employeeHours = 8;
                Console.WriteLine("The employee is present!");
            }
            else
            {
                employeeHours = 0;
                Console.WriteLine("The employee is not present!");
            }

            employeeWage = HOURLY_WAGE * employeeHours;
            Console.WriteLine("The number of working hours of employee is : " + employeeHours);
            Console.WriteLine("The daily wage of the employee is : " + employeeWage);
        }
    }
}
