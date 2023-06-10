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
            Console.Write(_message1);
            base.Countdown(4);
            Console.WriteLine();
            
            Console.Write(_message2);
            base.Countdown(6);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
        base.DisplayEndingMessage(3, 7);
    }
}