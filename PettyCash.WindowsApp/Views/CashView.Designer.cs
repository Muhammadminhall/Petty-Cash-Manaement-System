namespace PettyCash.WindowsApp.Views
{
    partial class CashView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashView));
            tlpCashView = new TableLayoutPanel();
            tsCash = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbView = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            tlpFilters = new TableLayoutPanel();
            lblDate = new Label();
            lblAmount = new Label();
            dtpCash = new DateTimePicker();
            numAmount = new NumericUpDown();
            dgvCash = new DataGridView();
            AmountAdded = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Note = new DataGridViewTextBoxColumn();
            tlpCashView.SuspendLayout();
            tsCash.SuspendLayout();
            tlpFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCash).BeginInit();
            SuspendLayout();
            // 
            // tlpCashView
            // 
            tlpCashView.BackColor = Color.White;
            tlpCashView.ColumnCount = 1;
            tlpCashView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCashView.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpCashView.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpCashView.Controls.Add(tsCash, 0, 0);
            tlpCashView.Controls.Add(tlpFilters, 0, 1);
            tlpCashView.Controls.Add(dgvCash, 0, 2);
            tlpCashView.Dock = DockStyle.Fill;
            tlpCashView.Location = new Point(0, 0);
            tlpCashView.Name = "tlpCashView";
            tlpCashView.RowCount = 3;
            tlpCashView.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpCashView.RowStyles.Add(new RowStyle(SizeType.Percent, 14.3307085F));
            tlpCashView.RowStyles.Add(new RowStyle(SizeType.Percent, 75.74803F));
            tlpCashView.Size = new Size(907, 635);
            tlpCashView.TabIndex = 0;
            // 
            // tsCash
            // 
            tsCash.BackColor = Color.White;
            tsCash.Dock = DockStyle.Fill;
            tsCash.ImageScalingSize = new Size(20, 20);
            tsCash.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbView, toolStripSeparator1, tsbRefresh });
            tsCash.Location = new Point(0, 0);
            tsCash.Name = "tsCash";
            tsCash.Size = new Size(907, 63);
            tsCash.TabIndex = 0;
            // 
            // tsbAdd
            // 
            tsbAdd.BackColor = Color.White;
            tsbAdd.BackgroundImageLayout = ImageLayout.None;
            tsbAdd.Image = (Image)resources.GetObject("tsbAdd.Image");
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(61, 60);
            tsbAdd.Text = "Add";
            tsbAdd.Click += tsbAdd_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.BackColor = Color.White;
            tsbEdit.Image = (Image)resources.GetObject("tsbEdit.Image");
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(59, 60);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsbView
            // 
            tsbView.BackColor = Color.White;
            tsbView.Image = (Image)resources.GetObject("tsbView.Image");
            tsbView.ImageTransparentColor = Color.Magenta;
            tsbView.Name = "tsbView";
            tsbView.Size = new Size(65, 60);
            tsbView.Text = "View";
            tsbView.Click += tsbView_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 63);
            // 
            // tsbRefresh
            // 
            tsbRefresh.BackColor = Color.White;
            tsbRefresh.Image = (Image)resources.GetObject("tsbRefresh.Image");
            tsbRefresh.ImageTransparentColor = Color.Magenta;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Size = new Size(82, 60);
            tsbRefresh.Text = "Refresh";
            tsbRefresh.Click += tsbRefresh_Click;
            // 
            // tlpFilters
            // 
            tlpFilters.ColumnCount = 2;
            tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.2808F));
            tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.7192F));
            tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpFilters.Controls.Add(lblDate, 0, 0);
            tlpFilters.Controls.Add(lblAmount, 1, 0);
            tlpFilters.Controls.Add(dtpCash, 0, 1);
            tlpFilters.Controls.Add(numAmount, 1, 1);
            tlpFilters.Dock = DockStyle.Fill;
            tlpFilters.Location = new Point(3, 66);
            tlpFilters.Name = "tlpFilters";
            tlpFilters.RowCount = 2;
            tlpFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFilters.Size = new Size(901, 84);
            tlpFilters.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Dock = DockStyle.Fill;
            lblDate.FlatStyle = FlatStyle.Flat;
            lblDate.Location = new Point(3, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(420, 42);
            lblDate.TabIndex = 1;
            lblDate.Text = "Date";
            lblDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Dock = DockStyle.Fill;
            lblAmount.FlatStyle = FlatStyle.Flat;
            lblAmount.Location = new Point(429, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(469, 42);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Amount";
            lblAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpCash
            // 
            dtpCash.CalendarMonthBackground = Color.White;
            dtpCash.Dock = DockStyle.Fill;
            dtpCash.Location = new Point(3, 45);
            dtpCash.Name = "dtpCash";
            dtpCash.Size = new Size(420, 27);
            dtpCash.TabIndex = 3;
            // 
            // numAmount
            // 
            numAmount.BackColor = Color.White;
            numAmount.Dock = DockStyle.Fill;
            numAmount.Location = new Point(429, 45);
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(469, 27);
            numAmount.TabIndex = 4;
            // 
            // dgvCash
            // 
            dgvCash.AllowUserToAddRows = false;
            dgvCash.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCash.BackgroundColor = Color.White;
            dgvCash.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCash.Columns.AddRange(new DataGridViewColumn[] { AmountAdded, Date, Note });
            dgvCash.Dock = DockStyle.Fill;
            dgvCash.GridColor = Color.Black;
            dgvCash.Location = new Point(3, 156);
            dgvCash.MultiSelect = false;
            dgvCash.Name = "dgvCash";
            dgvCash.ReadOnly = true;
            dgvCash.RowHeadersWidth = 51;
            dgvCash.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCash.Size = new Size(901, 476);
            dgvCash.TabIndex = 2;
            // 
            // AmountAdded
            // 
            AmountAdded.DataPropertyName = "Amount";
            AmountAdded.HeaderText = "Amount Added";
            AmountAdded.MinimumWidth = 6;
            AmountAdded.Name = "AmountAdded";
            AmountAdded.ReadOnly = true;
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Note
            // 
            Note.DataPropertyName = "Note";
            Note.HeaderText = "Note";
            Note.MinimumWidth = 6;
            Note.Name = "Note";
            Note.ReadOnly = true;
            // 
            // CashView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpCashView);
            Name = "CashView";
            Size = new Size(907, 635);
            tlpCashView.ResumeLayout(false);
            tlpCashView.PerformLayout();
            tsCash.ResumeLayout(false);
            tsCash.PerformLayout();
            tlpFilters.ResumeLayout(false);
            tlpFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCash).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCashView;
        private ToolStrip tsCash;
        private ToolStripButton tsbAdd;
        private ToolStripButton tsbEdit;
        private ToolStripButton tsbView;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbRefresh;
        private TableLayoutPanel tlpFilters;
        private Label lblDate;
        private Label lblAmount;
        private DateTimePicker dtpCash;
        private NumericUpDown numAmount;
        private DataGridView dgvCash;
        private DataGridViewTextBoxColumn AmountAdded;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Note;
    }
}
