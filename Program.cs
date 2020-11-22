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
            const int FULL_TIME_EMPLOYEE_HOURS = 8;
            const int ABSENT_EMPLOYEE_HOURS = 0;

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
                employeeHours = FULL_TIME_EMPLOYEE_HOURS;
                Console.WriteLine("The employee is present!");
            }
            else
            {
                employeeHours = ABSENT_EMPLOYEE_HOURS;
                Console.WriteLine("The employee is absent!");
            }

            //To calculate daily wage of employee 
            employeeWage = HOURLY_WAGE * employeeHours;

            Console.WriteLine("The number of working hours of employee is : " + employeeHours);
            Console.WriteLine("The daily wage of the employee is : " + employeeWage);
        }
    }
}
