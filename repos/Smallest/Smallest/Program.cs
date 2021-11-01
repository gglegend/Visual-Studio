using System;

namespace Smallest
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "beatles";

            int[] coins = { 1, 10, 1, 25, 10 };

            int index = 0;

            char purse = 'z';

            for (int i = 0; i <7; i++)
            {
                if (purse > word[i])
                {
                    purse = word[i];
                    index = i;
                }
                    
                    

              
            }
                

            Console.WriteLine(purse);
            Console.WriteLine(index);
        }
    }
}
