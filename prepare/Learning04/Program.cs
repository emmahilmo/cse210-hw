using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Emma Hilmo", "Fractions");
        MathAssignment mathAssignment = new MathAssignment("Emma Hilmo", "Fractions", "Section 7.3", "Problems 3-7");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
    }
}