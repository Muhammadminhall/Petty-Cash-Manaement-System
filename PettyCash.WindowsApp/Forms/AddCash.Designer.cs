namespace PettyCash.WindowsApp.Forms
{
    partial class AddCash
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
            pnlAddCash = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblNote = new Label();
            lblDate = new Label();
            txtNote = new RichTextBox();
            txtAmount = new TextBox();
            lblAmount = new Label();
            lblTitle = new Label();
            pnlAddCash.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAddCash
            // 
            pnlAddCash.BackColor = Color.White;
            pnlAddCash.Controls.Add(btnSave);
            pnlAddCash.Controls.Add(btnCancel);
            pnlAddCash.Controls.Add(dateTimePicker1);
            pnlAddCash.Controls.Add(lblNote);
            pnlAddCash.Controls.Add(lblDate);
            pnlAddCash.Controls.Add(txtNote);
            pnlAddCash.Controls.Add(txtAmount);
            pnlAddCash.Controls.Add(lblAmount);
            pnlAddCash.Controls.Add(lblTitle);
            pnlAddCash.Dock = DockStyle.Fill;
            pnlAddCash.Location = new Point(0, 0);
            pnlAddCash.Name = "pnlAddCash";
            pnlAddCash.Size = new Size(825, 580);
            pnlAddCash.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(494, 501);
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(141, 48);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(641, 501);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(141, 48);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(43, 235);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(741, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.FlatStyle = FlatStyle.Flat;
            lblNote.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNote.Location = new Point(43, 295);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(87, 38);
            lblNote.TabIndex = 5;
            lblNote.Text = "Note:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(43, 194);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(84, 38);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date:";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(43, 336);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(741, 120);
            txtNote.TabIndex = 3;
            txtNote.Text = "Add Note";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(43, 145);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(741, 27);
            txtAmount.TabIndex = 2;
            txtAmount.Text = "Enter Amount";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(43, 104);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(127, 38);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "Amount:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(30, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(185, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add Cash";
            // 
            // AddCash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 580);
            Controls.Add(pnlAddCash);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddCash";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Cash";
            pnlAddCash.ResumeLayout(false);
            pnlAddCash.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAddCash;
        private Label lblTitle;
        private DateTimePicker dateTimePicker1;
        private Label lblNote;
        private Label lblDate;
        private RichTextBox txtNote;
        private TextBox txtAmount;
        private Label lblAmount;
        private Button btnSave;
        private Button btnCancel;
    }
}