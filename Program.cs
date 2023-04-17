using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            int guess = 0;
            int numGuesses = 0;

            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100...");
            
            while (guess != randomNumber)
            {
                Console.Write("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                numGuesses++;

                if (guess < randomNumber)
                {
                    Console.WriteLine("Too low, try again.");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Too high, try again.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the number in " + numGuesses + " guesses!");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
