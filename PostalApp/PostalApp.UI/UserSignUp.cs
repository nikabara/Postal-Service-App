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

            var myUser = new Postal.Library.User
            {
                FirstName = NameInput.Text,
                LastName = LastNameInput.Text,
                Age = byte.Parse(AgeInput.Text),
                Email = EmailInput.Text,
                Password = PasswordInput.Text,
            };

            if (!connection.GetBasicUser().Any(x => connection.Equal(x, myUser)))
            {
                if (NameInput.Text != "" && LastNameInput.Text != "" &&
                    AgeInput.Text != "" && EmailInput.Text != "" && PasswordInput.Text != "" && EmailInput.Text.Length > 7 &&
                    EmailInput.Text.Contains('@') || EmailInput.Text.Contains('.'))
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
                else
                {
                    MessageBox.Show("Please fill out all the forms",
                        "Operation unsuccessful",
                            MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
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
