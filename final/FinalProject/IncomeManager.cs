using System;
using System.Collections.Generic;

public class IncomeManager
{
    private List<FinancialRecord> incomes;

    public IncomeManager()
    {
        incomes = new List<FinancialRecord>();
    }

    public void AddIncome(FinancialRecord income)
    {
        // Add income logic
    }

    public List<FinancialRecord> GetIncomes()
    {
        // Get incomes logic
        return incomes;
    }
}
