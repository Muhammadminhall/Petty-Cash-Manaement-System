using LiveChartsCore.SkiaSharpView.WinForms;

namespace PettyCash.WindowsApp.Views
{
    partial class DashBoardView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlDashboard = new Panel();
            lblDashboard = new Label();

            pnlTotalBalance = new Panel();
            lblTotalBalanceTitle = new Label();
            lblBalanceAmount = new Label();

            pnlCashAdded = new Panel();
            lblCashAddedTitle = new Label();
            lblCashAdded = new Label();

            panel2 = new Panel();
            lblExpenseTitle = new Label();
            lblExpenseAmount = new Label();

            pnlCurrentBaance = new Panel();
            lblCurrentBalanceTitle = new Label();
            lblCurrentBalance = new Label();

            panel3 = new Panel();
            lblTransTitle = new Label();
            lblTransAmout = new Label();

            pieChart = new PieChart();
            cartChart = new CartesianChart();
            lblPieTitle = new Label();
            lblBarTitle = new Label();

            pnlDashboard.SuspendLayout();
            SuspendLayout();

            // ── pnlDashboard ─────────────────────────────────────────────────────
            pnlDashboard.BackColor = Color.White;
            pnlDashboard.Dock = DockStyle.Fill;
            pnlDashboard.Padding = new Padding(16);
            pnlDashboard.AutoScroll = true;
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Controls.Add(pnlTotalBalance);
            pnlDashboard.Controls.Add(pnlCashAdded);
            pnlDashboard.Controls.Add(panel2);
            pnlDashboard.Controls.Add(pnlCurrentBaance);
            pnlDashboard.Controls.Add(panel3);
            pnlDashboard.Controls.Add(lblPieTitle);
            pnlDashboard.Controls.Add(lblBarTitle);
            pnlDashboard.Controls.Add(pieChart);
            pnlDashboard.Controls.Add(cartChart);

            // ── lblDashboard ─────────────────────────────────────────────────────
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblDashboard.ForeColor = Color.FromArgb(60, 60, 150);
            lblDashboard.Location = new Point(16, 16);
            lblDashboard.Text = "Dashboard";
            lblDashboard.TabIndex = 0;

            // ── pnlTotalBalance ──────────────────────────────────────────────────
            pnlTotalBalance.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalBalance.Location = new Point(16, 70);
            pnlTotalBalance.Size = new Size(185, 90);
            pnlTotalBalance.BackColor = Color.FromArgb(248, 248, 255);
            pnlTotalBalance.TabIndex = 1;
            pnlTotalBalance.Controls.Add(lblTotalBalanceTitle);
            pnlTotalBalance.Controls.Add(lblBalanceAmount);

            lblTotalBalanceTitle.AutoSize = true;
            lblTotalBalanceTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalBalanceTitle.ForeColor = Color.FromArgb(80, 80, 130);
            lblTotalBalanceTitle.Location = new Point(10, 10);
            lblTotalBalanceTitle.Text = "Total Balance";
            lblTotalBalanceTitle.TabIndex = 0;

            lblBalanceAmount.AutoSize = true;
            lblBalanceAmount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBalanceAmount.ForeColor = Color.FromArgb(40, 40, 100);
            lblBalanceAmount.Location = new Point(10, 46);
            lblBalanceAmount.Text = "—";
            lblBalanceAmount.TabIndex = 1;

            // ── pnlCashAdded ─────────────────────────────────────────────────────
            pnlCashAdded.BorderStyle = BorderStyle.FixedSingle;
            pnlCashAdded.Location = new Point(213, 70);
            pnlCashAdded.Size = new Size(185, 90);
            pnlCashAdded.BackColor = Color.FromArgb(248, 248, 255);
            pnlCashAdded.TabIndex = 2;
            pnlCashAdded.Controls.Add(lblCashAddedTitle);
            pnlCashAdded.Controls.Add(lblCashAdded);

            lblCashAddedTitle.AutoSize = true;
            lblCashAddedTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCashAddedTitle.ForeColor = Color.FromArgb(80, 80, 130);
            lblCashAddedTitle.Location = new Point(10, 10);
            lblCashAddedTitle.Text = "Cash Added";
            lblCashAddedTitle.TabIndex = 0;

            lblCashAdded.AutoSize = true;
            lblCashAdded.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCashAdded.ForeColor = Color.FromArgb(40, 40, 100);
            lblCashAdded.Location = new Point(10, 46);
            lblCashAdded.Text = "—";
            lblCashAdded.TabIndex = 1;

            // ── panel2 (Total Expenses) ───────────────────────────────────────────
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(410, 70);
            panel2.Size = new Size(185, 90);
            panel2.BackColor = Color.FromArgb(248, 248, 255);
            panel2.TabIndex = 3;
            panel2.Controls.Add(lblExpenseTitle);
            panel2.Controls.Add(lblExpenseAmount);

