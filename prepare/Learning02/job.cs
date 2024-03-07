using System;
public class Job
{
    public string _jobTitle;
    public string  _compagny;
    public int _startYear; 
    public int _endYear;

    public void Display()
    {
        Console.WriteLine ($"{_jobTitle} ({_compagny}) {_startYear} - {_endYear}");
    }
}