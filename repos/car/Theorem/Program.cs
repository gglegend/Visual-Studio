using System;

namespace Theorem
{
    class Program
    {

        static void Distance (int a, int b)
        {
            
            Console.WriteLine(a * a + b * b);


            double result = Math.Sqrt(a * a + b * b);
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Distance(3, 4);
        }
    }
}
