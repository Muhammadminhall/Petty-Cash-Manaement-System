namespace PettyCash.WindowsApp.Forms
{
    partial class ExpenseForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpExpense = new TableLayoutPanel();
            cmbCategory = new ComboBox();
            lblTitle = new Label();
            lblAmount = new Label();
            lblCategory = new Label();
            lblDate = new Label();
            lblDescription = new Label();
            dtpDate = new DateTimePicker();
            txtDescription = new TextBox();
            numAmount = new NumericUpDown();
            txtTitle = new TextBox();
            flpBottom = new FlowLayoutPanel();
            BtnSave = new Button();
            BtnCancel = new Button();
            tlpExpense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            flpBottom.SuspendLayout();
            SuspendLayout();
            // 
            // tlpExpense
            // 
            tlpExpense.BackColor = Color.White;
            tlpExpense.ColumnCount = 2;
            tlpExpense.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tlpExpense.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82F));
            tlpExpense.Controls.Add(cmbCategory, 1, 2);
            tlpExpense.Controls.Add(lblTitle, 0, 0);
            tlpExpense.Controls.Add(lblAmount, 0, 1);
            tlpExpense.Controls.Add(lblCategory, 0, 2);
            tlpExpense.Controls.Add(lblDate, 0, 3);
            tlpExpense.Controls.Add(lblDescription, 0, 4);
            tlpExpense.Controls.Add(dtpDate, 1, 3);
            tlpExpense.Controls.Add(txtDescription, 1, 4);
            tlpExpense.Controls.Add(numAmount, 1, 1);
            tlpExpense.Controls.Add(txtTitle, 1, 0);
            tlpExpense.Controls.Add(flpBottom, 1, 6);
            tlpExpense.Dock = DockStyle.Fill;
            tlpExpense.Location = new Point(0, 0);
            tlpExpense.Name = "tlpExpense";
            tlpExpense.RowCount = 7;
            tlpExpense.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4677057F));
            tlpExpense.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1358566F));
            tlpExpense.RowStyles.Add(new RowStyle(SizeType.Percent, 11.8040085F));
            tlpExpense.RowStyles.Add(new RowStyle(SizeType.Percent, 12.47216F));
            tlpExpense.RowStyles.Add(new RowStyle(SizeType.Percent, 37.41648F));
            tlpExpense.RowStyles.Add(new RowStyle());
            tlpExpense.RowStyles.Add(new RowStyle(SizeType.Percent, 16.7037849F));
            tlpExpense.Size = new Size(800, 450);
            tlpExpense.TabIndex = 0;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.WhiteSmoke;
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.FlatStyle = FlatStyle.Flat;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(147, 100);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(650, 28);
            cmbCategory.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(144, 47);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Dock = DockStyle.Fill;
            lblAmount.FlatStyle = FlatStyle.Flat;
            lblAmount.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblAmount.Location = new Point(0, 47);
            lblAmount.Margin = new Padding(0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(144, 50);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Amount";
            lblAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.FlatStyle = FlatStyle.Flat;
            lblCategory.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblCategory.Location = new Point(0, 97);
            lblCategory.Margin = new Padding(0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(144, 53);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Category";
            lblCategory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Dock = DockStyle.Fill;
            lblDate.FlatStyle = FlatStyle.Flat;
            lblDate.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblDate.Location = new Point(0, 150);
            lblDate.Margin = new Padding(0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(144, 56);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date";
            lblDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.FlatStyle = FlatStyle.Flat;
            lblDescription.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblDescription.Location = new Point(3, 206);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(138, 168);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // dtpDate
            // 
            dtpDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtpDate.Dock = DockStyle.Fill;
            dtpDate.Location = new Point(147, 153);
            dtpDate.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(650, 27);
            dtpDate.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.WhiteSmoke;
            txtDescription.Cursor = Cursors.IBeam;
            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Location = new Point(147, 209);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(650, 162);
            txtDescription.TabIndex = 9;
            // 
            // numAmount
            // 
            numAmount.BackColor = Color.WhiteSmoke;
            numAmount.Dock = DockStyle.Fill;
            numAmount.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            numAmount.Location = new Point(147, 50);
            numAmount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(650, 27);
            numAmount.TabIndex = 7;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.WhiteSmoke;
            txtTitle.Dock = DockStyle.Fill;
            txtTitle.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(144, 0);
            txtTitle.Margin = new Padding(0);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(656, 28);
            txtTitle.TabIndex = 8;
            // 
            // flpBottom
            // 
            flpBottom.Controls.Add(BtnSave);
            flpBottom.Controls.Add(BtnCancel);
            flpBottom.Dock = DockStyle.Fill;
            flpBottom.FlowDirection = FlowDirection.RightToLeft;
            flpBottom.Location = new Point(147, 377);
            flpBottom.Name = "flpBottom";
            flpBottom.Size = new Size(650, 70);
            flpBottom.TabIndex = 10;
            // 
            // BtnSave
            // 
            BtnSave.AutoSize = true;
            BtnSave.Cursor = Cursors.Hand;
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.Location = new Point(556, 0);
            BtnSave.Margin = new Padding(0);
            BtnSave.Name = "BtnSave";
            BtnSave.Padding = new Padding(3);
            BtnSave.Size = new Size(94, 36);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "Save";
            BtnSave.TextAlign = ContentAlignment.MiddleRight;
            BtnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.AutoSize = true;
            BtnCancel.Cursor = Cursors.Hand;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Location = new Point(462, 0);
            BtnCancel.Margin = new Padding(0);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Padding = new Padding(3);
            BtnCancel.Size = new Size(94, 36);
            BtnCancel.TabIndex = 1;
            BtnCancel.Text = "Cancel";
            BtnCancel.TextAlign = ContentAlignment.MiddleRight;
            BtnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // ExpenseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpExpense);
            Name = "ExpenseForm";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Expense";
            tlpExpense.ResumeLayout(false);
            tlpExpense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            flpBottom.ResumeLayout(false);
            flpBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpExpense;
        private ComboBox cmbCategory;
        private Label lblTitle;
        private Label lblAmount;
        private Label lblCategory;
        private Label lblDate;
        private Label lblDescription;
        private DateTimePicker dtpDate;
        private NumericUpDown numAmount;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private FlowLayoutPanel flpBottom;
        private Button BtnSave;
        private Button BtnCancel;
    }
}