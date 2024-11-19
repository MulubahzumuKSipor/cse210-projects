using System;
using System.Collections.Generic;

public class ToRead{
    public void DisplayInfo(List<Tuple<string, string, DateTime>> data){

        foreach (var collectedData in data)
                {
                    Console.WriteLine(@$"
                    Prompts: {collectedData.Item1}
                    Response: {collectedData.Item2}
                    {collectedData.Item3}");
                }
    }
}