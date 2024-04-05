using System;
using System.Collections.Generic;

public class Budget
{
    private string _category;
    private decimal _amount;

    public Budget(string category, decimal amount)
    {
        _category = category;
        _amount = amount;
    }

    public string GetCategory()
    {
        return _category;
    }

    public decimal GetAmount()
    {
        return _amount;
    }

    public void SetAmount(decimal amount)
    {
        _amount = amount;
    }
}