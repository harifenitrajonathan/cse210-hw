using System;
using System.Collections.Generic;

public class ExpenseManager
{
    private List<FinancialRecord> _expenses;

    public ExpenseManager()
    {
        _expenses = new List<FinancialRecord>();
    }

    public void AddExpense(FinancialRecord expense)
    {
        _expenses.Add(expense);
    }

    public List<FinancialRecord> GetExpenses()
    {
        return _expenses;
    }

    public void ClearExpenses()
    {
        _expenses.Clear();
    }
}