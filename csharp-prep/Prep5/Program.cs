using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int userNumSquared = SquareNumber(userNumber);
        DisplayResult(userName, userNumSquared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!\n");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNum)
    {
        Console.WriteLine($"\nYour name is {name}.");
        Console.WriteLine($"Your favorite number squared is {squaredNum}.");
    }
}