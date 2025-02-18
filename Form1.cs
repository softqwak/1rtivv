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

            if (valid && finalStates.Contains(currentState))
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

        private void btnSetTransitions_Click(object sender, EventArgs e)
        {
            transitions.Clear();
            initialState = txtInitialState.Text;
            finalStates = txtFinalStates.Text.Split(',').Select(s => s.Trim()).ToList();

            foreach (DataGridViewRow row in dgvTransitions.Rows)
            {
                if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null)
                    continue;

                string fromState = row.Cells[0].Value.ToString();
                char symbol = row.Cells[1].Value.ToString()[0];
                string toState = row.Cells[2].Value.ToString();

                transitions[(fromState, symbol)] = toState;
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
    }
}
