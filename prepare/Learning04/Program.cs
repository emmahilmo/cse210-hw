using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Emma ", "Math");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Francis", "Fractions", "7.3", "3-7");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Jorge", "History", "WW2");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}