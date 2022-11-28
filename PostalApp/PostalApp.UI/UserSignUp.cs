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
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.Devices;
using PostalApp.UI;

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
            if (NameInput.Text != string.Empty && LastNameInput.Text != string.Empty && EmailInput.Text != string.Empty && PasswordInput.Text != string.Empty && AgeInput.Text != string.Empty &&
                NameInput.Text.Length < 30 && LastNameInput.Text.Length < 35 && EmailInput.Text.Length > 7 && EmailInput.Text.Length < 50 && EmailInput.Text.Contains('@') && EmailInput.Text.Contains('.') && 
                PasswordInput.Text.Length > 4 && PasswordInput.Text.Length < 10 && byte.Parse(AgeInput.Text) >= 15 && byte.Parse(AgeInput.Text) <= 120 && Regex.IsMatch(PasswordInput.Text, @"^(?=.*[a-zA-Z])(?=.*[0-9])"))
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
            else if (NameInput.Text == string.Empty || LastNameInput.Text == string.Empty || EmailInput.Text == string.Empty || PasswordInput.Text == string.Empty || AgeInput.Text == string.Empty)
            {
                MessageBox.Show("Please fill all out all the forms",
                    "Operation unsuccessful",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(PasswordInput.Text, @"^(?=.*[a-zA-Z])(?=.*[0-9])"))
            {
                MessageBox.Show("Password must contain at least one number from 0 to 9 and letters from a to z",
                        "Operation unsuccessful",
                            MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (byte.Parse(AgeInput.Text) < 15 || byte.Parse(AgeInput.Text) > 120)
            {
                MessageBox.Show("Age must be between 15 and 120",
                    "Operation unsuccessful",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }

            else if (NameInput.Text.Length >= 30)
            {
                MessageBox.Show("Name is too big max 29 characters",
                    "Operation unsuccessful",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else if (LastNameInput.Text.Length >= 35)
            {
                MessageBox.Show("Last-name is too big max 34 characters",
                    "Operation unsuccessful",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else if (EmailInput.Text.Length <= 7 || EmailInput.Text.Length >= 50)
            {
                MessageBox.Show("Email must be more than 7 and less than 50 characters",
                    "Operation unsuccessful",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else if (!EmailInput.Text.Contains('@') && !EmailInput.Text.Contains('.'))
            {
                MessageBox.Show("Email must contain '.' and '@'",
                    "Operation unsuccessful",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else if (PasswordInput.Text.Length <= 4 || PasswordInput.Text.Length >= 10)
            {
                MessageBox.Show("Password must be more than 4 and less than 10 characters",
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


