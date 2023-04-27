using System;

namespace ROS
{
    internal class Restaurant
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Restaurant(string name, string address, string phone, string email)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
        }
    }
}
