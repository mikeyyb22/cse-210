using System;

class Program
{
    static void Main(string[] args)
    {

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
                Console.WriteLine("Breathing Activity chosen.");
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
                // // Standard prompt (description - "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
                // // Select random prompt to show to user
                // // After, ask user to reflect on questions that relate to the experience.
                // // Pause for several seconds before continuing to next question
                // // Continue until reaching # of seconds user specified
                // // Standard ending

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