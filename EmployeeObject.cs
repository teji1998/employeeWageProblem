using System;
using System.Collections.Generic;
using System.Text;

namespace employeeWageProblem
{
    public class EmployeeObject
    {

        //constant
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int FULL_TIME_EMPLOYEE_HOURS = 8;
        const int PART_TIME_EMPLOYEE_HOURS = 4;
        const int ABSENT_EMPLOYEE_HOURS = 0;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        //Created an object for the employee
        public EmployeeObject(String company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth )
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        //To calculate the wages
        public void ComputingTheEmployeeSalary()
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;

                // using switch case to check if employee is present or not
                // To check working hours for part-time or full-time employee
                switch (EmployeeCheck())
                {
                    case IS_FULL_TIME:
                        empHrs = FULL_TIME_EMPLOYEE_HOURS;
                        Console.WriteLine("The full-time employee is present!");
                        break;

                    case IS_PART_TIME:
                        empHrs = PART_TIME_EMPLOYEE_HOURS;
                        Console.WriteLine("The part-time employee is present!");
                        break;

                    default:
                        empHrs = ABSENT_EMPLOYEE_HOURS;
                        Console.WriteLine("The employee is absent");
                        break;

                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day:" + totalWorkingDays + " Emp hrs " + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
 

        //To check if employee present or not
        public static int EmployeeCheck()
        {
            //Random class reference
            Random random = new Random();
            int attendance = random.Next(0, 3);
            return attendance;
        }

        public string toString()
        {
            return "Total Emp Wage for company: " + this.company + " is : " + this.totalEmpWage;
        }
    }
}
