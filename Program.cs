using System;

namespace employeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            const int IS_PRESENT = 1;
            Console.WriteLine("Welcome to employee wage computation problem!");
            Random random = new Random();
            int attendance = random.Next(0, 2);
            if (attendance == IS_PRESENT)
            {
                Console.WriteLine("The employee is present!");
            }
            else
            {
                Console.WriteLine("The employee is not present");
            }
            


        }
    }
}
