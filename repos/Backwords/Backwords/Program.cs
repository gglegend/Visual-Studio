using System;

namespace Backwords
{
    class Program
    {
        static void Main(string[] args)
        {
            /*       Console.WriteLine("Enter a Word:");
                   string word = Console.ReadLine();
                   Console.WriteLine(word.Length);

                  // Console.WriteLine(word[0]);
                  // Console.WriteLine(word[word.Length-1]);

                   for (int i = 0; i < word.Length; i++)
                       Console.WriteLine(word[i]);

                   for (int i = word.Length-1; i > -1; i--)
                       Console.WriteLine(word[i]);
            */

            string Word = "tree";

            for (int i = 0; i < Word.Length; i++)
                Console.WriteLine(Word[i]);
            Console.ReadLine();
            for (int i = Word.Length - 1; i > -1; i--)
                Console.WriteLine(Word[i]);

           // char[] word = "peanut".ToCharArray();
           // word[0] = 'b';

            Console.ReadLine();

            string[] food = {
                "fries", "burgers", "chicken"
            };

            for (int i = 0; i < food.Length; i++)
                Console.WriteLine(food[i]);
            Console.ReadLine();
            int[] lottery = {
                6, 16, 25, 32, 48
            };

            for (int i = 0; i < lottery.Length; i++)
                Console.WriteLine(lottery[i]);
            Console.ReadLine();
            string[] names = { "Jack", "Theodore", "Michael", "Joshua" };

            long[] phonenumbers = { 7189054350, 718756982, 9176789946, 3476581549 };



            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(names[i]);
                Console.WriteLine(phonenumbers[i]);
            }

            Console.ReadLine();

            string evil = "satan";
            char[] good = "?????".ToCharArray();
            good[0] = evil[0];
            good[1] = evil[1];
            good[2] = evil[4];
            good[3] = evil[2];
            good[4] = evil[3];

            Console.WriteLine(good);


            string[] sentence = { "stressed", "denim", "rats" };

            for (int i = sentence.Length - 1; i > -1; i--)
            { 
                string word = sentence[i];

                for (int n = word.Length - 1; n > -1; n--)
                    Console.Write(word[n]);

               // for(int n = sentence.Length; n < phrase.Length; i++)
                    Console.WriteLine();  
            }
                
        }
    }
}
