namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateComboBoxes();
        }
        private void PopulateComboBoxes() 
        {
            // Populate Day ComboBox(1 to 31)
            for (int day = 1; day <= 31; day++)
            {
                cmbDay.Items.Add(day.ToString());
            }
            cmbDay.SelectedIndex = 0; // Default to first item

            // Populate Month ComboBox (1 to 12)
            for (int month = 1; month <= 12; month++)
            {
                cmbMonth.Items.Add(month.ToString());
            }
            cmbMonth.SelectedIndex = 0; // Default to first item

            // Populate Year ComboBox (1900 to current year)
            int currentYear = DateTime.Now.Year;
            for (int year = 1900; year <= currentYear; year++)
            {
                cmbYear.Items.Add(year.ToString());
            }
            cmbYear.SelectedIndex = cmbYear.Items.Count - 1; // Default to current year
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtStudentName.Text))
                {
                    MessageBox.Show("Please enter student name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtStudentId.Text))
                {
                    MessageBox.Show("Please enter student ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    MessageBox.Show("Please enter address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbDay.SelectedIndex == -1 || cmbMonth.SelectedIndex == -1 || cmbYear.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select date of birth.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get selected values
                string studentName = txtStudentName.Text;
                string studentId = txtStudentId.Text;
                string gender = rbMale.Checked ? "Male" : "Female";
                string day = cmbDay.SelectedItem.ToString();
                string month = cmbMonth.SelectedItem.ToString();
                string year = cmbYear.SelectedItem.ToString();
                string address = txtAddress.Text;

                // Format output
                string output = $"Student Information:\n\n" +
                               $"Name: {studentName}\n" +
                               $"Student ID: {studentId}\n" +
                               $"Gender: {gender}\n" +
                               $"Date of Birth (MM/DD/YY): {month}/{day}/{year}\n" +
                               $"Address: {address}";

                // Display in message box
                MessageBox.Show(output, "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Also display in the label
                lblOutput.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
