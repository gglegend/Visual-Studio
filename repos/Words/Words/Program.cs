using System;

namespace Words
{
    class Program
    {
        static void Swap(char [] word, int from, int to)
        {
            char temp = word[from];
            word[from] = word[to];
            word[to] = temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();

            char[] letters = word.ToCharArray();

            for(int i = 0; i < letters.Length/2; i++)
            {
                Swap(letters, i, letters.Length - i - 1);
            }
        
            Console.WriteLine(letters);
        }
    }
}
