using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private string[] _prompts = new string[] {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private string[] _answers = new string[] {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string name) : base(name)
    {

    }

    public void Reflect()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        StartSpinner(6);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        
        Random randomizer = new Random();
        int randomIndex = randomizer.Next(0, _prompts.Length);
        Console.WriteLine($"-- {_prompts[randomIndex]} --");

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press <enter> to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base.GetDuration());
        List<int> indices = new List<int>();
        while (startTime < endTime)
        {
            randomIndex = randomizer.Next(0, _answers.Length);

            if (indices.Count == _answers.Length)
            {
                break;
            }
            else if (indices.Exists(index => index == randomIndex))
            {
                continue;
            }

            Console.Write($"> {_answers[randomIndex]} ");
            StartSpinner(8);
            Console.WriteLine();
            indices.Add(randomIndex);
            startTime = DateTime.Now;
        }
        base.DisplayEndingMessage(3, 7);
    }
}