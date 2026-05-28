using PettyCash.Core.Models;

namespace PettyCash.Core.Contracts
{
    public interface ICashEntryService
    {
        Task<IList<CashEntry>> GetAllAsync();
        Task<CashEntry?> GetByIdAsync(int id);
        Task<int> AddAsync(CashEntry entry);
        Task UpdateAsync(CashEntry entry);
        Task DeleteAsync(int id);
        Task<decimal> GetTotalCashAsync();
    }
}
