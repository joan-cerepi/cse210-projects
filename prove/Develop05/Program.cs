using System;
using System.Collections.Generic;

class Program
{
    private static List<Goal> _goals = new List<Goal>();

    static void Main(string[] args)
    {
        bool isRunning = true;
        while (isRunning)
        {
            Menu();
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CreateNewGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again...");
                    break;
            }
        }
    }

    static void Menu()
    {
        int pointsTotal = 0;
        Console.WriteLine();
        Console.WriteLine($"You have {pointsTotal} points.");
        Console.WriteLine();

        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.WriteLine("\t6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    static void CreateNewGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checkpoint Goal");

        Console.Write("Which type of Goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                SimpleGoal simpleGoal = new SimpleGoal();
                _goals.Add(simpleGoal);
                break;
            case 2:
                break;
            case 3:
                break;
            default:
                Console.WriteLine("Invalid input. Please try again...");
                break;
        }
    }

    static void ListGoals()
    {
        if (_goals.Count > 0)
        {
            int counter = 0;
            foreach (Goal goal in _goals)
            {
                counter++;
                Console.WriteLine($"{counter}. {goal.GetGoal()}");
            }
        }
        else
        {
            Console.WriteLine("There are no goals in your list.");
        }
    }
}