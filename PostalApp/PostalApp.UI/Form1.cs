using Postal.Library;
using System.Data;
using Postal.Services.Interfaces;
using Microsoft.Data.SqlClient;
using Postal.Services;

namespace PostalApp.UI
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataConnector dataConnection = new SqlDataConnector();
            dataConnection.InsertUser(new User
            {
                FirstName = NameInput.Text,
                LastName = LastNameInput.Text,
                Age = byte.Parse(AgeInput.Text),
                Email = EmailInput.Text,
                PhoneNumber = PhoneNumberInput.Text
            });
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}