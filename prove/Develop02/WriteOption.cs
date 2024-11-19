using System;
using System.Collections.Generic;

public class ToWrite
{
    public void Declare(List<Tuple<string, string, DateTime>> data)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string currentPrompt = promptGenerator.DisplayResult();

        Console.WriteLine(currentPrompt);
        Console.Write("> ");
        string response = Console.ReadLine();
        DateTime currentTime = DateTime.Now;

        data.Add(new Tuple<string, string, DateTime>(currentPrompt, response, currentTime));

        Console.WriteLine("Response saved!");
    }
}
