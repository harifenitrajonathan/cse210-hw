using System;
using System.Collections.Generic;

public class Budget
{
    private string category;
    private decimal amount;

    public string Category => category;
    public decimal Amount => amount;

    public Budget(string category, decimal amount)
    {
        this.category = category;
        this.amount = amount;
    }
}