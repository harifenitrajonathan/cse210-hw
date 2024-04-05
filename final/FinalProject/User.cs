using System;
using System.Collections.Generic;

public class User
{
    private int userId;
    private string username;
    private string password;

    public int UserId => userId;

    public User(int userId, string username, string password)
    {
        this.userId = userId;
        this.username = username;
        this.password = password;
    }

    public bool Login(string username, string password)
    {
        return this.username == username && this.password == password;
    }

    public void Logout()
    {
        
    }

    public void AddIncome(decimal amount, string category, DateTime date)
    {
        
    }

    public void AddExpense(decimal amount, string category, DateTime date)
    {
        
    }

    public void SetBudget(string category, decimal amount)
    {
        
    }

    public decimal GetBudget(string category)
    {
        
        return 0;
    }

    public Report GenerateReport(DateTime startDate, DateTime endDate)
    {
        
        return null;
    }
}
