using System;
using System.Collections.Generic;

/*
    For the creativity part I wrote code that displays a random inspirational quote every time
    you record an event and it gets checked off.
*/

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
                    Save();
                    break;
                case 4:
                    Load();
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

    static void Save()
    {
        if (_goals.Count > 0)
        {
            Console.Write("Where would you like to save your program (filepath)? ");
            string filepath = Console.ReadLine();
            File.AppendAllText(filepath, $"{_pointsTotal}\n");
            foreach(Goal goal in _goals)
            {
                goal.Save(filepath);
            }
        }
        else
        {
            Console.WriteLine("There is no goals to save.");
        }
    }

    static void Load()
    {
        Console.Write("Where is the goal tracker file you wish to retrieve? ");
        string filepath = Console.ReadLine();
        string[] lines = File.ReadAllLines(filepath);
        _goals = new List<Goal>();
        _pointsTotal = int.Parse(lines[0]);

        foreach(string line in lines.Skip(1))
        {
            string[] cleanLine = line.Trim().Split("||");
            string goalType = cleanLine[0];
            string name = cleanLine[1];
            string shortDescription = cleanLine[2];
            int pointsWorth = int.Parse(cleanLine[3]);
            int pointsEarned = int.Parse(cleanLine[4]);
            switch(goalType)
            {
                case "SimpleGoal":
                    bool isComplete = Boolean.Parse(cleanLine[5]);
                    SimpleGoal simpleGoal = new SimpleGoal(name, shortDescription, goalType, pointsWorth, pointsEarned, isComplete);
                    _goals.Add(simpleGoal);
                    break;
                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal(name, shortDescription, goalType, pointsWorth, pointsEarned);
                    _goals.Add(eternalGoal);
                    break;
                case "ChecklistGoal":
                    bool isComplete2 = Boolean.Parse(cleanLine[8]);
                    int bonus = int.Parse(cleanLine[5]);
                    int timesCompleted = int.Parse(cleanLine[6]);
                    int totalTimes = int.Parse(cleanLine[7]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, shortDescription, goalType, pointsWorth, pointsEarned, timesCompleted, totalTimes, bonus, isComplete2);
                    _goals.Add(checklistGoal);
                    break;
            }
        }
    }

    static void Record()
    {
        if (_goals.Count > 0)
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
            completedGoal.RecordEvent();
            int pointsWorth = completedGoal.GetPointsWorth();
            _pointsTotal += pointsWorth;
            Console.WriteLine($"Congratulations! You have earned {pointsWorth} points.");
            Console.WriteLine($"You now have {_pointsTotal} points.");
            completedGoal.DisplayInspirationalQuote();
        }
        else
        {
            Console.WriteLine("There are no goals in the list.");
        }
    }
}