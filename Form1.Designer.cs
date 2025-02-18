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
            txtInitialState = new TextBox();
            txtFinalStates = new TextBox();
            btnRecognize = new Button();
            btnSetTransitions = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblResult = new Label();
            lstPath = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgvTransitions).BeginInit();
            SuspendLayout();
            // 
            // dgvTransitions
            // 
            dgvTransitions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTransitions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransitions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvTransitions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransitions.Columns.AddRange(new DataGridViewColumn[] { CurrentState, InputSymbol, NextState });
            dgvTransitions.Location = new Point(12, 12);
            dgvTransitions.Name = "dgvTransitions";
            dgvTransitions.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvTransitions.Size = new Size(515, 248);
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
            txtInput.Location = new Point(585, 55);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(114, 23);
            txtInput.TabIndex = 1;
            // 
            // txtInitialState
            // 
            txtInitialState.Location = new Point(586, 97);
            txtInitialState.Name = "txtInitialState";
            txtInitialState.Size = new Size(113, 23);
            txtInitialState.TabIndex = 2;
            txtInitialState.TextChanged += txtInitialState_TextChanged;
            // 
            // txtFinalStates
            // 
            txtFinalStates.Location = new Point(586, 137);
            txtFinalStates.Name = "txtFinalStates";
            txtFinalStates.Size = new Size(113, 23);
            txtFinalStates.TabIndex = 3;
            txtFinalStates.TextChanged += txtFinalStates_TextChanged;
            // 
            // btnRecognize
            // 
            btnRecognize.Location = new Point(585, 191);
            btnRecognize.Name = "btnRecognize";
            btnRecognize.Size = new Size(114, 23);
            btnRecognize.TabIndex = 4;
            btnRecognize.Text = "Recognize";
            btnRecognize.UseVisualStyleBackColor = true;
            btnRecognize.Click += btnRecognize_Click;
            // 
            // btnSetTransitions
            // 
            btnSetTransitions.Location = new Point(586, 237);
            btnSetTransitions.Name = "btnSetTransitions";
            btnSetTransitions.Size = new Size(113, 23);
            btnSetTransitions.TabIndex = 5;
            btnSetTransitions.Text = "SetTransitions";
            btnSetTransitions.UseVisualStyleBackColor = true;
            btnSetTransitions.Click += btnSetTransitions_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(705, 63);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 6;
            label1.Text = "input";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(705, 105);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 7;
            label2.Text = "initialState";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(705, 145);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 8;
            label3.Text = "finalStates";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(586, 286);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(39, 15);
            lblResult.TabIndex = 9;
            lblResult.Text = "Result";
            // 
            // lstPath
            // 
            lstPath.FormattingEnabled = true;
            lstPath.ItemHeight = 15;
            lstPath.Location = new Point(12, 286);
            lstPath.Name = "lstPath";
            lstPath.Size = new Size(515, 124);
            lstPath.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstPath);
            Controls.Add(lblResult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSetTransitions);
            Controls.Add(btnRecognize);
            Controls.Add(txtFinalStates);
            Controls.Add(txtInitialState);
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
        private TextBox txtInitialState;
        private TextBox txtFinalStates;
        private Button btnRecognize;
        private Button btnSetTransitions;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblResult;
        private ListBox lstPath;
        private DataGridViewTextBoxColumn CurrentState;
        private DataGridViewTextBoxColumn InputSymbol;
        private DataGridViewTextBoxColumn NextState;
    }
}
