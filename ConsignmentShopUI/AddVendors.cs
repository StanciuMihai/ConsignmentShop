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
        public AddVendors()
        {
            InitializeComponent();
        }

        private void closeAddVendorButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
