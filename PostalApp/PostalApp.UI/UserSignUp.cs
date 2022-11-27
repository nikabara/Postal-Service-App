using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Postal.Services;
using Postal.Library;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PostalApp.UI
{
    public partial class UserSignUp : Form
    {
        public UserSignUp()
        {
            InitializeComponent();
        }

        private void LoginLinkText_Click_1(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            this.Hide();
            logInForm.Show();
        }

        SqlDataConnector connection = new SqlDataConnector();
        private void ContinueButton_Click(object sender, EventArgs e)
        {
            if (NameInput.Text != "" && LastNameInput.Text != "" && AgeInput.Text != "" && EmailInput.Text != "" && PasswordInput.Text != "" && EmailInput.Text.Length > 7 && EmailInput.Text.Contains('@') == true || EmailInput.Text.Contains('.') == true &&
                AgeInput.Text != "" && byte.Parse(AgeInput.Text) >= 15 && byte.Parse(AgeInput.Text) <= 120)
            {
                var myUser = new Postal.Library.User
                {
                    FirstName = NameInput.Text,
                    LastName = LastNameInput.Text,
                    Age = byte.Parse(AgeInput.Text),
                    Email = EmailInput.Text,
                    Password = PasswordInput.Text,
                };
                PostaAppWindow mainAppWindow = new PostaAppWindow(myUser);
                if (!connection.GetBasicUser().Any(x => connection.Equal(x, myUser)))
                {
                    connection.InsertUser(new Postal.Library.User
                    {
                        FirstName = NameInput.Text,
                        LastName = LastNameInput.Text,
                        Age = byte.Parse(AgeInput.Text),
                        Email = EmailInput.Text,
                        Password = PasswordInput.Text,
                    });
                }
                else if (connection.GetBasicUser().Any(x => connection.Equal(x, myUser)))
                {
                    NameInput.ResetText();
                    LastNameInput.ResetText();
                    AgeInput.ResetText();
                    EmailInput.ResetText();
                    PasswordInput.ResetText();
                    MessageBox.Show("User with this credentials already exist",
                            "Operation unsuccessful",
                                MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
                this.Close();
                mainAppWindow.Show();
            }
            else if (NameInput.Text == "" && LastNameInput.Text == "" &&
                AgeInput.Text == "" && EmailInput.Text == "" && PasswordInput.Text == "")
            {
                MessageBox.Show("Please fill out all the forms",
                    "Operation unsuccessful",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else if (EmailInput.Text.Length < 7 || EmailInput.Text.Length > 50)
            {
                MessageBox.Show("Email length must be at least 7 characcters and maximum 49",
                    "Operation unsuccessful",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else if (EmailInput.Text.Contains('@') == false || EmailInput.Text.Contains('.') == false)
            {
                MessageBox.Show("Email must contain '@' and '.'",
                    "Operation unsuccessful",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else if (PasswordInput.Text.Length < 4 || PasswordInput.Text.Length >= 10)
            {
                MessageBox.Show("Password must be more than 4 and less than 10 characters",
                    "Operation unsuccessful",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else if (AgeInput.Text == "")
            {
                MessageBox.Show("Please enter your age",
                    "Operation unsuccessful",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else if (byte.Parse(AgeInput.Text) < 15)
            {
                MessageBox.Show("You're not old enough",
                    "Operation unsuccessful",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else if (byte.Parse(AgeInput.Text) > 120)
            {
                MessageBox.Show("Age is too big",
                    "Operation unsuccessful",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }

        private void AgeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void ExitButtonSignUp_MouseHover(object sender, EventArgs e)
        {
            ExitButtonSignUp.BackColor = Color.Red;
        }
        private void ExitButtonSignUp_MouseLeave(object sender, EventArgs e)
        {
            ExitButtonSignUp.BackColor = Color.DarkGray;
        }
        private void ExitButtonSignUp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
