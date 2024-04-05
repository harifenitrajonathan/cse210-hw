using System;
using System.Collections.Generic;

public class Program
{
    private static AccountManager _accountManager = new AccountManager();
    private static ExpenseManager _expenseManager = new ExpenseManager();

    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Personal Finance Tracker!");

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Sign in");
            Console.WriteLine("2. Create an account");
            Console.WriteLine("3. Quit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SignIn();
                    break;
                case 2:
                    CreateAccount();
                    break;
                case 3:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void SignIn()
    {
        Console.WriteLine("Enter your username:");
        string username = Console.ReadLine();

        Console.WriteLine("Enter your password:");
        string password = Console.ReadLine();

        User user = _accountManager.GetCurrentUser();
        if (user != null && user.Login(username, password))
        {
            Console.WriteLine("Login successful!");

            bool loggedIn = true;
            while (loggedIn)
            {
                Console.WriteLine("1. Create an expense");
                Console.WriteLine("2. Recorded expenses");
                Console.WriteLine("3. Clear expenses");
                Console.WriteLine("4. Quit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateExpense();
                        break;
                    case 2:
                        ShowExpenses();
                        break;
                    case 3:
                        ClearExpenses();
                        break;
                    case 4:
                        loggedIn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid username or password. Please try again.");
        }
    }

    private static void CreateAccount()
    {
        Console.WriteLine("Enter a username:");
        string username = Console.ReadLine();

        Console.WriteLine("Enter a password:");
        string password = Console.ReadLine();

        _accountManager.Register(username, password);
        Console.WriteLine("Account created successfully!");
    }

    private static void CreateExpense()
    {
        Console.WriteLine("Enter expense amount:");
        decimal amount = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter expense category:");
        string category = Console.ReadLine();

        Console.WriteLine("Enter expense date (YYYY-MM-DD):");
        DateTime date = Convert.ToDateTime(Console.ReadLine());

        User user = _accountManager.GetCurrentUser();
        if (user != null)
        {
            user.AddExpense(amount, category, date);
            _expenseManager.AddExpense(new FinancialRecord(amount, category, date));
            Console.WriteLine("Expense added successfully!");
        }
        else
        {
            Console.WriteLine("User not found. Please sign in again.");
        }
    }

    private static void ShowExpenses()
    {
        User user = _accountManager.GetCurrentUser();
        if (user != null)
        {
            List<FinancialRecord> expenses = user.GetExpenses();
            Console.WriteLine("Recorded expenses:");
            foreach (var expense in expenses)
            {
                Console.WriteLine($"Category: {expense.GetCategory()}, Amount: {expense.GetAmount()}, Date: {expense.GetDate()}");
            }
        }
        else
        {
            Console.WriteLine("User not found. Please sign in again.");
        }
    }

    private static void ClearExpenses()
    {
        User user = _accountManager.GetCurrentUser();
        if (user != null)
        {
            user.ClearExpenses();
            _expenseManager.ClearExpenses();
            Console.WriteLine("Expenses cleared successfully!");
        }
        else
        {
            Console.WriteLine("User not found. Please sign in again.");
        }
    }
}