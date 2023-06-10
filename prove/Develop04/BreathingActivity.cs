using System;
using System.Collections.Generic;

public class BreathingActivity : Activity
{
    private string _message1 = "Breathe in...";
    private string _message2 = "Now breathe out...";

    public BreathingActivity(string name) : base(name)
    {
        
    }

    public void Breathe()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        StartSpinner(7);

        int duration = base.GetDuration();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(duration);

        while (currentTime < futureTime)
        {
            Console.WriteLine();
            for (int i = 4; i > 0; i--)
            {
                Console.Write($"{_message1}{i}");
                string whiteOut = new string('\b', _message1.Length + 2);
                Console.Write(whiteOut);
                Thread.Sleep(1000);
                currentTime = DateTime.Now;
            }
            Console.WriteLine($"{_message1}  ");

            for (int i = 6; i > 0; i--)
            {
                Console.Write($"{_message2}{i}");
                string whiteOut = new string('\b', _message2.Length + 2);
                Console.Write(whiteOut);
                Thread.Sleep(1000);
                currentTime = DateTime.Now;
            }
            Console.WriteLine($"{_message2}  ");
        }
        SetEndingMessage();
        string endingMessage = base.GetEndingMessage();
        Console.WriteLine(endingMessage);
        StartSpinner(7);
        Console.Clear();
    }
}