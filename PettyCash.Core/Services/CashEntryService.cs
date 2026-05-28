using PettyCash.Core.Contracts;
using PettyCash.Core.Models;

namespace PettyCash.Core.Services
{
    public class CashEntryService : ICashEntryService
    {
        private readonly ICashEntryRepository _repo;

        public CashEntryService(ICashEntryRepository repo) => _repo = repo;

        public Task<IList<CashEntry>> GetAllAsync() => _repo.GetAllAsync();

        public Task<CashEntry?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);

        public Task<int> AddAsync(CashEntry entry)
        {
            ValidateEntry(entry);
            entry.Date = entry.Date == default ? DateTime.Now : entry.Date;
            return _repo.AddAsync(entry);
        }

        public Task UpdateAsync(CashEntry entry)
        {
            ValidateEntry(entry);
            return _repo.UpdateAsync(entry);
        }

        public Task DeleteAsync(int id) => _repo.DeleteAsync(id);

        public Task<decimal> GetTotalCashAsync() => _repo.GetTotalAsync();

        private static void ValidateEntry(CashEntry entry)
        {
            if (entry.Amount <= 0)
                throw new ArgumentException("Cash amount must be greater than zero.", nameof(entry));
        }
    }
}
