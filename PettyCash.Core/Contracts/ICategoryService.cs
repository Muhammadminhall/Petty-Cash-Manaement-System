using PettyCash.Core.Models;

namespace PettyCash.Core.Contracts
{
    public interface ICategoryService
    {
        Task<IList<Category>> GetAllAsync();
        Task<Category?>       GetByIdAsync(int id);
        Task<int>             AddAsync(Category category);
        Task                  UpdateAsync(Category category);
        Task                  DeleteAsync(int id);
    }
}
