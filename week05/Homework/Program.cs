using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Bob Jones", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment math1 = new MathAssignment("5.9", "6-25", "Bub Dubbs", "Calculus");
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment history1 = new WritingAssignment("The Things Our Fathers Saw", "Bib Dibbs", "History");
        Console.WriteLine(history1.GetWritingInformation());
    }
}