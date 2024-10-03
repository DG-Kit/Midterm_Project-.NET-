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
    public partial class Employee : Form
    {
        private DatabaseConnection dbconn;
        public Employee()
        {
            InitializeComponent();
            dbconn= new DatabaseConnection();
            LoadEmployeeData();
            // Disable the window control buttons
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void LoadEmployeeData()
        {
            try
            {
                string query = "SELECT * FROM Employee";
                DataTable dataTable = dbconn.ExecuteQuery(query);
                dataGridViewEmployees.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateEmployeeInputs()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Please enter a name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) || !textBoxEmail.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxPhone.Text) || !long.TryParse(textBoxPhone.Text, out _))
            {
                MessageBox.Show("Please enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxSalary.Text) || !decimal.TryParse(textBoxSalary.Text, out _))
            {
                MessageBox.Show("Please enter a valid salary.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateEmployeeInputs())
            {
                try
                {
                    string name = textBoxName.Text;
                    string email = textBoxEmail.Text;
                    string phone = textBoxPhone.Text;
                    string address = textBoxAddress.Text;
                    decimal salary = decimal.Parse(textBoxSalary.Text);
                    DateTime hireDate = dateTimePickerHireDate.Value;

                    string commandText = $"INSERT INTO Employee (Name, Email, Phone, Address, Salary, HireDate) VALUES ('{name}', '{email}', '{phone}', '{address}', {salary}, '{hireDate}')";
                    dbconn.ExecuteNonQuery(commandText);

                    LoadEmployeeData();
                    MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                if (ValidateEmployeeInputs())
                {
                    try
                    {
                        int id = (int)dataGridViewEmployees.SelectedRows[0].Cells["ID"].Value;
                        string name = textBoxName.Text;
                        string email = textBoxEmail.Text;
                        string phone = textBoxPhone.Text;
                        string address = textBoxAddress.Text;
                        decimal salary = decimal.Parse(textBoxSalary.Text);
                        DateTime hireDate = dateTimePickerHireDate.Value;

                        string commandText = $"UPDATE Employee SET Name = '{name}', Email = '{email}', Phone = '{phone}', Address = '{address}', Salary = {salary}, HireDate = '{hireDate}' WHERE ID = {id}";
                        dbconn.ExecuteNonQuery(commandText);

                        LoadEmployeeData();
                        MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                try
                {
                    int id = (int)dataGridViewEmployees.SelectedRows[0].Cells["ID"].Value;
                    string commandText = $"DELETE FROM Employee WHERE ID = {id}";
                    dbconn.ExecuteNonQuery(commandText);

                    LoadEmployeeData();
                    MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEmployees.Rows[e.RowIndex];

                textBoxName.Text = row.Cells["Name"].Value.ToString();
                textBoxEmail.Text = row.Cells["Email"].Value.ToString();
                textBoxPassword.Text = row.Cells["Password"].Value.ToString(); // Add this field if password is displayed
                textBoxPhone.Text = row.Cells["Phone"].Value.ToString();
                textBoxAddress.Text = row.Cells["Address"].Value.ToString();
                textBoxSalary.Text = row.Cells["Salary"].Value.ToString();
                dateTimePickerHireDate.Value = Convert.ToDateTime(row.Cells["HireDate"].Value);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Clear all the TextBox fields
            textBoxName.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();
            textBoxAddress.Clear();
            textBoxSalary.Clear();
            textBoxPassword.Clear();

            // Reset the DateTimePicker to the current date
            dateTimePickerHireDate.Value = DateTime.Now;

            // Optionally, clear the selection in DataGridView if required
            dataGridViewEmployees.ClearSelection();
        }
    }
}
