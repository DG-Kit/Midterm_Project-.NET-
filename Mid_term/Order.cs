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
    public partial class Order : Form
    {
        private DatabaseConnection dbconn;
        public Order()
        {
            InitializeComponent();
            dbconn = new DatabaseConnection();
            LoadOrders();
        }

        private void LoadOrders()
        {
            string query = "SELECT * FROM [Order]";
            DataTable ordersTable = dbconn.ExecuteQuery(query);
            dataGridViewOrders.DataSource = ordersTable;
        }

        private void buttonViewDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                int orderId = (int)dataGridViewOrders.SelectedRows[0].Cells["ID"].Value;
                LoadOrderItems(orderId);
            }
            else
            {
                MessageBox.Show("Please select an order to view details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadOrderItems(int orderId)
        {
            string query = $"SELECT oi.ID, oi.Quantity, p.Name AS ProductName, p.Price AS ProductPrice " +
                           $"FROM OrderItem oi " +
                           $"INNER JOIN Product p ON oi.ProductID = p.ID " +
                           $"WHERE oi.OrderID = {orderId}";
            DataTable dataTable = dbconn.ExecuteQuery(query);
            dataGridViewOrderItems.DataSource = dataTable;
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                int orderId = (int)dataGridViewOrders.SelectedRows[0].Cells["ID"].Value;

                // Optional: Show confirmation dialog
                var result = MessageBox.Show("Are you sure you want to delete this order?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string commandText = $"DELETE FROM [Order] WHERE ID = {orderId}";
                    dbconn.ExecuteNonQuery(commandText);
                    LoadOrders(); // Refresh the orders list
                    MessageBox.Show("Order deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select an order to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                int orderId = (int)dataGridViewOrders.SelectedRows[0].Cells["ID"].Value;
                Console.WriteLine("Selected Order ID: " + orderId); // Debugging line
                LoadOrderItems(orderId);
            }
            else
            {
                dataGridViewOrderItems.DataSource = null;
            }
        }
    }
}
