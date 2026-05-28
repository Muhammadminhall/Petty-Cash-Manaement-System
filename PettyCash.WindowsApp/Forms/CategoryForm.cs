using PettyCash.Core.Models;

namespace PettyCash.WindowsApp.Forms
{
    public partial class CategoryForm : Form
    {
        private readonly CategoryFormMode _mode;
        private readonly Category?        _existing;

        public CategoryForm(CategoryFormMode mode, Category? category = null)
        {
            InitializeComponent();
            _mode     = mode;
            _existing = category;

            Load             += (s, e) => Setup();
            btnSave.Click    += async (s, e) => await SaveAsync();
            btnCancel.Click  += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        private void Setup()
        {
            switch (_mode)
            {
                case CategoryFormMode.Add:
                    Text = "Add Category";
                    break;
                case CategoryFormMode.Edit:
                    Text = "Edit Category";
                    PopulateFields();
                    break;
                case CategoryFormMode.View:
                    Text = "View Category";
                    PopulateFields();
                    txtName.ReadOnly = txtDesc.ReadOnly = true;
                    btnSave.Visible  = false;
                    btnCancel.Text   = "Close";
                    break;
            }
        }

        private void PopulateFields()
        {
            if (_existing == null) return;
            txtName.Text = _existing.Name;
            txtDesc.Text = _existing.Description ?? string.Empty;
        }

        private async Task SaveAsync()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            try
            {
                if (_mode == CategoryFormMode.Add)
                {
                    await Program.CategoryService.AddAsync(new Category
                    {
                        Name        = txtName.Text.Trim(),
                        Description = txtDesc.Text.Trim()
                    });
                    MessageBox.Show("Category added.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (_mode == CategoryFormMode.Edit && _existing != null)
                {
                    _existing.Name        = txtName.Text.Trim();
                    _existing.Description = txtDesc.Text.Trim();
                    await Program.CategoryService.UpdateAsync(_existing);
                    MessageBox.Show("Category updated.", "Success",
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
    }
}
