using System;
using System.Collections.Generic;

public class ExpenseManager
{
    private List<FinancialRecord> expenses;

    public ExpenseManager()
    {
        expenses = new List<FinancialRecord>();
    }

    public void AddExpense(FinancialRecord expense)
    {
        // Add expense logic
    }

    public List<FinancialRecord> GetExpenses()
    {
        // Get expenses logic
        return expenses;
    }
}