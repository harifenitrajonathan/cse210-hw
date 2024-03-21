using System;

class Program
{
    static void Main(string[] args)
    {
        int activityChoice;
        
        while (true)
        {
            Console.WriteLine("Mindfulness Activities:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");

            Console.Write("Choose an activity (1-4): ");
            string choice = Console.ReadLine();

            if (int.TryParse(choice, out activityChoice))
            {
                if (activityChoice == 1)
                {
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                }
                else if (activityChoice == 2)
                {
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                }
                else if (activityChoice == 3)
                {
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                }
                else if (activityChoice == 4)
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select again.");
            }
        }
    }
}