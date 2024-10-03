using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mid_term
{
    public partial class PlaceOrder : Form
    {
        private DatabaseConnection dbconn;

        public PlaceOrder()
        {
            InitializeComponent();
            dbconn = new DatabaseConnection();
            LoadClients();
            LoadProducts();
            orderedProducts = new Dictionary<int, int>(); // Initialize the dictionary

        }

        private void LoadClients()
        {
            string query = "SELECT * FROM Client";
            DataTable clients = dbconn.ExecuteQuery(query);
            comboBoxClients.DataSource = clients;
            comboBoxClients.DisplayMember = "Name";
            comboBoxClients.ValueMember = "ID";
        }

        private void LoadProducts()
        {
            string query = "SELECT * FROM Product";
            DataTable products = dbconn.ExecuteQuery(query);
            dataGridViewProducts.DataSource = products;
        }

        private void UpdateTotalPrice(decimal price)
        {
            decimal currentTotal = string.IsNullOrEmpty(textBoxTotalPrice.Text) ? 0 : Convert.ToDecimal(textBoxTotalPrice.Text);
            textBoxTotalPrice.Text = (currentTotal + price).ToString("F2");
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewProducts.SelectedRows[0];
                int productId = (int)selectedRow.Cells["ID"].Value;
                string productName = selectedRow.Cells["Name"].Value.ToString();
                decimal price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);

                // Add product to ListBox and update dictionary
                if (orderedProducts.ContainsKey(productId))
                {
                    // If the product is already in the dictionary, increase the quantity
                    orderedProducts[productId]++;
                }
                else
                {
                    // Add the product to the dictionary with an initial quantity of 1
                    orderedProducts[productId] = 1;
                }

                // Add or update the product in the ListBox with quantity
                UpdateListBoxDisplay();
                UpdateTotalPrice(price);
            }
        }
        private Dictionary<int, int> orderedProducts; // Dictionary to track product ID and quantity

        // Helper method to update the ListBox display with product names and quantities
        private void UpdateListBoxDisplay()
        {
            listBoxSelectedProducts.Items.Clear();
            foreach (var item in orderedProducts)
            {
                // Assuming you have a way to get the product name from product ID
                string productNameQuery = $"SELECT Name FROM Product WHERE ID = {item.Key}";
                DataTable productNameTable = dbconn.ExecuteQuery(productNameQuery);
                string productName = productNameTable.Rows[0]["Name"].ToString();

                listBoxSelectedProducts.Items.Add($"{productName} (Quantity: {item.Value})");
            }
        }

        private void buttonSubmitOrder_Click(object sender, EventArgs e)
        {
            if (comboBoxClients.SelectedItem != null && listBoxSelectedProducts.Items.Count > 0)
            {
                int clientId = (int)comboBoxClients.SelectedValue;
                int employeeId = GetCurrentEmployeeId(); // Get the current employee ID
                decimal totalPrice = Convert.ToDecimal(textBoxTotalPrice.Text);

                // Insert the order into the Order table
                string commandText = $"INSERT INTO [Order] (ClientID, EmployeeID, OrderDate, TotalPrice) VALUES ({clientId}, {employeeId}, GETDATE(), {totalPrice})";
                dbconn.ExecuteNonQuery(commandText);

                // Retrieve the last inserted OrderID
                int newOrderId = GetLastInsertedOrderId();

                // Insert Order Items and Update Product Quantity
                foreach (var product in orderedProducts)
                {
                    int productId = product.Key;
                    int orderedQuantity = product.Value;

                    // Insert into OrderItem table with the quantity
                    string orderItemCommand = $"INSERT INTO OrderItem (OrderID, ProductID, Quantity) VALUES ({newOrderId}, {productId}, {orderedQuantity})";
                    dbconn.ExecuteNonQuery(orderItemCommand);

                    // Update the quantity in the Product table
                    string updateProductCommand = $"UPDATE Product SET Quantity = Quantity - {orderedQuantity} WHERE ID = {productId}";
                    dbconn.ExecuteNonQuery(updateProductCommand);
                }

                MessageBox.Show("Order submitted successfully!");
                this.Close(); // Optionally close the form after submission
            }
            else
            {
                MessageBox.Show("Please select a client and add products to the order.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Method to retrieve the last inserted Order ID
        private int GetLastInsertedOrderId()
        {
            string query = "SELECT MAX(ID) FROM [Order]";
            DataTable dt = dbconn.ExecuteQuery(query);
            return dt.Rows[0][0] != DBNull.Value ? (int)dt.Rows[0][0] : 0;
        }

        // Example method to get the current employee ID
        private int GetCurrentEmployeeId()
        {
            // Assuming you have a way to access the current user's employee ID.
            return CurrentUser.EmployeeId; // Adjust as necessary based on your application architecture
        }

        private void buttonClearSelection_Click(object sender, EventArgs e)
        {
            listBoxSelectedProducts.Items.Clear();
            textBoxTotalPrice.Clear();
        }

        private void dataGridViewProducts_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Highlight the selected product for better visibility
            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in dataGridViewProducts.Rows)
                {
                    row.Selected = false;
                }
                dataGridViewProducts.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
