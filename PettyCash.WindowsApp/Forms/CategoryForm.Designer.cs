namespace PettyCash.WindowsApp.Forms
{
    partial class CategoryForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tlp         = new TableLayoutPanel();
            lblName     = new Label();
            txtName     = new TextBox();
            lblDesc     = new Label();
            txtDesc     = new TextBox();
            flpButtons  = new FlowLayoutPanel();
            btnSave     = new Button();
            btnCancel   = new Button();

            tlp.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();

            // tlp
            tlp.BackColor   = Color.White;
            tlp.ColumnCount = 2;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp.Controls.Add(lblName,    0, 0);
            tlp.Controls.Add(txtName,    1, 0);
            tlp.Controls.Add(lblDesc,    0, 1);
            tlp.Controls.Add(txtDesc,    1, 1);
            tlp.Controls.Add(flpButtons, 1, 2);
            tlp.Dock      = DockStyle.Fill;
            tlp.RowCount  = 3;
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tlp.Padding   = new Padding(12);
            tlp.TabIndex  = 0;

            // labels
            void Lbl(Label l, string t) { l.Text = t; l.Dock = DockStyle.Fill; l.TextAlign = ContentAlignment.MiddleLeft; l.Font = new Font("Segoe UI", 10F); }
            Lbl(lblName, "Name:");
            Lbl(lblDesc, "Description:");

            // inputs
            txtName.Dock = DockStyle.Fill; txtName.Font = new Font("Segoe UI", 10F);
            txtDesc.Dock = DockStyle.Fill; txtDesc.Font = new Font("Segoe UI", 10F);
            txtDesc.Multiline = true;

            // buttons
            flpButtons.Dock          = DockStyle.Fill;
            flpButtons.FlowDirection = FlowDirection.RightToLeft;
            flpButtons.Controls.Add(btnCancel);
            flpButtons.Controls.Add(btnSave);

            void Btn(Button b, string t, int tab) { b.Text = t; b.AutoSize = true; b.Font = new Font("Segoe UI", 10F); b.FlatStyle = FlatStyle.Flat; b.Cursor = Cursors.Hand; b.Margin = new Padding(4, 8, 0, 0); b.TabIndex = tab; }
            Btn(btnSave,   "Save",   0);
            Btn(btnCancel, "Cancel", 1);

            // form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode       = AutoScaleMode.Font;
            ClientSize          = new Size(480, 260);
            Controls.Add(tlp);
            FormBorderStyle     = FormBorderStyle.FixedDialog;
            MaximizeBox         = false;
            MinimizeBox         = false;
            StartPosition       = FormStartPosition.CenterParent;
            Text                = "Category";

            tlp.ResumeLayout(false);
            flpButtons.ResumeLayout(false);
            flpButtons.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tlp;
        private Label  lblName, lblDesc;
        private TextBox txtName, txtDesc;
        private FlowLayoutPanel flpButtons;
        private Button btnSave, btnCancel;
    }
}
