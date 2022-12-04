using Postal.Library;

namespace PostalApp.UI
{
    public partial class PostaAppWindow : Form
    {
        public User? gottenUser { get; set; }
        public PostaAppWindow(User? gottenUser)
        {
            InitializeComponent();
            this.gottenUser = gottenUser;
        }

        private void MainExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainExitButton_MouseHover(object sender, EventArgs e)
        {
            MainExitButton.BackColor = Color.Red;
        }

        private void MainExitButton_MouseLeave(object sender, EventArgs e)
        {
            MainExitButton.BackColor = Color.DarkGray;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PostaAppWindow_Load(object sender, EventArgs e)
        {
            NameText.Text = $"{gottenUser.FirstName} {gottenUser.LastName}";
            EmailText.Text = gottenUser.Email;
            Userid.Text = $"{gottenUser.UserId}";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
