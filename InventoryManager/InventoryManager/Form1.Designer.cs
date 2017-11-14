namespace InventoryManager
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.pricingSolutionButton = new System.Windows.Forms.Button();
            this.dicountsButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.editButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Items";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pricingSolutionButton
            // 
            this.pricingSolutionButton.Location = new System.Drawing.Point(68, 147);
            this.pricingSolutionButton.Name = "pricingSolutionButton";
            this.pricingSolutionButton.Size = new System.Drawing.Size(141, 62);
            this.pricingSolutionButton.TabIndex = 1;
            this.pricingSolutionButton.Text = "Apply Pricing Solution";
            this.pricingSolutionButton.UseVisualStyleBackColor = true;
            // 
            // dicountsButton
            // 
            this.dicountsButton.Location = new System.Drawing.Point(68, 215);
            this.dicountsButton.Name = "dicountsButton";
            this.dicountsButton.Size = new System.Drawing.Size(141, 60);
            this.dicountsButton.TabIndex = 2;
            this.dicountsButton.Text = "Send Disoucnts";
            this.dicountsButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(68, 359);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 244);
            this.listBox1.TabIndex = 3;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(68, 300);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(136, 53);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit Item";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(68, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 62);
            this.button5.TabIndex = 5;
            this.button5.Text = "View Inventory";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 651);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dicountsButton);
            this.Controls.Add(this.pricingSolutionButton);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pricingSolutionButton;
        private System.Windows.Forms.Button dicountsButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button button5;
    }
}

