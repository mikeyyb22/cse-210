using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        // List<int> numbers = new List<int>();
        // List<string> words = new List<string>();
        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");
        // // Size of list
        // Console.WriteLine(words.Count);
        // // Iterate through list
        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }

        List<int> numbers = new List<int>();
        bool inputCheck = false;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (inputCheck == false)
        {
            Console.Write("Enter number: ");
            string userEntry = Console.ReadLine();
            int userInput = int.Parse(userEntry);
            if (userInput == 0)
            {
                inputCheck = true;
            }
            else
            {
                numbers.Add(userInput);
            }
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        int total = numbers.Count;
        float average = sum / total;
        Console.WriteLine($"The average is: {average}");

        int largestNum = 0;
        foreach (int num in numbers)
        {
            if (num > largestNum)
            {
                largestNum = num;
            }
        }
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}