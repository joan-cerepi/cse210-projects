using System;

public class SimpleGoal : Goal
{
    public SimpleGoal() : base()
    {
        _goalType = "SimpleGoal";
    }

    public SimpleGoal(string name, string shortDescription, string goalType, int pointsWorth, int pointsEarned, bool isComplete) : base(name, shortDescription, goalType, pointsWorth, pointsEarned)
    {
        _isComplete = isComplete;
    }

    public override string GetGoal()
    {
        string checkMark = _isComplete ? "[X]" : "[ ]";
        return $"{checkMark} {base.GetName()} ({base.GetShortDescription()})";
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        _pointsEarned += _pointsWorth;
    }

    public override void Save(string filepath)
    {
        string goalType = _goalType;
        string name = base.GetName();
        string shortDescription = base.GetShortDescription();
        int pointsWorth = base.GetPointsWorth();
        int pointsEarned = base.GetPointsEarned();
        bool isComplete = base.IsComplete();
        File.AppendAllText(filepath, $"{goalType}||{name}||{shortDescription}||{pointsWorth}||{pointsEarned}||{isComplete}\n");
    }
}