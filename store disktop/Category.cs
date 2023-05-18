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
    public partial class Category : Form
    {
        public System.Data.SqlClient.SqlConnection connection;
        public System.Data.SqlClient.SqlCommand command;

        string connectionString = "Data Source=DESKTOP-BQU3B12;Initial Catalog=Bike Store;Integrated Security=True";
        private System.Data.SqlClient.SqlDataAdapter adapter;
        private DataTable dataTable;
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bike_StoreDataSet.categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.bike_StoreDataSet.categories);

        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            // Retrieve the product ID from the TextBox or Label control
            //int id = int.Parse(idtext.Text);
            string name = nametext.Text;
            connection = new System.Data.SqlClient.SqlConnection(connectionString);
            command = connection.CreateCommand();

            try
            {
                // Open the database connection
                connection.Open();

                // Set up the SQL query with parameterized values
                string query = "INSERT INTO production.categories (category_name) VALUES (@Name)";

                // Set the parameter values
                //command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", name);

                // Execute the SQL query
                command.CommandText = query;
                command.ExecuteNonQuery();

                // Refresh the data grid to reflect the changes
                LoadcategoryData();

                // Display success message
                MessageBox.Show("Product added successfully!");
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                connection.Close();
            }



        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                idtext.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                nametext.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();


            }

        }
        private void LoadcategoryData()
        {
            try
            {
                // Open the database connection


                // Set up the SQL query to retrieve product data
                string query = "SELECT * FROM production.categories";

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

        private void Delete_Click(object sender, EventArgs e)
        {
            // Retrieve the product ID from the TextBox or Label control
            int id = int.Parse(idtext.Text);


            connection = new System.Data.SqlClient.SqlConnection(connectionString);
            command = connection.CreateCommand();

            try
            {
                // Open the database connection
                connection.Open();

                // Set up the SQL query with parameterized values
                string query = "DELETE FROM production.categories WHERE category_id= @Id";

                // Set the parameter values
                command.Parameters.AddWithValue("@Id", id);

                // Execute the SQL query
                command.CommandText = query;
                command.ExecuteNonQuery();

                // Refresh the data grid to reflect the changes
                LoadcategoryData();

                // Display success message
                MessageBox.Show("Product deleted successfully!");
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                connection.Close();
            }
        }

        private void UpdateCategory_Click(object sender, EventArgs e)
        {
            // Retrieve the product ID from the TextBox or Label control
            int id = int.Parse(idtext.Text);
            string name = nametext.Text;
            connection = new System.Data.SqlClient.SqlConnection(connectionString);
            command = connection.CreateCommand();

            try
            {
                // Open the database connection
                connection.Open();

                // Set up the SQL query with parameterized values
                string query = "UPDATE production.categories SET category_name = @Name WHERE category_id = @Id";

                // Set the parameter values
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", name);

                // Execute the SQL query
                command.CommandText = query;
                command.ExecuteNonQuery();

                // Refresh the data grid to reflect the changes
                LoadcategoryData();

                // Display success message
                MessageBox.Show("Product updated successfully!");
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                connection.Close();
            }

        }
    }
}
