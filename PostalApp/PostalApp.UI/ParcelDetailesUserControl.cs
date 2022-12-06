using Postal.Library;
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
    public partial class ParcelDetailesUserControl : UserControl
    {
        public User MyUserId { get; set; }
        public ParcelDetailesUserControl(User MyUserId)
        {
            InitializeComponent();
            this.MyUserId = MyUserId;
        }

        private void createParcel_Click(object sender, EventArgs e)
        {

            SqlDataConnector connector = new SqlDataConnector();

            bool delivery = false;
            if (deliveryOut.Text == "Included")
            {
                delivery = true;
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
                ShippingId = 1
            };

            connector.InsertParcel(res);

    }
    }
}
