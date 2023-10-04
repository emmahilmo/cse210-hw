using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs 3:5");
        string scriptureText = "Trust in the Lord with all your hear and lean not on your own understanding.";
        Scripture scripture = new(reference, scriptureText);
    }
}