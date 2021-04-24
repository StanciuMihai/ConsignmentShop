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
    public partial class AddVendors : Form
    {
        public Store store = new Store();
        public string vendorFirstname;
        public string vendorLastName;
        public string vendorCommission;
        public AddVendors()
        {
            InitializeComponent();
        }

        private void closeAddVendorButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewVendorButton_Click(object sender, EventArgs e)
        {
            vendorFirstname = firstNameBox.Text;
            vendorLastName = lastNameBox.Text;
            vendorCommission = commissionBox.Text;

            if (vendorFirstname == "" || vendorLastName == "")
            {
                MessageBox.Show("Please enter the required fields before adding a new vendor!");
            }
            else
            {
                if (vendorCommission== "")
                {
                    store.Vendors.Add(new Vendor { FirstName = vendorFirstname, LastName = vendorLastName });
                    MessageBox.Show("New vendor successfully added!");

                }
               

            }

        }
    }
}
