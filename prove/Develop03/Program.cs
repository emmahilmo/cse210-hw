using System;

class Program
{
    static void Main(string[] args)
    {
        string userinput = Console.ReadLine();
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all your hear and lean not on your own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new(reference, scriptureText);
        Random random = new Random();

        Console.WriteLine(reference.GetReference());
        Console.WriteLine(scripture.Display());
        Console.WriteLine("Press 'enter' to continue or type 'quit' to end:");

        if (userinput != "quit") {

            while (Console.ReadKey().Key == ConsoleKey.Enter) {
                int number = random.Next(scripture.GetWord());
                scripture.HideRandomWord(number);
                Console.Clear();
            
                Console.WriteLine(reference.GetReference());
                Console.WriteLine(scripture.Display());
                Console.WriteLine("Press 'enter' to continue or type 'quit' to end:");
            }
        }
    }
}