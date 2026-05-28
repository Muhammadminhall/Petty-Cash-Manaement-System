using PettyCash.WindowsApp.Views;
using System.Configuration;

using PettyCash.Core.Utilities;
namespace PettyCash.WindowsApp
{
    public partial class MainForm : Form
    {
        private Button? _activeNavButton;
        private readonly Color NavNormalBack = Color.FromArgb(244, 244, 255);
        private readonly Color NavActiveBack = Color.FromArgb(90, 90, 200);
        private readonly Color NavNormalFore = Color.FromArgb(50, 50, 50);
        private readonly Color NavActiveFore = Color.White;

        private readonly Dictionary<Type, UserControl> _views = new();

        public MainForm()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                // Open Dashboard by default
                btnDashboard_Click(btnDashboard, EventArgs.Empty);
                UpdateStatusBar("Ready");
            };
        }

        // ── Status Bar ───────────────────────────────────────────────────────────

        public void UpdateStatusBar(string message)
        {
            tsslStatus.Text = message;
            tsslTime.Text   = DateTime.Now.ToString("dd MMM yyyy  HH:mm");
        }

        // ── Navigation helpers ───────────────────────────────────────────────────

        private void SetActiveNavButton(Button btn)
        {
            if (_activeNavButton != null)
            {
                _activeNavButton.BackColor = NavNormalBack;
                _activeNavButton.ForeColor = NavNormalFore;
                _activeNavButton.Font      = new Font(_activeNavButton.Font, FontStyle.Regular);
            }
            _activeNavButton           = btn;
            _activeNavButton.BackColor = NavActiveBack;
            _activeNavButton.ForeColor = NavActiveFore;
            _activeNavButton.Font      = new Font(_activeNavButton.Font, FontStyle.Bold);
        }

        private void ShowView<T>(Func<T> factory) where T : UserControl
        {
            var key = typeof(T);
            // Always recreate so data refreshes on nav
            var view = factory();
            _views[key] = view;
            view.Dock   = DockStyle.Fill;

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(view);
        }

        // ── Nav Clicks ───────────────────────────────────────────────────────────

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SetActiveNavButton(btnDashboard);
            ShowView(() => new DashBoardView());
            UpdateStatusBar("Dashboard");
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            SetActiveNavButton(btnExpenses);
            ShowView(() => new ExpenseView());
            UpdateStatusBar("Expenses");
        }

        private void BtnCash_Click(object sender, EventArgs e)
        {
            SetActiveNavButton(BtnCash);
            ShowView(() => new CashView());
            UpdateStatusBar("Cash Entries");
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            SetActiveNavButton(btnCategories);
            ShowView(() => new CategoryView());
            UpdateStatusBar("Categories");
        }
    }
}
