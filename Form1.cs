using System.Diagnostics;
using System.Windows.Forms;

namespace rtivv1
{
    public partial class Form1 : Form
    {

        private Dictionary<(string, string), string> transitions = new();
        private string initialState;
        private List<string> finalStates = new();

        private List<char> charNumber = new() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private List<char> charSpot = new() { '.', ',' };
        private List<char> charSign = new() { '+', '-' };
        private List<char> charEx = new() { 'e', 'E' };




        public Form1()
        {
            InitializeComponent();
        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            unSelectCells();
            string input = txtInput.Text;
            // Старт распознования начинается из 1 состояния
            string currentState = "1";
            List<string> path = new() { };
            bool valid = true;

            foreach (char symbol in input)
            {
                /*
                 * Создать алгоритм определения символа(цифра, точка, +-, е)
                 * symbol(any) -> nonTerminalSymbol
                 * 
                 * В дополнении к path должна быть подсветка ячеек таблицы
                 */
                string? nonTerminalSymbol = definitionSymbol(symbol);
                if (nonTerminalSymbol != null)
                {
                    if (transitions.TryGetValue((currentState, nonTerminalSymbol), out string? nextState))
                    {
                        int rowNumber = definitionRowNumberByNonTerminalSymbol(nonTerminalSymbol);
                        try
                        {
                            dgvTransitions.Rows[rowNumber].Cells[int.Parse(currentState)].Style.BackColor = Color.LightGreen;
                            path.Add(currentState + " -> " + nonTerminalSymbol + " -> " + nextState);
                            currentState = nextState!;
                        }
                        catch
                        {
                            valid = false;
                            unSelectCells();
                            break;
                        }
                    }
                    else
                    {
                        valid = false;
                        unSelectCells();
                        break;
                    }
                }
                else
                {
                    valid = false;
                    break;
                }
            }

            if (valid)
            {
                lblResult.Text = "Распознано!";
                lblResult.ForeColor = Color.Green;
            }
            else
            {
                lblResult.Text = "Не распознано.";
                lblResult.ForeColor = Color.Red;
            }

            lstPath.Items.Clear();
            lstPath.Items.AddRange(path.ToArray());
        }

        public string? definitionSymbol(char symbol)
        {

            if (charNumber.Contains(symbol)) { return "Цифра"; }
            if (charSpot.Contains(symbol)) { return "Точка"; }
            if (charSign.Contains(symbol)) { return "+, -"; }
            if (charEx.Contains(symbol)) { return "e"; }
            return null;
        }

        public int definitionRowNumberByNonTerminalSymbol(string nonTerminalSymbol)
        {
            DataGridViewRowCollection rows = dgvTransitions.Rows;
            for (int i = 0; i < rows.Count - 1; i++)
            {
                string? nonTerminalSymbolInCell = rows[i].Cells[0].Value?.ToString();
                if (nonTerminalSymbolInCell != null && nonTerminalSymbolInCell == nonTerminalSymbol)
                {
                    return i;
                }
            }
            return -1;
        }

        private void txtFinalStates_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInitialState_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            int columnIndex = dgvTransitions.Columns.Count + 1;
            dgvTransitions.Columns.Add("Column" + columnIndex, "" + (columnIndex - 1));
            dgvTransitions.Columns["Column" + columnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in dgvTransitions.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvTransitions.Rows.Add();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgvTransitions.SelectedCells.Count > 0)
            {
                int columnIndex = dgvTransitions.SelectedCells[0].ColumnIndex;
                if (columnIndex != 0)
                    dgvTransitions.Columns.RemoveAt(columnIndex);
            }
            else
            {
                MessageBox.Show("Выберите ячейку в столбце для удаления!");
            }
        }

        private void btnDelRow_Click(object sender, EventArgs e)
        {
            if (dgvTransitions.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvTransitions.SelectedRows)
                {
                    if (!row.IsNewRow)  // Не удалять пустую строку для ввода
                        dgvTransitions.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления!");
            }
        }

        private void dgvTransitions_Leave(object sender, DataGridViewCellEventArgs e)
        {
            transitions.Clear();
            DataGridViewRowCollection rows = dgvTransitions.Rows;
            for (int i = 0; i < rows.Count - 1; i++)
            {
                string? nonTerminalSymbol = rows[i].Cells[0].Value?.ToString();
                var nextStates = rows[i].Cells;
                for (int j = 1; j < nextStates.Count; j++)
                {
                    // здесь формируется transitions
                    // <(currentState, nonTerminalSymbol), nextState>
                    string? nextState = nextStates[j].Value?.ToString();
                    string currentState = j.ToString();
                    if (nonTerminalSymbol != null && nextState != null)
                    {
                        transitions.Add((currentState, nonTerminalSymbol!), nextState!);
                    }
                }
            }
        }

        public void printTransitions()
        {
            foreach (var transition in transitions)
            {
                // Ключ - это кортеж (string, string)
                var key = transition.Key;
                var value = transition.Value;
                // Доступ к элементам кортежа:
                var state = key.Item1; // первый элемент кортежа
                var symbol = key.Item2; // второй элемент кортежа

                // Выводим результат
                MessageBox.Show($"currentState: {state}, nonTerminalSymbol: {symbol}, nextState: {value}");
            }
        }

        private void unSelectCells()
        {
            DataGridViewRowCollection rows = dgvTransitions.Rows;
            for (int i = 0; i < rows.Count - 1; i++)
            {
                var nextStates = rows[i].Cells;
                for (int j = 0; j < nextStates.Count; j++)
                {
                    nextStates[j].Style.BackColor = Color.White;
                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            printTransitions();
        }
    }
}
