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
            
        }

        private void AddItems_Load(object sender, EventArgs e)
        {
            ConsignmentShop cs = new ConsignmentShop();
            foreach (Vendor vendor in cs.store.Vendors)
            {
                vendorComboBox.Items.Add(vendor.FirstName);
            }
        }
    }
}
