using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int choice;
        do
        {
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        CreateGoal();
                        break;
                    case 2:
                        ListGoalDetails();
                        break;
                    case 3:
                        SaveGoals();
                        break;
                    case 4:
                        LoadGoals();
                        break;
                    case 5:
                        RecordEvent();
                        break;
                    case 6:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        } while (choice != 6);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player's score: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("List of goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.ShortName);
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("List of goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Types of Goals:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            string name, description;
            int points, target, bonus;
            switch (choice)
            {
                case 1:
                    Console.Write("What is the name of your goal? ");
                    name = Console.ReadLine();
                    Console.Write("What is the short description of it? ");
                    description = Console.ReadLine();
                    Console.Write("What amount of points associated with this goal? ");
                    int.TryParse(Console.ReadLine(), out points);
                    _goals.Add(new SimpleGoal(name, description, points));
                    break;
                case 2:
                    Console.Write("What is the name of your goal? ");
                    name = Console.ReadLine();
                    Console.Write("What is the short description of it? ");
                    description = Console.ReadLine();
                    Console.Write("What amount of points associated with this goal? ");
                    int.TryParse(Console.ReadLine(), out points);
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case 3:
                    Console.Write("What is the name of your goal? ");
                    name = Console.ReadLine();
                    Console.Write("What is the short description of it? ");
                    description = Console.ReadLine();
                    Console.Write("What amount of points associated with this goal? ");
                    int.TryParse(Console.ReadLine(), out points);
                    Console.Write("What is the target number of completions for this goal? ");
                    int.TryParse(Console.ReadLine(), out target);
                    Console.Write("What is the bonus to accomplishing it that many times? ");
                    int.TryParse(Console.ReadLine(), out bonus);
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void RecordEvent()
    {
        Console.Write("Which Goal did you accomplish? ");
        string goalName = Console.ReadLine();
        Goal goal = _goals.FirstOrDefault(g => g.ShortName.Equals(goalName, StringComparison.OrdinalIgnoreCase));
        if (goal != null)
        {
            goal.RecordEvent();
            _score += goal.Points;
            Console.WriteLine($"Congratulations! You have earned {goal.Points} points.");
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 5)
                    {
                        string type = parts[0];
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        if (type.Equals("Simple"))
                        {
                            _goals.Add(new SimpleGoal(name, description, points));
                        }
                        else if (type.Equals("Eternal"))
                        {
                            _goals.Add(new EternalGoal(name, description, points));
                        }
                        else if (type.Equals("Checklist"))
                        {
                            int target = int.Parse(parts[3]);
                            int bonus = int.Parse(parts[4]);
                            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                        }
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}