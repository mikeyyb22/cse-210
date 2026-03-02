using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input your current grade %: ");
        string gradeInput = Console.ReadLine();
        int userGrade = int.Parse(gradeInput);
        char letterGrade = 'E';

        if (userGrade >= 90)
        {
            letterGrade = 'A';
        }
        else if (userGrade >= 80)
        {
            letterGrade = 'B';
        }
        else if (userGrade >= 70)
        {
            letterGrade = 'C';
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
    }
}