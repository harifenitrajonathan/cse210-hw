using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public string ShortName { get { return _shortName; } }
    public int Points { get { return _points; } }

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description}";
    }

    public string GetStringRepresentation()
    {
        return $"{GetType().Name}|{_shortName}|{_description}|{_points}";
    }
}