using System;
using System.IO;

class Program
{
    static Journal journal = new Journal();
    static PromptGenerator promptGenerator = new PromptGenerator();

    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            DisplayMenu();
            int choice = GetChoice();
            if (choice == 1)
            {
                WriteNewEntry();
            }
            else if (choice == 2)
            {
                DisplayJournal();
            }
            else if (choice == 3)
            {
                SaveJournalToFile();
            }
            else if (choice == 4)
            {
                LoadJournalFromFile();
            }
            else if (choice == 5)
            {
                exit = true;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");
    }

    static int GetChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
        }
        return choice;
    }

    static void WriteNewEntry()
    {
        Console.WriteLine("Writing a new entry...");
        string _prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine("Prompt: " + _prompt);
        Console.WriteLine("Enter your response:");
        string _response = Console.ReadLine();
        Entry entry = new Entry { _Date = DateTime.Now, _Prompt = _prompt, _Response = _response };
        journal.AddEntry(entry);
    }

    static void DisplayJournal()
    {
        journal.DisplayAll();
    }

    static void SaveJournalToFile()
    {
        Console.WriteLine("Enter filename to save the journal:");
        string _filename = Console.ReadLine();
        journal.SaveToFile(_filename);
        Console.WriteLine("Journal saved to file successfully.");
    }

    static void LoadJournalFromFile()
    {
        Console.WriteLine("Enter filename to load the journal:");
        string _filename = Console.ReadLine();
        journal.LoadFromFile(_filename);
        Console.WriteLine("Journal loaded from file successfully.");
    }
}