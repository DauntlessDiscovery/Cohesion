using F23.StringSimilarity;
using FuzzySharp;
using System.Data;
using System.Runtime.CompilerServices;

namespace Cohesion
{
    public partial class Form1 : Form
    {
        DataTable dtInput = new DataTable();
        DataTable dtCompare = new DataTable();

        string[] arrInput = null;
        string[][,] arrMatrix = null;
        string[][,] arrMatrix2 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            dtInput.Columns.Add("id", typeof(string));
            dtInput.Columns.Add("content", typeof(string));

            string filePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
            else
            {
                return;
            }

            var lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                //this.dgInput.Rows.Add(i, line);
                DataRow dr = dtInput.NewRow();
                dr["id"] = (i + 1).ToString();
                dr["content"] = line;
                dtInput.Rows.Add(dr);
            }
            dgInput.Rows.Clear();
            dgInput.DataSource = dtInput;

            double[,] arrayCompare = new double[dgInput.Rows.Count, dgInput.Rows.Count];

            int nummy = 0;
            foreach (DataRow dr in dtInput.Rows)
            {
                dtCompare.Columns.Add("", typeof(string));

                for (int i = 0; i < dgInput.Rows.Count; i++)
                {
                    arrayCompare[nummy, i] = Fuzz.Ratio(dtInput.Rows[nummy][1].ToString(), dtInput.Rows[i][1].ToString());
                }
                nummy++;
            }

            var rowCount = arrayCompare.GetLength(0);
            var rowLength = arrayCompare.GetLength(1);

            for (int rowIndex = 0; rowIndex < rowCount; ++rowIndex)
            {
                dgCompare.Columns.Add(rowIndex.ToString(), rowIndex.ToString());
            }

            for (int rowIndex = 0; rowIndex < rowCount; ++rowIndex)
            {
                var row = new DataGridViewRow();

                for (int columnIndex = 0; columnIndex < rowLength; ++columnIndex)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell()
                    {
                        Value = arrayCompare[rowIndex, columnIndex]
                    });
                }

                dgCompare.Rows.Add(row);
            }
        }

        private void dgInput_SelectionChanged(object sender, EventArgs e)
        {
            if (dgInput.SelectedRows.Count > 0)
            {
                dgSelected.Rows.Clear();

                string selectedString = dgInput.Rows[dgInput.SelectedRows[0].Index].Cells["Content"].Value.ToString();

                labelSelected.Text = selectedString;

                foreach (DataGridViewRow row in dgInput.Rows)
                {
                    string currentIndex = row.Cells["ID"].Value.ToString();
                    string currentString = row.Cells["Content"].Value.ToString();

                    string ratio = Fuzz.Ratio(selectedString, currentString).ToString();
                    string partialratio = Fuzz.PartialRatio(selectedString, currentString).ToString();
                    string tokensortratio = Fuzz.TokenSortRatio(selectedString, currentString).ToString();
                    string tokensetratio = Fuzz.TokenSetRatio(selectedString, currentString).ToString();
                    string tokeninitratio = Fuzz.TokenInitialismRatio(selectedString, currentString).ToString();
                    string tokenabbrevratio = Fuzz.TokenAbbreviationRatio(selectedString, currentString).ToString();
                    string weightedratio = Fuzz.WeightedRatio(selectedString, currentString).ToString();
                    dgSelected.Rows.Add(currentIndex, currentString, ratio, partialratio, tokensortratio, tokensetratio, tokeninitratio, tokenabbrevratio, weightedratio);

                }
            }
            dgInput.Refresh();
            dgCompare.Refresh();
        }

        private void dgSelected_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string[] colFormat = new string[] { "ratio", "partialratio", "tokensortratio", "tokensetratio", "tokeninitialismratio", "tokenabbrevratio", "weightedratio"};
            string bleh = dgSelected.Columns[e.ColumnIndex].Name;
            int cellValue = 0;
            int.TryParse(e.Value.ToString(), out cellValue);

            if (colFormat.Contains(this.dgSelected.Columns[e.ColumnIndex].Name))
            {
                if (e.Value != null && Enumerable.Range(0, 20).Contains(cellValue))
                {
                    dgSelected.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.IndianRed;
                }
                if (e.Value != null && Enumerable.Range(20, 69).Contains(cellValue))
                {
                    dgSelected.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.SandyBrown;
                }
                if (e.Value != null && Enumerable.Range(70, 79).Contains(cellValue))
                {
                    dgSelected.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Gold;
                }
                if (e.Value != null && Enumerable.Range(80, 100).Contains(cellValue))
                {
                    dgSelected.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightGreen;
                }
            }
        }

        private void dgCompare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgCompare_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int cellValue = 0;
            int.TryParse(e.Value.ToString(), out cellValue);

            if (e.Value != null && Enumerable.Range(0, 20).Contains(cellValue))
            {
                dgCompare.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.IndianRed;
            }
            if (e.Value != null && Enumerable.Range(20, 69).Contains(cellValue))
            {
                dgCompare.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.SandyBrown;
            }
            if (e.Value != null && Enumerable.Range(70, 79).Contains(cellValue))
            {
                dgCompare.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Gold;
            }
            if (e.Value != null && Enumerable.Range(80, 100).Contains(cellValue))
            {
                dgCompare.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightGreen;
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            //DauntlessOutput[] thingy = Process.ExtractSorted("goolge", new[] { "google", "bing", "facebook", "linkedin", "twitter", "googleplus", "bingnews", "plexoogl" });
        }
    }
    public class DauntlessInput
    {
        public string[] arrInput { get; set; }
        public double[][,] arrMatrix { get; set; }
    }
    public class DauntlessOutput
    {
        public string value { get; set; }
        public double score { get; set; }
        public int index { get; set; }
    }
}