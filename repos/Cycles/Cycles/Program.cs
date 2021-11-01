using System;

namespace Cycles
{
    class Program
    {
        static void Hello()
        {
            Console.WriteLine("Hello, how are you?");
        }

        static void Add3(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }

        static void Reverse(string word)
        {
            Console.WriteLine("before: " + word);
            Console.Write("after: ");

            for (int i = 0; i < word.Length; i++)
                Console.Write(word[word.Length - 1 - i]);

        }


        static void Main(string[] args)
        {
            Hello();

            Add3(5, 7, 87);

            Reverse("devil");

            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            Console.WriteLine("stammering: ");
            for (int i = 0; i < word.Length; i++)
            {
                for(int x = 0; x< word.Length; x++)
                {
                    Console.Write(word[i]);
                }

            }

            Console.WriteLine("\n ---------------------");
            foreach (char letter in word)
            {
                Console.Write(letter);
            }

        }
    }
}
