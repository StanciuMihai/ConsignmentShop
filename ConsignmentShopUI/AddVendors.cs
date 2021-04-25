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
        ConsignmentShop form1 = new ConsignmentShop();
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
                    form1.store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });



                }
               

            }

        }
    }
}
