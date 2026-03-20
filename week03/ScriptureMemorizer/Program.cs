using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, scriptureText);
        string referenceText = reference.GetDisplayText();

        Console.Write("How many words would you like to hide at a time? ");
        int wordsToHide = int.Parse(Console.ReadLine());

        bool memorizing = true;
        while (memorizing == true)
        {
            string tempScriptureText = scripture.GetDisplayText();
            Console.WriteLine(referenceText);
            Console.WriteLine(tempScriptureText);
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                memorizing = false;
            }
            else
            {
                bool completelyHidden = scripture.isCompletelyHidden();
                if (completelyHidden == true)
                {
                    Console.WriteLine($"You have memorized {referenceText}!");
                    memorizing = false;
                }
                else
                {
                    scripture.HideRandomWords(wordsToHide);
                    Console.Clear();

                    continue;
                }

            }
        }
    }
}