using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store_disktop
{

    public partial class Oredr : Form
    {

        public System.Data.SqlClient.SqlConnection connection;
        public System.Data.SqlClient.SqlCommand command;

        string connectionString = "Data Source=DESKTOP-BQU3B12;Initial Catalog=Bike Store;Integrated Security=True";
        private System.Data.SqlClient.SqlDataAdapter adapter;
        private DataTable dataTable;

        public Oredr()
        {
            InitializeComponent();
        }

        private void Oredr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bike_StoreDataSet.orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.bike_StoreDataSet.orders);

        }
        private void LoadcategoryData()
        {
            try
            {
                // Open the database connection


                // Set up the SQL query to retrieve product data
                string query = "SELECT * FROM sales.orders";

                // Create a new data adapter and fill the data table
                adapter = new System.Data.SqlClient.SqlDataAdapter(query, connection);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Set the data source of the data grid
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            oidtext.Text = selectRow.Cells[0].Value.ToString();
            cidtext.Text = selectRow.Cells[1].Value.ToString();
            ostext.Text = selectRow.Cells[2].Value.ToString();
            odtext.Text = selectRow.Cells[3].Value.ToString();
            rdtext.Text = selectRow.Cells[4].Value.ToString();
            sdtext.Text = selectRow.Cells[5].Value.ToString();
            sidtext.Text = selectRow.Cells[6].Value.ToString();
            sidotext.Text = selectRow.Cells[7].Value.ToString();

        }
        private void ClearTextboxes()
        {
            oidtext.Text = string.Empty;
            cidtext.Text = string.Empty;
            ostext.Text = string.Empty;
            odtext.Text = string.Empty;
            rdtext.Text = string.Empty;
            sdtext.Text = string.Empty;
            sidtext.Text = string.Empty;
            sidotext.Text = string.Empty;
        }
        private void Search_Click(object sender, EventArgs e)
        {

            using (connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                try
                {
                    int searchId = int.Parse(oidtext.Text); // Get the ID to search for

                    // Create the SQL query to search for staff by ID
                    string query = "SELECT * FROM sales.orders WHERE order_id= @id";
                    connection.Open();
                    command = new System.Data.SqlClient.SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", searchId);

                    adapter = new System.Data.SqlClient.SqlDataAdapter(command);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1) // If a matching staff record is found
                    {
                        // Populate the textboxes with the data from the row
                        oidtext.Text = dataTable.Rows[0][0].ToString();
                        cidtext.Text = dataTable.Rows[0][1].ToString();
                        ostext.Text = dataTable.Rows[0][2].ToString();
                        odtext.Text = dataTable.Rows[0][3].ToString();
                        rdtext.Text = dataTable.Rows[0][4].ToString();
                        sdtext.Text = dataTable.Rows[0][5].ToString();
                        sidtext.Text = dataTable.Rows[0][6].ToString();
                        sidotext.Text = dataTable.Rows[0][7].ToString();
                    }
                    else
                    {
                        // Clear the textboxes if no matching staff record is found
                        ClearTextboxes();
                        MessageBox.Show("No staff record found with the provided ID.");
                    }
                    LoadcategoryData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            using (connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                try
                {
                    // Create the SQL query to insert staff
                    string query = "INSERT INTO sales.orders (customer_id, order_status, order_date, required_date, shipped_date, store_id, staff_id) VALUES (@cid, @os, @od, @rd, @sd, @sid, @stid)";
                    connection.Open();
                    command = new System.Data.SqlClient.SqlCommand(query, connection);

                    // Add the parameters from the textboxes
                    command.Parameters.AddWithValue("@cid", cidtext.Text);
                    command.Parameters.AddWithValue("@os", ostext.Text);
                    command.Parameters.AddWithValue("@od", odtext.Text);
                    command.Parameters.AddWithValue("@rd", rdtext.Text);
                    command.Parameters.AddWithValue("@sd", sdtext.Text);
                    command.Parameters.AddWithValue("@sid", sidtext.Text);
                    command.Parameters.AddWithValue("@stid", sidotext.Text);

                    adapter = new System.Data.SqlClient.SqlDataAdapter(command);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    MessageBox.Show("Order added successfully.");
                    ClearTextboxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                LoadcategoryData();
            }

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            using (connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                try
                {
                    int deleteId = int.Parse(oidtext.Text); // Get the ID to delete

                    // Create the SQL query to delete staff
                    string query = "DELETE FROM sales.orders WHERE order_id = @id";
                    connection.Open();
                    command = new System.Data.SqlClient.SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", deleteId);

                    adapter = new System.Data.SqlClient.SqlDataAdapter(command);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    MessageBox.Show("Order deleted successfully.");
                    ClearTextboxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                LoadcategoryData();
            }

        }
    }
}
