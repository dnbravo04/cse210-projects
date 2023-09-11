using System;

class Program
{
    static void Main(string[] args)
    {
        //Creating an instance of the Random class for generating the magic number.
        Random randomGenerator = new();
        // Declaring variables
        int attempts = 0;
        int magicNumber = randomGenerator.Next(1, 101);
        // Asking user for the guess number
        
        Console.Write("What is your guess? ");
        int guessNumber = int.Parse(Console.ReadLine());
        //Business logic
        while (magicNumber != guessNumber)
        {
            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Too high!");
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Too low!");
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
            }
            ++attempts;
        }
        Console.WriteLine($"You got it!It took you {attempts+1} attempts to guess the number.");

    }
}