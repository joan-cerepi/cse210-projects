using System;
using System.Collections.Generic;
using System.IO;

public class ListingActivity : Activity
{
    private string[] _prompts = new string[] {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name) : base(name)
    {

    }

    public void ListActivities()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        StartSpinner(6);
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();

        Random randomizer = new Random();
        int randomIndex = randomizer.Next(0, _prompts.Length);
        Console.WriteLine($"-- {_prompts[randomIndex]} --");

        Console.Write("You may begin in: ");
        Countdown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base.GetDuration());

        string path = @"./listedActivities.txt";

        if (File.Exists(path))
        {
            File.Delete(path);
        }
        
        File.AppendAllText(path, $"-- {_prompts[randomIndex]} --\n\n");
        int itemCounter = 0;
        while (startTime < endTime)
        {
            Console.Write("> ");
            string userAnswer = Console.ReadLine();
            File.AppendAllText(path, userAnswer + "\n");
            itemCounter++;
            startTime = DateTime.Now;
        }
        base.DisplayEndingMessage(3, 7);
    }
}