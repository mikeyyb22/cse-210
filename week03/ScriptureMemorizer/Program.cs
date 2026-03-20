using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, scriptureText);
        scriptureText = reference.GetDisplayText();
        bool memorizing = true;

        while (memorizing == true)
        {
            Console.WriteLine(scriptureText);
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                memorizing = false;
            }
            else
            {
                scripture.HideRandomWords(3);

                Console.Clear();

                continue;
            }
        }
    }
}