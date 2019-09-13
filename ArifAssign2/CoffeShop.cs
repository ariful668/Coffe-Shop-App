using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArifAssign2
{
    public partial class CoffeShop : Form
    {
        public CoffeShop()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string phone = phoneTextBox.Text;
            string address = addressTextBox.Text;
            string order = itemComboBox.Text;
            string quantity = quantityTextBox.Text;

            if(itemComboBox.SelectedItem.ToString() == "Black")
            {
                quantity = (float.Parse(quantity) * 120).ToString();
            }
            else if (itemComboBox.SelectedItem.ToString() == "Cold")
            {
                quantity = (float.Parse(quantity) * 100).ToString();
            }
            else if (itemComboBox.SelectedItem.ToString() == "Hot")
            {
                quantity = (float.Parse(quantity) * 90).ToString();
            }
            else if (itemComboBox.SelectedItem.ToString() == "Regular")
            {
                quantity = (float.Parse(quantity) * 80).ToString();
            }
            else
            {
                MessageBox.Show("Select an item");
            }

            itemRichTextBox.Text = "Customer Name: " + name + "\n" + "\n" + "Customer No: " + phone + "\n" + "\n" + "Address: " + address + "\n" + "\n" + "Order: " + order + "\n" + "\n" + "Price: " + quantity;

        }
    }
}
