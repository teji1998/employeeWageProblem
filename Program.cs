using System;

namespace employeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //constant
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int HOURLY_WAGE = 20;
            const int FULL_TIME_EMPLOYEE_HOURS = 8;
            const int PART_TIME_EMPLOYEE_HOURS = 4;
            const int ABSENT_EMPLOYEE_HOURS = 0;

            //variables
            int employeeHours = 0;
            int employeeWage = 0;

            //Welcome message
            Console.WriteLine("Welcome to employee wage computation problem!");

            //Random class reference
            Random random = new Random();
            int attendance = random.Next(0, 3);

            // using switch case to check if employee is present or not
            //To check working hours for part-time or full-time employee
            switch (attendance)
            {
                case IS_FULL_TIME:
                    employeeHours = FULL_TIME_EMPLOYEE_HOURS;
                    Console.WriteLine("The full-time employee is present!");
                    break;
                case IS_PART_TIME:
                    employeeHours = PART_TIME_EMPLOYEE_HOURS;
                    Console.WriteLine("The part-time employee is present!");
                    break;
                default:
                    employeeHours = ABSENT_EMPLOYEE_HOURS;
                    Console.WriteLine("The employee is absent");
                    break;

            }
                

            /*if (attendance == IS_FULL_TIME)
            {
                employeeHours = FULL_TIME_EMPLOYEE_HOURS;
                Console.WriteLine("The full-time employee is present!");
            }
            else if (attendance == IS_PART_TIME)
            {
                employeeHours = PART_TIME_EMPLOYEE_HOURS;
                Console.WriteLine("The part-time employee is present!");
            }
            else
            {
                employeeHours = ABSENT_EMPLOYEE_HOURS;
                Console.WriteLine("The employee is absent");
            }*/

            //To calculate daily wage of employee 
            employeeWage = HOURLY_WAGE * employeeHours;

            Console.WriteLine("The number of working hours of employee is : " + employeeHours);
            Console.WriteLine("The daily wage of the employee is : " + employeeWage);
        }
    }
}
