using Microsoft.Data.SqlClient;
using PettyCash.Core.Contracts;
using PettyCash.Core.Models;
using PettyCash.Core.Utilities;

namespace PettyCash.Core.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly DbHelper _db;

        public ExpenseRepository(DbHelper db) => _db = db;

        private static Expense Map(SqlDataReader r) => new()
        {
            Id          = r.GetInt32(r.GetOrdinal("Id")),
            Title       = r.GetString(r.GetOrdinal("Title")),
            Amount      = r.GetDecimal(r.GetOrdinal("Amount")),
            Date        = r.GetDateTime(r.GetOrdinal("Date")),
            Category    = r.GetString(r.GetOrdinal("Category")),
            Description = r.IsDBNull(r.GetOrdinal("Description")) ? null : r.GetString(r.GetOrdinal("Description"))
        };

        public Task<List<Expense>> GetAllAsync() =>
            _db.ExecuteReaderAsync(
                "SELECT Id, Title, Amount, Date, Category, Description FROM Expenses ORDER BY Date DESC",
                Map);

        async Task<IList<Expense>> IExpenseRepository.GetAllAsync() => await GetAllAsync();

        public async Task<Expense?> GetByIdAsync(int id)
        {
            var list = await _db.ExecuteReaderAsync(
                "SELECT Id, Title, Amount, Date, Category, Description FROM Expenses WHERE Id = @Id",
                Map,
                cmd => cmd.Parameters.AddWithValue("@Id", id));
            return list.FirstOrDefault();
        }

        public async Task<int> AddAsync(Expense expense)
        {
            var id = await _db.ExecuteScalarAsync<int>(
                """
                INSERT INTO Expenses (Title, Amount, Date, Category, Description)
                OUTPUT INSERTED.Id
                VALUES (@Title, @Amount, @Date, @Category, @Description)
                """,
                cmd =>
                {
                    cmd.Parameters.AddWithValue("@Title",       expense.Title);
                    cmd.Parameters.AddWithValue("@Amount",      expense.Amount);
                    cmd.Parameters.AddWithValue("@Date",        expense.Date);
                    cmd.Parameters.AddWithValue("@Category",    expense.Category);
                    cmd.Parameters.AddWithValue("@Description", (object?)expense.Description ?? DBNull.Value);
                });
            return id;
        }

        public Task UpdateAsync(Expense expense) =>
            _db.ExecuteNonQueryAsync(
                """
                UPDATE Expenses
                SET Title = @Title, Amount = @Amount, Date = @Date,
                    Category = @Category, Description = @Description
                WHERE Id = @Id
                """,
                cmd =>
                {
                    cmd.Parameters.AddWithValue("@Title",       expense.Title);
                    cmd.Parameters.AddWithValue("@Amount",      expense.Amount);
                    cmd.Parameters.AddWithValue("@Date",        expense.Date);
                    cmd.Parameters.AddWithValue("@Category",    expense.Category);
                    cmd.Parameters.AddWithValue("@Description", (object?)expense.Description ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Id",          expense.Id);
                });

        public Task DeleteAsync(int id) =>
            _db.ExecuteNonQueryAsync(
                "DELETE FROM Expenses WHERE Id = @Id",
                cmd => cmd.Parameters.AddWithValue("@Id", id));

        public async Task<decimal> GetTotalAsync() =>
            await _db.ExecuteScalarAsync<decimal>("SELECT ISNULL(SUM(Amount), 0) FROM Expenses");

        public Task<List<Expense>> GetRecentAsync(int count) =>
            _db.ExecuteReaderAsync(
                $"SELECT TOP (@Count) Id, Title, Amount, Date, Category, Description FROM Expenses ORDER BY Date DESC",
                Map,
                cmd => cmd.Parameters.AddWithValue("@Count", count));

        async Task<IList<Expense>> IExpenseRepository.GetRecentAsync(int count) => await GetRecentAsync(count);

        public async Task<IList<string>> GetCategoriesAsync() =>
            await _db.ExecuteReaderAsync(
                "SELECT DISTINCT Category FROM Expenses ORDER BY Category",
                r => r.GetString(0));
    }
}
