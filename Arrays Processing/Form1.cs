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
                file_name = ImportFileDialog.FileName;
            try
            {
                string json = File.ReadAllText(file_name);
                array.Values = JsonSerializer.Deserialize<int[]>(json);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString(), "Excpetion"); }

            if (array != null)
                ArrayOutput();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

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

            for (int i = 0; i < array.Values.Length; i++)
            {
                ArrayDataGridView.Rows.Add(i.ToString(), array.Values[i].ToString());
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            array.GenerateArray(Convert.ToInt32(SizeNumericUpDown.Value), Convert.ToInt32(MinNumericUpDown.Value), Convert.ToInt32(MaxNumericUpDown.Value));
            ArrayOutput();
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
        }
    }
}