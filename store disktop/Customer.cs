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
    public partial class Customer : Form
    {
        public System.Data.SqlClient.SqlConnection connection;
        public System.Data.SqlClient.SqlCommand command;

        string connectionString = "Data Source=DESKTOP-BQU3B12;Initial Catalog=Bike Store;Integrated Security=True";
        private System.Data.SqlClient.SqlDataAdapter adapter;
        private DataTable dataTable;
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bike_StoreDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.bike_StoreDataSet.customers);

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            cidtext.Text = selectRow.Cells[0].Value.ToString();
            fnctext.Text = selectRow.Cells[1].Value.ToString();
            lnctext.Text = selectRow.Cells[2].Value.ToString();
            pctext.Text = selectRow.Cells[3].Value.ToString();
            ectext.Text = selectRow.Cells[4].Value.ToString();
            sctext.Text = selectRow.Cells[5].Value.ToString();
            cctext.Text = selectRow.Cells[6].Value.ToString();
            stext.Text = selectRow.Cells[7].Value.ToString();
            zctext.Text = selectRow.Cells[8].Value.ToString();


        }
        private void ClearTextboxes()
        {
            cidtext.Text = string.Empty;
            fnctext.Text = string.Empty;
            lnctext.Text = string.Empty;
            pctext.Text = string.Empty;
            ectext.Text = string.Empty;
            sctext.Text = string.Empty;
            cctext.Text = string.Empty;
            stext.Text = string.Empty;
            zctext.Text = string.Empty;
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {

            using (connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                try
                {
                    int searchId = int.Parse(cidtext.Text); // Get the ID to search for

                    // Create the SQL query to search for staff by ID
                    string query = "SELECT * FROM sales.customers WHERE customer_id= @id";
                    connection.Open();
                    command = new System.Data.SqlClient.SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", searchId);

                    adapter = new System.Data.SqlClient.SqlDataAdapter(command);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1) // If a matching staff record is found
                    {
                        // Populate the textboxes with the data from the row
                        cidtext.Text = dataTable.Rows[0][0].ToString();
                        fnctext.Text = dataTable.Rows[0][1].ToString();
                        lnctext.Text = dataTable.Rows[0][2].ToString();
                        pctext.Text = dataTable.Rows[0][3].ToString();
                        ectext.Text = dataTable.Rows[0][4].ToString();
                        sctext.Text = dataTable.Rows[0][5].ToString();
                        cctext.Text = dataTable.Rows[0][6].ToString();
                        stext.Text = dataTable.Rows[0][7].ToString();
                        zctext.Text = dataTable.Rows[0][8].ToString();
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
    }
}
