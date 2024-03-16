using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();
            if (input == "quit")
                break;
            else
                scripture.HideRandomWords(2);
        } 

        Console.WriteLine("All words have been hidden. Press any key to exit.");
        Console.ReadKey();
    }
}