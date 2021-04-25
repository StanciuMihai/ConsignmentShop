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
        
        public string vendorFirstName;
        public string vendorLastName;
        public string vendorCommission;
        public AddVendors()
        {
            InitializeComponent();

            
        }


        private void closeAddVendorButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void addNewVendorButton_Click(object sender, EventArgs e)
        {
            vendorFirstName = firstNameBox.Text;
            vendorLastName = lastNameBox.Text;
            vendorCommission = commissionBox.Text;


            if (vendorFirstName == "" || vendorLastName == "" || vendorCommission=="")
            {
                MessageBox.Show("Please enter the required fields before adding a new vendor!");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
    }
}
