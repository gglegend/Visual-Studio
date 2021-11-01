using System;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] choices = new int[5];
            string [] persons = new string[5];
     
          for (int name = 0; name < 5; name++)
            {
                Console.WriteLine("What is your name?");
                persons[name] = Console.ReadLine();
                Console.WriteLine("Enter your secret number: ");
                choices[name] =  int.Parse(Console.ReadLine());       
            }

          /*  Console.WriteLine("first choice was " + choices[0]);
            Console.WriteLine("second choice was " + choices[1]);
            Console.WriteLine("third choice was " + choices[2]); */

            Random r = new Random();
            int lottery = r.Next(1, 11);

            Console.WriteLine("the number was " + lottery);

            for (int name = 0; name < 5; name++)
            {
                if (choices[name] == lottery)
                    Console.WriteLine(persons[name] + " wins!");
                else
                    Console.WriteLine(persons[name] + " - no luck :(");

            }

        }
    }
}
