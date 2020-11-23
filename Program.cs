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
            const int NUMBER_OF_WORKING_DAYS = 20;

            //variables
            int employeeHours = 0;
            int employeeWage = 0;
            int totalEmployeeWage = 0;

            //Welcome message
            Console.WriteLine("Welcome to employee wage computation problem!");

            //using for loop
            for (int days = 0; days <= NUMBER_OF_WORKING_DAYS; days++)
            {
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

                //To calculate daily wage of employee 
                employeeWage = HOURLY_WAGE * employeeHours;

                //To calculate monthly wage of employee
                totalEmployeeWage += employeeWage;

                Console.WriteLine("The number of working hours of employee is : " + employeeHours);
                Console.WriteLine("The daily wage of the employee is : " + employeeWage + " for day " + days);
            }
            Console.WriteLine("The monthly wage of the employee is : " + totalEmployeeWage);
        }
    }
}
