using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROS
{
    public partial class Payment : UserControl
    {
        private readonly string connectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        public Payment()
        {
            InitializeComponent();

            paymentLabel.BackColor = System.Drawing.Color.Transparent;
            customerDetailsBox.BackColor = System.Drawing.Color.Transparent;

            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("name", "Name");
            dataGridView1.Columns.Add("category", "Category");
            dataGridView1.Columns.Add("price", "Price");
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || phoneTextBox.Text == "" || emailTextBox.Text == "" || paymentCombo.SelectedIndex == -1 || deliveryCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                MessageBox.Show("Thank you for your order!");
                this.Hide();
            }
        }

        private void updateCurrentOrderButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM orders4 ORDER BY date DESC", connection))

                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            List<String> menu_Item_Names = reader.GetString(1).Split(',').ToList();
                            List<String> menu_Item_Categories = reader.GetString(2).Split(',').ToList();
                            List<String> menu_Item_Prices = reader.GetString(3).Split(',').ToList();


                            for (int i = 0; i < menu_Item_Names.Count; i++)
                            {
                                dataGridView1.Rows.Add(i + 1, menu_Item_Names[i], menu_Item_Categories[i], menu_Item_Prices[i]);
                            }

                            decimal total = 0;
                            foreach (String price in menu_Item_Prices)
                            {
                                total += Convert.ToDecimal(price);
                            }

                            totalBill.Text = total.ToString();
                        }
                       
                    }
                }
            }
        }
    }
}
