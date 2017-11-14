namespace InventoryManager
{
    partial class CreateUserForm
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
            this.newUserNameTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.reEnterTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createUserButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Re-Enter Password";
            // 
            // newUserNameTextBox
            // 
            this.newUserNameTextBox.Location = new System.Drawing.Point(178, 37);
            this.newUserNameTextBox.Name = "newUserNameTextBox";
            this.newUserNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.newUserNameTextBox.TabIndex = 3;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(178, 117);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(100, 26);
            this.newPasswordTextBox.TabIndex = 4;
            // 
            // reEnterTextBox
            // 
            this.reEnterTextBox.Location = new System.Drawing.Point(178, 160);
            this.reEnterTextBox.Name = "reEnterTextBox";
            this.reEnterTextBox.Size = new System.Drawing.Size(100, 26);
            this.reEnterTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(178, 76);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 26);
            this.emailTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email:";
            // 
            // createUserButton
            // 
            this.createUserButton.Location = new System.Drawing.Point(84, 232);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(153, 43);
            this.createUserButton.TabIndex = 8;
            this.createUserButton.Text = "Create Account";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(267, 303);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(87, 31);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 361);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.createUserButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.reEnterTextBox);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.newUserNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateUserForm";
            this.Text = "CreateUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newUserNameTextBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.TextBox reEnterTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Button backButton;
    }
}