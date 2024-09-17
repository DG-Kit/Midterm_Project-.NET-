using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mid_term
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        private DatabaseConnection dbconn;
        public LoginForm()
        {
            InitializeComponent();
            dbconn = new DatabaseConnection();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            // Input validation
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = $"SELECT * FROM Employee WHERE Email = '{username}' AND Password = '{password}'";

                DataTable dataTable = dbconn.ExecuteQuery(query);

                if (dataTable.Rows.Count > 0)
                {
                    // Login successful, open the main form
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide(); // Hide login form
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while logging in: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string name = textBoxRegisterName.Text.Trim();
            string email = textBoxRegisterEmail.Text.Trim();
            string phone = textBoxRegisterPhone.Text.Trim();
            string address = textBoxRegisterAddress.Text.Trim();
            string password = textBoxRegisterPassword.Text.Trim();
            decimal salary;
            DateTime hireDate = dateTimePickerRegisterHireDate.Value;

            // Input validation for empty fields
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter an email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please enter a phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(phone, out _))
            {
                MessageBox.Show("Please enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please enter an address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxRegisterSalary.Text) || !decimal.TryParse(textBoxRegisterSalary.Text, out salary))
            {
                MessageBox.Show("Please enter a valid salary.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string commandText = $"INSERT INTO Employee (Name, Email, Phone, Address, Password, Salary, HireDate) VALUES ('{name}', '{email}', '{phone}', '{address}', '{password}', {salary}, '{hireDate}')";
                dbconn.ExecuteNonQuery(commandText);

                MessageBox.Show("Registration successful!");

                // Optionally, hide the registration panel after registration
                panelRegister.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShowRegister_Click(object sender, EventArgs e)
        {
            // Hiển thị panel hoặc ẩn panel
            panelRegister.Visible = !panelRegister.Visible;
        }

        private void buttonTogglePassword_Click(object sender, EventArgs e)
        {
            if (textBoxRegisterPassword.PasswordChar == '*')
            {
                // Show password
                textBoxRegisterPassword.PasswordChar = '\0'; // '\0' means no masking
                buttonTogglePassword.Text = "Hide"; // Change button text to "Hide Password"
            }
            else
            {
                // Hide password
                textBoxRegisterPassword.PasswordChar = '*'; // Mask the password
                buttonTogglePassword.Text = "Show"; // Change button text to "Show Password"
            }
        }

        private void buttonTogglePassword_1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar == '*')
            {
                // Show password
                textBoxPassword.PasswordChar = '\0'; // '\0' means no masking
                buttonTogglePassword_1.Text = "Hide"; // Change button text to "Hide Password"
            }
            else
            {
                // Hide password
                textBoxPassword.PasswordChar = '*'; // Mask the password
                buttonTogglePassword_1.Text = "Show"; // Change button text to "Show Password"
            }
        }
    }
}
