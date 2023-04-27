using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROS
{
    internal class MenuItem
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public MenuItem(string category, string name, decimal price)
        {
            Category = category;
            Name = name;
            Price = price;
        }
    }
}
