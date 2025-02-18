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
            CurrentState = new DataGridViewTextBoxColumn();
            InputSymbol = new DataGridViewTextBoxColumn();
            NextState = new DataGridViewTextBoxColumn();
            txtInput = new TextBox();
            btnRecognize = new Button();
            label1 = new Label();
            lblResult = new Label();
            lstPath = new ListBox();
            btnExample1 = new Button();
            btnExample2 = new Button();
            btnExample3 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTransitions).BeginInit();
            SuspendLayout();
            // 
            // dgvTransitions
            // 
            dgvTransitions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTransitions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransitions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvTransitions.BackgroundColor = SystemColors.Window;
            dgvTransitions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransitions.Columns.AddRange(new DataGridViewColumn[] { CurrentState, InputSymbol, NextState });
            dgvTransitions.Location = new Point(12, 34);
            dgvTransitions.Name = "dgvTransitions";
            dgvTransitions.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvTransitions.Size = new Size(616, 244);
            dgvTransitions.TabIndex = 0;
            dgvTransitions.CellContentClick += dgvTransitions_CellContentClick;
            // 
            // CurrentState
            // 
            CurrentState.HeaderText = "Текущее состояние";
            CurrentState.Name = "CurrentState";
            // 
            // InputSymbol
            // 
            InputSymbol.HeaderText = "Входной символ";
            InputSymbol.Name = "InputSymbol";
            // 
            // NextState
            // 
            NextState.HeaderText = "Следующее состояние";
            NextState.Name = "NextState";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 9F);
            txtInput.Location = new Point(12, 313);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(308, 23);
            txtInput.TabIndex = 1;
            txtInput.TextChanged += btnRecognize_Click;
            // 
            // btnRecognize
            // 
            btnRecognize.Font = new Font("Segoe UI", 9F);
            btnRecognize.Location = new Point(12, 342);
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
            label1.Location = new Point(12, 295);
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
            lblResult.Location = new Point(78, 368);
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
            lstPath.SelectedIndexChanged += lstPath_SelectedIndexChanged;
            // 
            // btnExample1
            // 
            btnExample1.Location = new Point(12, 5);
            btnExample1.Name = "btnExample1";
            btnExample1.Size = new Size(100, 23);
            btnExample1.TabIndex = 11;
            btnExample1.Text = "Пример №1";
            btnExample1.UseVisualStyleBackColor = true;
            btnExample1.Click += btnExample1_Click;
            // 
            // btnExample2
            // 
            btnExample2.Location = new Point(118, 5);
            btnExample2.Name = "btnExample2";
            btnExample2.Size = new Size(100, 23);
            btnExample2.TabIndex = 12;
            btnExample2.Text = "Пример №2";
            btnExample2.UseVisualStyleBackColor = true;
            btnExample2.Click += btnExample2_Click;
            // 
            // btnExample3
            // 
            btnExample3.Location = new Point(224, 5);
            btnExample3.Name = "btnExample3";
            btnExample3.Size = new Size(100, 23);
            btnExample3.TabIndex = 13;
            btnExample3.Text = "Пример №3";
            btnExample3.UseVisualStyleBackColor = true;
            btnExample3.Click += btnExample3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(12, 368);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 14;
            label2.Text = "Результат: ";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnExample3);
            Controls.Add(btnExample2);
            Controls.Add(btnExample1);
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
        private DataGridViewTextBoxColumn CurrentState;
        private DataGridViewTextBoxColumn InputSymbol;
        private DataGridViewTextBoxColumn NextState;
        private Button btnExample1;
        private Button btnExample2;
        private Button btnExample3;
        private Label label2;
    }
}
