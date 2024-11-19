using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string DisplayResult()
    {
        // Display random prompts
        {
            Random random = new Random();
            int randomIndex = random.Next(prompts.Count);

            //Print random prompts
            string randomSelect = prompts[randomIndex];
            return randomSelect;
        }
    }
}