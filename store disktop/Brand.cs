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
    public partial class Brand : Form
    {
        public System.Data.SqlClient.SqlConnection connection;
        public System.Data.SqlClient.SqlCommand command;

        string connectionString = "Data Source=DESKTOP-BQU3B12;Initial Catalog=Bike Store;Integrated Security=True";
        private System.Data.SqlClient.SqlDataAdapter adapter;
        private DataTable dataTable;
        public Brand()
        {
            InitializeComponent();
        }

        private void Brand_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bike_StoreDataSet.brands' table. You can move, or remove it, as needed.
            this.brandsTableAdapter.Fill(this.bike_StoreDataSet.brands);

        }
        private void ClearTextboxes()
        {
            bidtext.Text = string.Empty;
            bntext.Text = string.Empty;

        }
        private void LoadcategoryData()
        {
            try
            {
                // Open the database connection


                // Set up the SQL query to retrieve product data
                string query = "SELECT * FROM production.brands";

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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            using (connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                try
                {
                    int searchId = int.Parse(bidtext.Text); // Get the ID to search for

                    // Create the SQL query to search for staff by ID
                    string query = "SELECT * FROM production.brands WHERE brand_id= @id";
                    connection.Open();
                    command = new System.Data.SqlClient.SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", searchId);

                    adapter = new System.Data.SqlClient.SqlDataAdapter(command);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1) // If a matching staff record is found
                    {
                        // Populate the textboxes with the data from the row
                        bidtext.Text = dataTable.Rows[0][0].ToString();
                        bntext.Text = dataTable.Rows[0][1].ToString();

                    }
                    else
                    {
                        // Clear the textboxes if no matching staff record is found
                        ClearTextboxes();
                        MessageBox.Show("No staff record found with the provided ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {


            using (connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                try
                {
                    // Create the SQL query to add the new staff record
                    string query = "INSERT INTO production.brands VALUES ( @name)";

                    // Create a new command and parameterise it
                    command = new System.Data.SqlClient.SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", bidtext.Text);
                    command.Parameters.AddWithValue("@name", bntext.Text);


                    connection.Open();
                    command.ExecuteNonQuery();

                    // Display a success message
                    MessageBox.Show("New brand record successfully added.");

                    // Reload the data into the form
                    LoadcategoryData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                try
                {
                    int searchId = int.Parse(bidtext.Text); // Get the ID to search for

                    // Create the SQL query to search for staff by ID
                    string query = "DELETE FROM production.brands WHERE brand_id= @id";
                    connection.Open();
                    command = new System.Data.SqlClient.SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", searchId);

                    adapter = new System.Data.SqlClient.SqlDataAdapter(command);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1) // If a matching staff record is found
                    {
                        // Populate the textboxes with the data from the row
                        bidtext.Text = dataTable.Rows[0][0].ToString();
                        bntext.Text = dataTable.Rows[0][1].ToString();

                    }
                    else
                    {
                        // Clear the textboxes if no matching staff record is found
                        ClearTextboxes();
                        MessageBox.Show("No staff deleted successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                LoadcategoryData();


            }


        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            bidtext.Text = selectRow.Cells[0].Value.ToString();
            bntext.Text = selectRow.Cells[1].Value.ToString();
        }
    }
}
