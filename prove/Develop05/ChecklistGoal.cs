using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} - Completed {_amountCompleted}/{_target} times";
    }

    public override string ToString()
    {
        return $"[Checklist Goal] {_shortName}: {_description} ({_points} points, Target: {_target}, Bonus: {_bonus})";
    }
}