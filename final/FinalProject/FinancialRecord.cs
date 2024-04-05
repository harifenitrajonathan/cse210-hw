using System;
using System.Collections.Generic;

public class FinancialRecord
{
    private static int _nextId = 1;
    private int _recordId;
    private decimal _amount;
    private string _category;
    private DateTime _date;

    public FinancialRecord(decimal amount, string category, DateTime date)
    {
        _recordId = _nextId++;
        _amount = amount;
        _category = category;
        _date = date;
    }

    public decimal GetAmount()
    {
        return _amount;
    }

    public string GetCategory()
    {
        return _category;
    }

    public DateTime GetDate()
    {
        return _date;
    }
}