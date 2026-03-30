using System.Security.Principal;

public class EnumerationActivity : Activity
{

    private List<string> _prompts;

    public EnumerationActivity(List<string> prompts, string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = prompts;
    }

    // Run activity
    public void Run()
    {
        Console.WriteLine(GetRandomPrompt());
        // Program should give user countdown to think about prompt, then prompt to list items
        Console.WriteLine("Take some time to think about this, then get ready to write!");
        ShowCountdown(10);
        List<string> userList = GetListFromUser();
        // Activity displays number of items entered

        Console.WriteLine($"Time's up! You entered {userList.Count} items. Nice job. To see what you entered, type \'1.\' Otherwise, type \'0.\'");
        int showList = int.Parse(Console.ReadLine());
        if (showList == 1)
        {
            for (int i = 0; i < userList.Count; i++)
            {
                Console.WriteLine($"{i}. {userList[i]}");
            }
        }
    }

    // Get random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count - 1);
        Console.WriteLine(randomNumber);
        string randomPrompt = _prompts[randomNumber];

        return randomPrompt;
    }

    // Get list of responses from user
    public List<string> GetListFromUser()
    {
        List<string> userResponses = new List<string>();
        int duration = GetDuration();
        Console.WriteLine($"You have {duration} seconds to list as many things as you can. The timer will not interrupt you while you are typing.");
        // User should list as many items as they can until time runs out

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        Console.WriteLine("Begin!");
        while (startTime < endTime)
        {
            string userListResponse = Console.ReadLine();
            userResponses.Add(userListResponse);
            startTime = DateTime.Now;
        }

        return userResponses;
    }

}