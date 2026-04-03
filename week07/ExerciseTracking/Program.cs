using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();

        RunningExercise running1 = new RunningExercise(5.0, "3/31/2026", 25);
        CyclingExercise cycling1 = new CyclingExercise(45.0, "4/2/26", 10);
        SwimmingExercise swimming1 = new SwimmingExercise(7, "4/3/2026", 30);

        exercises.Add(running1);
        exercises.Add(cycling1);
        exercises.Add(swimming1);

        foreach (Exercise exercise in exercises)
        {
            string summary = exercise.GetSummary();
            Console.WriteLine(summary);
        }

    }
}