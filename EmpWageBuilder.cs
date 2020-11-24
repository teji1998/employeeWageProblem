using System;

namespace employeeWageProblem
{
    class EmpWageBuilder
    {  
        static void Main(string[] args) {
            //Welcome message
            Console.WriteLine("Welcome to employee wage computation problem!");
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();

        }
       
    }
}