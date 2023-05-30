using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Joan Çerepi", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        MathAssignment assignment2 = new MathAssignment("Joan Çerepi", "Fractions", "7.3", "9-11");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine();
        
        WritingAssignment assignment3 = new WritingAssignment(
            "Joan Çerepi", "European History", "The Causes of World War II"
        );
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}