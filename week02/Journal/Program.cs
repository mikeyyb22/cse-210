using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a new entry
        // 5 different prompts for users to answer (they choose 1)

        // Display journal

        // Save journal to file

        // Load journal from file

        // Provide menu with above options
        bool userMenu = true;
        while (userMenu == true)
        {
            Console.WriteLine("Please choose one of the options below: ");
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. End session");
            string userOption = Console.ReadLine();

            Journal journal1 = new Journal();
            PromptGenerator prompts = new PromptGenerator();
            prompts._prompts.Add("Who was the most interesting person I interacted with today?");
            prompts._prompts.Add("What was the best part of my day?");
            prompts._prompts.Add("How did I see the hand of the Lord in my life today?");
            prompts._prompts.Add("What was the strongest emotion I felt today?");
            prompts._prompts.Add("If I had one thing I could do over today, what would it be?");


            if (userOption == "1")
            {
                Console.WriteLine("Write new entry chosen");
                Entry entry = new Entry();
                entry._promptText = prompts.GetRandomPrompt();
                Console.WriteLine("Today's date: ");
                entry._date = Console.ReadLine();
                Console.WriteLine($"{entry._promptText}");
                entry._entryText = Console.ReadLine();
                continue;
            }
            else if (userOption == "2")
            {
                Console.WriteLine("Display journal entries chosen");
                continue;
            }
            else if (userOption == "3")
            {
                Console.WriteLine("Save journal to file chosen");
                continue;
            }
            else if (userOption == "4")
            {
                Console.WriteLine("Load journal from file chosen");
                continue;
            }
            else
            {
                Console.WriteLine("Thank you for using the journal program.");
                userMenu = false;
            }
        }
    }
}