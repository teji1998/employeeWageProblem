using System;
using System.Collections.Generic;
using System.Text;

namespace employeeWageProblem
{
    public class CompanyEmpWage
    {
        //variables
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

     
        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            //this is used to refer the current instances
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        //this method returns the string itself
        public string toString()
        {
            return "Total Emp Wage for company: " + this.company + " is: " + this.totalEmpWage;
        }
    }
}
