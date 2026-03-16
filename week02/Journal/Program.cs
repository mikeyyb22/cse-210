using System;

class Program
{
    static void Main(string[] args)
    {

        Journal journal1 = new Journal();
        PromptGenerator prompts = new PromptGenerator();
        string filename = "journalFile.txt";

        prompts._prompts.Add("Who was the most interesting person I interacted with today?");
        prompts._prompts.Add("What was the best part of my day?");
        prompts._prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts._prompts.Add("What was the strongest emotion I felt today?");
        prompts._prompts.Add("If I had one thing I could do over today, what would it be?");

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

            if (userOption == "1")
            {
                Console.WriteLine("Write new entry chosen");
                Entry entry = new Entry();
                entry._promptText = prompts.GetRandomPrompt();
                DateTime currentTime = DateTime.Now;
                entry._date = currentTime.ToShortDateString();
                Console.WriteLine($"{entry._promptText}");
                entry._entryText = Console.ReadLine();
                journal1.AddEntry(entry);
                continue;
            }
            else if (userOption == "2")
            {
                Console.WriteLine("Display journal entries chosen");
                journal1.DisplayAll();
                continue;
            }
            else if (userOption == "3")
            {
                Console.WriteLine("Save journal to file chosen");
                journal1.SaveToFile(filename);
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