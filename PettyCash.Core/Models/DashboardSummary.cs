namespace PettyCash.Core.Models
{
    public class DashboardSummary
    {
        public decimal TotalCashAdded  { get; set; }
        public decimal TotalExpenses   { get; set; }
        public decimal Balance         => TotalCashAdded - TotalExpenses;
        public int     ExpenseCount    { get; set; }
        public int     CashEntryCount  { get; set; }
        public IList<Expense>              RecentExpenses        { get; set; } = new List<Expense>();
        // Chart data: category → total amount
        public IDictionary<string, decimal> ExpenseByCategory    { get; set; } = new Dictionary<string, decimal>();
        // Chart data: last 6 months expenses
        public IDictionary<string, decimal> MonthlyExpenses      { get; set; } = new Dictionary<string, decimal>();
    }
}
