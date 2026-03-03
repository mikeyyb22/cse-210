using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input your current grade %: ");
        string gradeInput = Console.ReadLine();
        int userGrade = int.Parse(gradeInput);
        bool passedClass = false;
        char letterGrade = 'E';

        if (userGrade >= 90)
        {
            letterGrade = 'A';
            passedClass = true;
        }
        else if (userGrade >= 80)
        {
            letterGrade = 'B';
            passedClass = true;
        }
        else if (userGrade >= 70)
        {
            letterGrade = 'C';
            passedClass = true;
        }
        else if (userGrade >= 60)
        {
            letterGrade = 'D';
        }
        else
        {
            letterGrade = 'F';
        }
        Console.WriteLine($"Your letter grade is a {letterGrade}.");
        if (passedClass == true)
        {
            Console.WriteLine("You passed! Nice job!");
        }
        else
        {
            Console.WriteLine("You did not pass. Try again, you can do it!");
        }
    }
}