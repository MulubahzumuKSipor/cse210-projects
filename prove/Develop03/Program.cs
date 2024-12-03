using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string _filePath = "Scripture.txt";

        if (File.Exists(_filePath))
        {
            string[] _lines = File.ReadAllLines(_filePath);

            if (_lines.Length >= 2)
            {
                string _referenceLine = _lines[0];
                string _textLine = string.Join(" ", _lines, 1, _lines.Length - 1);

                Reference _reference = new Reference(_referenceLine);
                Scripture _scripture = new Scripture(_reference, _textLine);

                // Main loop
                while (true)
                {
                    _scripture.DisplayScripture();
                    Console.WriteLine(
                        "\nPress Enter to continue or type 'quit' to exit the program:"
                    );

                    string _userPrompt = Console.ReadLine();

                    if (_userPrompt?.ToLower() == "quit")
                    {
                        break;
                    }

                    if (string.IsNullOrEmpty(_userPrompt))
                    {
                        _scripture.HideRandomWord();
                    }

                    // Check if all words have been hidden
                    if (_scripture.AllWordsHidden())
                    {
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine(
                    "Invalid file format. Ensure the file contains at least a reference and a scripture text."
                );
            }
        }
        else
        {
            Console.WriteLine("The file does not exist.");
        }
    }
}
