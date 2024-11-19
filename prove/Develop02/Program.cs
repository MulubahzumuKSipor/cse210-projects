using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int userNumber = -1;
        
        ToWrite toWrite = new ToWrite();
        ToRead toRead = new ToRead();
        LoadOption toLoad = new LoadOption();
        SaveData toSave = new SaveData();


        // Store entered prompts and responses
        List<Tuple<string, string, DateTime>> data = new List<Tuple<string, string, DateTime>>();
        
        while (userNumber != 5)
        {
            Console.WriteLine(@"Please select one of the following choices: 
    1. Write
    2. Display
    3. Load
    4. Save
    5. Quit");

            Console.Write("What would you like to do?");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            

            if (userNumber == 1) // Display random prompts and store responses
            {
                toWrite.Declare(data);
            }
            else if(userNumber == 2){
                toRead.DisplayInfo(data);
            }
            else if (userNumber == 3)
            {
                toLoad.LoadData();
            }
            else if(userNumber == 4){
                toSave.SavedData(data);
            }
            

            }
            }
            }
            


    



