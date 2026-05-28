using PettyCash.Core.Models;
using PettyCash.WindowsApp.Forms;

namespace PettyCash.WindowsApp.Views
{
    public partial class CategoryView : UserControl
    {
        private IList<Category> _all = new List<Category>();

        public CategoryView()
        {
            InitializeComponent();
            Load += async (s, e) => await LoadAsync();
            txtSearch.TextChanged += (s, e) => ApplyFilter();
        }

        // ── Load / Bind ──────────────────────────────────────────────────────────

        private async Task LoadAsync()
        {
            SetLoading(true);
            try
            {
                _all = await Program.CategoryService.GetAllAsync();
                ApplyFilter();
                MainForm?.UpdateStatusBar($"Categories — {_all.Count} record(s)");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load categories:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { SetLoading(false); }
        }

        private void ApplyFilter()
        {
            var q = txtSearch.Text.Trim();
            var filtered = string.IsNullOrEmpty(q)
                ? _all
                : _all.Where(c =>
                    c.Name.Contains(q, StringComparison.OrdinalIgnoreCase) ||
                    (c.Description?.Contains(q, StringComparison.OrdinalIgnoreCase) ?? false))
                  .ToList();

            bsCategory.DataSource = null;
            bsCategory.DataSource = filtered;
        }

        private void SetLoading(bool loading)
        {
            tsCategory.Enabled  = !loading;
            dgvCategory.Enabled = !loading;
            Cursor = loading ? Cursors.WaitCursor : Cursors.Default;
        }

        private MainForm? MainForm => FindForm() as MainForm;

        private Category? GetSelected()
        {
            if (bsCategory.Current is Category c) return c;
            MessageBox.Show("Please select a row first.", "No Selection",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return null;
        }

        // ── Toolbar ──────────────────────────────────────────────────────────────

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            using var f = new CategoryForm(CategoryFormMode.Add);
            if (f.ShowDialog() == DialogResult.OK) _ = LoadAsync();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var c = GetSelected();
            if (c == null) return;
            using var f = new CategoryForm(CategoryFormMode.Edit, c);
            if (f.ShowDialog() == DialogResult.OK) _ = LoadAsync();
        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            var c = GetSelected();
            if (c == null) return;
            using var f = new CategoryForm(CategoryFormMode.View, c);
            f.ShowDialog();
        }

        private async void tsbDelete_Click(object sender, EventArgs e)
        {
            var c = GetSelected();
            if (c == null) return;

            if (MessageBox.Show($"Delete category \"{c.Name}\"?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            try
            {
                await Program.CategoryService.DeleteAsync(c.Id);
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
            txtSearch.Clear();
            await LoadAsync();
        }
    }
}
