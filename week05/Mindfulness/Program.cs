using System;

class Program
{
    static void Main(string[] args)
    {

        List<string> reflectionPrompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
        List<string> reflectionQuestions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
        List<string> listPrompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];

        // Activity testAct = new Activity();
        // testAct.ShowSpinner(5);

        // Program:
        // - Menu system to choose activity
        bool userMenu = true;
        while (userMenu == true)
        {
            Console.WriteLine("Welcome to the Mindfulness Program. Please choose an activity below to start:");
            Console.WriteLine("1. Breathing Activity\n2. Reflection Activity\n3. Listing Activity");
            Console.WriteLine("Please type a number to continue (\"0\" to quit): ");
            int userChoice = int.Parse(Console.ReadLine());
            if (userChoice == 1)
            {
                // Breathing Activity:
                string breathingName = "Breathing";
                string breathingDescrip = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                int breathingDuration = 0;
                BreathingActivity breathingAct = new BreathingActivity(breathingName, breathingDescrip, breathingDuration);
                // Standard prompt
                breathingAct.DisplayStartingMessage();
                breathingAct.Run();
                // Standard ending
                breathingAct.DisplayEndingMessage();
                continue;
            }
            else if (userChoice == 2)
            {
                // Reflection Activity
                string reflectionName = "Reflection";
                string reflectionDescrip = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                int reflectionDuration = 0;
                ReflectionActivity reflectionAct = new ReflectionActivity(reflectionPrompts, reflectionQuestions, reflectionName, reflectionDescrip, reflectionDuration);
                // Standard prompt
                reflectionAct.DisplayStartingMessage();
                reflectionAct.Run();
                // // Standard ending
                reflectionAct.DisplayEndingMessage();
                continue;
            }
            else if (userChoice == 3)
            {
                // Enumeration Activity
                // // Standard Prompt (description - This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
                // // Select random prompt to show user
                // // Program should give user countdown to think about prompt, then prompt to list items
                // // User should list as many items as they can until time runs out
                // // Activity displays number of items entered
                // // Standard ending

                continue;
            }
            else
            {
                userMenu = false;
            }
        }

    }
}