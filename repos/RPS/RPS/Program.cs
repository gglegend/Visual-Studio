using System;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("rock, paper, or scissors?");
            string choice1 = Console.ReadLine();

            Console.WriteLine("rock, paper, or scissors?");
            string choice2 = Console.ReadLine();

            if (choice1 == choice2)
                Console.WriteLine("tie");

            if (choice1 == "rock")
            {
                if (choice2 == "paper")
                    Console.WriteLine("Player 2 won!");
                if (choice2 == "scissors")
                    Console.WriteLine("Player 1 Won!");
            }

            if (choice1 == "paper")
            {
                if (choice2 == "rock")
                    Console.WriteLine("Player 1 won!");
                if (choice2 == "scissors")
                    Console.WriteLine("Player 2 won!");
            }

            if (choice1 == "scissors")
            {
                if (choice2 == "rock")
                    Console.WriteLine("Player 2 won!");
                if (choice2 == "paper")
                    Console.WriteLine("Player 1 won!");
            }


        }
    }
}
