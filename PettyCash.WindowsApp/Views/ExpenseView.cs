using PettyCash.Core.Models;
using PettyCash.WindowsApp.Forms;

namespace PettyCash.WindowsApp.Views
{
    public partial class ExpenseView : UserControl
    {
        private IList<Expense>  _all = new List<Expense>();
        private readonly BindingSource _bs = new BindingSource();

        public ExpenseView()
        {
            InitializeComponent();
            dgvExpense.DataSource           = _bs;
            dgvExpense.AllowUserToOrderColumns = true;

            Load += async (s, e) => await LoadAsync();
            txtTitle.TextChanged             += (s, e) => ApplyFilter();
            txtDate.TextChanged              += (s, e) => ApplyFilter();
            cmbCategory.SelectedIndexChanged += (s, e) => ApplyFilter();
        }

        private async Task LoadAsync()
        {
            SetLoading(true);
            try
            {
                _all = await Program.ExpenseService.GetAllAsync();
                await RefreshCategoriesAsync();
                ApplyFilter();
                MainForm?.UpdateStatusBar($"Expenses — {_all.Count} record(s)");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load expenses:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { SetLoading(false); }
        }

        private async Task RefreshCategoriesAsync()
        {
            var cats = await Program.ExpenseService.GetCategoriesAsync();
            cmbCategory.SelectedIndexChanged -= (s, e) => ApplyFilter();
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All");
            foreach (var c in cats) cmbCategory.Items.Add(c);
            cmbCategory.SelectedIndex = 0;
            cmbCategory.SelectedIndexChanged += (s, e) => ApplyFilter();
        }

        private void ApplyFilter()
        {
            var f = _all.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(txtTitle.Text))
                f = f.Where(e => e.Title.Contains(txtTitle.Text, StringComparison.OrdinalIgnoreCase));
            if (!string.IsNullOrWhiteSpace(txtDate.Text))
                f = f.Where(e => e.Date.ToString("yyyy-MM-dd").Contains(txtDate.Text));
            if (cmbCategory.SelectedItem is string cat && cat != "All")
                f = f.Where(e => e.Category.Equals(cat, StringComparison.OrdinalIgnoreCase));

            _bs.DataSource = null;
            _bs.DataSource = f.ToList();
        }

        private void SetLoading(bool loading)
        {
            tsExpense.Enabled   = !loading;
            dgvExpense.Enabled  = !loading;
            Cursor = loading ? Cursors.WaitCursor : Cursors.Default;
        }

        private MainForm? MainForm => FindForm() as MainForm;

        private Expense? GetSelected()
        {
            if (_bs.Current is Expense e) return e;
            MessageBox.Show("Please select a row first.", "No Selection",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return null;
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            using var f = new ExpenseForm(ExpenseFormModeEnum.Add);
            if (f.ShowDialog() == DialogResult.OK) _ = LoadAsync();
        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            var exp = GetSelected();
            if (exp == null) return;
            using var f = new ExpenseForm(ExpenseFormModeEnum.View, exp);
            f.ShowDialog();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var exp = GetSelected();
            if (exp == null) return;
            using var f = new ExpenseForm(ExpenseFormModeEnum.Edit, exp);
            if (f.ShowDialog() == DialogResult.OK) _ = LoadAsync();
        }

        private async void tsbDelete_Click(object sender, EventArgs e)
        {
            var exp = GetSelected();
            if (exp == null) return;
            if (MessageBox.Show($"Delete \"{exp.Title}\"?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            try
            {
                await Program.ExpenseService.DeleteAsync(exp.Id);
                await LoadAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Delete failed:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void tsbRefresh_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtDate.Clear();
            await LoadAsync();
        }
    }
}
