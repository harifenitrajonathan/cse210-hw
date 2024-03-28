using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }
     public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string ToString()
    {
        return $"[Simple Goal] {_shortName}: {_description} ({_points} points)";
    }
}