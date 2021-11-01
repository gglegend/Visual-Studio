using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How big (in feet) do you want your Christmas Tree to be?");
            int length = int.Parse(Console.ReadLine());


            for (int count = 0; count < length; count++)
                Console.WriteLine("   *    ");


            Console.ReadLine();

            //    if (length <= 10)




            string line1 = "|===================|";
            string gallow1 = "|                   O";
            string gallow2 = "|                  /|\\";
            string gallow3 = "|                   /\\";

            if(length > 1 )
                Console.WriteLine(line1);
            if(length > 2)
                 Console.WriteLine(gallow1);
            if(length > 3)
                  Console.WriteLine(gallow2);
            if (length > 4)
                Console.WriteLine(gallow3);

        }
    }
}
