using Postal.Library;
using Postal.Services;

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
            //ParcelDetailesUserControl myControl = new ParcelDetailesUserControl(gottenUser.UserId);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        readonly ParcelUserControl CreateParcel = new ParcelUserControl() { Dock = DockStyle.Fill };
        private void placeOrder_Click(object sender, EventArgs e)
        {
            UserControlDiv.Controls.Clear();
            UserControlDiv.Controls.Add(CreateParcel);
        }

        readonly AllParcelsUserControl GetParcels = new AllParcelsUserControl() { Dock = DockStyle.Fill };
        private void allParcels_Click(object sender, EventArgs e)
        {
            ListBox listBox = new ListBox();
            SqlDataConnector con = new SqlDataConnector();

            listBox.Dock = DockStyle.Fill;
            listBox.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            listBox.BorderStyle = BorderStyle.Fixed3D;
            listBox.BackColor = Color.Wheat;
            List<Parcel> UserParcels = con.GetAllParcelsPerUser(gottenUser.UserId);

            UserControlDiv.Controls.Clear();

            string DeliveryType;
            string StatusType = string.Empty;
            foreach (var item in UserParcels)
            {
                if (item.ShippingId == 1) { StatusType = "by air"; } else if (item.ShippingId == 2) { StatusType = "by ground"; } else if (item.ShippingId == 3) { StatusType = "by sea"; }
                if (item.Delivery == true) { DeliveryType = "Included"; } else if (item.Delivery == false) { DeliveryType = "Not included"; }
                string gottenParcel = $"Parcel : {item.ParcelName}   Description : {item.ParcelDescription}   Delivery : {item.Delivery}   Price : {item.ParcelPrice}$   Send-date : {item.SendDate}   From : {item.SentFrom}   To : {item.SentTo}   Shipping : {StatusType}";
                listBox.Items.Add(gottenParcel);
            }


            GetParcels.ParcelHolder.Controls.Add(listBox);

            UserControlDiv.Controls.Clear();
            UserControlDiv.Controls.Add(GetParcels);
        }
    }
}
