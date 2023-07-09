using System;

public class EternalGoal : Goal
{
    public EternalGoal() : base()
    {
        _goalType = "EternalGoal";
    }

    public EternalGoal(string name, string shortDescription, string goalType, int pointsWorth, int pointsEarned) : base(name, shortDescription, goalType, pointsWorth, pointsEarned)
    {
        
    }

    public override string GetGoal()
    {
        string checkMark = _isComplete ? "[X]" : "[ ]";
        return $"{checkMark} {base.GetName()} ({base.GetShortDescription()})";
    }

    public override void RecordEvent()
    {
        _pointsEarned += _pointsWorth;
    }

    public override void Save(string filepath)
    {
        string goalType = _goalType;
        string name = base.GetName();
        string shortDescription = base.GetShortDescription();
        int getPointsWorth = base.GetPointsWorth();
        int getPointsEarned = base.GetPointsEarned();
        File.AppendAllText(filepath, $"{goalType}||{name}||{shortDescription}||{getPointsWorth}||{getPointsEarned}\n");
    }
}