            lblExpenseTitle.AutoSize = true;
            lblExpenseTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblExpenseTitle.ForeColor = Color.FromArgb(80, 80, 130);
            lblExpenseTitle.Location = new Point(10, 10);
            lblExpenseTitle.Text = "Total Expenses";
            lblExpenseTitle.TabIndex = 0;

            lblExpenseAmount.AutoSize = true;
            lblExpenseAmount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblExpenseAmount.ForeColor = Color.FromArgb(40, 40, 100);
            lblExpenseAmount.Location = new Point(10, 46);
            lblExpenseAmount.Text = "—";
            lblExpenseAmount.TabIndex = 1;

            // ── pnlCurrentBaance (Net Balance) ────────────────────────────────────
            pnlCurrentBaance.BorderStyle = BorderStyle.FixedSingle;
            pnlCurrentBaance.Location = new Point(607, 70);
            pnlCurrentBaance.Size = new Size(185, 90);
            pnlCurrentBaance.BackColor = Color.FromArgb(248, 248, 255);
            pnlCurrentBaance.TabIndex = 4;
            pnlCurrentBaance.Controls.Add(lblCurrentBalanceTitle);
            pnlCurrentBaance.Controls.Add(lblCurrentBalance);

            lblCurrentBalanceTitle.AutoSize = true;
            lblCurrentBalanceTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCurrentBalanceTitle.ForeColor = Color.FromArgb(80, 80, 130);
            lblCurrentBalanceTitle.Location = new Point(10, 10);
            lblCurrentBalanceTitle.Text = "Net Balance";
            lblCurrentBalanceTitle.TabIndex = 0;

            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCurrentBalance.ForeColor = Color.FromArgb(40, 40, 100);
            lblCurrentBalance.Location = new Point(10, 46);
            lblCurrentBalance.Text = "—";
            lblCurrentBalance.TabIndex = 1;

            // ── panel3 (Transactions) ─────────────────────────────────────────────
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(804, 70);
            panel3.Size = new Size(185, 90);
            panel3.BackColor = Color.FromArgb(248, 248, 255);
            panel3.TabIndex = 5;
            panel3.Controls.Add(lblTransTitle);
            panel3.Controls.Add(lblTransAmout);

            lblTransTitle.AutoSize = true;
            lblTransTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTransTitle.ForeColor = Color.FromArgb(80, 80, 130);
            lblTransTitle.Location = new Point(10, 10);
            lblTransTitle.Text = "Transactions";
            lblTransTitle.TabIndex = 0;

            lblTransAmout.AutoSize = true;
            lblTransAmout.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTransAmout.ForeColor = Color.FromArgb(40, 40, 100);
            lblTransAmout.Location = new Point(10, 46);
            lblTransAmout.Text = "—";
            lblTransAmout.TabIndex = 1;

            // ── Chart titles ──────────────────────────────────────────────────────
            lblPieTitle.AutoSize = true;
            lblPieTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPieTitle.ForeColor = Color.FromArgb(60, 60, 130);
            lblPieTitle.Location = new Point(16, 178);
            lblPieTitle.Text = "Expenses by Category";
            lblPieTitle.TabIndex = 6;

            lblBarTitle.AutoSize = true;
            lblBarTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBarTitle.ForeColor = Color.FromArgb(60, 60, 130);
            lblBarTitle.Location = new Point(530, 178);
            lblBarTitle.Text = "Monthly Expenses";
            lblBarTitle.TabIndex = 7;

            // ── pieChart ──────────────────────────────────────────────────────────
            pieChart.Location = new Point(16, 200);
            pieChart.Size = new Size(490, 320);
            pieChart.BackColor = Color.White;
            pieChart.TabIndex = 8;

            // ── cartChart ─────────────────────────────────────────────────────────
            cartChart.Location = new Point(530, 200);
            cartChart.Size = new Size(490, 320);
            cartChart.BackColor = Color.White;
            cartChart.TabIndex = 9;

            // ── DashBoardView ─────────────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlDashboard);
            Name = "DashBoardView";
            Size = new Size(1040, 560);

            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlDashboard;
        private Label lblDashboard;
        private Panel pnlTotalBalance;
        private Label lblTotalBalanceTitle;
        private Label lblBalanceAmount;
        private Panel pnlCashAdded;
        private Label lblCashAddedTitle;
        private Label lblCashAdded;
        private Panel panel2;
        private Label lblExpenseTitle;
        private Label lblExpenseAmount;
        private Panel pnlCurrentBaance;
        private Label lblCurrentBalanceTitle;
        private Label lblCurrentBalance;
        private Panel panel3;
        private Label lblTransTitle;
        private Label lblTransAmout;
        private Label lblPieTitle;
        private Label lblBarTitle;
        private PieChart pieChart;
        private CartesianChart cartChart;
    }
}