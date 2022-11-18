using Postal.Library;
using System.Data;
using Postal.Services.Interfaces;
using Microsoft.Data.SqlClient;
using Postal.Services;

namespace PostalApp.UI
{
    public partial class LogInForm : Form
    {
        public LogInForm()
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

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void SignUpLinkText_Click(object sender, EventArgs e)
        {
            UserSignUp SignUpForm = new UserSignUp();
            this.Hide();
            SignUpForm.ShowDialog();
        }
    }
}