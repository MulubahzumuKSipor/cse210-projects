using System;

class Program
{
    static void Main(string[] args)
    {
        int _userResponse = 0;

        while (_userResponse != 4)
        {
            //Clear Console
            Console.Clear();
            // Display Menu of options
            Console.WriteLine(
                @"
1. Breathing activity
2. Reflection activity
3. Listing activity
4. Quit
What would you like to do?"
            );
            // Store response
            _userResponse = int.Parse(Console.ReadLine());

            // Get all common info
            string name = "";
            string description = "";
            int time = 0;
            // Logical and final aspect of the program
            //Breathing activity
            Breathing breathing = new Breathing(name, description, time);
            Listing listing = new Listing(name, description, time);
            Reflecting reflecting = new Reflecting(name, description, time);
            if (_userResponse == 1)
            {
                breathing.Run();
            }
            //Reflect Activity
            else if (_userResponse == 2)
            {
                reflecting.Run();
            }
            //List Activity
            else if (_userResponse == 3)
            {
                listing.Run();
            }

            Activity newActivity = new Activity(name, description, time);

            time = newActivity.Duration;
        }
    }
}
