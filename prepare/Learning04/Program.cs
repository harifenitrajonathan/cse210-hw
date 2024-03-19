using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment first = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(first.GetSummary());

        MathAssignment second = new MathAssignment ("Roberto Rodriguez", "Fractions", " 7.3", "8-9");
        Console.WriteLine(second.GetSummary());
        Console.WriteLine(second.GetHomeworklist());
    
        WrittingAssignment third = new WrittingAssignment("Mary Waters", "European History", "The Cause of The World War II");
        Console.WriteLine(third.GetSummary());
        Console.WriteLine(third.GetWritingInformation());
    }
}