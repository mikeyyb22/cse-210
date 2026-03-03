using System;

class Program
{
    static void Main(string[] args)
    {
        //Functions
        // returnType FunctionName(dataType parameter1, dataType parameter2)
        // {
        //     // function_body
        // }

        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int squaredNum = SquareNumber(userNum);
        DisplayResult(userName, squaredNum);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int userNum = int.Parse(userInput);

        return userNum;
    }

    static int SquareNumber(int favNum)
    {
        int squareNum = favNum * favNum;
        return squareNum;
    }

    static void DisplayResult(string userName, int userNum)
    {
        Console.WriteLine($"{userName}, the square of your number is {userNum}");
    }
}