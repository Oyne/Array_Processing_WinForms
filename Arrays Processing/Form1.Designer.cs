namespace Arrays_Processing
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ArayLabel = new Label();
            ExportButton = new Button();
            ImportButton = new Button();
            SaveButton = new Button();
            OperationsGroupBox = new GroupBox();
            OperationFourButton = new RadioButton();
            OperationThreeButton = new RadioButton();
            OperationTwoButton = new RadioButton();
            OperationOneButton = new RadioButton();
            ArrayOperationsGroupBox = new GroupBox();
            OperationButton = new Button();
            ClearButton = new Button();
            GenerateButton = new Button();
            groupBox2 = new GroupBox();
            MaxLabel = new Label();
            MaxNumericUpDown = new NumericUpDown();
            MinLabel = new Label();
            MinNumericUpDown = new NumericUpDown();
            SizeLabel = new Label();
            SizeNumericUpDown = new NumericUpDown();
            ResultLabel = new Label();
            ResultTextBox = new TextBox();
            ImportFileDialog = new OpenFileDialog();
            ArrayDataGridView = new DataGridView();
            ExportFileDialog = new SaveFileDialog();
            ToolTip = new ToolTip(components);
            OperationsGroupBox.SuspendLayout();
            ArrayOperationsGroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MaxNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SizeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ArrayDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ArayLabel
            // 
            ArayLabel.AutoSize = true;
            ArayLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ArayLabel.ForeColor = Color.FromArgb(255, 224, 192);
            ArayLabel.Location = new Point(81, 17);
            ArayLabel.Name = "ArayLabel";
            ArayLabel.Size = new Size(63, 28);
            ArayLabel.TabIndex = 3;
            ArayLabel.Text = "Array:";
            // 
            // ExportButton
            // 
            ExportButton.BackColor = Color.FromArgb(64, 64, 64);
            ExportButton.FlatAppearance.BorderSize = 0;
            ExportButton.FlatStyle = FlatStyle.Flat;
            ExportButton.Image = (Image)resources.GetObject("ExportButton.Image");
            ExportButton.Location = new Point(504, 268);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(59, 64);
            ExportButton.TabIndex = 4;
            ToolTip.SetToolTip(ExportButton, "Export file");
            ExportButton.UseVisualStyleBackColor = false;
            ExportButton.Click += ExportButton_Click;
            // 
            // ImportButton
            // 
            ImportButton.BackColor = Color.FromArgb(64, 64, 64);
            ImportButton.FlatAppearance.BorderSize = 0;
            ImportButton.FlatStyle = FlatStyle.Flat;
            ImportButton.Image = (Image)resources.GetObject("ImportButton.Image");
            ImportButton.Location = new Point(434, 268);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(59, 64);
            ImportButton.TabIndex = 5;
            ToolTip.SetToolTip(ImportButton, "Import file");
            ImportButton.UseVisualStyleBackColor = false;
            ImportButton.Click += ImportButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(64, 64, 64);
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Image = (Image)resources.GetObject("SaveButton.Image");
            SaveButton.Location = new Point(575, 268);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(59, 64);
            SaveButton.TabIndex = 6;
            ToolTip.SetToolTip(SaveButton, "Save file");
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // OperationsGroupBox
            // 
            OperationsGroupBox.Controls.Add(OperationFourButton);
            OperationsGroupBox.Controls.Add(OperationThreeButton);
            OperationsGroupBox.Controls.Add(OperationTwoButton);
            OperationsGroupBox.Controls.Add(OperationOneButton);
            OperationsGroupBox.ForeColor = Color.FromArgb(255, 224, 192);
            OperationsGroupBox.Location = new Point(434, 38);
            OperationsGroupBox.Name = "OperationsGroupBox";
            OperationsGroupBox.Size = new Size(200, 214);
            OperationsGroupBox.TabIndex = 7;
            OperationsGroupBox.TabStop = false;
            OperationsGroupBox.Text = "Operations";
            // 
            // OperationFourButton
            // 
            OperationFourButton.AutoSize = true;
            OperationFourButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            OperationFourButton.Location = new Point(7, 173);
            OperationFourButton.Name = "OperationFourButton";
            OperationFourButton.Size = new Size(122, 27);
            OperationFourButton.TabIndex = 3;
            OperationFourButton.Text = "Operation 4";
            ToolTip.SetToolTip(OperationFourButton, "Calculate sum and number of elements of the array, in which number created from first and second digit, element also divisible by 5");
            OperationFourButton.UseVisualStyleBackColor = true;
            // 
            // OperationThreeButton
            // 
            OperationThreeButton.AutoSize = true;
            OperationThreeButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            OperationThreeButton.Location = new Point(7, 124);
            OperationThreeButton.Name = "OperationThreeButton";
            OperationThreeButton.Size = new Size(122, 27);
            OperationThreeButton.TabIndex = 2;
            OperationThreeButton.Text = "Operation 3";
            ToolTip.SetToolTip(OperationThreeButton, "Calculate sum and number of elements of the array, in which number created from last and third from end digit, element also must be even");
            OperationThreeButton.UseVisualStyleBackColor = true;
            // 
            // OperationTwoButton
            // 
            OperationTwoButton.AutoSize = true;
            OperationTwoButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            OperationTwoButton.Location = new Point(7, 75);
            OperationTwoButton.Name = "OperationTwoButton";
            OperationTwoButton.Size = new Size(122, 27);
            OperationTwoButton.TabIndex = 1;
            OperationTwoButton.Text = "Operation 2";
            ToolTip.SetToolTip(OperationTwoButton, "Sort elements in descending order");
            OperationTwoButton.UseVisualStyleBackColor = true;
            // 
            // OperationOneButton
            // 
            OperationOneButton.AutoSize = true;
            OperationOneButton.Checked = true;
            OperationOneButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            OperationOneButton.Location = new Point(7, 26);
            OperationOneButton.Name = "OperationOneButton";
            OperationOneButton.Size = new Size(122, 27);
            OperationOneButton.TabIndex = 0;
            OperationOneButton.TabStop = true;
            OperationOneButton.Text = "Operation 1";
            ToolTip.SetToolTip(OperationOneButton, "Find min, max element of array and median");
            OperationOneButton.UseVisualStyleBackColor = true;
            // 
            // ArrayOperationsGroupBox
            // 
            ArrayOperationsGroupBox.Controls.Add(OperationButton);
            ArrayOperationsGroupBox.Controls.Add(ClearButton);
            ArrayOperationsGroupBox.Controls.Add(GenerateButton);
            ArrayOperationsGroupBox.ForeColor = Color.FromArgb(255, 224, 192);
            ArrayOperationsGroupBox.Location = new Point(224, 38);
            ArrayOperationsGroupBox.Name = "ArrayOperationsGroupBox";
            ArrayOperationsGroupBox.Size = new Size(198, 133);
            ArrayOperationsGroupBox.TabIndex = 8;
            ArrayOperationsGroupBox.TabStop = false;
            ArrayOperationsGroupBox.Text = "Array Operations";
            // 
            // OperationButton
            // 
            OperationButton.FlatStyle = FlatStyle.Flat;
            OperationButton.Location = new Point(6, 96);
            OperationButton.Name = "OperationButton";
            OperationButton.Size = new Size(186, 29);
            OperationButton.TabIndex = 9;
            OperationButton.Text = "Operation";
            ToolTip.SetToolTip(OperationButton, "Perform chosen operation");
            OperationButton.UseVisualStyleBackColor = true;
            OperationButton.Click += OperationButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Location = new Point(6, 61);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(186, 29);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ToolTip.SetToolTip(ClearButton, "Clears everything");
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // GenerateButton
            // 
            GenerateButton.FlatStyle = FlatStyle.Flat;
            GenerateButton.Location = new Point(6, 26);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(186, 29);
            GenerateButton.TabIndex = 0;
            GenerateButton.Text = "Generate";
            ToolTip.SetToolTip(GenerateButton, "Generates array with specified size, min and max value");
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(MaxLabel);
            groupBox2.Controls.Add(MaxNumericUpDown);
            groupBox2.Controls.Add(MinLabel);
            groupBox2.Controls.Add(MinNumericUpDown);
            groupBox2.Controls.Add(SizeLabel);
            groupBox2.Controls.Add(SizeNumericUpDown);
            groupBox2.ForeColor = Color.FromArgb(255, 224, 192);
            groupBox2.Location = new Point(224, 177);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(198, 155);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Array Settings";
            // 
            // MaxLabel
            // 
            MaxLabel.AutoSize = true;
            MaxLabel.Location = new Point(6, 119);
            MaxLabel.Name = "MaxLabel";
            MaxLabel.Size = new Size(37, 20);
            MaxLabel.TabIndex = 8;
            MaxLabel.Text = "Max";
            // 
            // MaxNumericUpDown
            // 
            MaxNumericUpDown.BackColor = Color.FromArgb(64, 64, 64);
            MaxNumericUpDown.ForeColor = Color.FromArgb(255, 224, 192);
            MaxNumericUpDown.Location = new Point(57, 117);
            MaxNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            MaxNumericUpDown.Name = "MaxNumericUpDown";
            MaxNumericUpDown.Size = new Size(135, 27);
            MaxNumericUpDown.TabIndex = 7;
            MaxNumericUpDown.ValueChanged += MaxNumericUpDown_ValueChanged;
            // 
            // MinLabel
            // 
            MinLabel.AutoSize = true;
            MinLabel.Location = new Point(6, 71);
            MinLabel.Name = "MinLabel";
            MinLabel.Size = new Size(34, 20);
            MinLabel.TabIndex = 6;
            MinLabel.Text = "Min";
            // 
            // MinNumericUpDown
            // 
            MinNumericUpDown.BackColor = Color.FromArgb(64, 64, 64);
            MinNumericUpDown.ForeColor = Color.FromArgb(255, 224, 192);
            MinNumericUpDown.Location = new Point(57, 69);
            MinNumericUpDown.Name = "MinNumericUpDown";
            MinNumericUpDown.Size = new Size(135, 27);
            MinNumericUpDown.TabIndex = 5;
            MinNumericUpDown.ValueChanged += MinNumericUpDown_ValueChanged;
            // 
            // SizeLabel
            // 
            SizeLabel.AutoSize = true;
            SizeLabel.Location = new Point(6, 23);
            SizeLabel.Name = "SizeLabel";
            SizeLabel.Size = new Size(36, 20);
            SizeLabel.TabIndex = 4;
            SizeLabel.Text = "Size";
            // 
            // SizeNumericUpDown
            // 
            SizeNumericUpDown.BackColor = Color.FromArgb(64, 64, 64);
            SizeNumericUpDown.ForeColor = Color.FromArgb(255, 224, 192);
            SizeNumericUpDown.Location = new Point(57, 21);
            SizeNumericUpDown.Name = "SizeNumericUpDown";
            SizeNumericUpDown.Size = new Size(135, 27);
            SizeNumericUpDown.TabIndex = 3;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ResultLabel.ForeColor = Color.FromArgb(255, 224, 192);
            ResultLabel.Location = new Point(12, 353);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(68, 28);
            ResultLabel.TabIndex = 10;
            ResultLabel.Text = "Result:";
            // 
            // ResultTextBox
            // 
            ResultTextBox.BackColor = Color.FromArgb(64, 64, 64);
            ResultTextBox.ForeColor = Color.FromArgb(255, 224, 192);
            ResultTextBox.Location = new Point(81, 357);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.ReadOnly = true;
            ResultTextBox.Size = new Size(547, 27);
            ResultTextBox.TabIndex = 11;
            // 
            // ArrayDataGridView
            // 
            ArrayDataGridView.AllowUserToAddRows = false;
            ArrayDataGridView.AllowUserToDeleteRows = false;
            ArrayDataGridView.AllowUserToResizeColumns = false;
            ArrayDataGridView.AllowUserToResizeRows = false;
            ArrayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ArrayDataGridView.BackgroundColor = Color.FromArgb(64, 64, 64);
            ArrayDataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ArrayDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ArrayDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ArrayDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            ArrayDataGridView.GridColor = Color.White;
            ArrayDataGridView.Location = new Point(12, 48);
            ArrayDataGridView.Name = "ArrayDataGridView";
            ArrayDataGridView.ReadOnly = true;
            ArrayDataGridView.RowHeadersVisible = false;
            ArrayDataGridView.RowHeadersWidth = 51;
            ArrayDataGridView.RowTemplate.Height = 29;
            ArrayDataGridView.Size = new Size(198, 284);
            ArrayDataGridView.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(646, 413);
            Controls.Add(ResultTextBox);
            Controls.Add(ResultLabel);
            Controls.Add(groupBox2);
            Controls.Add(ArrayOperationsGroupBox);
            Controls.Add(OperationsGroupBox);
            Controls.Add(SaveButton);
            Controls.Add(ImportButton);
            Controls.Add(ExportButton);
            Controls.Add(ArayLabel);
            Controls.Add(ArrayDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Arrays Processing";
            OperationsGroupBox.ResumeLayout(false);
            OperationsGroupBox.PerformLayout();
            ArrayOperationsGroupBox.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MaxNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)SizeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ArrayDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView ArrayDataGridView;
        private Label ArayLabel;
        private Button ExportButton;
        private Button ImportButton;
        private Button SaveButton;
        private GroupBox OperationsGroupBox;
        private RadioButton OperationFourButton;
        private RadioButton OperationThreeButton;
        private RadioButton OperationTwoButton;
        private RadioButton OperationOneButton;
        private GroupBox ArrayOperationsGroupBox;
        private Button OperationButton;
        private Button ClearButton;
        private Button GenerateButton;
        private GroupBox groupBox2;
        private Label MaxLabel;
        private NumericUpDown MaxNumericUpDown;
        private Label MinLabel;
        private NumericUpDown MinNumericUpDown;
        private Label SizeLabel;
        private NumericUpDown SizeNumericUpDown;
        private Label ResultLabel;
        private TextBox ResultTextBox;
        private OpenFileDialog ImportFileDialog;
        private SaveFileDialog ExportFileDialog;
        private ToolTip ToolTip;
    }
}