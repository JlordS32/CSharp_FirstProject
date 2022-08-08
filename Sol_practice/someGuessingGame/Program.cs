using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace someGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game();
        }

        static void Game()
        {
            string secretWord = "giraffe";
            string guess;
            int attempts = 0;

            Console.Clear();
            Console.Write("Enter your guess: ");
            guess = Console.ReadLine();

            while (guess != secretWord)
            {
                Console.Clear();
                Console.Write("Wrong guess\n" +
                    "Enter your guess: ");
                guess = Console.ReadLine();
                attempts++;

                if (attempts > 5)
                {
                    Console.Clear();
                    Console.Write("It seems like you cannot guess it right" +
                                    "\nPress [esc] to quit or else continue.");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Game();
                    }
                }
            }

            Console.WriteLine($"\nYou made the correct guess." +
                $"\nAttempts: {attempts}");
            Console.ReadLine();
        }
    }
}
