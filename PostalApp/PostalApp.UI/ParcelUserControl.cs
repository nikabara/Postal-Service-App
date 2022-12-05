using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace PostalApp.UI
{
    public partial class ParcelUserControl : UserControl
    {
        ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
        public ParcelUserControl()
        {
            InitializeComponent();
        }

        bool stripToggle = false;
        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Size = new Size(500, 50);

            contextMenuStrip1.Items.Clear();
            contextMenuStrip1.Items.Add("Air");
            contextMenuStrip1.Items.Add("Ground");
            contextMenuStrip1.Items.Add("Marine");


            contextMenuStrip1.ItemClicked += ContextMenuStrip1_ItemClicked;


            stripToggle = !stripToggle;

            if (stripToggle)
            {
                contextMenuStrip1.Show(shippingtypeButton, new Point(0,shippingtypeButton.Height));
            }
            else
            {
                contextMenuStrip1.Hide();
            }
        }

        private void ContextMenuStrip1_ItemClicked(object? sender, ToolStripItemClickedEventArgs e)
        {
            shippingtypeButton.Text = e.ClickedItem.Text;
            stripToggle = false;
        }

        private void deliveryCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (deliveryCheck.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("This will add delivery fee (10$) to your total","Attention!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.No)
                {
                    deliveryCheck.Checked = false;
                }
            }
        }

        private void weightInput_KeyPress(object sender, KeyPressEventArgs e)
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

        private void createParcel_Click(object sender, EventArgs e)
        {

            if (nameInput.Text != "" && descriptionInput.Text != "" && weightInput.Text != "" && sentfromInput.Text != "" && senttoInput.Text != "" &&
                shippingtypeButton.Text == "Air" || shippingtypeButton.Text == "Ground" || shippingtypeButton.Text == "Marine" && nameInput.Text.Length < 30 &&
                descriptionInput.Text.Length < 250 && double.Parse(weightInput.Text) > 0 && double.Parse(weightInput.Text) < 10000 && sentfromInput.Text.Length < 20 && senttoInput.Text.Length < 20)

            {
                double deliveryFee;

                awaitingText.Visible = false;
                var obj = new ParcelDetailesUserControl() { Dock = DockStyle.Fill };
                parcelDetailControlDiv.Controls.Add(obj);

                obj.parcelNameOut.Text = nameInput.Text;
                obj.parcelDescrOut.Text = descriptionInput.Text;
                obj.parcelWeightOut.Text = weightInput.Text;    
                obj.fromOut.Text = sentfromInput.Text;
                obj.toOut.Text = senttoInput.Text;
                if (deliveryCheck.Checked == true)
                {
                    obj.deliveryOut.Text = "Included";
                    deliveryFee = 8;
                }
                else
                {
                    obj.deliveryOut.Text = "Not included";
                    deliveryFee = 0;
                }
                double total = double.Parse(weightInput.Text) / 125 + deliveryFee;
                obj.totalOut.Text = $"{total}";
            }
            else if (nameInput.Text == "" || descriptionInput.Text == "" || weightInput.Text == "" || sentfromInput.Text == "" || senttoInput.Text == "")
            {
                MessageBox.Show("Please fill out all the forms", 
                    "Operation unsuccesfull",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (shippingtypeButton.Text != "Air" || shippingtypeButton.Text != "Ground" || shippingtypeButton.Text != "Marine")
            {
                MessageBox.Show("Please choose shipping type",
                    "Operation unsuccesfull",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nameInput.Text.Length >= 30)
            {
                MessageBox.Show("Parcel name must be less than 30 characters",
                    "Operation unsuccesfull",
                        MessageBoxButtons.OK,  
                            MessageBoxIcon.Error);           
            }
            else if (descriptionInput.Text.Length >= 250)
            {
                MessageBox.Show("Description must be less than 250 characters",
                    "Operation unsuccesfull",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else if (double.Parse(weightInput.Text) >= 10000 || double.Parse(weightInput.Text) == 0)
            {
                MessageBox.Show("Parcel weight must be more than 0 and less than 10000",
                    "Operation unsuccesfull",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else if (sentfromInput.Text.Length > 20)
            {
                MessageBox.Show("From option must be less than 20 chars",
                    "Operation unsuccesfull",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else if (senttoInput.Text.Length > 20)
            {
                MessageBox.Show("To option must be less than 20 chars",
                    "Operation unsuccesfull",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }
    }
}
