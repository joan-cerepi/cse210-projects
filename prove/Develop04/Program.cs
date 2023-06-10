using System;
/*
    -- Creativity --
    In the listing activity, I wrote code that will store the randomly selected prompt, plus all the
    user answers in a file in the current program folder.
    I also wrote code for the reflection activity that will make a decision for the random prompts
    based on previously selected prompts, so that the user will not be given the same prompt more than once.
    Also, if the program runs out of prompts, it will break out of the loop and move on with the rest
    of the code.
*/


class Program
{
    static void Main(string[] args)
    {
        bool isActive = true;
        while (isActive)
        {
            Menu();
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity");
                    breathingActivity.SetStartingMessage("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathingActivity.DisplayStartingMessage();
                    Console.WriteLine();
                    breathingActivity.DisplayStartingPrompt();
                    breathingActivity.SetDuration();
                    breathingActivity.Breathe();
                    break;
                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity");
                    reflectionActivity.SetStartingMessage("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflectionActivity.DisplayStartingMessage();
                    Console.WriteLine();
                    reflectionActivity.DisplayStartingPrompt();
                    reflectionActivity.SetDuration();
                    reflectionActivity.Reflect();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity("Listing Activity");
                    listingActivity.SetStartingMessage("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listingActivity.DisplayStartingMessage();
                    Console.WriteLine();
                    listingActivity.DisplayStartingPrompt();
                    listingActivity.SetDuration();
                    listingActivity.ListActivities();
                    break;
                case 4:
                    isActive = false;
                    break;
            }
        }
    }

    static void Menu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflection activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
    }
}