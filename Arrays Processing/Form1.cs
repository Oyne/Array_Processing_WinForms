using System.Drawing;
using System.Text.Json;
using System.Windows.Forms;

namespace Arrays_Processing
{
    public partial class Form1 : Form
    {
        int column_count = 2;
        ArrayOperations array = new ArrayOperations();
        string? file_name { get; set; }
        int[] res;

        public Form1()
        {
            InitializeComponent();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {

            ImportFileDialog.InitialDirectory = "Desktop";
            ImportFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";

            ImportFileDialog.FilterIndex = 1;
            ImportFileDialog.Title = "Import file";

            if (ImportFileDialog.ShowDialog() == DialogResult.OK)
            {
                file_name = ImportFileDialog.FileName;
                string json = File.ReadAllText(file_name);
                array.Value = JsonSerializer.Deserialize<int[]>(json);
                ArrayOutput();
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

            ExportFileDialog.InitialDirectory = "Desktop";
            ExportFileDialog.Title = "Export file";
            ExportFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            ExportFileDialog.AddExtension = true;

            if (ExportFileDialog.ShowDialog() == DialogResult.OK)
            {
                file_name = ExportFileDialog.FileName;
                string json = JsonSerializer.Serialize(array.Value);
                File.WriteAllText(file_name, json);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (file_name != null)
            {
                string json = JsonSerializer.Serialize(array.Value);
                File.WriteAllText(file_name, json);
            }
        }

        private void ArrayOutput()
        {
            ArrayDataGridView.RowCount = 0;
            ArrayDataGridView.EnableHeadersVisualStyles = false;
            ArrayDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            ArrayDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 224, 192);

            ArrayDataGridView.ColumnCount = column_count;

            ArrayDataGridView.Columns[0].HeaderText = "i";
            ArrayDataGridView.Columns[0].Width = 48;

            ArrayDataGridView.Columns[1].HeaderText = "a[i]";

            foreach (DataGridViewColumn dgvc in ArrayDataGridView.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < array.Value.Length; i++)
            {
                ArrayDataGridView.Rows.Add(i.ToString(), array.Value[i].ToString());
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (SizeNumericUpDown.Value > 0)
            {
                array.GenerateArray(Convert.ToInt32(SizeNumericUpDown.Value), Convert.ToInt32(MinNumericUpDown.Value), Convert.ToInt32(MaxNumericUpDown.Value));
                ArrayOutput();
            }
        }

        private void MinNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (MinNumericUpDown.Value > MaxNumericUpDown.Value) { MaxNumericUpDown.Value++; }
        }

        private void MaxNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (MaxNumericUpDown.Value < MinNumericUpDown.Value) { MinNumericUpDown.Value--; }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ArrayDataGridView.RowCount = 0;
            array.Clear();
            ResultTextBox.Clear();
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            if (array.Value.Length > 0)
            {
                if (OperationOneButton.Checked)
                {
                    res = array.OperationOne();
                    ResultTextBox.Text = "Min = " + res[0].ToString() + ", Max = " + res[1].ToString() + ", Median = " + res[2].ToString();
                }
                else if (OperationTwoButton.Checked)
                {
                    array.OperationTwo();
                    ResultTextBox.Text = "Array was sorted";
                    ArrayOutput();
                }
                else if (OperationThreeButton.Checked)
                {
                    res = array.OperationThree();
                    ResultTextBox.Text = "Count = " + res[0].ToString() + ", Sum = " + res[1].ToString();

                }
                else if (OperationFourButton.Checked)
                {
                    res = array.OperationFour();
                    ResultTextBox.Text = "Count = " + res[0].ToString() + ", Sum = " + res[1].ToString();
                }
            }

        }
    }
}