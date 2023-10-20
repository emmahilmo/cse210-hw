using System;

class Program
{
    static void Main(string[] args)
    {
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
            Console.WriteLine("Select a choice from the menu: ");
            selection = int.Parse(Console.ReadLine());

            switch(selection) {
                case 1: {
                    // create new goal

                    break;
                }
                case 2: {
                    // list goals

                    break;
                }
                case 3: {
                    // save goals

                    break;
                }
                case 4: {
                    // load goals

                    break;
                }
                case 5: {
                    // record event
                    
                    break;
                }
            }
        }
    }
}