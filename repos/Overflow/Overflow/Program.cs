using System;

namespace Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.MaxValue;

            Console.WriteLine(i);
            i++;
            Console.WriteLine(i);
            i++;
            Console.WriteLine(i);

            char c = (char)127;
            Console.WriteLine(c);
            c++;
            Console.WriteLine(c);

        }
    }
}
