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
    public partial class Client : Form
    {
        private DatabaseConnection dbconn;
        public Client()
        {
            InitializeComponent();
            dbconn = new DatabaseConnection();
            LoadClientData();
            // Disable the window control buttons
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        // Load all clients into the DataGridView
        private void LoadClientData()
        {
            string query = "SELECT * FROM Client";
            DataTable dataTable = dbconn.ExecuteQuery(query);
            dataGridViewClients.DataSource = dataTable;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Input validation
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Please enter a valid name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) || !textBoxEmail.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPhone.Text) || !long.TryParse(textBoxPhone.Text, out _))
            {
                MessageBox.Show("Please enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Please enter a valid address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert client into the database
            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;
            string address = textBoxAddress.Text;

            string commandText = $"INSERT INTO Client (Name, Email, Phone, Address) VALUES ('{name}', '{email}', '{phone}', '{address}')";
            dbconn.ExecuteNonQuery(commandText);

            MessageBox.Show("Client added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadClientData(); // Reload clients list
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                int id = (int)dataGridViewClients.SelectedRows[0].Cells["ID"].Value;
                string name = textBoxName.Text;
                string email = textBoxEmail.Text;
                string phone = textBoxPhone.Text;
                string address = textBoxAddress.Text;

                // Input validation
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address))
                {
                    MessageBox.Show("All fields must be filled in.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!email.Contains("@"))
                {
                    MessageBox.Show("Please enter a valid email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!long.TryParse(phone, out _))
                {
                    MessageBox.Show("Please enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update client in the database
                string commandText = $"UPDATE Client SET Name = '{name}', Email = '{email}', Phone = '{phone}', Address = '{address}' WHERE ID = {id}";
                dbconn.ExecuteNonQuery(commandText);

                MessageBox.Show("Client updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadClientData();
            }
            else
            {
                MessageBox.Show("Please select a client to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                int id = (int)dataGridViewClients.SelectedRows[0].Cells["ID"].Value;

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this client?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    string commandText = $"DELETE FROM Client WHERE ID = {id}";
                    dbconn.ExecuteNonQuery(commandText);

                    MessageBox.Show("Client deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadClientData();
                }
            }
            else
            {
                MessageBox.Show("Please select a client to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();
            textBoxAddress.Clear();
        }

        private void dataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewClients.Rows[e.RowIndex];
                textBoxName.Text = row.Cells["Name"].Value.ToString();
                textBoxEmail.Text = row.Cells["Email"].Value.ToString();
                textBoxPhone.Text = row.Cells["Phone"].Value.ToString();
                textBoxAddress.Text = row.Cells["Address"].Value.ToString();
            }
        }
    }
}
