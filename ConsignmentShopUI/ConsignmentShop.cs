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
    public partial class ConsignmentShop : Form
    {
       
        public static Store store = new Store();
        List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;
        string vendorFirstName ="";
        string vendorLastName = "";
        string vendorCommission = "";
        string itemTitle;
        string itemDescription;
        decimal itemPrice;
        int itemOwner;
        

        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items;
            itemsListbox.DataSource = itemsBinding;

            itemsListbox.DisplayMember = "Display";
            itemsListbox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartListbox.DataSource = cartBinding;

            shoppingCartListbox.DisplayMember = "Display";
            shoppingCartListbox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            vendorListbox.DataSource = vendorsBinding;

            vendorListbox.DisplayMember = "Display";
            vendorListbox.ValueMember = "Display";

        }
        private void SetupData()
        {
            if (store.Vendors.Count == 0)
            {
                store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith", Commission = .50 });
                store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones", Commission = .50 });


                store.Items.Add(new Item
                {
                    Title = "Moby Dick",
                    Description = "A book about a whale ",
                    Price = 4.50M,
                    Owner = store.Vendors[0]
                });
                store.Items.Add(new Item
                {
                    Title = "A Tale of Two Cities",
                    Description = "A book about a revolution ",
                    Price = 3.80M,
                    Owner = store.Vendors[1]
                });
                store.Items.Add(new Item
                {
                    Title = "Harry Potter Book 1",
                    Description = "A book about a boy ",
                    Price = 5.20M,
                    Owner = store.Vendors[1]
                }); store.Items.Add(new Item
                {
                    Title = "Jane Eyre",
                    Description = "A book about a girl ",
                    Price = 1.50M,
                    Owner = store.Vendors[0]
                });
                store.Name = "Seconds are Better";
            }
        }
        

        private void addToCart_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)itemsListbox.SelectedItem;
            shoppingCartData.Add(selectedItem);
            store.Items.Remove(selectedItem);
            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            foreach (Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;
            }
            storeProfitValue.Text = string.Format("{0:C2}", storeProfit);
            shoppingCartData.Clear();
            cartBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
            //MessageBox.Show("Thank you for your purchase!");
        }

        private void undoAddToCart_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)shoppingCartListbox.SelectedItem;
            store.Items.Add(selectedItem);
            shoppingCartData.Remove(selectedItem);
            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
           
        }

        private void addVendorsButton_Click(object sender, EventArgs e)
        {
            AddVendors addVendorsWindow = new AddVendors();
           if( addVendorsWindow.ShowDialog()== System.Windows.Forms.DialogResult.OK )
           {
                vendorFirstName = addVendorsWindow.vendorFirstName;
                vendorLastName = addVendorsWindow.vendorLastName;
                vendorCommission = addVendorsWindow.vendorCommission;
                store.Vendors.Add(new Vendor { FirstName = vendorFirstName, LastName = vendorLastName, Commission= float.Parse(vendorCommission) });
                cartBinding.ResetBindings(false);
                vendorsBinding.ResetBindings(false);
                itemsBinding.ResetBindings(false);

            }
        }

        private void addItemsButton_Click(object sender, EventArgs e)
        {
            AddItems addItemsWindow = new AddItems();
            if (addItemsWindow.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                itemTitle = addItemsWindow.itemTitle;
                itemDescription = addItemsWindow.itemDescription;
                itemPrice = decimal.Parse(addItemsWindow.itemPrice);
                itemOwner = addItemsWindow.vendorindex;
                store.Items.Add(new Item { Title = itemTitle, Description = itemDescription, Price = itemPrice, Owner = store.Vendors[itemOwner] });
                cartBinding.ResetBindings(false);
                vendorsBinding.ResetBindings(false);
                itemsBinding.ResetBindings(false);
            }

        }

        private void ConsignmentShop_Activated(object sender, EventArgs e)
        {
            cartBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
        }
    }
}
