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
        List<string> name = new List<string> { };
        List<int> phone = new List<int> {  };
        List<string> address = new List<string> {  };
        List<string> order = new List<string> {  };
        List<int> quantity = new List<int> {  };


        public CoffeShop()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (phone.Contains(Convert.ToInt32(phoneTextBox.Text)))
                {
                    MessageBox.Show("Phone Number must be unique");
                    return;
                }
                else
                {
                    phone.Add(Convert.ToInt32(phoneTextBox.Text));
                }
                if (!String.IsNullOrEmpty(itemComboBox.Text))
                {
                    order.Add(itemComboBox.Text);
                }
                else
                {
                    MessageBox.Show("Please select any Item");
                    return;
                }

                if (!String.IsNullOrEmpty(quantityTextBox.Text))
                {
                    quantity.Add(Convert.ToInt32(quantityTextBox.Text));
                }
                else
                {
                    MessageBox.Show("Please insert the Quantity");
                    return;
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            name.Add(nameTextBox.Text);
            address.Add(addressTextBox.Text);
            addCustomer();
            MessageBox.Show("Data Added");
            nameTextBox.Clear();
            phoneTextBox.Clear();
            addressTextBox.Clear();
            itemComboBox.SelectedIndex = -1;
            quantityTextBox.Clear();
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            showCustomer();
        }
        private void showCustomer()
        {
            string Message = "";
            for (int i = 0; i < name.Count(); i++)
            {
                Message += "Customer Name: " + name[i] + "\n" + "Customer Phone: " + phone[i] + "\n" + "Customer Address: " + address[i] + "\n" + "order: " + order[i] + "\n" + "Price: " + quantity[i] + "\n" + "\n";
            }

            itemRichTextBox.Text = Message;
        }
        private void addCustomer()
        {
            for (int i = 0; i < name.Count(); i++)
            {
                if (itemComboBox.SelectedItem.ToString() == "Black")
                {
                    quantity[i] = quantity[i] * 120;
                }
                else if (itemComboBox.SelectedItem.ToString() == "Cold")
                {
                    quantity[i] = quantity[i] * 100;
                }
                else if (itemComboBox.SelectedItem.ToString() == "Hot")
                {
                    quantity[i] = quantity[i] * 90;
                }
                else if (itemComboBox.SelectedItem.ToString() == "Regular")
                {
                    quantity[i] = quantity[i] * 80;
                }
                else
                {
                    MessageBox.Show("Select an item");
                }
                itemRichTextBox.Text = "Customer Name: " + name[i] + "\n" + "Customer Phone: " + phone[i] + "\n" + "Customer Address: " + address[i] + "\n" + "order: " + order[i] + "\n" + "Price: " + quantity[i] + "\n" + "\n";
            }
        }   
    }
}
