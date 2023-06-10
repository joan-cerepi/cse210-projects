using System;

public class Activity
{
    private string _name;
    private string _description;
    private string _endingMessage;
    private int _duration;
    private string _startingPrompt = "How long, in seconds, would you like for your session? ";

    public Activity(string name)
    {
        _name = name;
    }

    public void SetDescription(string message)
    {
        _description = message;
    }

    public string GetStartingMessage()
    {
        return _description;
    }

    public void SetEndingMessage()
    {
        _endingMessage = $"\nWell done!!\n\nYou have completed {_duration} seconds of the {_name}.";
    }

    public string GetEndingMessage()
    {
        return _endingMessage;
    }

    public void SetDuration()
    {
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingPrompt()
    {
        Console.Write(_startingPrompt);
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
    }

    public void StartSpinner(int timeInSeconds)
    {
        string[] characters = {"|", "/", "-", "\\", "|", "/", "-", "\\"};
        int seconds = timeInSeconds;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (startTime < endTime)
        {
            foreach (string character in characters)
            {
                Console.Write(character);
                Thread.Sleep(300);
                Console.Write($"\b \b");
            }
            startTime = DateTime.Now;
        }
    }

    public void Countdown(int timeInSeconds)
    {
        int seconds = timeInSeconds;
        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds--;
        }
    }
}