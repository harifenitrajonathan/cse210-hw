using System;
using System.Collections.Generic;

public abstract class FinancialRecord
{
    private int recordId;
    private decimal amount;
    private string category;
    private DateTime date;

    public int RecordId => recordId;
    public decimal Amount => amount;
    public string Category => category;
    public DateTime Date => date;

    public FinancialRecord(int recordId, decimal amount, string category, DateTime date)
    {
        this.recordId = recordId;
        this.amount = amount;
        this.category = category;
        this.date = date;
    }

    public abstract string GetRecordType();
}

public class Income : FinancialRecord
{
    public Income(int recordId, decimal amount, string category, DateTime date) : base(recordId, amount, category, date)
    {
    }

    public override string GetRecordType()
    {
        return "Income";
    }
}

public class Expense : FinancialRecord
{
    public Expense(int recordId, decimal amount, string category, DateTime date) : base(recordId, amount, category, date)
    {
    }

    public override string GetRecordType()
    {
        return "Expense";
    }
}