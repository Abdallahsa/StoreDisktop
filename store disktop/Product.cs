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
    public partial class Product : Form
    {
        public System.Data.SqlClient.SqlConnection connection;
        public System.Data.SqlClient.SqlCommand command;

        string connectionString = "Data Source=DESKTOP-BQU3B12;Initial Catalog=Bike Store;Integrated Security=True";
        private System.Data.SqlClient.SqlDataAdapter adapter;
        private DataTable dataTable;
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bike_StoreDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.bike_StoreDataSet.products);

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            idtext.Text = selectRow.Cells[0].Value.ToString();
            nametext.Text = selectRow.Cells[1].Value.ToString();
            bidtext.Text = selectRow.Cells[2].Value.ToString();
            cidtext.Text = selectRow.Cells[3].Value.ToString();
            midtext.Text = selectRow.Cells[4].Value.ToString();
            lidtext.Text = selectRow.Cells[5].Value.ToString();

        }
        private void LoadcategoryData()
        {
            try
            {
                // Open the database connection


                // Set up the SQL query to retrieve product data
                string query = "SELECT * FROM production.products";

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


        private void Add_Click(object sender, EventArgs e)
        {
            //using try
           
            string name = nametext.Text;
            int bid = int.Parse(bidtext.Text);
            int cid = int.Parse(cidtext.Text);
            int mid = int.Parse(midtext.Text);
            int lid = int.Parse(lidtext.Text);
            if (name == "" || bid == 0 || cid == 0 || mid == 0 || lid == 0)
            {

                MessageBox.Show("Please fill all the information");
            }
            else
            {
                try
                {
                    // Open the database connection
                    connection = new System.Data.SqlClient.SqlConnection(connectionString);
                    connection.Open();
                    // Set up a command with the given query and associate
                    // this with the current connection.
                    string query = "INSERT INTO production.products VALUES(@name,@bid,@cid,@mid,@lid)";
                    command = new System.Data.SqlClient.SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@bid", bid);
                    command.Parameters.AddWithValue("@cid", cid);
                    command.Parameters.AddWithValue("@mid", mid);
                    command.Parameters.AddWithValue("@lid", lid);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Add success");
                    LoadcategoryData();
                }
                catch (Exception ex)
                {
                    // Display error message
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Close the connection
                    connection.Close();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idtext.Text);
            if (id == 0)
            {
                MessageBox.Show("Please fill all the information");
            }
            else
            {
                try
                {
                    // Open the database connection
                    connection = new System.Data.SqlClient.SqlConnection(connectionString);
                    connection.Open();
                    // Set up a command with the given query and associate
                    // this with the current connection.
                    string query = "DELETE FROM production.products WHERE product_id = @id";
                    command = new System.Data.SqlClient.SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Delete success");
                    LoadcategoryData();
                }
                catch (Exception ex)
                {
                    // Display error message
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Close the connection
                    connection.Close();
                }
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idtext.Text);
            string name = nametext.Text.ToString();
            int bid = int.Parse(bidtext.Text);
            int cid = int.Parse(cidtext.Text);
            int mid = int.Parse(midtext.Text);
            Decimal lid = Decimal.Parse(lidtext.Text);
            if (id == 0 || name == "" || bid == 0 || cid == 0 || mid == 0 || lid == 0)
            {

                MessageBox.Show("Please fill all the information");
            }
            else
            {
                try
                {
                    // Open the database connection
                    connection = new System.Data.SqlClient.SqlConnection(connectionString);
                    connection.Open();
                    // Set up a command with the given query and associate
                    // this with the current connection.
                    string query = "UPDATE production.products SET product_name = @name, brand_id = @bid, category_id = @cid, model_year = @mid, list_price = @lid WHERE product_id = @id";
                    command = new System.Data.SqlClient.SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@bid", bid);
                    command.Parameters.AddWithValue("@cid", cid);
                    command.Parameters.AddWithValue("@mid", mid);
                    command.Parameters.AddWithValue("@lid", lid);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Update success");
                    LoadcategoryData();
                }
                catch (Exception ex)
                {
                    // Display error message
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Close the connection
                    connection.Close();
                }
            }

        }
    }
}
