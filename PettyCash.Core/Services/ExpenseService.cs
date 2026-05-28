using PettyCash.Core.Contracts;
using PettyCash.Core.Models;

namespace PettyCash.Core.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository _repo;

        public ExpenseService(IExpenseRepository repo) => _repo = repo;

        public Task<IList<Expense>> GetAllAsync() => _repo.GetAllAsync();

        public Task<Expense?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);

        public Task<int> AddAsync(Expense expense)
        {
            Validate(expense);
            expense.Date = expense.Date == default ? DateTime.Now : expense.Date;
            return _repo.AddAsync(expense);
        }

        public Task UpdateAsync(Expense expense)
        {
            Validate(expense);
            return _repo.UpdateAsync(expense);
        }

        public Task DeleteAsync(int id) => _repo.DeleteAsync(id);

        public Task<decimal> GetTotalExpensesAsync() => _repo.GetTotalAsync();

        public Task<IList<string>> GetCategoriesAsync() => _repo.GetCategoriesAsync();

        private static void Validate(Expense expense)
        {
            if (string.IsNullOrWhiteSpace(expense.Title))
                throw new ArgumentException("Expense title is required.", nameof(expense));
            if (expense.Amount <= 0)
                throw new ArgumentException("Expense amount must be greater than zero.", nameof(expense));
            if (string.IsNullOrWhiteSpace(expense.Category))
                throw new ArgumentException("Expense category is required.", nameof(expense));
        }
    }
}
