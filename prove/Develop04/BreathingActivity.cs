using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public void Run()
    {
        DisplayStartingMessage();

        for (int i = 0; i < _duration; i += 2)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(2);
            Console.Write("\b\b"); 
            Console.WriteLine("Breathe out...");
            ShowCountDown(2);
            Console.Write("\b\b"); 

        }

        DisplayEndingMessage();
    }
}