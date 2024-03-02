using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int x = -1;

        while (x != magicNumber)
        {
            Console.Write("What is your guess? ");
            x = int.Parse(Console.ReadLine());

            if (magicNumber > x )
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < x)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } 
    }
}