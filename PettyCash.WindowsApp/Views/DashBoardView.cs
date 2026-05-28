using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using PettyCash.Core.Models;
using SkiaSharp;

namespace PettyCash.WindowsApp.Views
{
    public partial class DashBoardView : UserControl
    {
        public DashBoardView()
        {
            InitializeComponent();
            Load += async (s, e) => await LoadAsync();
        }

        private async Task LoadAsync()
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                var summary = await Program.DashboardService.GetSummaryAsync();
                PopulateSummaryCards(summary);
                BuildPieChart(summary);
                BuildBarChart(summary);
                (FindForm() as MainForm)?.UpdateStatusBar("Dashboard loaded");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load dashboard:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Cursor = Cursors.Default; }
        }

        // ── Summary Cards ─────────────────────────────────────────────────────────

        private void PopulateSummaryCards(DashboardSummary s)
        {
            lblBalanceAmount.Text  = $"${s.TotalCashAdded:N2}";
            lblCashAdded.Text      = $"${s.TotalCashAdded:N2}";
            lblExpenseAmount.Text  = $"${s.TotalExpenses:N2}";
            lblCurrentBalance.Text = $"${s.Balance:N2}";
            lblTransAmout.Text     = (s.CashEntryCount + s.ExpenseCount).ToString();

            lblCurrentBalance.ForeColor = s.Balance < 0
                ? Color.Crimson : Color.FromArgb(40, 40, 100);
        }

        // ── Pie Chart — Expense by Category ──────────────────────────────────────

        private void BuildPieChart(DashboardSummary s)
        {
            if (!s.ExpenseByCategory.Any())
            {
                pieChart.Series = Array.Empty<ISeries>();
                return;
            }

            var palette = new[]
            {
                SKColor.Parse("#5A5AC8"), SKColor.Parse("#E8734A"),
                SKColor.Parse("#4DB6AC"), SKColor.Parse("#F06292"),
                SKColor.Parse("#AED581"), SKColor.Parse("#FFB74D")
            };

            var series = s.ExpenseByCategory
                .Select((kv, i) => new PieSeries<decimal>
                {
                    Values      = new[] { kv.Value },
                    Name        = kv.Key,
                    Fill        = new SolidColorPaint(palette[i % palette.Length]),
                    DataLabelsSize = 13,
                    DataLabelsPaint = new SolidColorPaint(SKColors.White),
                    DataLabelsFormatter = p => $"{kv.Key}\n${p.Coordinate.PrimaryValue:N0}"
                })
                .Cast<ISeries>()
                .ToArray();

            pieChart.Series = series;
        }

        // ── Bar Chart — Monthly Expenses ──────────────────────────────────────────

        private void BuildBarChart(DashboardSummary s)
        {
            if (!s.MonthlyExpenses.Any())
            {
                cartChart.Series = Array.Empty<ISeries>();
                return;
            }

            var values = s.MonthlyExpenses.Values.Select(v => (double)v).ToArray();
            var labels = s.MonthlyExpenses.Keys.ToArray();

            cartChart.Series = new ISeries[]
            {
                new ColumnSeries<double>
                {
                    Values      = values,
                    Name        = "Expenses",
                    Fill        = new SolidColorPaint(SKColor.Parse("#5A5AC8")),
                    Stroke      = null,
                    MaxBarWidth = 40,
                    DataLabelsSize = 11,
                    DataLabelsPaint = new SolidColorPaint(SKColor.Parse("#444444")),
                    DataLabelsFormatter = p => $"${p.Coordinate.PrimaryValue:N0}"
                }
            };

            cartChart.XAxes = new[]
            {
                new Axis
                {
                    Labels      = labels,
                    LabelsPaint = new SolidColorPaint(SKColor.Parse("#555555")),
                    TextSize    = 11
                }
            };

            cartChart.YAxes = new[]
            {
                new Axis
                {
                    LabelsPaint     = new SolidColorPaint(SKColor.Parse("#555555")),
                    TextSize        = 11,
                    Labeler         = v => $"${v:N0}"
                }
            };
        }
    }
}
