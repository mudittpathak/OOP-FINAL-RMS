using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROS
{
    public partial class Menu : UserControl
    {
        private const string connectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        String createTableQuery = "CREATE TABLE orders4 (id INTEGER PRIMARY KEY, name TEXT, category TEXT, price TEXT, total NUMERIC, date DATETIME)";

        public Menu()
        {
            InitializeComponent();
            // create the database and table if they don't exist
            CreateDatabaseandTable();
            //CreateTable();
            welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            chooseLabel.BackColor = System.Drawing.Color.Transparent;

            // iterate through all GroupBoxes on the form
            foreach (GroupBox groupBox in this.Controls.OfType<GroupBox>())
            {
                // iterate through all CheckBox controls in the GroupBox
                foreach (CheckBox checkBox in groupBox.Controls.OfType<CheckBox>())
                {
                    checkBox.CheckedChanged += checkBox_CheckedChanged;
                }
            }
        }

        private void CreateDatabaseandTable()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'orders4'", connection))
                    {
                        if (command.ExecuteScalar() == null)
                        {
                            // Create the table if it does not already exist
                            using (SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection))
                            {
                                createTableCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            foreach (Control groupBox in this.Controls.OfType<GroupBox>())
            {
                foreach (CheckBox checkBox in groupBox.Controls.OfType<CheckBox>())
                {
                    if (checkBox.Checked)
                    {
                        menuItems.Add(new MenuItem(groupBox.Text, checkBox.Text, Convert.ToDecimal(checkBox.Tag)));
                    }

                }
            }

            if (menuItems.Count > 0)
            {
                Order order = new Order();
                order.AddToOrder(menuItems);
                MessageBox.Show("Order placed successfully!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select at least one item.");
               
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            decimal totalPrice = 0;

            // iterate through all group boxes
            foreach (Control groupBox in this.Controls.OfType<GroupBox>())
            {
                // iterate through all checkboxes in the current group box
                foreach (CheckBox checkBox in groupBox.Controls.OfType<CheckBox>())
                {
                    if (checkBox.Checked)
                    {
                        totalPrice += Convert.ToDecimal(checkBox.Tag);
                    }
                }
            }
            menuTotalBill.Text = totalPrice.ToString("C");
        }
    }
}
