using PettyCash.Core.Models;

namespace PettyCash.Core.Contracts
{
    public interface IExpenseService
    {
        Task<IList<Expense>> GetAllAsync();
        Task<Expense?> GetByIdAsync(int id);
        Task<int> AddAsync(Expense expense);
        Task UpdateAsync(Expense expense);
        Task DeleteAsync(int id);
        Task<decimal> GetTotalExpensesAsync();
        Task<IList<string>> GetCategoriesAsync();
    }
}
