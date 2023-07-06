using System;

public class SimpleGoal : Goal
{
    public SimpleGoal() : base()
    {

    }

    public override void Complete()
    {
        _isComplete = true;
        _pointsEarned = _pointsWorth;
    }
}