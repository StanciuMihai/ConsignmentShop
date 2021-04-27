using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
    public partial class AddItems : Form
    {
        

        public AddItems()
        {
            InitializeComponent();

        }
        
        string itemTitle;
        string itemDescription;
        string price;
        string owner;
        int vendorindex;
        public void AddToCombo(Array array, ComboBox c)
        {
            foreach (var a in array)
            {
                c.Items.Add(a);
            }
        }
        private void closeAddItemsWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            itemTitle = titleTextBox.Text;
            itemDescription = descriptionTextBox.Text;
            price = priceTextBox.Text;

            if (itemTitle == "" || itemDescription == "" || price == "" || vendorComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please enter the required fields before adding a new item!");

            }
            else 
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }



        }

        private void AddItems_Load(object sender, EventArgs e)
        {
            ConsignmentShop asdf = new ConsignmentShop();
            foreach (Vendor vendor in ConsignmentShop.store.Vendors)
            {
                string ven = vendor.FirstName + " " + vendor.LastName;
                vendorComboBox.Items.Add(ven);
            }
        }

        private void vendorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            vendorindex = vendorComboBox.SelectedIndex;
           

            
        }
    }
}
