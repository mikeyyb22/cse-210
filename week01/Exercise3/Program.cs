using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        bool guessCorrect = false;

        while (guessCorrect == false)
        {
            Console.Write("What is the magic number? (1-100) ");
            string userGuess = Console.ReadLine();
            int userInt = int.Parse(userGuess);

            if (userInt == number)
            {
                Console.WriteLine("Nice job! You guessed the magic number!");
                guessCorrect = true;
            }
            else if (userInt > number)
            {
                Console.WriteLine("Lower...");
            }
            else
            {
                Console.WriteLine("Higher...");
            }
        }
        
    }
}