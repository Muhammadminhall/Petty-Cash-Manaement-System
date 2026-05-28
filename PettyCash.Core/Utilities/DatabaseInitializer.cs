namespace PettyCash.Core.Utilities
{
    /// <summary>Creates required tables on first run if they do not exist.</summary>
    public class DatabaseInitializer
    {
        private readonly DbHelper _db;
        public DatabaseInitializer(DbHelper db) => _db = db;

        public async Task InitializeAsync()
        {
            const string sql = """
                IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Categories' AND xtype='U')
                CREATE TABLE Categories (
                    Id          INT IDENTITY(1,1) PRIMARY KEY,
                    Name        NVARCHAR(100) NOT NULL,
                    Description NVARCHAR(500) NULL
                );

                IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='CashEntries' AND xtype='U')
                CREATE TABLE CashEntries (
                    Id     INT IDENTITY(1,1) PRIMARY KEY,
                    Amount DECIMAL(18,2) NOT NULL,
                    Date   DATETIME2     NOT NULL,
                    Note   NVARCHAR(500) NULL
                );

                IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Expenses' AND xtype='U')
                CREATE TABLE Expenses (
                    Id          INT IDENTITY(1,1) PRIMARY KEY,
                    Title       NVARCHAR(200)  NOT NULL,
                    Amount      DECIMAL(18,2)  NOT NULL,
                    Date        DATETIME2      NOT NULL,
                    Category    NVARCHAR(100)  NOT NULL,
                    Description NVARCHAR(1000) NULL
                );

                -- Seed default categories if empty
                IF NOT EXISTS (SELECT 1 FROM Categories)
                BEGIN
                    INSERT INTO Categories (Name, Description) VALUES
                        ('Office Supplies', 'Stationery, paper, pens etc.'),
                        ('Travel',          'Transport and accommodation'),
                        ('Food & Beverage', 'Meals and refreshments'),
                        ('Utilities',       'Electricity, water, internet'),
                        ('Maintenance',     'Repairs and upkeep'),
                        ('Miscellaneous',   'Other expenses');
                END
                """;

            await _db.ExecuteNonQueryAsync(sql);
        }
    }
}
