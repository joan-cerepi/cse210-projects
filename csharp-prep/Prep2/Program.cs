using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentString = Console.ReadLine();
        int gradePercent = int.Parse(gradePercentString);
        char letter;

        if (gradePercent >= 90)
        {
            letter = 'A';
        }
        else if (gradePercent >= 80)
        {
            letter = 'B';
        }
        else if (gradePercent >= 70)
        {
            letter = 'C';
        }
        else if (gradePercent >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }
        Console.WriteLine(letter);

        // Blank line separator.
        Console.WriteLine();

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("You need at least 70% to pass this class. Better luck next time.");
        }
    }
}