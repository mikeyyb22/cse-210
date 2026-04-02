// XP System

using System;

class Program
{
    static void Main(string[] args)
    {
        // Provide for simple goals that can be marked complete and user gains XP
        // Provide for eternal goals that are never complete, but gain XP every time they're done
        // Provide for checklist goal that must be accomplished a certain amount of times before they're complete
        // Display score (XP/Level)
        // Show list of goals with current progress (checklist/times completed)
        // Allow goals and current XP/Level to saved and loaded

        GoalManager goalManager = new GoalManager();

        goalManager.Start();

    }
}