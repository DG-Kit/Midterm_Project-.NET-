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
    public partial class Products : Form
    {
        private DatabaseConnection dbconn;

        public Products()
        {
            InitializeComponent();
            dbconn = new DatabaseConnection();
            LoadProductData();
        }
        private void LoadProductData()
        {
            try
            {
                string query = "SELECT * FROM Product";
                DataTable dt = dbconn.ExecuteQuery(query);
                dataGridViewProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading product data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Input validation
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxPrice.Text) || string.IsNullOrWhiteSpace(textBoxQuantity.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string name = textBoxName.Text;
                string description = textBoxDescription.Text;
                decimal price = decimal.Parse(textBoxPrice.Text);
                int quantity = int.Parse(textBoxQuantity.Text);

                string commandText = $"INSERT INTO Product (Name, Description, Price, Quantity) VALUES ('{name}', '{description}', {price}, {quantity})";
                dbconn.ExecuteNonQuery(commandText);

                MessageBox.Show("Product added successfully!");
                LoadProductData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int id = (int)dataGridViewProducts.SelectedRows[0].Cells["ID"].Value;
                string name = textBoxName.Text;
                string description = textBoxDescription.Text;
                decimal price = decimal.Parse(textBoxPrice.Text);
                int quantity = int.Parse(textBoxQuantity.Text);

                string commandText = $"UPDATE Product SET Name = '{name}', Description = '{description}', Price = {price}, Quantity = {quantity} WHERE ID = {id}";
                dbconn.ExecuteNonQuery(commandText);

                MessageBox.Show("Product updated successfully!");
                LoadProductData();
            }
            else
            {
                MessageBox.Show("Please select a product to edit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int id = (int)dataGridViewProducts.SelectedRows[0].Cells["ID"].Value;
                string commandText = $"DELETE FROM Product WHERE ID = {id}";
                dbconn.ExecuteNonQuery(commandText);

                MessageBox.Show("Product deleted successfully!");
                LoadProductData();
            }
            else
            {
                MessageBox.Show("Please select a product to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Clear text boxes
            textBoxName.Text = "";
            textBoxDescription.Text = "";
            textBoxPrice.Text = "";
            textBoxQuantity.Text = "";
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Populate text boxes when a row in the DataGridView is selected
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];
                textBoxName.Text = row.Cells["Name"].Value.ToString();
                textBoxDescription.Text = row.Cells["Description"].Value.ToString();
                textBoxPrice.Text = row.Cells["Price"].Value.ToString();
                textBoxQuantity.Text = row.Cells["Quantity"].Value.ToString();
            }
        }
    }
}
