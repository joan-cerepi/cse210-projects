using System;

public class ChecklistGoal : Goal
{
    private int _timesCompleted = 0;
    private int _totalTimes = 0;
    private int _bonus = 0;

    public ChecklistGoal() : base()
    {
        _goalType = "ChecklistGoal";
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _totalTimes = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
    }

    public ChecklistGoal(string name, string shortDescription, string goalType, int pointsWorth, int pointsEarned, int timesCompleted, int totalTimes, int bonus, bool isComplete) : base(name, shortDescription, goalType, pointsWorth, pointsEarned)
    {
        _isComplete = isComplete;
        _timesCompleted = timesCompleted;
        _totalTimes = totalTimes;
        _bonus = bonus;
    }

    public override string GetGoal()
    {
        string checkMark = _isComplete ? "[X]" : "[ ]";
        return $"{checkMark} {base.GetName()} ({base.GetShortDescription()}) -- Currently completed: {_timesCompleted}/{_totalTimes}";
    }

    public override void RecordEvent()
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
            _pointsEarned += _pointsWorth;
        }
    }

    public override void Save(string filepath)
    {
        string goalType = _goalType;
        string name = base.GetName();
        string shortDescription = base.GetShortDescription();
        int pointsWorth = base.GetPointsWorth();
        int pointsEarned = base.GetPointsEarned();
        bool isComplete = base.IsComplete();
        File.AppendAllText(filepath, $"{goalType}||{name}||{shortDescription}||{pointsWorth}||{pointsEarned}||{_bonus}||{_timesCompleted}||{_totalTimes}||{isComplete}\n");
    }
}