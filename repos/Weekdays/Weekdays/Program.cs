using System;

namespace Weekdays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
           
            for (int week = 0; week < 4; week++)
            {
                for (int day = 0; day < 7; day++)
                {
                    Console.WriteLine(Weekdays[day]);
                }
            }
          
        }
    }
}
