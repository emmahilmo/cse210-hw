using System;

class Program
{
    static void Main(string[] args)
    {
        int selection = -1;
        while(selection != 4) {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            selection = int.Parse(Console.ReadLine());

            switch(selection) {
                case 1: {
                    Console.Clear();
                    string name = "Breathing Activity";
                    string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                    BreathingActivity breathingActivity = new BreathingActivity(name, description);
                    breathingActivity.Run();

                    break;
                }
                case 2: {
                    Console.Clear();
                    // string name = "Reflecting Activity";
                    // string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                    // ReflectingActivity reflectingActivity = new ReflectingActivity(name, description);
                    // reflectingActivity.Run();

                    break;
                }
                case 3: {
                    // string name = "Listing Activity";
                    // string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                    // ListingActivity listingActivity = new ListingActivity(name, description, duration, count, prompts);
                    // listingActivity.Run();

                    break;
                }
            }
        }
    }
}