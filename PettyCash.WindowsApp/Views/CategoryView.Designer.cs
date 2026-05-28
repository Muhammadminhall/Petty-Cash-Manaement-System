namespace PettyCash.WindowsApp.Views
{
    partial class CategoryView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tlpCategory    = new TableLayoutPanel();
            tsCategory     = new ToolStrip();
            tsbAdd         = new ToolStripButton();
            tsbEdit        = new ToolStripButton();
            tsbView        = new ToolStripButton();
            tsbDelete      = new ToolStripButton();
            sep1           = new ToolStripSeparator();
            tsbRefresh     = new ToolStripButton();
            pnlSearch      = new Panel();
            lblSearch      = new Label();
            txtSearch      = new TextBox();
            bsCategory     = new BindingSource();
            dgvCategory    = new DataGridView();
            colId          = new DataGridViewTextBoxColumn();
            colName        = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();

            tlpCategory.SuspendLayout();
            tsCategory.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();

            // tlpCategory
            tlpCategory.BackColor   = Color.White;
            tlpCategory.ColumnCount = 1;
            tlpCategory.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCategory.Controls.Add(tsCategory,  0, 0);
            tlpCategory.Controls.Add(pnlSearch,   0, 1);
            tlpCategory.Controls.Add(dgvCategory, 0, 2);
            tlpCategory.Dock      = DockStyle.Fill;
            tlpCategory.RowCount  = 3;
            tlpCategory.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tlpCategory.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpCategory.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCategory.TabIndex  = 0;

            // tsCategory
            tsCategory.BackColor       = Color.White;
            tsCategory.Dock            = DockStyle.Fill;
            tsCategory.ImageScalingSize = new Size(20, 20);
            tsCategory.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbView, tsbDelete, sep1, tsbRefresh });
            tsCategory.TabIndex        = 0;

            void TBtn(ToolStripButton b, string text, EventHandler h)
            {
                b.BackColor             = Color.White;
                b.ImageTransparentColor = Color.Magenta;
                b.Text                  = text;
                b.DisplayStyle          = ToolStripItemDisplayStyle.Text;
                b.Click                += h;
            }
            TBtn(tsbAdd,     "＋ Add",     tsbAdd_Click);
            TBtn(tsbEdit,    "✏ Edit",    tsbEdit_Click);
            TBtn(tsbView,    "👁 View",    tsbView_Click);
            TBtn(tsbDelete,  "✖ Delete",  tsbDelete_Click);
            TBtn(tsbRefresh, "↺ Refresh", tsbRefresh_Click);

            // pnlSearch
            pnlSearch.BackColor = Color.White;
            pnlSearch.Dock      = DockStyle.Fill;
            pnlSearch.Padding   = new Padding(6, 8, 6, 0);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(lblSearch);

            lblSearch.AutoSize  = true;
            lblSearch.Location  = new Point(6, 12);
            lblSearch.Text      = "Search:";
            lblSearch.Font      = new Font("Segoe UI", 9F);

            txtSearch.Location  = new Point(65, 8);
            txtSearch.Size      = new Size(300, 27);
            txtSearch.Font      = new Font("Segoe UI", 9F);

            // dgvCategory
            dgvCategory.AllowUserToAddRows    = false;
            dgvCategory.AllowUserToDeleteRows = false;
            dgvCategory.AutoSizeColumnsMode   = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategory.BackgroundColor       = Color.White;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colDescription });
            dgvCategory.DataSource            = bsCategory;
            dgvCategory.Dock                  = DockStyle.Fill;
            dgvCategory.MultiSelect           = false;
            dgvCategory.ReadOnly              = true;
            dgvCategory.RowHeadersWidth       = 51;
            dgvCategory.SelectionMode         = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.AllowUserToOrderColumns = true;
            dgvCategory.TabIndex              = 2;

            colId.DataPropertyName  = "Id";   colId.HeaderText  = "ID";   colId.FillWeight  = 8;
            colName.DataPropertyName = "Name"; colName.HeaderText = "Name"; colName.FillWeight = 35;
            colDescription.DataPropertyName = "Description"; colDescription.HeaderText = "Description"; colDescription.FillWeight = 57;

            // CategoryView
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode       = AutoScaleMode.Font;
            Controls.Add(tlpCategory);
            Name = "CategoryView";

            tlpCategory.ResumeLayout(false);
            tsCategory.ResumeLayout(false);
            tsCategory.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
        }

        private TableLayoutPanel            tlpCategory;
        private ToolStrip                   tsCategory;
        private ToolStripButton             tsbAdd, tsbEdit, tsbView, tsbDelete, tsbRefresh;
        private ToolStripSeparator          sep1;
        private Panel                       pnlSearch;
        private Label                       lblSearch;
        private TextBox                     txtSearch;
        private BindingSource               bsCategory;
        private DataGridView                dgvCategory;
        private DataGridViewTextBoxColumn   colId, colName, colDescription;
    }
}
