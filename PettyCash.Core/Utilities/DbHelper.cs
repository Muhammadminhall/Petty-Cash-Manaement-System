using Microsoft.Data.SqlClient;

namespace PettyCash.Core.Utilities
{
    public class DbHelper
    {
        private readonly string _connectionString;

        public DbHelper(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            _connectionString = connectionString;
        }

        public SqlConnection CreateConnection() => new SqlConnection(_connectionString);

        public async Task<T?> ExecuteScalarAsync<T>(string sql, Action<SqlCommand>? parameterize = null)
        {
            await using var conn = CreateConnection();
            await conn.OpenAsync();
            await using var cmd = new SqlCommand(sql, conn);
            parameterize?.Invoke(cmd);
            var result = await cmd.ExecuteScalarAsync();
            if (result == null || result == DBNull.Value) return default;
            return (T)Convert.ChangeType(result, typeof(T));
        }

        public async Task<int> ExecuteNonQueryAsync(string sql, Action<SqlCommand>? parameterize = null)
        {
            await using var conn = CreateConnection();
            await conn.OpenAsync();
            await using var cmd = new SqlCommand(sql, conn);
            parameterize?.Invoke(cmd);
            return await cmd.ExecuteNonQueryAsync();
        }

        public async Task<List<T>> ExecuteReaderAsync<T>(
            string sql,
            Func<SqlDataReader, T> map,
            Action<SqlCommand>? parameterize = null)
        {
            var results = new List<T>();
            await using var conn = CreateConnection();
            await conn.OpenAsync();
            await using var cmd = new SqlCommand(sql, conn);
            parameterize?.Invoke(cmd);
            await using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
                results.Add(map(reader));
            return results;
        }
    }
}
