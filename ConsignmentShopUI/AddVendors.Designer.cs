
namespace ConsignmentShopUI
{
    partial class AddVendors
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addNewVendorButton = new System.Windows.Forms.Button();
            this.closeAddVendorButton = new System.Windows.Forms.Button();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.commissionBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Commission %";
            // 
            // addNewVendorButton
            // 
            this.addNewVendorButton.Location = new System.Drawing.Point(208, 254);
            this.addNewVendorButton.Name = "addNewVendorButton";
            this.addNewVendorButton.Size = new System.Drawing.Size(79, 48);
            this.addNewVendorButton.TabIndex = 4;
            this.addNewVendorButton.Text = "Add Vendor";
            this.addNewVendorButton.UseVisualStyleBackColor = true;
            this.addNewVendorButton.Click += new System.EventHandler(this.addNewVendorButton_Click);
            // 
            // closeAddVendorButton
            // 
            this.closeAddVendorButton.Location = new System.Drawing.Point(371, 254);
            this.closeAddVendorButton.Name = "closeAddVendorButton";
            this.closeAddVendorButton.Size = new System.Drawing.Size(79, 48);
            this.closeAddVendorButton.TabIndex = 5;
            this.closeAddVendorButton.Text = "Cancel";
            this.closeAddVendorButton.UseVisualStyleBackColor = true;
            this.closeAddVendorButton.Click += new System.EventHandler(this.closeAddVendorButton_Click);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(208, 39);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(242, 26);
            this.firstNameBox.TabIndex = 6;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(208, 90);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(242, 26);
            this.lastNameBox.TabIndex = 7;
            // 
            // commissionBox
            // 
            this.commissionBox.Location = new System.Drawing.Point(208, 138);
            this.commissionBox.Name = "commissionBox";
            this.commissionBox.Size = new System.Drawing.Size(242, 26);
            this.commissionBox.TabIndex = 8;
            this.commissionBox.Text = ".50";
            // 
            // AddVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 325);
            this.Controls.Add(this.commissionBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.closeAddVendorButton);
            this.Controls.Add(this.addNewVendorButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddVendors";
            this.Text = "AddVendors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addNewVendorButton;
        private System.Windows.Forms.Button closeAddVendorButton;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox commissionBox;
    }
}