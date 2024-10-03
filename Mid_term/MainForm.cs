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
    public partial class MainForm : Form
    {
        private DatabaseConnection dbconn;
        public MainForm()
        {
            InitializeComponent();
            dbconn = new DatabaseConnection();
            // Disable the window control buttons
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void buttonManageEmployees_Click(object sender, EventArgs e)
        {
            Employee employeeManagementForm = new Employee();
            employeeManagementForm.ShowDialog(); // Use ShowDialog for modal form
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            // Close the MainForm
            this.Close();


            // Show the LoginForm again
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void buttonManageClients_Click(object sender, EventArgs e)
        {
            Client clientManagementForm = new Client();
            clientManagementForm.ShowDialog();
        }

        private void buttonManageProducts_Click(object sender, EventArgs e)
        {
            Products productsManagementForm = new Products();
            productsManagementForm.ShowDialog();
        }

        private void buttonPlaceOrders_Click(object sender, EventArgs e)
        {
            PlaceOrder placeOrderForm = new PlaceOrder();
            placeOrderForm.ShowDialog();
        }

        private void buttonManageOrders_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
