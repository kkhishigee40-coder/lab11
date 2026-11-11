namespace lab11
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblLang = new Label();
            cmbLang = new ComboBox();
            lblDb2 = new Label();
            dgvWords = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            dataGridView3 = new DataGridView();
            colSaved = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSave = new Button();
            lblStatus = new Label();
            txtEn = new Label();
            txtMn = new Label();
            txtRu = new Label();
            t = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvWords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(12, 40);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(39, 17);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Хайх:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(57, 37);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Хайх үг";
            txtSearch.Size = new Size(342, 25);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblLang
            // 
            lblLang.AutoSize = true;
            lblLang.Location = new Point(434, 40);
            lblLang.Name = "lblLang";
            lblLang.Size = new Size(32, 17);
            lblLang.TabIndex = 2;
            lblLang.Text = "Хэл:";
            // 
            // cmbLang
            // 
            cmbLang.FormattingEnabled = true;
            cmbLang.Items.AddRange(new object[] { "Бүгд", "Англи", "Монгол", "Орос" });
            cmbLang.Location = new Point(472, 37);
            cmbLang.Name = "cmbLang";
            cmbLang.Size = new Size(121, 25);
            cmbLang.TabIndex = 3;
            cmbLang.SelectedIndexChanged += cmbLang_SelectedIndexChanged;
            // 
            // lblDb2
            // 
            lblDb2.AutoSize = true;
            lblDb2.Location = new Point(12, 76);
            lblDb2.Name = "lblDb2";
            lblDb2.Size = new Size(92, 17);
            lblDb2.TabIndex = 4;
            lblDb2.Text = "toli.db · words";
            lblDb2.Click += label1_Click;
            // 
            // dgvWords
            // 
            dgvWords.AllowUserToAddRows = false;
            dgvWords.AllowUserToResizeRows = false;
            dgvWords.BackgroundColor = SystemColors.ButtonFace;
            dgvWords.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvWords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvWords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWords.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvWords.DefaultCellStyle = dataGridViewCellStyle2;
            dgvWords.EnableHeadersVisualStyles = false;
            dgvWords.Location = new Point(12, 107);
            dgvWords.Name = "dgvWords";
            dgvWords.ReadOnly = true;
            dgvWords.RowHeadersVisible = false;
            dgvWords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWords.Size = new Size(366, 334);
            dgvWords.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "№";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Англи";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Монгол";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Орос";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(434, 76);
            label2.Name = "label2";
            label2.Size = new Size(147, 17);
            label2.TabIndex = 6;
            label2.Text = "saved.db · saved_words";
            label2.Click += label2_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.BackgroundColor = Color.DarkGray;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.GreenYellow;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = Color.Green;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { colSaved });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.GridColor = Color.Silver;
            dataGridView3.Location = new Point(434, 107);
            dataGridView3.MultiSelect = false;
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(240, 170);
            dataGridView3.TabIndex = 8;
            // 
            // colSaved
            // 
            colSaved.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSaved.HeaderText = "Санасан үг";
            colSaved.Name = "colSaved";
            colSaved.ReadOnly = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(13, 488);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 26);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "+  Нэмэх";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(94, 488);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 26);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "✎  Засах";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(175, 488);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 26);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "✖Устгах";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(256, 488);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(93, 26);
            btnClear.TabIndex = 13;
            btnClear.Text = "↻Цэвэрлэх";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.FromArgb(128, 255, 128);
            btnSave.Location = new Point(355, 488);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 26);
            btnSave.TabIndex = 14;
            btnSave.Text = "✔Санах";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += button5_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(13, 526);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(147, 17);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "Нийт: 10 үг · Санасан: 0";
            // 
            // txtEn
            // 
            txtEn.AutoSize = true;
            txtEn.Location = new Point(13, 453);
            txtEn.Name = "txtEn";
            txtEn.Size = new Size(42, 17);
            txtEn.TabIndex = 16;
            txtEn.Text = "Англи";
            // 
            // txtMn
            // 
            txtMn.AutoSize = true;
            txtMn.Location = new Point(175, 453);
            txtMn.Name = "txtMn";
            txtMn.Size = new Size(55, 17);
            txtMn.TabIndex = 17;
            txtMn.Text = "Монгол";
            // 
            // txtRu
            // 
            txtRu.AutoSize = true;
            txtRu.Location = new Point(335, 453);
            txtRu.Name = "txtRu";
            txtRu.Size = new Size(40, 17);
            txtRu.TabIndex = 18;
            txtRu.Text = "Орос";
            // 
            // t
            // 
            t.Location = new Point(57, 450);
            t.Name = "t";
            t.Size = new Size(100, 25);
            t.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(229, 450);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 25);
            textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(381, 450);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 25);
            textBox3.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 772);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(t);
            Controls.Add(txtRu);
            Controls.Add(txtMn);
            Controls.Add(txtEn);
            Controls.Add(lblStatus);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView3);
            Controls.Add(label2);
            Controls.Add(dgvWords);
            Controls.Add(lblDb2);
            Controls.Add(cmbLang);
            Controls.Add(lblLang);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "Form1";
            Text = "Гурван хэлний толь бичиг";
            ((System.ComponentModel.ISupportInitialize)dgvWords).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblLang;
        private ComboBox cmbLang;
        private Label lblDb2;
        private DataGridView dgvWords;
        private Label label2;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn colSaved;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSave;
        private Label lblStatus;
        private Label txtEn;
        private Label txtMn;
        private Label txtRu;
        private TextBox t;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
