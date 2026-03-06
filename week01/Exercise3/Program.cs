using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
         string playAgain = "yes";

        while (playAgain == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guessCount = 0;

            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            while (guess != magicNumber)
            {
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }

            guessCount++;

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {guessCount} guesses.");

            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        }
    }
}