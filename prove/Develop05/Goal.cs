using System;

public abstract class Goal
{
    private string _name = "";
    private string _shortDescription = "";
    protected bool _isComplete = false;
    protected string _goalType;
    protected int _pointsWorth;
    protected int _pointsEarned = 0;
    protected string[] _inspirationalQuotes = {
        "\"Success is not the key to happiness. Happiness is the key to success. If you love what you are doing, you will be successful.\" - Albert Schweitzer",
        "\"The future belongs to those who believe in the beauty of their dreams.\" - Eleanor Roosevelt",
        "\"The only way to do great work is to love what you do.\" - Steve Jobs",
        "\"You are never too old to set another goal or to dream a new dream.\" - C.S. Lewis",
        "\"Believe you can and you're halfway there.\" - Theodore Roosevelt",
        "\"Success is not final, failure is not fatal: It is the courage to continue that counts.\" - Winston Churchill",
        "\"The only limit to our realization of tomorrow will be our doubts of today.\" - Franklin D. Roosevelt",
        "\"Don't watch the clock; do what it does. Keep going.\" - Sam Levenson",
        "\"Your time is limited, don't waste it living someone else's life.\" - Steve Jobs",
        "\"You have within you right now, everything you need to deal with whatever the world can throw at you.\" - Brian Tracy"
    };

    public Goal()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _shortDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _pointsWorth = int.Parse(Console.ReadLine());
    }

    public Goal(string name, string shortDescription, string goalType, int pointsWorth, int pointsEarned)
    {
        _name = name;
        _shortDescription = shortDescription;
        _goalType = goalType;
        _pointsWorth = pointsWorth;
        _pointsEarned = pointsEarned;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;        
    }

    public string GetShortDescription()
    {
        return _shortDescription;
    }

    public void SetShortDescription(string description)
    {
        _shortDescription = description;
    }

    public int GetPointsWorth()
    {
        return _pointsWorth;
    }

    public void SetPointsWorth(int pointsWorth)
    {
        _pointsWorth = pointsWorth;
    }

    public int GetPointsEarned()
    {
        return _pointsEarned;
    }

    public void SetPointsEarned(int pointsEarned)
    {
        _pointsEarned = pointsEarned;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }

    public void SetStatus(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public void DisplayInspirationalQuote()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, _inspirationalQuotes.Length);
        Console.WriteLine();
        Console.WriteLine(_inspirationalQuotes[randomIndex]);
        Console.WriteLine();
    }

    public abstract string GetGoal();

    public abstract void RecordEvent();

    public abstract void Save(string filepath);
}