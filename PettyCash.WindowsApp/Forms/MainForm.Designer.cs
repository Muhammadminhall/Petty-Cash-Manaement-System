namespace PettyCash.WindowsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpMain = new TableLayoutPanel();
            FlpTop = new FlowLayoutPanel();
            FlpNav = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnExpenses = new Button();
            BtnCash = new Button();
            BtnReport = new Button();
            FlpContent = new FlowLayoutPanel();
            lblTitle = new Label();
            tlpMain.SuspendLayout();
            FlpNav.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 188F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(FlpTop, 1, 0);
            tlpMain.Controls.Add(FlpNav, 0, 1);
            tlpMain.Controls.Add(FlpContent, 1, 1);
            tlpMain.Controls.Add(lblTitle, 0, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0430412F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 89.956955F));
            tlpMain.Size = new Size(1053, 697);
            tlpMain.TabIndex = 0;
            // 
            // FlpTop
            // 
            FlpTop.BackColor = Color.White;
            FlpTop.Dock = DockStyle.Fill;
            FlpTop.Location = new Point(191, 3);
            FlpTop.Name = "FlpTop";
            FlpTop.Size = new Size(859, 63);
            FlpTop.TabIndex = 1;
            // 
            // FlpNav
            // 
            FlpNav.BackColor = Color.White;
            FlpNav.Controls.Add(btnDashboard);
            FlpNav.Controls.Add(btnExpenses);
            FlpNav.Controls.Add(BtnCash);
            FlpNav.Controls.Add(BtnReport);
            FlpNav.Dock = DockStyle.Fill;
            FlpNav.Location = new Point(3, 72);
            FlpNav.Name = "FlpNav";
            FlpNav.Size = new Size(182, 622);
            FlpNav.TabIndex = 2;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.ActiveCaptionText;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Margin = new Padding(0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(179, 64);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnExpenses
            // 
            btnExpenses.BackColor = Color.Transparent;
            btnExpenses.Cursor = Cursors.Hand;
            btnExpenses.FlatAppearance.BorderSize = 0;
            btnExpenses.FlatStyle = FlatStyle.Flat;
            btnExpenses.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnExpenses.ForeColor = SystemColors.ActiveCaptionText;
            btnExpenses.Location = new Point(0, 64);
            btnExpenses.Margin = new Padding(0);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Size = new Size(179, 64);
            btnExpenses.TabIndex = 1;
            btnExpenses.Text = "Expenses";
            btnExpenses.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExpenses.UseVisualStyleBackColor = false;
            // 
            // BtnCash
            // 
            BtnCash.BackColor = Color.Transparent;
            BtnCash.Cursor = Cursors.Hand;
            BtnCash.FlatAppearance.BorderSize = 0;
            BtnCash.FlatStyle = FlatStyle.Flat;
            BtnCash.Font = new Font("Microsoft Sans Serif", 10.8F);
            BtnCash.ForeColor = SystemColors.ActiveCaptionText;
            BtnCash.Location = new Point(0, 128);
            BtnCash.Margin = new Padding(0);
            BtnCash.Name = "BtnCash";
            BtnCash.Size = new Size(179, 64);
            BtnCash.TabIndex = 3;
            BtnCash.Text = "Cash";
            BtnCash.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCash.UseVisualStyleBackColor = false;
            // 
            // BtnReport
            // 
            BtnReport.BackColor = Color.Transparent;
            BtnReport.Cursor = Cursors.Hand;
            BtnReport.FlatAppearance.BorderSize = 0;
            BtnReport.FlatStyle = FlatStyle.Flat;
            BtnReport.Font = new Font("Microsoft Sans Serif", 10.8F);
            BtnReport.ForeColor = SystemColors.ActiveCaptionText;
            BtnReport.Location = new Point(0, 192);
            BtnReport.Margin = new Padding(0);
            BtnReport.Name = "BtnReport";
            BtnReport.Size = new Size(179, 64);
            BtnReport.TabIndex = 4;
            BtnReport.Text = "Reports";
            BtnReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnReport.UseVisualStyleBackColor = false;
            // 
            // FlpContent
            // 
            FlpContent.BackColor = Color.White;
            FlpContent.Font = new Font("Segoe UI", 16.2F);
            FlpContent.Location = new Point(188, 69);
            FlpContent.Margin = new Padding(0);
            FlpContent.Name = "FlpContent";
            FlpContent.Size = new Size(865, 628);
            FlpContent.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(188, 69);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "ICash";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 697);
            Controls.Add(tlpMain);
            Name = "MainForm";
            Text = "I-Cash";
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            FlpNav.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private FlowLayoutPanel FlpTitle;
        private FlowLayoutPanel FlpTop;
        private FlowLayoutPanel FlpNav;
        private Button btnDashboard;
        private Button btnExpenses;
        private Button BtnCash;
        private Button BtnReport;
        private FlowLayoutPanel FlpContent;
        private Label lblTitle;
    }
}
