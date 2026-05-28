namespace PettyCash.WindowsApp.Views
{
    partial class ExpenseView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseView));
            tlpExpense = new TableLayoutPanel();
            tsExpense = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbView = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            dgvExpense = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            tlpFilterExpense = new TableLayoutPanel();
            lblTitle = new Label();
            lblDate = new Label();
            lblCategory = new Label();
            txtTitle = new TextBox();
            txtDate = new TextBox();
            cmbCategory = new ComboBox();
            tlpExpense.SuspendLayout();
            tsExpense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpense).BeginInit();
            tlpFilterExpense.SuspendLayout();
            SuspendLayout();
            // 
            // tlpExpense
            // 
            tlpExpense.BackColor = Color.White;
            tlpExpense.ColumnCount = 1;
            tlpExpense.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpExpense.Controls.Add(tsExpense, 0, 0);
            tlpExpense.Controls.Add(dgvExpense, 0, 2);
            tlpExpense.Controls.Add(tlpFilterExpense, 0, 1);
            tlpExpense.Dock = DockStyle.Fill;
            tlpExpense.Location = new Point(0, 0);
            tlpExpense.Name = "tlpExpense";
            tlpExpense.RowCount = 3;
            tlpExpense.RowStyles.Add(new RowStyle(SizeType.Percent, 9.882006F));
            tlpExpense.RowStyles.Add(new RowStyle(SizeType.Percent, 19.0265484F));
            tlpExpense.RowStyles.Add(new RowStyle(SizeType.Percent, 71.0914459F));
            tlpExpense.Size = new Size(984, 678);
            tlpExpense.TabIndex = 0;
            // 
            // tsExpense
            // 
            tsExpense.Dock = DockStyle.Fill;
            tsExpense.ImageScalingSize = new Size(20, 20);
            tsExpense.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbView, tsbEdit, tsbDelete, toolStripSeparator1, tsbRefresh });
            tsExpense.Location = new Point(0, 0);
            tsExpense.Name = "tsExpense";
            tsExpense.Size = new Size(984, 67);
            tsExpense.TabIndex = 0;
            tsExpense.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            tsbAdd.Image = (Image)resources.GetObject("tsbAdd.Image");
            tsbAdd.ImageAlign = ContentAlignment.MiddleLeft;
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(61, 64);
            tsbAdd.Text = "Add";
            tsbAdd.Click += tsbAdd_Click;
            // 
            // tsbView
            // 
            tsbView.Image = (Image)resources.GetObject("tsbView.Image");
            tsbView.ImageAlign = ContentAlignment.MiddleLeft;
            tsbView.ImageTransparentColor = Color.Magenta;
            tsbView.Name = "tsbView";
            tsbView.Size = new Size(65, 64);
            tsbView.Text = "View";
            tsbView.Click += tsbView_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.Image = (Image)resources.GetObject("tsbEdit.Image");
            tsbEdit.ImageAlign = ContentAlignment.MiddleLeft;
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(59, 64);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.Image = (Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.ImageAlign = ContentAlignment.MiddleLeft;
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(77, 64);
            tsbDelete.Text = "Delete";
            tsbDelete.Click += tsbDelete_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 67);
            // 
            // tsbRefresh
            // 
            tsbRefresh.Image = (Image)resources.GetObject("tsbRefresh.Image");
            tsbRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            tsbRefresh.ImageTransparentColor = Color.Magenta;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Size = new Size(82, 64);
            tsbRefresh.Text = "Refresh";
            tsbRefresh.Click += tsbRefresh_Click;
            // 
            // dgvExpense
            // 
            dgvExpense.AllowUserToAddRows = false;
            dgvExpense.AllowUserToDeleteRows = false;
            dgvExpense.AllowUserToOrderColumns = true;
            dgvExpense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpense.BackgroundColor = Color.White;
            dgvExpense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpense.Columns.AddRange(new DataGridViewColumn[] { Id, Title, Amount, Date, Category });
            dgvExpense.Dock = DockStyle.Fill;
            dgvExpense.Location = new Point(3, 199);
            dgvExpense.MultiSelect = false;
            dgvExpense.Name = "dgvExpense";
            dgvExpense.RowHeadersWidth = 51;
            dgvExpense.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpense.Size = new Size(978, 476);
            dgvExpense.TabIndex = 1;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            // 
            // tlpFilterExpense
            // 
            tlpFilterExpense.ColumnCount = 3;
            tlpFilterExpense.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpFilterExpense.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpFilterExpense.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpFilterExpense.Controls.Add(lblTitle, 0, 1);
            tlpFilterExpense.Controls.Add(lblDate, 1, 1);
            tlpFilterExpense.Controls.Add(lblCategory, 2, 1);
            tlpFilterExpense.Controls.Add(txtTitle, 0, 2);
            tlpFilterExpense.Controls.Add(txtDate, 1, 2);
            tlpFilterExpense.Controls.Add(cmbCategory, 2, 2);
            tlpFilterExpense.Dock = DockStyle.Fill;
            tlpFilterExpense.Location = new Point(3, 70);
            tlpFilterExpense.Name = "tlpFilterExpense";
            tlpFilterExpense.RowCount = 3;
            tlpFilterExpense.RowStyles.Add(new RowStyle(SizeType.Percent, 15.447154F));
            tlpFilterExpense.RowStyles.Add(new RowStyle(SizeType.Percent, 40.6504059F));
            tlpFilterExpense.RowStyles.Add(new RowStyle(SizeType.Percent, 43.90244F));
            tlpFilterExpense.Size = new Size(978, 123);
            tlpFilterExpense.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Location = new Point(3, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(319, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Dock = DockStyle.Fill;
            lblDate.FlatStyle = FlatStyle.Flat;
            lblDate.Location = new Point(328, 19);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(319, 50);
            lblDate.TabIndex = 1;
            lblDate.Text = "Date";
            lblDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.FlatStyle = FlatStyle.Flat;
            lblCategory.Location = new Point(653, 19);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(322, 50);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            lblCategory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTitle
            // 
            txtTitle.Dock = DockStyle.Fill;
            txtTitle.Location = new Point(3, 72);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(319, 27);
            txtTitle.TabIndex = 3;
            // 
            // txtDate
            // 
            txtDate.Dock = DockStyle.Fill;
            txtDate.Location = new Point(328, 72);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(319, 27);
            txtDate.TabIndex = 4;
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(653, 72);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(322, 28);
            cmbCategory.TabIndex = 5;
            // 
            // ExpenseView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpExpense);
            Name = "ExpenseView";
            Size = new Size(984, 678);
            tlpExpense.ResumeLayout(false);
            tlpExpense.PerformLayout();
            tsExpense.ResumeLayout(false);
            tsExpense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpense).EndInit();
            tlpFilterExpense.ResumeLayout(false);
            tlpFilterExpense.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpExpense;
        private ToolStrip tsExpense;
        private ToolStripButton tsbAdd;
        private ToolStripButton tsbView;
        private ToolStripButton tsbEdit;
        private ToolStripButton tsbDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbRefresh;
        private TableLayoutPanel tlpFilterExpense;
        private Label lblTitle;
        private Label lblDate;
        private Label lblCategory;
        private DataGridView dgvExpense;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Category;
        private TextBox txtTitle;
        private TextBox txtDate;
        private ComboBox cmbCategory;
    }
}
