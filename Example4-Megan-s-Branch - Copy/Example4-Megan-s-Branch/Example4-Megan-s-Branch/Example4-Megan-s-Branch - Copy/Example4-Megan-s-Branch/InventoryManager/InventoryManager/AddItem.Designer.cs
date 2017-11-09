namespace InventoryManager
{
    partial class AddItem
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
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.categoryListBox = new System.Windows.Forms.ListBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.wholeSaleCostTextBox = new System.Windows.Forms.TextBox();
            this.wholesaleCostLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.currentAmtTextBox = new System.Windows.Forms.TextBox();
            this.currentAmtLabel = new System.Windows.Forms.Label();
            this.itemAttributesLabel = new System.Windows.Forms.Label();
            this.priceSolAttributesLabel = new System.Windows.Forms.Label();
            this.reorderAttributesLabel = new System.Windows.Forms.Label();
            this.reorderMaxAmtTextBox = new System.Windows.Forms.TextBox();
            this.reorderMinAmountTextBox = new System.Windows.Forms.TextBox();
            this.reorderMinAmtLabel = new System.Windows.Forms.Label();
            this.reorderMaxAmtLabel = new System.Windows.Forms.Label();
            this.daysThresholdTextBox = new System.Windows.Forms.TextBox();
            this.maxSoldAmtTextBox = new System.Windows.Forms.TextBox();
            this.minSoldAmtTextBox = new System.Windows.Forms.TextBox();
            this.minSoldLabel = new System.Windows.Forms.Label();
            this.maxSoldLabel = new System.Windows.Forms.Label();
            this.discountAmtTextBox = new System.Windows.Forms.TextBox();
            this.daysThresholdLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(132, 29);
            this.itemNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(89, 22);
            this.itemNameTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(48, 31);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(37, 356);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(152, 49);
            this.addItemButton.TabIndex = 4;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoryListBox
            // 
            this.categoryListBox.FormattingEnabled = true;
            this.categoryListBox.ItemHeight = 16;
            this.categoryListBox.Items.AddRange(new object[] {
            "Clothing",
            "Makeup",
            "Style Products",
            "Accessories"});
            this.categoryListBox.Location = new System.Drawing.Point(132, 62);
            this.categoryListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryListBox.Name = "categoryListBox";
            this.categoryListBox.Size = new System.Drawing.Size(107, 116);
            this.categoryListBox.TabIndex = 5;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(48, 62);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(65, 17);
            this.categoryLabel.TabIndex = 6;
            this.categoryLabel.Text = "Category";
            // 
            // wholeSaleCostTextBox
            // 
            this.wholeSaleCostTextBox.Location = new System.Drawing.Point(132, 206);
            this.wholeSaleCostTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wholeSaleCostTextBox.Name = "wholeSaleCostTextBox";
            this.wholeSaleCostTextBox.Size = new System.Drawing.Size(89, 22);
            this.wholeSaleCostTextBox.TabIndex = 7;
            // 
            // wholesaleCostLabel
            // 
            this.wholesaleCostLabel.AutoSize = true;
            this.wholesaleCostLabel.Location = new System.Drawing.Point(4, 206);
            this.wholesaleCostLabel.Name = "wholesaleCostLabel";
            this.wholesaleCostLabel.Size = new System.Drawing.Size(106, 17);
            this.wholesaleCostLabel.TabIndex = 8;
            this.wholesaleCostLabel.Text = "Wholesale Cost";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(132, 242);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(89, 22);
            this.priceTextBox.TabIndex = 9;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(11, 242);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(40, 17);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.Text = "Price";
            // 
            // currentAmtTextBox
            // 
            this.currentAmtTextBox.Location = new System.Drawing.Point(132, 278);
            this.currentAmtTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentAmtTextBox.Name = "currentAmtTextBox";
            this.currentAmtTextBox.Size = new System.Drawing.Size(89, 22);
            this.currentAmtTextBox.TabIndex = 11;
            // 
            // currentAmtLabel
            // 
            this.currentAmtLabel.AutoSize = true;
            this.currentAmtLabel.Location = new System.Drawing.Point(3, 283);
            this.currentAmtLabel.Name = "currentAmtLabel";
            this.currentAmtLabel.Size = new System.Drawing.Size(107, 17);
            this.currentAmtLabel.TabIndex = 12;
            this.currentAmtLabel.Text = "Current Amount";
            // 
            // itemAttributesLabel
            // 
            this.itemAttributesLabel.AutoSize = true;
            this.itemAttributesLabel.Location = new System.Drawing.Point(78, 7);
            this.itemAttributesLabel.Name = "itemAttributesLabel";
            this.itemAttributesLabel.Size = new System.Drawing.Size(102, 17);
            this.itemAttributesLabel.TabIndex = 14;
            this.itemAttributesLabel.Text = "Item Attributes:";
            // 
            // priceSolAttributesLabel
            // 
            this.priceSolAttributesLabel.AutoSize = true;
            this.priceSolAttributesLabel.Location = new System.Drawing.Point(330, 7);
            this.priceSolAttributesLabel.Name = "priceSolAttributesLabel";
            this.priceSolAttributesLabel.Size = new System.Drawing.Size(170, 17);
            this.priceSolAttributesLabel.TabIndex = 15;
            this.priceSolAttributesLabel.Text = "Pricing Solution Attributes";
            // 
            // reorderAttributesLabel
            // 
            this.reorderAttributesLabel.AutoSize = true;
            this.reorderAttributesLabel.Location = new System.Drawing.Point(375, 256);
            this.reorderAttributesLabel.Name = "reorderAttributesLabel";
            this.reorderAttributesLabel.Size = new System.Drawing.Size(124, 17);
            this.reorderAttributesLabel.TabIndex = 16;
            this.reorderAttributesLabel.Text = "Reorder Attributes";
            // 
            // reorderMaxAmtTextBox
            // 
            this.reorderMaxAmtTextBox.Location = new System.Drawing.Point(411, 341);
            this.reorderMaxAmtTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reorderMaxAmtTextBox.Name = "reorderMaxAmtTextBox";
            this.reorderMaxAmtTextBox.Size = new System.Drawing.Size(89, 22);
            this.reorderMaxAmtTextBox.TabIndex = 18;
            // 
            // reorderMinAmountTextBox
            // 
            this.reorderMinAmountTextBox.Location = new System.Drawing.Point(411, 301);
            this.reorderMinAmountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reorderMinAmountTextBox.Name = "reorderMinAmountTextBox";
            this.reorderMinAmountTextBox.Size = new System.Drawing.Size(89, 22);
            this.reorderMinAmountTextBox.TabIndex = 19;
            // 
            // reorderMinAmtLabel
            // 
            this.reorderMinAmtLabel.AutoSize = true;
            this.reorderMinAmtLabel.Location = new System.Drawing.Point(320, 303);
            this.reorderMinAmtLabel.Name = "reorderMinAmtLabel";
            this.reorderMinAmtLabel.Size = new System.Drawing.Size(82, 17);
            this.reorderMinAmtLabel.TabIndex = 20;
            this.reorderMinAmtLabel.Text = "Min Amount";
            // 
            // reorderMaxAmtLabel
            // 
            this.reorderMaxAmtLabel.AutoSize = true;
            this.reorderMaxAmtLabel.Location = new System.Drawing.Point(311, 341);
            this.reorderMaxAmtLabel.Name = "reorderMaxAmtLabel";
            this.reorderMaxAmtLabel.Size = new System.Drawing.Size(85, 17);
            this.reorderMaxAmtLabel.TabIndex = 21;
            this.reorderMaxAmtLabel.Text = "Max Amount";
            // 
            // daysThresholdTextBox
            // 
            this.daysThresholdTextBox.Location = new System.Drawing.Point(411, 131);
            this.daysThresholdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.daysThresholdTextBox.Name = "daysThresholdTextBox";
            this.daysThresholdTextBox.Size = new System.Drawing.Size(89, 22);
            this.daysThresholdTextBox.TabIndex = 22;
            // 
            // maxSoldAmtTextBox
            // 
            this.maxSoldAmtTextBox.Location = new System.Drawing.Point(411, 91);
            this.maxSoldAmtTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxSoldAmtTextBox.Name = "maxSoldAmtTextBox";
            this.maxSoldAmtTextBox.Size = new System.Drawing.Size(89, 22);
            this.maxSoldAmtTextBox.TabIndex = 23;
            // 
            // minSoldAmtTextBox
            // 
            this.minSoldAmtTextBox.Location = new System.Drawing.Point(411, 50);
            this.minSoldAmtTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minSoldAmtTextBox.Name = "minSoldAmtTextBox";
            this.minSoldAmtTextBox.Size = new System.Drawing.Size(89, 22);
            this.minSoldAmtTextBox.TabIndex = 24;
            // 
            // minSoldLabel
            // 
            this.minSoldLabel.AutoSize = true;
            this.minSoldLabel.Location = new System.Drawing.Point(290, 50);
            this.minSoldLabel.Name = "minSoldLabel";
            this.minSoldLabel.Size = new System.Drawing.Size(114, 17);
            this.minSoldLabel.TabIndex = 25;
            this.minSoldLabel.Text = "Min Sold Amount";
            // 
            // maxSoldLabel
            // 
            this.maxSoldLabel.AutoSize = true;
            this.maxSoldLabel.Location = new System.Drawing.Point(284, 91);
            this.maxSoldLabel.Name = "maxSoldLabel";
            this.maxSoldLabel.Size = new System.Drawing.Size(117, 17);
            this.maxSoldLabel.TabIndex = 26;
            this.maxSoldLabel.Text = "Max Sold Amount";
            // 
            // discountAmtTextBox
            // 
            this.discountAmtTextBox.Location = new System.Drawing.Point(411, 176);
            this.discountAmtTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.discountAmtTextBox.Name = "discountAmtTextBox";
            this.discountAmtTextBox.Size = new System.Drawing.Size(89, 22);
            this.discountAmtTextBox.TabIndex = 27;
            // 
            // daysThresholdLabel
            // 
            this.daysThresholdLabel.AutoSize = true;
            this.daysThresholdLabel.Location = new System.Drawing.Point(292, 131);
            this.daysThresholdLabel.Name = "daysThresholdLabel";
            this.daysThresholdLabel.Size = new System.Drawing.Size(108, 17);
            this.daysThresholdLabel.TabIndex = 28;
            this.daysThresholdLabel.Text = "Days Threshold";
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(281, 176);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(115, 17);
            this.discountLabel.TabIndex = 29;
            this.discountLabel.Text = "Dicsount Amount";
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 489);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.daysThresholdLabel);
            this.Controls.Add(this.discountAmtTextBox);
            this.Controls.Add(this.maxSoldLabel);
            this.Controls.Add(this.minSoldLabel);
            this.Controls.Add(this.minSoldAmtTextBox);
            this.Controls.Add(this.maxSoldAmtTextBox);
            this.Controls.Add(this.daysThresholdTextBox);
            this.Controls.Add(this.reorderMaxAmtLabel);
            this.Controls.Add(this.reorderMinAmtLabel);
            this.Controls.Add(this.reorderMinAmountTextBox);
            this.Controls.Add(this.reorderMaxAmtTextBox);
            this.Controls.Add(this.reorderAttributesLabel);
            this.Controls.Add(this.priceSolAttributesLabel);
            this.Controls.Add(this.itemAttributesLabel);
            this.Controls.Add(this.currentAmtLabel);
            this.Controls.Add(this.currentAmtTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.wholesaleCostLabel);
            this.Controls.Add(this.wholeSaleCostTextBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.categoryListBox);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.itemNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddItem";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.ListBox categoryListBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox wholeSaleCostTextBox;
        private System.Windows.Forms.Label wholesaleCostLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox currentAmtTextBox;
        private System.Windows.Forms.Label currentAmtLabel;
        private System.Windows.Forms.Label itemAttributesLabel;
        private System.Windows.Forms.Label priceSolAttributesLabel;
        private System.Windows.Forms.Label reorderAttributesLabel;
        private System.Windows.Forms.TextBox reorderMaxAmtTextBox;
        private System.Windows.Forms.TextBox reorderMinAmountTextBox;
        private System.Windows.Forms.Label reorderMinAmtLabel;
        private System.Windows.Forms.Label reorderMaxAmtLabel;
        private System.Windows.Forms.TextBox daysThresholdTextBox;
        private System.Windows.Forms.TextBox maxSoldAmtTextBox;
        private System.Windows.Forms.TextBox minSoldAmtTextBox;
        private System.Windows.Forms.Label minSoldLabel;
        private System.Windows.Forms.Label maxSoldLabel;
        private System.Windows.Forms.TextBox discountAmtTextBox;
        private System.Windows.Forms.Label daysThresholdLabel;
        private System.Windows.Forms.Label discountLabel;
    }
}