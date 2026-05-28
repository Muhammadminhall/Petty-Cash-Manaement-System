namespace PettyCash.WindowsApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tlpMain = new TableLayoutPanel();
            FlpTop = new FlowLayoutPanel();
            FlpNav = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnExpenses = new Button();
            BtnCash = new Button();
            btnCategories = new Button();
            lblTitle = new Label();
            pnlContent = new Panel();
            statusStrip = new StatusStrip();
            tsslStatus = new ToolStripStatusLabel();
            tsslSpacer = new ToolStripStatusLabel();
            tsslTime = new ToolStripStatusLabel();

            tlpMain.SuspendLayout();
            FlpNav.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();

            // ── tlpMain ──────────────────────────────────────────────────────────
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 188F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(FlpTop, 1, 0);
            tlpMain.Controls.Add(FlpNav, 0, 1);
            tlpMain.Controls.Add(lblTitle, 0, 0);
            tlpMain.Controls.Add(pnlContent, 1, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1053, 670);
            tlpMain.TabIndex = 0;

            // ── FlpTop ───────────────────────────────────────────────────────────
            FlpTop.BackColor = Color.FromArgb(245, 245, 255);
            FlpTop.Dock = DockStyle.Fill;
            FlpTop.TabIndex = 1;

            // ── FlpNav ───────────────────────────────────────────────────────────
            FlpNav.BackColor = Color.FromArgb(244, 244, 255);
            FlpNav.FlowDirection = FlowDirection.TopDown;
            FlpNav.WrapContents = false;
            FlpNav.Controls.Add(btnDashboard);
            FlpNav.Controls.Add(btnExpenses);
            FlpNav.Controls.Add(BtnCash);
            FlpNav.Controls.Add(btnCategories);
            FlpNav.Dock = DockStyle.Fill;
            FlpNav.TabIndex = 2;

            // ── btnDashboard ─────────────────────────────────────────────────────
            btnDashboard.BackColor = Color.FromArgb(244, 244, 255);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.FromArgb(50, 50, 50);
            btnDashboard.Size = new Size(185, 52);
            btnDashboard.Margin = new Padding(0);
            btnDashboard.Text = "  Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Padding = new Padding(14, 0, 0, 0);
            btnDashboard.TabIndex = 0;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;

            // ── btnExpenses ──────────────────────────────────────────────────────
            btnExpenses.BackColor = Color.FromArgb(244, 244, 255);
            btnExpenses.Cursor = Cursors.Hand;
            btnExpenses.FlatAppearance.BorderSize = 0;
            btnExpenses.FlatStyle = FlatStyle.Flat;
            btnExpenses.Font = new Font("Segoe UI", 10F);
            btnExpenses.ForeColor = Color.FromArgb(50, 50, 50);
            btnExpenses.Size = new Size(185, 52);
            btnExpenses.Margin = new Padding(0);
            btnExpenses.Text = "  Expenses";
            btnExpenses.TextAlign = ContentAlignment.MiddleLeft;
            btnExpenses.Padding = new Padding(14, 0, 0, 0);
            btnExpenses.TabIndex = 1;
            btnExpenses.UseVisualStyleBackColor = false;
            btnExpenses.Click += btnExpenses_Click;

            // ── BtnCash ──────────────────────────────────────────────────────────
            BtnCash.BackColor = Color.FromArgb(244, 244, 255);
            BtnCash.Cursor = Cursors.Hand;
            BtnCash.FlatAppearance.BorderSize = 0;
            BtnCash.FlatStyle = FlatStyle.Flat;
            BtnCash.Font = new Font("Segoe UI", 10F);
            BtnCash.ForeColor = Color.FromArgb(50, 50, 50);
            BtnCash.Size = new Size(185, 52);
            BtnCash.Margin = new Padding(0);
            BtnCash.Text = "  Cash";
            BtnCash.TextAlign = ContentAlignment.MiddleLeft;
            BtnCash.Padding = new Padding(14, 0, 0, 0);
            BtnCash.TabIndex = 2;
            BtnCash.UseVisualStyleBackColor = false;
            BtnCash.Click += BtnCash_Click;

            // ── btnCategories ────────────────────────────────────────────────────
            btnCategories.BackColor = Color.FromArgb(244, 244, 255);
            btnCategories.Cursor = Cursors.Hand;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI", 10F);
            btnCategories.ForeColor = Color.FromArgb(50, 50, 50);
            btnCategories.Size = new Size(185, 52);
            btnCategories.Margin = new Padding(0);
            btnCategories.Text = "  Categories";
            btnCategories.TextAlign = ContentAlignment.MiddleLeft;
            btnCategories.Padding = new Padding(14, 0, 0, 0);
            btnCategories.TabIndex = 3;
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;

            // ── lblTitle ─────────────────────────────────────────────────────────
            lblTitle.BackColor = Color.FromArgb(90, 90, 200);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.Margin = new Padding(0);
            lblTitle.Text = "PettyCash";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.TabIndex = 4;

            // ── pnlContent ───────────────────────────────────────────────────────
            pnlContent.BackColor = Color.White;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.TabIndex = 5;

            // ── statusStrip ──────────────────────────────────────────────────────
            statusStrip.Items.AddRange(new ToolStripItem[] { tsslStatus, tsslSpacer, tsslTime });
            statusStrip.BackColor = Color.FromArgb(235, 235, 248);
            statusStrip.Dock = DockStyle.Bottom;
            statusStrip.TabIndex = 6;
            statusStrip.SizingGrip = false;

            tsslStatus.AutoSize = true;
            tsslStatus.Text = "Ready";
            tsslStatus.ForeColor = Color.FromArgb(60, 60, 60);

            tsslSpacer.Spring = true;

            tsslTime.AutoSize = true;
            tsslTime.Text = DateTime.Now.ToString("dd MMM yyyy  HH:mm");
            tsslTime.ForeColor = Color.FromArgb(80, 80, 120);

            // ── MainForm ─────────────────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 720);
            Controls.Add(tlpMain);
            Controls.Add(statusStrip);
            MinimumSize = new Size(900, 600);
            Name = "MainForm";
            Text = "PettyCash — Management System";
            StartPosition = FormStartPosition.CenterScreen;

            tlpMain.ResumeLayout(false);
            FlpNav.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private TableLayoutPanel tlpMain;
        private FlowLayoutPanel FlpTop;
        private FlowLayoutPanel FlpNav;
        private Button btnDashboard;
        private Button btnExpenses;
        private Button BtnCash;
        private Button btnCategories;
        private Label lblTitle;
        private Panel pnlContent;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel tsslStatus;
        private ToolStripStatusLabel tsslSpacer;
        private ToolStripStatusLabel tsslTime;
    }
}