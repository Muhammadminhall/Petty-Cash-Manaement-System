using PettyCash.Core.Repositories;
using PettyCash.Core.Services;
using PettyCash.Core.Utilities;
using PettyCash.WindowsApp.Forms;
using System.Configuration;

namespace PettyCash.WindowsApp
{
    internal static class Program
    {
        public static CashEntryService   CashService      { get; private set; } = null!;
        public static ExpenseService     ExpenseService   { get; private set; } = null!;
        public static DashboardService   DashboardService { get; private set; } = null!;
        public static CategoryService    CategoryService  { get; private set; } = null!;

        [STAThread]
        static async Task Main()
        {
            ApplicationConfiguration.Initialize();

            var connStr  = ConfigurationManager.ConnectionStrings["PettyCashDB"].ConnectionString;
            var dbHelper = new DbHelper(connStr);

            // Auto-create tables + seed data
            await new DatabaseInitializer(dbHelper).InitializeAsync();

            // Wire repositories
            var cashRepo     = new CashEntryRepository(dbHelper);
            var expenseRepo  = new ExpenseRepository(dbHelper);
            var categoryRepo = new CategoryRepository(dbHelper);

            // Wire services
            CashService      = new CashEntryService(cashRepo);
            ExpenseService   = new ExpenseService(expenseRepo);
            DashboardService = new DashboardService(cashRepo, expenseRepo);
            CategoryService  = new CategoryService(categoryRepo);

            Application.Run(new MainForm());
        }
    }
}
