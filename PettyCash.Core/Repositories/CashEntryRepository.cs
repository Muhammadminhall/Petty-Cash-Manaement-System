using Microsoft.Data.SqlClient;
using PettyCash.Core.Contracts;
using PettyCash.Core.Models;
using PettyCash.Core.Utilities;

namespace PettyCash.Core.Repositories
{
    public class CashEntryRepository : ICashEntryRepository
    {
        private readonly DbHelper _db;

        public CashEntryRepository(DbHelper db) => _db = db;

        private static CashEntry Map(SqlDataReader r) => new()
        {
            Id     = r.GetInt32(r.GetOrdinal("Id")),
            Amount = r.GetDecimal(r.GetOrdinal("Amount")),
            Date   = r.GetDateTime(r.GetOrdinal("Date")),
            Note   = r.IsDBNull(r.GetOrdinal("Note")) ? null : r.GetString(r.GetOrdinal("Note"))
        };

        public Task<List<CashEntry>> GetAllAsync() =>
            _db.ExecuteReaderAsync("SELECT Id, Amount, Date, Note FROM CashEntries ORDER BY Date DESC", Map);

        async Task<IList<CashEntry>> ICashEntryRepository.GetAllAsync() => await GetAllAsync();

        public async Task<CashEntry?> GetByIdAsync(int id)
        {
            var list = await _db.ExecuteReaderAsync(
                "SELECT Id, Amount, Date, Note FROM CashEntries WHERE Id = @Id",
                Map,
                cmd => cmd.Parameters.AddWithValue("@Id", id));
            return list.FirstOrDefault();
        }

        public async Task<int> AddAsync(CashEntry entry)
        {
            var id = await _db.ExecuteScalarAsync<int>(
                "INSERT INTO CashEntries (Amount, Date, Note) OUTPUT INSERTED.Id VALUES (@Amount, @Date, @Note)",
                cmd =>
                {
                    cmd.Parameters.AddWithValue("@Amount", entry.Amount);
                    cmd.Parameters.AddWithValue("@Date", entry.Date);
                    cmd.Parameters.AddWithValue("@Note", (object?)entry.Note ?? DBNull.Value);
                });
            return id;
        }

        public Task UpdateAsync(CashEntry entry) =>
            _db.ExecuteNonQueryAsync(
                "UPDATE CashEntries SET Amount = @Amount, Date = @Date, Note = @Note WHERE Id = @Id",
                cmd =>
                {
                    cmd.Parameters.AddWithValue("@Amount", entry.Amount);
                    cmd.Parameters.AddWithValue("@Date", entry.Date);
                    cmd.Parameters.AddWithValue("@Note", (object?)entry.Note ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Id", entry.Id);
                });

        public Task DeleteAsync(int id) =>
            _db.ExecuteNonQueryAsync(
                "DELETE FROM CashEntries WHERE Id = @Id",
                cmd => cmd.Parameters.AddWithValue("@Id", id));

        public async Task<decimal> GetTotalAsync() =>
            await _db.ExecuteScalarAsync<decimal>("SELECT ISNULL(SUM(Amount), 0) FROM CashEntries");
    }
}
