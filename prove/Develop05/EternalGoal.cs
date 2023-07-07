using System;

public class EternalGoal : Goal
{
    public EternalGoal() : base()
    {

    }

    public override string GetGoal()
    {
        string checkMark = _isComplete ? "[X]" : "[ ]";
        return $"{checkMark} {base.GetName()} ({base.GetShortDescription()})";
    }

    public override void Complete()
    {
        _pointsEarned += _pointsWorth;
    }
}