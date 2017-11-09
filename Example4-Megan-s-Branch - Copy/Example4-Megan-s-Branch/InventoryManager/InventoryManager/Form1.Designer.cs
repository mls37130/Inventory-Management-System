namespace InventoryManager
{
    partial class MainForm
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
            this.addItemsButton = new System.Windows.Forms.Button();
            this.pricingSolutionButton = new System.Windows.Forms.Button();
            this.dicountsButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.editButton = new System.Windows.Forms.Button();
            this.viewInventoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addItemsButton
            // 
            this.addItemsButton.Location = new System.Drawing.Point(60, 64);
            this.addItemsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addItemsButton.Name = "addItemsButton";
            this.addItemsButton.Size = new System.Drawing.Size(125, 49);
            this.addItemsButton.TabIndex = 0;
            this.addItemsButton.Text = "Add Items";
            this.addItemsButton.UseVisualStyleBackColor = true;
            this.addItemsButton.Click += new System.EventHandler(this.addItemsButton_Click);
            // 
            // pricingSolutionButton
            // 
            this.pricingSolutionButton.Location = new System.Drawing.Point(60, 118);
            this.pricingSolutionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pricingSolutionButton.Name = "pricingSolutionButton";
            this.pricingSolutionButton.Size = new System.Drawing.Size(125, 50);
            this.pricingSolutionButton.TabIndex = 1;
            this.pricingSolutionButton.Text = "Apply Pricing Solution";
            this.pricingSolutionButton.UseVisualStyleBackColor = true;
            // 
            // dicountsButton
            // 
            this.dicountsButton.Location = new System.Drawing.Point(60, 172);
            this.dicountsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dicountsButton.Name = "dicountsButton";
            this.dicountsButton.Size = new System.Drawing.Size(125, 48);
            this.dicountsButton.TabIndex = 2;
            this.dicountsButton.Text = "Send Disoucnts";
            this.dicountsButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(60, 287);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(139, 196);
            this.listBox1.TabIndex = 3;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(60, 240);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(121, 42);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit Item";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // viewInventoryButton
            // 
            this.viewInventoryButton.Location = new System.Drawing.Point(60, 10);
            this.viewInventoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewInventoryButton.Name = "viewInventoryButton";
            this.viewInventoryButton.Size = new System.Drawing.Size(125, 50);
            this.viewInventoryButton.TabIndex = 5;
            this.viewInventoryButton.Text = "View Inventory";
            this.viewInventoryButton.UseVisualStyleBackColor = true;
            this.viewInventoryButton.Click += new System.EventHandler(this.viewInventoryButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 518);
            this.Controls.Add(this.viewInventoryButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dicountsButton);
            this.Controls.Add(this.pricingSolutionButton);
            this.Controls.Add(this.addItemsButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addItemsButton;
        private System.Windows.Forms.Button pricingSolutionButton;
        private System.Windows.Forms.Button dicountsButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button viewInventoryButton;
    }
}

