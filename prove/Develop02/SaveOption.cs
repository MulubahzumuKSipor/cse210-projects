using System;
using System.Collections.Generic;
using System.IO;

public class SaveData{

    public void SavedData(List<Tuple<string, string, DateTime>> data){
        {
        Console.Write("Enter the filename to save responses (e.g., responses.txt): ");
        string filename = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(filename))
        {
            filename = "responses.txt"; // Default filename if user doesn't provide one
        }

        string filePath = filename;

        using (StreamWriter writer = new StreamWriter(filePath, true)) // 'true' allows appending to the file
        {
            foreach (var response in data)
            {
                writer.WriteLine("Prompt: " + response.Item1);
                writer.WriteLine("Response: " + response.Item2);
                writer.WriteLine("Time: " + response.Item3);
                writer.WriteLine("------------"); // Separate entries for clarity
            }
        }

        Console.WriteLine($"Responses have been saved to the file: {filePath}");
    }
}


}



    