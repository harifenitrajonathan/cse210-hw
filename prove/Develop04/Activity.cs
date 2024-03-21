using System;

public class Activity
{ 
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} activity.");
        Console.WriteLine(_description);
        Console.WriteLine(" How long, in second, would you like for you sessions ?  ");
        string input = Console.ReadLine();
        while (!int.TryParse(input, out _duration) || _duration <= 0)
        {
            Console.WriteLine("Invalid input. Please enter the duration: ");
            input = Console.ReadLine();
        }
        Console.WriteLine($"Duration: {_duration} seconds.");
        Thread.Sleep(2000);
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(2000);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You've completed the {_name} activity.");
        Console.WriteLine($"Duration: {_duration} seconds.");
        Console.WriteLine("Well done!");
        Thread.Sleep(2000);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

}