using PettyCash.Core.Models;

namespace PettyCash.Core.Contracts
{
    public interface IDashboardService
    {
        Task<DashboardSummary> GetSummaryAsync();
    }
}
