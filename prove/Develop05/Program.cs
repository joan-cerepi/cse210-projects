using System;
using System.Collections.Generic;

class Program
{
    private static List<Goal> _goals = new List<Goal>();
    private static int _pointsTotal = 0;
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
                    Record();
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
        Console.WriteLine();
        Console.WriteLine($"You have {_pointsTotal} points.");
        Console.WriteLine();

        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Create New Goal");
        Console.WriteLine("    2. List Goals");
        Console.WriteLine("    3. Save Goals");
        Console.WriteLine("    4. Load Goals");
        Console.WriteLine("    5. Record Event");
        Console.WriteLine("    6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    static void CreateNewGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checkpoint Goal");

        Console.Write("Which type of Goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                SimpleGoal simpleGoal = new SimpleGoal();
                _goals.Add(simpleGoal);
                break;
            case 2:
                EternalGoal eternalGoal = new EternalGoal();
                _goals.Add(eternalGoal);
                break;
            case 3:
                ChecklistGoal checklistGoal = new ChecklistGoal();
                _goals.Add(checklistGoal);
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

    static void Record()
    {
        Console.WriteLine("The goals are:");
        int counter = 0;
        foreach (Goal goal in _goals)
        {
            counter++;
            Console.WriteLine($"{counter}. {goal.GetName()}");
        }
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        Goal completedGoal = _goals[choice - 1];
        completedGoal.Complete();
        int pointsWorth = completedGoal.GetPointsWorth();
        _pointsTotal += pointsWorth;
        Console.WriteLine($"Congratulations! You have earned {pointsWorth} points.");
        Console.WriteLine($"You now have {_pointsTotal} points.");
    }
}