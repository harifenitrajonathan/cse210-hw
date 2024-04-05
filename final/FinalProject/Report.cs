using System;
using System.Collections.Generic;

public class Report
{
    private DateTime _startDate;
    private DateTime _endDate;
    private List<FinancialRecord> _incomeRecords;
    private List<FinancialRecord> _expenseRecords;

    public Report(DateTime startDate, DateTime endDate)
    {
        _startDate = startDate;
        _endDate = endDate;
        _incomeRecords = new List<FinancialRecord>();
        _expenseRecords = new List<FinancialRecord>();
    }

    public decimal GetTotalIncome()
    {
        return 0;
    }

    public decimal GetTotalExpense()
    {
        return 0;
    }

    public decimal GetNetIncome()
    {
        return 0;
    }

    public List<FinancialRecord> GetIncomeRecords()
    {
        return _incomeRecords;
    }

    public List<FinancialRecord> GetExpenseRecords()
    {
        return _expenseRecords;
    }
}