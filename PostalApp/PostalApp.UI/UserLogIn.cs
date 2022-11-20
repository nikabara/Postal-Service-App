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

        UserSignUp SignUpForm = new UserSignUp();
        private void SignUpLinkText_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm.Show();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            SqlDataConnector sqlDataConnection = new SqlDataConnector();
            UserSignUp signUpWindow = new UserSignUp();
            PostaAppWindow mainAppWindow = new PostaAppWindow();

            var gottenUser = sqlDataConnection.GetLoggedInUserInfo(LogInEmailInput.Text, LogInPasswordInput.Text);

            if (gottenUser.Email == LogInEmailInput.Text && gottenUser.Password == LogInPasswordInput.Text)
            {
                MessageBox.Show("Sucessfully Logged In","Operation successful", MessageBoxButtons.OK,MessageBoxIcon.None);
                this.Hide();
                signUpWindow.Hide();
                mainAppWindow.Show();
            }
            else
            {
                MessageBox.Show("Error logging you in", "Operation unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButtonLogIn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitButtonLogIn_MouseHover(object sender, EventArgs e)
        {
            ExitButtonLogIn.BackColor = Color.Red;
        }

        private void ExitButtonLogIn_MouseLeave(object sender, EventArgs e)
        {
            ExitButtonLogIn.BackColor = Color.DarkGray;
        }
    }
}