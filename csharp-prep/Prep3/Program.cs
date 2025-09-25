using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number?");
        // int magicNumber = int.Parse(Console.ReadLine())

        int guessNumber = 0;

        string loopDecision = "yes";

        while (loopDecision == "yes")
        {
            int guessCounter = 0;

            Random number = new Random();
            int magicNumber = number.Next(1, 101); //Generates a non-negative integer between 1 and 100 (inclusive of 1, exclusive of 101)

            while (magicNumber != guessNumber)
            {
                Console.Write("What is your guess?");
                guessNumber = int.Parse(Console.ReadLine());
                if (magicNumber < guessNumber)
                {
                    Console.WriteLine("Lower");
                    guessCounter += 1;

                }
                else if (magicNumber > guessNumber)
                {
                    Console.WriteLine("Higher");
                    guessCounter += 1;
                }
                else
                {
                    guessCounter += 1;
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You had {guessCounter} guesses.");
                    Console.Write("Would you like to play again? yes/no: ");
                    loopDecision = Console.ReadLine();
                }
            }
        }
    }
}