using PettyCash.Core.Contracts;
using PettyCash.Core.Models;

namespace PettyCash.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repo;
        public CategoryService(ICategoryRepository repo) => _repo = repo;

        public Task<IList<Category>> GetAllAsync() => _repo.GetAllAsync();
        public Task<Category?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);

        public Task<int> AddAsync(Category category)
        {
            if (string.IsNullOrWhiteSpace(category.Name))
                throw new ArgumentException("Category name is required.", nameof(category));
            return _repo.AddAsync(category);
        }

        public Task UpdateAsync(Category category)
        {
            if (string.IsNullOrWhiteSpace(category.Name))
                throw new ArgumentException("Category name is required.", nameof(category));
            return _repo.UpdateAsync(category);
        }

        public Task DeleteAsync(int id) => _repo.DeleteAsync(id);
    }
}
