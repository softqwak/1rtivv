namespace rtivv1
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
            dgvTransitions = new DataGridView();
            Column1 = new DataGridViewComboBoxColumn();
            txtInput = new TextBox();
            btnRecognize = new Button();
            label1 = new Label();
            lblResult = new Label();
            lstPath = new ListBox();
            label2 = new Label();
            btnAddColumn = new Button();
            btnAddRow = new Button();
            btnDelColumn = new Button();
            btnDelRow = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTransitions).BeginInit();
            SuspendLayout();
            // 
            // dgvTransitions
            // 
            dgvTransitions.AllowUserToResizeColumns = false;
            dgvTransitions.AllowUserToResizeRows = false;
            dgvTransitions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransitions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvTransitions.BackgroundColor = SystemColors.Window;
            dgvTransitions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransitions.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dgvTransitions.Location = new Point(12, 34);
            dgvTransitions.Name = "dgvTransitions";
            dgvTransitions.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvTransitions.Size = new Size(616, 244);
            dgvTransitions.TabIndex = 1;
            dgvTransitions.RowValidated += dgvTransitions_Leave;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.Items.AddRange(new object[] { "Цифра", "Точка", "e", "+, -", "Конец числа" });
            Column1.Name = "Column1";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 9F);
            txtInput.Location = new Point(12, 363);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(308, 23);
            txtInput.TabIndex = 1;
            txtInput.TextChanged += btnRecognize_Click;
            // 
            // btnRecognize
            // 
            btnRecognize.Font = new Font("Segoe UI", 9F);
            btnRecognize.Location = new Point(12, 392);
            btnRecognize.Name = "btnRecognize";
            btnRecognize.Size = new Size(183, 23);
            btnRecognize.TabIndex = 4;
            btnRecognize.Text = "Распознать";
            btnRecognize.UseVisualStyleBackColor = true;
            btnRecognize.Click += btnRecognize_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(12, 345);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 6;
            label1.Text = "Входное слово";
            label1.Click += label1_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 9F);
            lblResult.Location = new Point(78, 418);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 9;
            // 
            // lstPath
            // 
            lstPath.FormattingEnabled = true;
            lstPath.ItemHeight = 15;
            lstPath.Location = new Point(655, 34);
            lstPath.Name = "lstPath";
            lstPath.Size = new Size(133, 244);
            lstPath.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(12, 418);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 14;
            label2.Text = "Результат: ";
            label2.Click += label2_Click;
            // 
            // btnAddColumn
            // 
            btnAddColumn.Location = new Point(12, 5);
            btnAddColumn.Name = "btnAddColumn";
            btnAddColumn.Size = new Size(132, 23);
            btnAddColumn.TabIndex = 15;
            btnAddColumn.Text = "Добавить колонку";
            btnAddColumn.UseVisualStyleBackColor = true;
            btnAddColumn.Click += btnAddColumn_Click;
            // 
            // btnAddRow
            // 
            btnAddRow.Location = new Point(150, 5);
            btnAddRow.Name = "btnAddRow";
            btnAddRow.Size = new Size(132, 23);
            btnAddRow.TabIndex = 16;
            btnAddRow.Text = "Добавить строку";
            btnAddRow.UseVisualStyleBackColor = true;
            btnAddRow.Click += button1_Click;
            // 
            // btnDelColumn
            // 
            btnDelColumn.ForeColor = Color.Red;
            btnDelColumn.Location = new Point(288, 5);
            btnDelColumn.Name = "btnDelColumn";
            btnDelColumn.Size = new Size(132, 23);
            btnDelColumn.TabIndex = 17;
            btnDelColumn.Text = "Удалить колонку";
            btnDelColumn.UseVisualStyleBackColor = true;
            btnDelColumn.Click += button1_Click_1;
            // 
            // btnDelRow
            // 
            btnDelRow.ForeColor = Color.Red;
            btnDelRow.Location = new Point(426, 5);
            btnDelRow.Name = "btnDelRow";
            btnDelRow.Size = new Size(132, 23);
            btnDelRow.TabIndex = 18;
            btnDelRow.Text = "Удалить строку";
            btnDelRow.UseVisualStyleBackColor = true;
            btnDelRow.Click += btnDelRow_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(605, 410);
            button1.Name = "button1";
            button1.Size = new Size(183, 23);
            button1.TabIndex = 19;
            button1.Text = "Transitions";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnDelRow);
            Controls.Add(btnDelColumn);
            Controls.Add(btnAddRow);
            Controls.Add(btnAddColumn);
            Controls.Add(label2);
            Controls.Add(lstPath);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(btnRecognize);
            Controls.Add(txtInput);
            Controls.Add(dgvTransitions);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransitions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTransitions;
        private TextBox txtInput;
        private Button btnRecognize;
        private Label label1;
        private Label lblResult;
        private ListBox lstPath;
        private Label label2;
        private Button btnAddColumn;
        private Button btnAddRow;
        private DataGridViewComboBoxColumn Column1;
        private Button btnDelColumn;
        private Button btnDelRow;
        private Button button1;
    }
}
