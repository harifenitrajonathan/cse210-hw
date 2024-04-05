using System;
using System.Collections.Generic;

public class Report
{
    private DateTime startDate;
    private DateTime endDate;
    private List<FinancialRecord> incomeRecords;
    private List<FinancialRecord> expenseRecords;

    public DateTime StartDate => startDate;
    public DateTime EndDate => endDate;
    public List<FinancialRecord> IncomeRecords => incomeRecords;
    public List<FinancialRecord> ExpenseRecords => expenseRecords;

    public Report(DateTime startDate, DateTime endDate, List<FinancialRecord> incomeRecords, List<FinancialRecord> expenseRecords)
    {
        this.startDate = startDate;
        this.endDate = endDate;
        this.incomeRecords = incomeRecords;
        this.expenseRecords = expenseRecords;
    }

    public decimal GetTotalIncome()
    {
        decimal totalIncome = 0;
        foreach (var record in incomeRecords)
        {
            totalIncome += record.Amount;
        }
        return totalIncome;
    }

    public decimal GetTotalExpense()
    {
        decimal totalExpense = 0;
        foreach (var record in expenseRecords)
        {
            totalExpense += record.Amount;
        }
        return totalExpense;
    }

    public decimal GetNetIncome()
    {
        return GetTotalIncome() - GetTotalExpense();
    }
}