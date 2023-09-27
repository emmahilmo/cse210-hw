using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        myJournal._entries = new List<Entry>();

        Console.WriteLine("Welcome to the Journal Program");

        int choice = -1;

        while(choice != 5)
        {
            Console.WriteLine("Please select one of the following choices?");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
           
            string userinput = Console.ReadLine();
            //userNumber = int.Parse(userinput);

            if(choice == 1)
            {
                Entry newEntry = new Entry();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Prompt prompt = new Prompt();

                newEntry._promptText = prompt.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);
                newEntry._entryText = Console.ReadLine();

                myJournal.AddEntry(newEntry);
            }
            else if(choice == 2)
            {
                myJournal.DisplayAll();
            }
            else if(choice == 3)
            {
                Console.Write("What is the file name: ");
                string fileName = Console.ReadLine();

                myJournal.LoadFromFile(fileName);
            }
            else if (choice == 4)
            {
                Console.Write("Enter a file name: ");
                string fileName = Console.ReadLine();

                myJournal.SaveToFile(fileName);
            }
            else
            {
                Console.WriteLine("Thank you for using the Journal Program. We hope to see you again!");
            }
        
        }
    
    }
}


//Write a new entry - Show the user a random prompt (from a list that you create), 
//and save their response, the prompt, and the date as an Entry.
//Display the journal - Iterate through all entries in the journal and display them to the screen.
//Save the journal to a file - Prompt the user for a filename and then save the current journal 
//(the complete list of entries) to that file location.
//Load the journal from a file - Prompt the user for a filename and then load the journal
//(a complete list of entries) from that file. This should replace any entries currently stored the journal.
//Provide a menu that allows the user choose these options
//Your list of prompts must contain at least five different prompts. Make sure to add your own prompts to the list, 
//but the following are examples to help get you started:
//Who was the most interesting person I interacted with today?
//What was the best part of my day?
//How did I see the hand of the Lord in my life today?
//What was the strongest emotion I felt today?
//If I had one thing I could do over today, what would it be?

//Design requirements:
//Contain classes for the major components in the program.
//Contain at least two classes in addition to the Program class.
//Demonstrate the principle of abstraction by using member variables and methods appropriately.