using System;

public abstract class Goal
{
    private string _name = "";
    private string _shortDescription = "";
    protected bool _isComplete;
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

    public string GetName()
    {
        return _name;
    }

    public string GetShortDescription()
    {
        return _shortDescription;
    }

    public abstract void Complete();

    public string GetGoal()
    {
        string checkMark = _isComplete ? "[X]" : "[ ]";
        return $"{checkMark} {_name} ({_shortDescription})";
    }
}