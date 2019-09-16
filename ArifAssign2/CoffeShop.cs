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
        const int size = 3;
        string[] name = new string[size];
        string[] phone = new string[size];
        string[] address = new string[size];
        string[] order = new string[size];
        int[] quantity = new int[size];
        int index = 0;
        string Message = "";


        public CoffeShop()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (index < size)
            {
                name[index] = nameTextBox.Text;
                phone[index] = phoneTextBox.Text;
                address[index] = addressTextBox.Text;
                order[index] = itemComboBox.Text;
                quantity[index] = Convert.ToInt32(quantityTextBox.Text);
                index++;
            }
            else
            {
                MessageBox.Show("Array is Full");
            }

        }
        private void showButton_Click(object sender, EventArgs e)
        {
            
            for (int index = 0; index < size; index++)
            {
                if (itemComboBox.SelectedItem.ToString() == "Black")
                {
                    quantity[index] = ((quantity[index]) * 120);
                }
                else if (itemComboBox.SelectedItem.ToString() == "Cold")
                {
                    quantity[index] = ((quantity[index]) * 100);
                }
                else if (itemComboBox.SelectedItem.ToString() == "Hot")
                {
                    quantity[index] = ((quantity[index]) * 90);
                }
                else if (itemComboBox.SelectedItem.ToString() == "Regular")
                {
                    quantity[index] = ((quantity[index]) * 80);
                }
                else
                {
                    MessageBox.Show("Select an item");
                }
                Message += "Customer Name: " + name[index]  + "\n" + "Customer No: " + phone[index]  + "\n" + "Address: " + address[index] + "\n"  + "Order: " + order[index] +  "\n" + "Price: " + quantity[index] + "\n" + "\n";
            }
            

            itemRichTextBox.Text= Message;

        }
    }
}
