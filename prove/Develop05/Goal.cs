using System;

public abstract class Goal
{
    private string _name = "";
    private string _shortDescription = "";
    protected bool _isComplete = false;
    protected string _goalType;
    protected int _pointsWorth;
    protected int _pointsEarned = 0;

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

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public abstract string GetGoal();

    public abstract void RecordEvent();

    public abstract void Save(string filepath);
}