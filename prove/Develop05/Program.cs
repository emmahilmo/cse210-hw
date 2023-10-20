using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        
        int selection = -1;
        while(selection != 6) {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            selection = int.Parse(Console.ReadLine());

            switch(selection) {
                case 1: {
                    // create new goal
                    Console.Clear();
                    goalManager.CreateGoal();
                    break;
                }
                case 2: {
                    // list goals
                    Console.Clear();
                    break;
                }
                case 3: {
                    // save goals
                    Console.Clear();
                    break;
                }
                case 4: {
                    // load goals
                    Console.Clear();
                    break;
                }
                case 5: {
                    // record event
                    Console.Clear();
                    break;
                }
            }
        }
    }
}