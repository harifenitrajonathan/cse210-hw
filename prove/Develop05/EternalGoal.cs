using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string ToString()
    {
        return $"[Eternal Goal] {_shortName}: {_description} ({_points} points)";
    }
}