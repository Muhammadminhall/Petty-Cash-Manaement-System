using PettyCash.Core.Models;
using PettyCash.WindowsApp.Forms;

namespace PettyCash.WindowsApp.Views
{
    public partial class CashView : UserControl
    {
        private IList<CashEntry> _all = new List<CashEntry>();
        private readonly BindingSource _bs = new BindingSource();

        public CashView()
        {
            InitializeComponent();
            dgvCash.DataSource = _bs;
            dgvCash.AllowUserToOrderColumns = true;

            Load += async (s, e) => await LoadAsync();
            dtpCash.ValueChanged   += (s, e) => ApplyFilter();
            numAmount.ValueChanged += (s, e) => ApplyFilter();
        }

        private async Task LoadAsync()
        {
            SetLoading(true);
            try
            {
                _all = await Program.CashService.GetAllAsync();
                ApplyFilter();
                MainForm?.UpdateStatusBar($"Cash — {_all.Count} record(s)");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load cash entries:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { SetLoading(false); }
        }

        private void ApplyFilter()
        {
            var f = _all.AsEnumerable();
            f = f.Where(e => e.Date.Date == dtpCash.Value.Date);
            if (numAmount.Value > 0)
                f = f.Where(e => e.Amount >= numAmount.Value);

            _bs.DataSource = null;
            _bs.DataSource = f.ToList();
        }

        private void SetLoading(bool loading)
        {
            tsCash.Enabled  = !loading;
            dgvCash.Enabled = !loading;
            Cursor = loading ? Cursors.WaitCursor : Cursors.Default;
        }

        private MainForm? MainForm => FindForm() as MainForm;

        private CashEntry? GetSelected()
        {
            if (_bs.Current is CashEntry e) return e;
            MessageBox.Show("Please select a row first.", "No Selection",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return null;
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            using var f = new AddCash(AddCashModeEnum.Add);
            if (f.ShowDialog() == DialogResult.OK) _ = LoadAsync();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entry = GetSelected();
            if (entry == null) return;
            using var f = new AddCash(AddCashModeEnum.Edit, entry);
            if (f.ShowDialog() == DialogResult.OK) _ = LoadAsync();
        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            var entry = GetSelected();
            if (entry == null) return;
            using var f = new AddCash(AddCashModeEnum.View, entry);
            f.ShowDialog();
        }

        private async void tsbRefresh_Click(object sender, EventArgs e)
        {
            numAmount.Value = 0;
            dtpCash.Value   = DateTime.Now;
            await LoadAsync();
        }
    }
}
