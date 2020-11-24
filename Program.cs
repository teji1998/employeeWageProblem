using System;

namespace employeeWageProblem
{
    class Program
    {

        //constant
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int FULL_TIME_EMPLOYEE_HOURS = 8;
        const int PART_TIME_EMPLOYEE_HOURS = 4;
        const int ABSENT_EMPLOYEE_HOURS = 0;
       /* const int NUMBER_OF_WORKING_DAYS = 20;
        const int MAXIMUM_WORKING_HOURS = 100;*/

        //To check if employee present or not
        public static int EmployeeCheck()
        {
            //Random class reference
            Random random = new Random();
            int attendance = random.Next(0, 3);
            return attendance;
        }

        static void Main(string[] args) {
            //Welcome message
            Console.WriteLine("Welcome to employee wage computation problem!");

            Console.WriteLine("The monthly wage of the employee is : " + ComputingTheEmployeeSalary("EXO", 10 ,5 , 30));
        }

        //Method to find the total salary of employee
        public static int ComputingTheEmployeeSalary(String company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
        //variables
        int employeeHours = 0;
        int employeeWage = 0;
        int totalEmployeeWage = 0;
        int totalEmployeeHours = 0;
        int totalEmployeeDays = 0;
        
        while(totalEmployeeHours <= maxHoursPerMonth && totalEmployeeDays < numOfWorkingDays)
        {
            totalEmployeeDays++;
                
           // using switch case to check if employee is present or not
           // To check working hours for part-time or full-time employee
           switch (EmployeeCheck())
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
           totalEmployeeHours += employeeHours;
           Console.WriteLine("For day : " + totalEmployeeDays + " and hours " + employeeHours);
           employeeWage = empRatePerHour * employeeHours;
           Console.WriteLine("Daily wage : " + employeeWage + " and the total hours:" + totalEmployeeHours);
           totalEmployeeWage += employeeWage;
        }
            return totalEmployeeWage;   
        }
    }
}