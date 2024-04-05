using System;
using System.Collections.Generic;

public class User
{
    private int _userId;
    private string _username;
    private string _password;

    public User(int userId, string username, string password)
    {
        _userId = userId;
        _username = username;
        _password = password;
    }

    public string GetUsername()
    {
        return _username;
    }

    public bool Login(string username, string password)
    {
        return _username == username && _password == password;
    }

    public void Logout()
    {

    }

    public void AddExpense(decimal amount, string category, DateTime date)
    {
    
    }

    public List<FinancialRecord> GetExpenses()
    {
        return new List<FinancialRecord>();
    }

    public void ClearExpenses()
    {
    
    }
}