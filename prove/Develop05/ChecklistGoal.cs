using System;

public class ChecklistGoal : Goal
{
    private int _timesCompleted = 0;
    private int _totalTimes = 0;
    private int _bonus = 0;

    public ChecklistGoal() : base()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _totalTimes = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
    }

    public override string GetGoal()
    {
        string checkMark = _isComplete ? "[X]" : "[ ]";
        return $"{checkMark} {base.GetName()} ({base.GetShortDescription()}) - {_timesCompleted}/{_totalTimes}";
    }

    public override void Complete()
    {
        _timesCompleted++;

        if (_timesCompleted < _totalTimes)
        {
            _pointsEarned += _pointsWorth;
        }
        else if (_timesCompleted > _totalTimes)
        {
            _pointsEarned += _pointsWorth;
        }
        else
        {
            _isComplete = true;
            Console.WriteLine("Congrats! You completed your checklist goal.");
            Console.WriteLine($"You received a bonus of {_bonus} points.");
            _pointsWorth += _bonus;
        }
    }
}