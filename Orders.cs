using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROS
{
    public partial class Orders : UserControl
    {
        private readonly string connectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        public Orders()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {

        }

        private void updateAllOrdersButton_Click(object sender, EventArgs e)
        {
            get();
        }

        // get all orders according to the database and table and menu item class
        private void get()
        {
            // add colums to datagrid
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("name", "Name");
            dataGridView1.Columns.Add("category", "Category");
            dataGridView1.Columns.Add("price", "Price");
            dataGridView1.Columns.Add("total", "Total");
            dataGridView1.Columns.Add("date", "Date");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM orders4", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), "~" + reader.GetDecimal(4).ToString(), reader.GetDateTime(5));
                        }
                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close the application
            Application.Exit();
        }
    }
}
