using Postal.Library;
using Postal.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostalApp.UI
{
    public partial class ParcelDetailesUserControl : UserControl
    {
        public User MyUserId { get; set; }
        public ParcelDetailesUserControl(User MyUserId)
        {
            InitializeComponent();
            this.MyUserId = MyUserId;
        }
        public ParcelDetailesUserControl()
        {
            InitializeComponent();
        }

        private void createParcel_Click(object sender, EventArgs e)
        {
            SqlDataConnector connector = new SqlDataConnector();

            bool delivery = false;
            if (deliveryOut.Text == "Included")
            {
                delivery = true;
            }

            byte MyShippingId = 0;
            if (shipMethod.Text == "Air")
            {
                MyShippingId = 1;
            }
            else if (shipMethod.Text == "Ground")
            {
                MyShippingId = 2;
            }
            else if (shipMethod.Text == "Marine")
            {
                MyShippingId = 3;
            }

            var res = new Parcel()
            {
                UserId = MyUserId.UserId,
                ParcelName = parcelNameOut.Text,
                ParcelDescription = parcelDescrOut.Text,
                Delivery = delivery,
                ParcelWeight = double.Parse(parcelWeightOut.Text),
                ParcelPrice = double.Parse(totalOut.Text),
                SendDate = DateTime.Now,
                SentFrom = fromOut.Text,
                SentTo = toOut.Text,
                StatusId = 1,
                ShippingId = MyShippingId
            };

            double Payment = double.Parse(totalOut.Text);
            double UserCurrentBalance = connector.GetLoggedInUserInfo(MyUserId.Email, MyUserId.Password).Balance;
            if (UserCurrentBalance >= 0 && UserCurrentBalance > Payment && UserCurrentBalance - Payment >= 0)
            {
                connector.InsertParcel(res);
                connector.MoneyTransaction(MyUserId.Email, -1 * Payment);

                this.Hide();
                MessageBox.Show("Parcel created", "Operation succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Not enought money on your balance", "Operation unsuccesful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

    }

        private void ParcelDetailesUserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void resetParcel_Click(object sender, EventArgs e)
        {
            this.Hide();
            parcelNameOut.Text = "";
            parcelDescrOut.Text = "";
            parcelWeightOut.Text = "";
            toOut.Text = "";
            fromOut.Text = "";
            shipTypeText.Text = "";
            deliveryOut.Text = "";
        }
    }
}
