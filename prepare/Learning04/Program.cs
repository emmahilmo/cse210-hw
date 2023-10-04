using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Emma Hilmo","Math");
        Console.WriteLine(assignment.GetSummary());
    }
}