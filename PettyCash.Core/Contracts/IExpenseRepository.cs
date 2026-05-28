using PettyCash.Core.Models;

namespace PettyCash.Core.Contracts
{
    public interface IExpenseRepository
    {
        Task<IList<Expense>> GetAllAsync();
        Task<Expense?> GetByIdAsync(int id);
        Task<int> AddAsync(Expense expense);
        Task UpdateAsync(Expense expense);
        Task DeleteAsync(int id);
        Task<decimal> GetTotalAsync();
        Task<IList<Expense>> GetRecentAsync(int count);
        Task<IList<string>> GetCategoriesAsync();
    }
}
