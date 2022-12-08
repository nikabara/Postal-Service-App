using Postal.Library;
using Postal.Services;
using System.Windows.Forms;

namespace PostalApp.UI
{
    public partial class PostaAppWindow : Form
    {
        public User? gottenUser = new User();
        ParcelUserControl CreateParcel = new ParcelUserControl();
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
            CreateParcel = new ParcelUserControl(gottenUser);
            NameText.Text = $"{gottenUser.FirstName} {gottenUser.LastName}";
            EmailText.Text = gottenUser.Email;
            Userid.Text = $"{gottenUser.UserId}";
            ParcelDetailesUserControl myControl = new ParcelDetailesUserControl(gottenUser);
        }


        private void placeOrder_Click(object sender, EventArgs e)
        {
            UserControlDiv.Controls.Clear();
            UserControlDiv.Controls.Add(CreateParcel);
            CreateParcel.Dock = DockStyle.Fill;
        }

        readonly ListBox listBox = new ListBox();
        readonly SqlDataConnector con = new SqlDataConnector();
        private void ParcelsBox_DoubleClick(object sender, EventArgs e)
        {
            ParcelDetailesUserControl parcelDetailesWindow = new ParcelDetailesUserControl();
            if (listBox.SelectedItems != null)
            {
                DialogResult openParcelDetailes = MessageBox.Show("Open detailes?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        readonly AllParcelsUserControl GetParcels = new AllParcelsUserControl() { Dock = DockStyle.Fill };
        private void allParcels_Click(object sender, EventArgs e)
        {
            GetParcels.nothingHereYet.Visible = false;
            if (listBox.Items.Count == 0)
            {
                GetParcels.nothingHereYet.Visible = true;
            }

            listBox.DoubleClick += new EventHandler(ParcelsBox_DoubleClick);

            listBox.Items.Clear();

            listBox.Dock = DockStyle.Fill;
            listBox.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            listBox.BorderStyle = BorderStyle.Fixed3D;
            listBox.BackColor = Color.Wheat;
            List<Parcel> UserParcels = con.GetAllParcelsPerUser(gottenUser.UserId);

            UserControlDiv.Controls.Clear();

            string DeliveryType = string.Empty;
            string StatusType = string.Empty;

            foreach (var item in UserParcels)
            {
                if (item.ShippingId == 1) { StatusType = "by air"; } else if (item.ShippingId == 2) { StatusType = "by ground"; } else if (item.ShippingId == 3) { StatusType = "by sea"; }
                if (item.Delivery == true) { DeliveryType = "Included"; } else if (item.Delivery == false) { DeliveryType = "Not included"; }
                string gottenParcel = $"Parcel : {item.ParcelName}   Description : {item.ParcelDescription}   Delivery : {DeliveryType}   Price : {item.ParcelPrice}$   Send-date : {item.SendDate}   From : {item.SentFrom}   To : {item.SentTo}   Shipping : {StatusType}";
                listBox.Items.Add(gottenParcel);
            }

            GetParcels.ParcelHolder.Controls.Add(listBox);
            UserControlDiv.Controls.Clear();
            UserControlDiv.Controls.Add(GetParcels);
        }

        private void personalInfo_Click(object sender, EventArgs e)
        {
            UserSettingsUserControl userSettingsControl = new UserSettingsUserControl();
            userSettingsControl.Dock = DockStyle.Fill;
            UserControlDiv.Controls.Clear();
            UserControlDiv.Controls.Add(userSettingsControl);
        }
    }
}
