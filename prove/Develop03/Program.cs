using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs 3:5-6");
        string scriptureText = "Trust in the Lord with all your hear and lean not on your own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new(reference, scriptureText);

        Console.WriteLine(reference.GetReference());
        Console.WriteLine(scripture.Display());
        Console.WriteLine("Press 'enter' to continue or type 'quit' to end:");
    }
}