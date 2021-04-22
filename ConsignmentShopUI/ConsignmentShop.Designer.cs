
namespace ConsignmentShopUI
{
    partial class ConsignmentShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListbox = new System.Windows.Forms.ListBox();
            this.itemsListboxLabel = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.shoppingCartListboxLabel = new System.Windows.Forms.Label();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.undoAddToCart = new System.Windows.Forms.Button();
            this.vendorListBoxLabel = new System.Windows.Forms.Label();
            this.vendorListbox = new System.Windows.Forms.ListBox();
            this.storePayoutLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(12, 9);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(306, 37);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop";
            // 
            // itemsListbox
            // 
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.ItemHeight = 20;
            this.itemsListbox.Location = new System.Drawing.Point(19, 80);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(296, 184);
            this.itemsListbox.TabIndex = 1;
            // 
            // itemsListboxLabel
            // 
            this.itemsListboxLabel.AutoSize = true;
            this.itemsListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListboxLabel.Location = new System.Drawing.Point(19, 57);
            this.itemsListboxLabel.Name = "itemsListboxLabel";
            this.itemsListboxLabel.Size = new System.Drawing.Size(103, 20);
            this.itemsListboxLabel.TabIndex = 2;
            this.itemsListboxLabel.Text = "Store Items";
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(352, 148);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(155, 51);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add To Cart ->";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // shoppingCartListboxLabel
            // 
            this.shoppingCartListboxLabel.AutoSize = true;
            this.shoppingCartListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartListboxLabel.Location = new System.Drawing.Point(553, 57);
            this.shoppingCartListboxLabel.Name = "shoppingCartListboxLabel";
            this.shoppingCartListboxLabel.Size = new System.Drawing.Size(124, 20);
            this.shoppingCartListboxLabel.TabIndex = 5;
            this.shoppingCartListboxLabel.Text = "Shopping Cart";
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.ItemHeight = 20;
            this.shoppingCartListbox.Location = new System.Drawing.Point(553, 80);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(296, 184);
            this.shoppingCartListbox.TabIndex = 4;
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(726, 280);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(123, 50);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // undoAddToCart
            // 
            this.undoAddToCart.Location = new System.Drawing.Point(553, 280);
            this.undoAddToCart.Name = "undoAddToCart";
            this.undoAddToCart.Size = new System.Drawing.Size(75, 50);
            this.undoAddToCart.TabIndex = 7;
            this.undoAddToCart.Text = "<- Undo";
            this.undoAddToCart.UseVisualStyleBackColor = true;
            this.undoAddToCart.Click += new System.EventHandler(this.undoAddToCart_Click);
            // 
            // vendorListBoxLabel
            // 
            this.vendorListBoxLabel.AutoSize = true;
            this.vendorListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListBoxLabel.Location = new System.Drawing.Point(19, 341);
            this.vendorListBoxLabel.Name = "vendorListBoxLabel";
            this.vendorListBoxLabel.Size = new System.Drawing.Size(124, 20);
            this.vendorListBoxLabel.TabIndex = 9;
            this.vendorListBoxLabel.Text = "Vendors Profit";
            // 
            // vendorListbox
            // 
            this.vendorListbox.FormattingEnabled = true;
            this.vendorListbox.ItemHeight = 20;
            this.vendorListbox.Location = new System.Drawing.Point(19, 364);
            this.vendorListbox.Name = "vendorListbox";
            this.vendorListbox.Size = new System.Drawing.Size(296, 184);
            this.vendorListbox.TabIndex = 8;
            // 
            // storePayoutLabel
            // 
            this.storePayoutLabel.AutoSize = true;
            this.storePayoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storePayoutLabel.Location = new System.Drawing.Point(549, 341);
            this.storePayoutLabel.Name = "storePayoutLabel";
            this.storePayoutLabel.Size = new System.Drawing.Size(106, 20);
            this.storePayoutLabel.TabIndex = 10;
            this.storePayoutLabel.Text = "Store Profit:";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValue.Location = new System.Drawing.Point(656, 341);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(54, 20);
            this.storeProfitValue.TabIndex = 11;
            this.storeProfitValue.Text = "$0.00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Vendors";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(768, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 50);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add Items";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 560);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storePayoutLabel);
            this.Controls.Add(this.vendorListBoxLabel);
            this.Controls.Add(this.vendorListbox);
            this.Controls.Add(this.undoAddToCart);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingCartListboxLabel);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.itemsListboxLabel);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.headerText);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListbox;
        private System.Windows.Forms.Label itemsListboxLabel;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Label shoppingCartListboxLabel;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Button undoAddToCart;
        private System.Windows.Forms.Label vendorListBoxLabel;
        private System.Windows.Forms.ListBox vendorListbox;
        private System.Windows.Forms.Label storePayoutLabel;
        private System.Windows.Forms.Label storeProfitValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

