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
    }
}
