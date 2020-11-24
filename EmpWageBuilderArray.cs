using System;
using System.Collections.Generic;
using System.Text;

namespace employeeWageProblem
{
    public class EmpWageBuilderArray
    {

        //constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;
      
        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

       
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }

       
        // Computes the emp wage.
        
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }


        public int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            ///While loop is used to check maximum working hours and number of working days.
            ///if it is true then it executes
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day:" + totalWorkingDays + " Emp hrs " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }

    }
}
