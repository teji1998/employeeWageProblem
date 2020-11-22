using System;

namespace employeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //constant
            const int IS_PRESENT = 1;

            //Welcome message
            Console.WriteLine("Welcome to employee wage computation problem!");

            //Random class reference
            Random random = new Random();
            int attendance = random.Next(0, 2);

            // using if else loop to check if employee is present or not
            if (attendance == IS_PRESENT)
            {
                Console.WriteLine("The employee is present!");
            }
            else
            {
                Console.WriteLine("The employee is not present!");
            }
        }
    }
}
