using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROS
{
    internal class Order
    {
        private const string connectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        public int OrderNumber { get; set; }
        public List<MenuItem> MenuItems { get; set; }
        public decimal Total { get; set; }

        public Order()
        {
            MenuItems = new List<MenuItem>();
        }

        public void AddToOrder(List<MenuItem> menuItems)
        {
            Random random = new Random();
            OrderNumber = random.Next(1, 100000);
            MenuItems.AddRange(menuItems);
            Total += menuItems.Sum(x => x.Price);
            Save();
        }
        private void Save()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String menu_Item_Names = string.Join(",", MenuItems.Select(x => x.Name));
                    String menu_Item_Categories = string.Join(",", MenuItems.Select(x => x.Category));
                    String menu_Item_Prices = string.Join(",", MenuItems.Select(x => x.Price.ToString()));

                    using (SqlCommand command = new SqlCommand("INSERT INTO orders4 (id, name, category, price, total, date) VALUES (@id, @name, @category, @price, @total, @date)", connection))
                    {
                        command.Parameters.AddWithValue("@id", OrderNumber);
                        command.Parameters.AddWithValue("@name", menu_Item_Names);
                        command.Parameters.AddWithValue("@category", menu_Item_Categories);
                        command.Parameters.AddWithValue("@price", menu_Item_Prices);
                        command.Parameters.AddWithValue("@total", Total);
                        command.Parameters.AddWithValue("@date", DateTime.Now);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
