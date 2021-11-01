using System;

namespace Match
{
    class Program
    {
        static void Main(string[] args)
        {
            
        string[] people =
            {
                "Tom", "Richard","Mary", "Kate"
            };

            string[] animals =
            {
                "poodle", "bobcat", "goldfish", "Zebra"
            };

            for (int i= 0; i<people.Length;i++ )
                 Console.WriteLine(people[i] + " gets a " + animals[i]);


            Console.ReadLine();

            for (int i = 0; i < animals.Length; i++)
                Console.WriteLine(people[i] + " gets a " + animals[animals.Length-1-i]);
        }
    }
}
