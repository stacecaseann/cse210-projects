using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        bool play = true;
        while (play)
        {
            int numGuesses = 0;
            int number = randomGenerator.Next(1,100);
            int guess = -1;
            while (guess != number)
            {            
                Console.Write("What is your guess?");
                numGuesses++;
                guess = int.Parse(Console.ReadLine());
                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it");
                }
            }
            Console.WriteLine($"You guessed {numGuesses} times");
            Console.Write("Do you want to play again? (Y/N) ");
            string playAgainString = Console.ReadLine();
            if (playAgainString == "Y")
                play = true;
            else
                play = false;
        }

    }
}