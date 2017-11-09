namespace InventoryManager
{
    partial class ViewInventoryFormcs
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
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.ItemHeight = 16;
            this.inventoryListBox.Location = new System.Drawing.Point(21, 51);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(639, 420);
            this.inventoryListBox.TabIndex = 0;
            // 
            // ViewInventoryFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 543);
            this.Controls.Add(this.inventoryListBox);
            this.Name = "ViewInventoryFormcs";
            this.Text = "View Inventory Form";
            this.Load += new System.EventHandler(this.ViewInventoryFormcs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox inventoryListBox;
    }
}