using PettyCash.Core.Models;

namespace PettyCash.WindowsApp.Forms
{
    public partial class AddCash : Form
    {
        private readonly AddCashModeEnum _mode;
        private readonly CashEntry?      _existing;

        // ── Constructors ─────────────────────────────────────────────────────────

        public AddCash(AddCashModeEnum mode, CashEntry? entry = null)
        {
            InitializeComponent();
            _mode     = mode;
            _existing = entry;

            Load += (s, e) => SetupForm();
            btnSave.Click   += async (s, e) => await SaveAsync();
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        // ── Setup ────────────────────────────────────────────────────────────────

        private void SetupForm()
        {
            switch (_mode)
            {
                case AddCashModeEnum.Add:
                    lblTitle.Text        = "Add Cash";
                    Text                 = "Add Cash";
                    dateTimePicker1.Value = DateTime.Now;
                    txtAmount.Text       = string.Empty;
                    txtNote.Text         = string.Empty;
                    break;

                case AddCashModeEnum.Edit:
                    lblTitle.Text        = "Edit Cash Entry";
                    Text                 = "Edit Cash Entry";
                    PopulateFields();
                    break;

                case AddCashModeEnum.View:
                    lblTitle.Text        = "View Cash Entry";
                    Text                 = "View Cash Entry";
                    PopulateFields();
                    SetReadOnly(true);
                    btnSave.Visible      = false;
                    btnCancel.Text       = "Close";
                    break;
            }
        }

        private void PopulateFields()
        {
            if (_existing == null) return;
            txtAmount.Text        = _existing.Amount.ToString("F2");
            dateTimePicker1.Value = _existing.Date;
            txtNote.Text          = _existing.Note ?? string.Empty;
        }

        private void SetReadOnly(bool readOnly)
        {
            txtAmount.ReadOnly       = readOnly;
            txtNote.ReadOnly         = readOnly;
            dateTimePicker1.Enabled  = !readOnly;
        }

        // ── Save ─────────────────────────────────────────────────────────────────

        private async Task SaveAsync()
        {
            if (!TryParseAmount(out decimal amount)) return;

            try
            {
                if (_mode == AddCashModeEnum.Add)
                {
                    var entry = new CashEntry
                    {
                        Amount = amount,
                        Date   = dateTimePicker1.Value,
                        Note   = txtNote.Text.Trim()
                    };
                    await Program.CashService.AddAsync(entry);
                    MessageBox.Show("Cash entry added successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (_mode == AddCashModeEnum.Edit && _existing != null)
                {
                    _existing.Amount = amount;
                    _existing.Date   = dateTimePicker1.Value;
                    _existing.Note   = txtNote.Text.Trim();
                    await Program.CashService.UpdateAsync(_existing);
                    MessageBox.Show("Cash entry updated successfully.", "Success",
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

        private bool TryParseAmount(out decimal amount)
        {
            if (decimal.TryParse(txtAmount.Text, out amount) && amount > 0)
                return true;

            MessageBox.Show("Please enter a valid amount greater than zero.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtAmount.Focus();
            return false;
        }
    }
}
