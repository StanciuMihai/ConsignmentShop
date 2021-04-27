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
        
       public string itemTitle;
       public string itemDescription;
       public string itemPrice;
       public int vendorindex;
       
        private void closeAddItemsWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            itemTitle = titleTextBox.Text;
            itemDescription = descriptionTextBox.Text;
            itemPrice = priceTextBox.Text;

            if (itemTitle == "" || itemDescription == "" || itemPrice == "" || vendorComboBox.SelectedItem == null)
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
