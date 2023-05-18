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
    public partial class Staff : Form
    {
        public System.Data.SqlClient.SqlConnection connection;
        public System.Data.SqlClient.SqlCommand command;

        string connectionString = "Data Source=DESKTOP-BQU3B12;Initial Catalog=Bike Store;Integrated Security=True";
        private System.Data.SqlClient.SqlDataAdapter adapter;
        private DataTable dataTable;
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bike_StoreDataSet.staffs' table. You can move, or remove it, as needed.
            this.staffsTableAdapter.Fill(this.bike_StoreDataSet.staffs);

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            idtext.Text = selectRow.Cells[0].Value.ToString();
            fnametext.Text = selectRow.Cells[1].Value.ToString();
            lnametext.Text = selectRow.Cells[2].Value.ToString();
            ptext.Text = selectRow.Cells[4].Value.ToString();
            etext.Text = selectRow.Cells[3].Value.ToString();
            atext.Text = selectRow.Cells[5].Value.ToString();
            sidtext.Text = selectRow.Cells[6].Value.ToString();
            midtext.Text = selectRow.Cells[7].Value.ToString();


        }

        private void Sreach_Click(object sender, EventArgs e)
        {
           

            using (connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                try
                {
                    int searchId = int.Parse(idtext.Text); // Get the ID to search for

                    // Create the SQL query to search for staff by ID
                    string query = "SELECT * FROM sales.staffs WHERE staff_id= @id";
                    connection.Open();
                    command = new System.Data.SqlClient.SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", searchId);

                    adapter = new System.Data.SqlClient.SqlDataAdapter(command);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1) // If a matching staff record is found
                    {
                        // Populate the textboxes with the data from the row
                        idtext.Text = dataTable.Rows[0][0].ToString();
                        fnametext.Text = dataTable.Rows[0][1].ToString();
                        lnametext.Text = dataTable.Rows[0][2].ToString();
                        ptext.Text = dataTable.Rows[0][3].ToString();
                        etext.Text = dataTable.Rows[0][4].ToString();
                        atext.Text = dataTable.Rows[0][5].ToString();
                        sidtext.Text = dataTable.Rows[0][6].ToString();
                        midtext.Text = dataTable.Rows[0][7].ToString();
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

        private void ClearTextboxes()
        {
            idtext.Text = string.Empty;
            fnametext.Text = string.Empty;
            lnametext.Text = string.Empty;
            ptext.Text = string.Empty;
            etext.Text = string.Empty;
            atext.Text = string.Empty;
            sidtext.Text = string.Empty;
            midtext.Text = string.Empty;
        }

        private void Button2_Click(object sender, EventArgs e)
        {//delete button
            
            using (connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                try
                {
                    int searchId = int.Parse(idtext.Text); // Get the ID to search for

                    // Create the SQL query to search for staff by ID
                    string query = "DELETE FROM sales.staffs WHERE staff_id= @id";

                    connection.Open();
                    command = new System.Data.SqlClient.SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", searchId);

                    adapter = new System.Data.SqlClient.SqlDataAdapter(command);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1) // If a matching staff record is found
                    {
                        // Populate the textboxes with the data from the row
                        idtext.Text = dataTable.Rows[0][0].ToString();
                        fnametext.Text = dataTable.Rows[0][1].ToString();
                        lnametext.Text = dataTable.Rows[0][2].ToString();
                        ptext.Text = dataTable.Rows[0][3].ToString();
                        etext.Text = dataTable.Rows[0][4].ToString();
                        atext.Text = dataTable.Rows[0][5].ToString();
                        sidtext.Text = dataTable.Rows[0][6].ToString();
                        midtext.Text = dataTable.Rows[0][7].ToString();
                        LoadcategoryData();

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
        private void LoadcategoryData()
        {
            try
            {
                // Open the database connection


                // Set up the SQL query to retrieve product data
                string query = "SELECT * FROM sales.staffs";

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

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Create the SQL query to add a new staff record
            string query = "INSERT INTO sales.staffs (first_name, last_name, phone, email, active, store_id, manager_id) VALUES (@fname, @lname, @phone, @email,"
                + "@active, @storeid, @managerid)";

            using (connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    command = new System.Data.SqlClient.SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@fname", fnametext.Text);
                    command.Parameters.AddWithValue("@lname", lnametext.Text);
                    command.Parameters.AddWithValue("@phone", ptext.Text);
                    command.Parameters.AddWithValue("@email", etext.Text);
                    command.Parameters.AddWithValue("@active", atext.Text);
                    command.Parameters.AddWithValue("@storeid", sidtext.Text);
                    command.Parameters.AddWithValue("@managerid", midtext.Text);

                    adapter = new System.Data.SqlClient.SqlDataAdapter(command);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    MessageBox.Show("Staff record added successfully.");
                    LoadcategoryData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
    }
}
