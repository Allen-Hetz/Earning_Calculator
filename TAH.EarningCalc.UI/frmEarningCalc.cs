namespace TAH.EarningCalc.UI
{
    public partial class frmEarningCalc : Form
    {
        public frmEarningCalc()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exits the application
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clears input and outputs
            txtDaysWorked.Text = "";
            lstOutput.Items.Clear();
            lblTotal.Text = "";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Clears listbox to prevent stacking
            lstOutput.Items.Clear();

            // Validates the number of days inputted
            if (!int.TryParse(txtDaysWorked.Text, out int intDaysWorked) || intDaysWorked <= 0 || string.IsNullOrWhiteSpace(txtDaysWorked.Text))
            {
                // Displays an error message if input is invalid
                MessageBox.Show("Please enter a valid amount of days", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Makes varable to calculate pay for each day
            decimal decPay = 0.01m;
            // Makes varable to calculate total
            decimal decTotal = 0.01m;

            // Adds the first day to the list
            lstOutput.Items.Add("Pay for Day 1 = $0.01");

            // Loops to calculate how much money is earned for each day
            for (int i = 2; i <= intDaysWorked; i++)
            {
                // Multiplys pay by 2
                decPay *= 2;
                // Adds pay to total
                decTotal = decTotal + decPay;
                // Adds an item to the listbox for each day
                lstOutput.Items.Add($"Pay for Day {i} = {decPay:C2}");
            }

            // Displays total
            lblTotal.Text = $"{decTotal:C2}";
        }

        private void txtDaysWorked_TextChanged(object sender, EventArgs e)
        {
            // Clears outputs when the user starts typing
            lstOutput.Items.Clear();
            lblTotal.Text = "";
        }
    }
}
