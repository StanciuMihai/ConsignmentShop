﻿using ConsignmentShopLibrary;
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
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
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

        }
        private void SetupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });


            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about a whale ",
                Price = 4.50M,
                Owner=store.Vendors[0]
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
            }
            shoppingCartData.Clear();
            cartBinding.ResetBindings(false);
            MessageBox.Show("Thank you for your purchase!");
        }

        private void undoAddToCart_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)shoppingCartListbox.SelectedItem;
            store.Items.Add(selectedItem);
            shoppingCartData.Remove(selectedItem);
            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
        }
    }
}
