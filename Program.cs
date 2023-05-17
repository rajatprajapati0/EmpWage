using System;

namespace EmployeeWage
{
    internal class Program
    {
        const int attendence = 1;
        static void Main(string[] args)
        {
            Random random = new Random();
            int check=random.Next(0,2);
            if (check ==attendence)
            {
                Console.WriteLine("present");
            }
            else
            {
                Console.WriteLine("absent");
            }
        }
    }
}
