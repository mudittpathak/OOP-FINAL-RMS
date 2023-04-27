
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ROS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Login";
            // Load the form
            Form1_Load(this, null);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create a new restaurant
            Restaurant restaurant = new Restaurant("Eat On!", "123 Main Street, Toronto, ON M1P 1A1, Canada", "(416) 555-1234", "eaton@food.com");

            // set these values to labels
            companyName.Text = restaurant.Name;
            companyAddress.Text = restaurant.Address;
            companyPhone.Text = restaurant.Phone;
            companyEmail.Text = restaurant.Email;

            // hide other forms
            menu1.Hide();
            payment1.Hide();
            orders1.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String checkEmail = "eaton@food.com";
            String checkPassword = "admin";

            if (loginEmailField.Text == checkEmail && loginPasswordField.Text == checkPassword)
            {
                // show menu form
                this.Text = "Welcome";
                orders1.Show();
                orders1.BringToFront();
                payment1.Show();
                payment1.BringToFront();
                menu1.Show();
                menu1.BringToFront();

            }
            else
            {
                MessageBox.Show("Incorrect email or password");
            }
        }

        private void orders1_Load(object sender, EventArgs e)
        {

        }
    }
}