namespace InventoryManager
{
    partial class EditItemForm
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
            this.itemIDTextBox = new System.Windows.Forms.TextBox();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.ItemIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemIDTextBox
            // 
            this.itemIDTextBox.Location = new System.Drawing.Point(148, 62);
            this.itemIDTextBox.Name = "itemIDTextBox";
            this.itemIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.itemIDTextBox.TabIndex = 0;
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(148, 103);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(116, 50);
            this.removeItemButton.TabIndex = 1;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // ItemIdLabel
            // 
            this.ItemIdLabel.AutoSize = true;
            this.ItemIdLabel.Location = new System.Drawing.Point(74, 62);
            this.ItemIdLabel.Name = "ItemIdLabel";
            this.ItemIdLabel.Size = new System.Drawing.Size(51, 17);
            this.ItemIdLabel.TabIndex = 2;
            this.ItemIdLabel.Text = "Item ID";
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 478);
            this.Controls.Add(this.ItemIdLabel);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.itemIDTextBox);
            this.Name = "EditItemForm";
            this.Text = "Edit Item Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemIDTextBox;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Label ItemIdLabel;
    }
}