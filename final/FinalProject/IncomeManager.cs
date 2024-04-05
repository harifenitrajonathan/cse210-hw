using System;
using System.Collections.Generic;

public class IncomeManager
{
    private List<FinancialRecord> _incomes;

    public IncomeManager()
    {
        _incomes = new List<FinancialRecord>();
    }

    public void AddIncome(FinancialRecord income)
    {
        _incomes.Add(income);
    }

    public List<FinancialRecord> GetIncomes()
    {
        return _incomes;
    }
}