using Microsoft.Data.SqlClient;
using PettyCash.Core.Contracts;
using PettyCash.Core.Models;
using PettyCash.Core.Utilities;

namespace PettyCash.Core.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DbHelper _db;
        public CategoryRepository(DbHelper db) => _db = db;

        private static Category Map(SqlDataReader r) => new()
        {
            Id          = r.GetInt32(r.GetOrdinal("Id")),
            Name        = r.GetString(r.GetOrdinal("Name")),
            Description = r.IsDBNull(r.GetOrdinal("Description")) ? null : r.GetString(r.GetOrdinal("Description"))
        };

        public Task<List<Category>> GetAllAsync() =>
            _db.ExecuteReaderAsync(
                "SELECT Id, Name, Description FROM Categories ORDER BY Name",
                Map);

        async Task<IList<Category>> ICategoryRepository.GetAllAsync() => await GetAllAsync();

        public async Task<Category?> GetByIdAsync(int id)
        {
            var list = await _db.ExecuteReaderAsync(
                "SELECT Id, Name, Description FROM Categories WHERE Id = @Id",
                Map,
                cmd => cmd.Parameters.AddWithValue("@Id", id));
            return list.FirstOrDefault();
        }

        public async Task<int> AddAsync(Category category)
        {
            return await _db.ExecuteScalarAsync<int>(
                "INSERT INTO Categories (Name, Description) OUTPUT INSERTED.Id VALUES (@Name, @Description)",
                cmd =>
                {
                    cmd.Parameters.AddWithValue("@Name",        category.Name);
                    cmd.Parameters.AddWithValue("@Description", (object?)category.Description ?? DBNull.Value);
                });
        }

        public Task UpdateAsync(Category category) =>
            _db.ExecuteNonQueryAsync(
                "UPDATE Categories SET Name = @Name, Description = @Description WHERE Id = @Id",
                cmd =>
                {
                    cmd.Parameters.AddWithValue("@Name",        category.Name);
                    cmd.Parameters.AddWithValue("@Description", (object?)category.Description ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Id",          category.Id);
                });

        public Task DeleteAsync(int id) =>
            _db.ExecuteNonQueryAsync(
                "DELETE FROM Categories WHERE Id = @Id",
                cmd => cmd.Parameters.AddWithValue("@Id", id));
    }
}
