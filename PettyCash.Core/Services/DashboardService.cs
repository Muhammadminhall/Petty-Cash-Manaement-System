using PettyCash.Core.Contracts;
using PettyCash.Core.Models;

namespace PettyCash.Core.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly ICashEntryRepository _cashRepo;
        private readonly IExpenseRepository   _expenseRepo;

        public DashboardService(ICashEntryRepository cashRepo, IExpenseRepository expenseRepo)
        {
            _cashRepo    = cashRepo;
            _expenseRepo = expenseRepo;
        }

        public async Task<DashboardSummary> GetSummaryAsync()
        {
            var allCashTask   = _cashRepo.GetAllAsync();
            var allExpTask    = _expenseRepo.GetAllAsync();
            var recentExpTask = _expenseRepo.GetRecentAsync(5);

            await Task.WhenAll(allCashTask, allExpTask, recentExpTask);

            var allCash    = await allCashTask;
            var allExp     = await allExpTask;
            var recentExp  = await recentExpTask;

            // Expense by category (for pie chart)
            var byCategory = allExp
                .GroupBy(e => e.Category)
                .ToDictionary(g => g.Key, g => g.Sum(e => e.Amount));

            // Monthly expenses for last 6 months (for bar/line chart)
            var cutoff = DateTime.Now.AddMonths(-5);
            var monthly = allExp
                .Where(e => e.Date >= cutoff)
                .GroupBy(e => e.Date.ToString("MMM yyyy"))
                .OrderBy(g => DateTime.Parse("01 " + g.Key))
                .ToDictionary(g => g.Key, g => g.Sum(e => e.Amount));

            return new DashboardSummary
            {
                TotalCashAdded     = allCash.Sum(c => c.Amount),
                TotalExpenses      = allExp.Sum(e => e.Amount),
                CashEntryCount     = allCash.Count,
                ExpenseCount       = allExp.Count,
                RecentExpenses     = recentExp,
                ExpenseByCategory  = byCategory,
                MonthlyExpenses    = monthly
            };
        }
    }
}
