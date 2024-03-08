using System;

public class Entry
{ 
    public DateTime _Date { get; set; }
    public string _Prompt { get; set; }
    public string _Response { get; set; }

    public void Display()
    {
        Console.WriteLine($"{_Date}: {_Prompt}");
        Console.WriteLine($"Response: {_Response}\n");
    }
}