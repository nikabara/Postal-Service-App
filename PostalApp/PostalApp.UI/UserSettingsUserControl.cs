using Postal.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostalApp.UI
{
    public partial class UserSettingsUserControl : UserControl
    {
        public UserSettingsUserControl()
        {
            InitializeComponent();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            PostaAppWindow MainAppWindow = new PostaAppWindow();
            SqlDataConnector con = new SqlDataConnector();
            if (NameInput.Text != "" && LastNameInput.Text != "" && PasswordInput.Text != "" && EmailInput.Text != "")
            {
                // alter user script here
                bool userExists = con.GetUsers().Any(x => x.Email == EmailInput.Text && x.Password == PasswordInput.Text);
                if (userExists)
                {
                    con.AlterUser(EmailInput.Text, PasswordInput.Text, NameInput.Text, LastNameInput.Text);
                    MessageBox.Show("User altered", "Operation succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainAppWindow.NameText.Text = $"{NameInput.Text} {LastNameInput.Text}";

                    NameInput.Text = "";
                    LastNameInput.Text = "";
                    PasswordInput.Text = "";
                    EmailInput.Text = "";
                }
                else if (!userExists)
                {
                    MessageBox.Show("User with given email and password was not found", "Operation unsuccesful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NameInput.Text = "";
                    LastNameInput.Text = "";
                    PasswordInput.Text = "";
                    EmailInput.Text = "";
                }
            }
            else if (NameInput.Text == "" || LastNameInput.Text == "" || PasswordInput.Text == "" || EmailInput.Text == "")
            {
                MessageBox.Show("Please fill all the forms", "Operation unsuccesful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            SqlDataConnector con = new SqlDataConnector();
            if (insertMoneyEmailConf.Text != "" && InsertMoney.Text != "")
            {
                bool userExists = con.GetUsers().Any(x => x.Email == insertMoneyEmailConf.Text);
                if (userExists)
                {
                    con.MoneyTransaction(insertMoneyEmailConf.Text, double.Parse(InsertMoney.Text));
                    MessageBox.Show("Money inserted", "Operation succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    insertMoneyEmailConf.Text = "";
                    InsertMoney.Text = "";
                }
                else if (!userExists)
                {
                    MessageBox.Show("User with given email was not found", "Operation unsuccesful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    insertMoneyEmailConf.Text = "";
                    InsertMoney.Text = "";
                }
            }
            else if (insertMoneyEmailConf.Text == "" && InsertMoney.Text == "")
            {
                MessageBox.Show("Please fill all the forms", "Operation unsuccesful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertMoney_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
