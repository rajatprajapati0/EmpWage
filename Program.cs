using System;

namespace EmployeeWage
{
    internal class Program
    {
        const int absent = 0;
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


            switch (check) 
            {
            case fullDay:empHours = fullDayHaour; break;
                case halfDay:empHours=halfDahour; break;

                case absent:empHours=0; break;
            }
            

            int dailyWage = empHours * perHourWage;

            Console.WriteLine(dailyWage);
        }

    }
}
    