using System;

namespace EmployeeWage
{
    internal class Program
    {
        const int attendence = 1;
        const int perHourWage = 20;
        const int fullDayHaour = 8;
        static void Main(string[] args)
        {
            Random random = new Random();
           int empHours = 0;
            int check=random.Next(0,2);
            if (check ==attendence)
            {
                empHours = fullDayHaour;
            }
            else
            {
                empHours = 0;
            }

            int dailyWage = empHours * perHourWage;

            Console.WriteLine(dailyWage);
        }

    }
}
    