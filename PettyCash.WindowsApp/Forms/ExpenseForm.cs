using PettyCash.Core.Models;

namespace PettyCash.WindowsApp.Forms
{
    public partial class ExpenseForm : Form
    {
        private readonly ExpenseFormModeEnum _mode;
        private readonly Expense?            _existing;

        public ExpenseForm(ExpenseFormModeEnum mode, Expense? expense = null)
        {
            InitializeComponent();
            _mode     = mode;
            _existing = expense;

            Load           += async (s, e) => await SetupAsync();
            BtnSave.Click  += async (s, e) => await SaveAsync();
            BtnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        private async Task SetupAsync()
        {
            await LoadCategoriesAsync();

            switch (_mode)
            {
                case ExpenseFormModeEnum.Add:
                    Text          = "Add Expense";
                    dtpDate.Value = DateTime.Now;
                    break;
                case ExpenseFormModeEnum.Edit:
                    Text = "Edit Expense";
                    PopulateFields();
                    break;
                case ExpenseFormModeEnum.View:
                    Text = "View Expense";
                    PopulateFields();
                    SetReadOnly(true);
                    BtnSave.Visible = false;
                    BtnCancel.Text  = "Close";
                    break;
            }
        }

        private async Task LoadCategoriesAsync()
        {
            cmbCategory.Items.Clear();
            try
            {
                var cats = await Program.CategoryService.GetAllAsync();
                foreach (var c in cats)
                    cmbCategory.Items.Add(c.Name);
            }
            catch
            {
                // fallback defaults
                foreach (var d in new[] { "Office Supplies", "Travel", "Food & Beverage",
                                           "Utilities", "Maintenance", "Miscellaneous" })
                    cmbCategory.Items.Add(d);
            }
            if (cmbCategory.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;
        }

        private void PopulateFields()
        {
            if (_existing == null) return;
            txtTitle.Text       = _existing.Title;
            numAmount.Value     = _existing.Amount;
            dtpDate.Value       = _existing.Date;
            txtDescription.Text = _existing.Description ?? string.Empty;

            int idx = cmbCategory.FindStringExact(_existing.Category);
            if (idx >= 0)
                cmbCategory.SelectedIndex = idx;
            else
            {
                cmbCategory.Items.Add(_existing.Category);
                cmbCategory.SelectedItem = _existing.Category;
            }
        }

        private void SetReadOnly(bool ro)
        {
            txtTitle.ReadOnly       = ro;
            numAmount.Enabled       = !ro;
            cmbCategory.Enabled     = !ro;
            dtpDate.Enabled         = !ro;
            txtDescription.ReadOnly = ro;
        }

        private async Task SaveAsync()
        {
            if (!Validate(out var err))
            {
                MessageBox.Show(err, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (_mode == ExpenseFormModeEnum.Add)
                {
                    await Program.ExpenseService.AddAsync(new Expense
                    {
                        Title       = txtTitle.Text.Trim(),
                        Amount      = numAmount.Value,
                        Date        = dtpDate.Value,
                        Category    = cmbCategory.SelectedItem?.ToString() ?? "",
                        Description = txtDescription.Text.Trim()
                    });
                    MessageBox.Show("Expense added.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (_mode == ExpenseFormModeEnum.Edit && _existing != null)
                {
                    _existing.Title       = txtTitle.Text.Trim();
                    _existing.Amount      = numAmount.Value;
                    _existing.Date        = dtpDate.Value;
                    _existing.Category    = cmbCategory.SelectedItem?.ToString() ?? "";
                    _existing.Description = txtDescription.Text.Trim();
                    await Program.ExpenseService.UpdateAsync(_existing);
                    MessageBox.Show("Expense updated.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Save failed:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validate(out string error)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))      { error = "Title is required.";    return false; }
            if (numAmount.Value <= 0)                           { error = "Amount must be > 0.";   return false; }
            if (cmbCategory.SelectedItem == null)              { error = "Select a category.";    return false; }
            error = string.Empty;
            return true;
        }
    }
}
