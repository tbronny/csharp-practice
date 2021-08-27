using System;
using System.Collections.Generic;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a difficulty level: (1) Cheater - (2) Easy - (3) Medium - (4) Hard");
            int difficulty = int.Parse(Console.ReadLine());

            // other possibility..
            // var difficulties = new int[] {1000, 8, 6, 4}
            var difficulties = new List<int>
            {
                1000, 8, 6, 4
            };

            int numOfAsks = difficulties[difficulty - 1];

        
            int SecretNumber = new Random().Next(1,100);
            

            Console.WriteLine("Can you guess the secret number?");
            Console.WriteLine("--------------------------------");
            Console.Write("Pick a number 1-100: ");

            int userInput = int.Parse(Console.ReadLine());

            // with the logic below you would not need the code above
            // for (int i = new int[] {1000, 8, 6, 4}[difficulty - 1]; i < numOfAsks; i++)
            for (int i = 1; i < numOfAsks; i++)
            {

                if (userInput == SecretNumber)
                {
                    Console.WriteLine();
                    Console.WriteLine("Correct! Can you read minds?");
                    return;
                }
                else
                {
                    if (userInput < SecretNumber)
                    {
                        Console.WriteLine();
                        Console.Write($"({numOfAsks - i} guesses left) Too low. Try again: ");
                        userInput = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write($"({numOfAsks - i} guesses left) Too high. Try again: ");
                        userInput = int.Parse(Console.ReadLine());
                    }
                }
            }
            if ( userInput == SecretNumber)
            {
                Console.WriteLine();
                Console.WriteLine("Correct! Can you read minds?");
                return;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Incorrect, better luck next time");
                Console.WriteLine($"The correct number was {SecretNumber}");
            }
        }
    }
}
