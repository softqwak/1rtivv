namespace rtivv1
{
    public partial class Form1 : Form
    {

        private Dictionary<(string, char), string> transitions = new();
        private string initialState;
        private List<string> finalStates = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            string currentState = initialState;
            List<string> path = new() { currentState };
            bool valid = true;

            foreach (char symbol in input)
            {
                if (transitions.TryGetValue((currentState, symbol), out string nextState))
                {
                    currentState = nextState;
                    path.Add(currentState);
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

        private void btnExample1_Click(object sender, EventArgs e)
        {
            PopulateTable(new List<(string, char, string)>
            {
                ("q0", 'a', "q1"),
                ("q1", 'b', "q2"),
                ("q2", 'a', "q3"),
                ("q3", 'b', "q0"),
                ("q3", 'a', "q2")
            }, "q0", new List<string> { "q3" });
        }

        private void btnExample2_Click(object sender, EventArgs e)
        {
            PopulateTable(new List<(string, char, string)>
            {
                ("q0", '0', "q1"),
                ("q1", '1', "q2"),
                ("q2", '0', "q3"),
                ("q3", '1', "q0"),
                ("q3", '0', "q2")
            }, "q0", new List<string> { "q3" });
        }

        private void btnExample3_Click(object sender, EventArgs e)
        {
            PopulateTable(new List<(string, char, string)>
            {
                ("q0", 'x', "q1"),
                ("q0", 'y', "q1"),
                ("q0", 'z', "q1"),
                ("q1", 'y', "q2"),
                ("q2", 'z', "q3"),
                ("q3", 'x', "q1"),
                ("q2", 'x', "q1")
            }, "q0", new List<string> { "q3" });
        }

        private void PopulateTable(List<(string, char, string)> transitionsList, string startState, List<string> endStates)
        {
            dgvTransitions.Rows.Clear();
            transitions.Clear();
            initialState = startState;
            finalStates = endStates;

            foreach (var (from, symbol, to) in transitionsList)
            {
                dgvTransitions.Rows.Add(from, symbol.ToString(), to);
                transitions[(from, symbol)] = to;
            }
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

        private void dgvTransitions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lstPath_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
