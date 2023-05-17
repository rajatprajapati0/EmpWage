using System;

namespace EmployeeWage
{
    internal class Program
    {
        const int fullDay = 1;
        const int halfDay = 2;
        const int perHourWage = 20;
        const int fullDayHaour = 8;
        const int halfDahour = 4;
        static void Main(string[] args)
        {
            Random random = new Random();
           int empHours = 0;
            int check=random.Next(0,3);
            if (check ==fullDay)
            {
                empHours = fullDayHaour;
            }
            else if (check == halfDay) 
            {
                empHours = halfDahour;
             
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
    