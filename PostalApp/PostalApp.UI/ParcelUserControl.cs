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
    }
}
