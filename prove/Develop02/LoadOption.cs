using System;
using System.IO;

public class LoadOption
{
    public void LoadData(){
    {
        Console.WriteLine("Enter the filename to load responses from: ");
        string filename = Console.ReadLine();
        string filePath = filename;

        if (File.Exists(filePath))
        {
            Console.WriteLine("Loaded responses:");
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        
        else if (string.IsNullOrWhiteSpace(filePath))
        {
            filePath = "responses.txt"; // Default filename if user doesn't provide one
        }

        else if (!File.Exists(filePath))
        {
            Console.WriteLine("File does not EXIST!!");
        }

        else
        {
            Console.WriteLine("No saved responses found.");
        }
    }}}