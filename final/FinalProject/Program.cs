using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Personal Finance Tracker!");

        
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        
        AccountManager accountManager = new AccountManager();
        UserManager userManager = new UserManager();
        ExpenseManager expenseManager = new ExpenseManager();
        IncomeManager incomeManager = new IncomeManager();

        
        int userId = accountManager.Register(username, password);

        
        User newUser = accountManager.GetUser(userId);
        userManager.AddUser(newUser);

        
        bool loggedIn = newUser.Login(username, password);
        if (loggedIn)
        {
            Console.WriteLine("Login successful.");

            
            Console.Write("Enter expense category: ");
            string expenseCategory = Console.ReadLine();

            Console.Write("Enter expense amount: ");
            decimal expenseAmount;
            while (!decimal.TryParse(Console.ReadLine(), out expenseAmount))
            {
                Console.WriteLine("Invalid amount. Please enter a valid number.");
                Console.Write("Enter expense amount: ");
            }

            newUser.AddExpense(expenseAmount, expenseCategory, DateTime.Now);

            Console.WriteLine("Expense added successfully.");
        }
        else
        {
            Console.WriteLine("Login failed.");
        }
    }
}