using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Mid_term
{
    internal class DatabaseConnection
    {
        private string connectionString = "initial catalog = Midterm_DotNet; data source = DESKTOP-D21A1I4\\SQLEXPRESS; integrated security = true";

        // Method to get a connection
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Method to execute a query and return a DataTable
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        // Method to execute a non-query command (Insert, Update, Delete)
        public void ExecuteNonQuery(string commandText)
        {
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
