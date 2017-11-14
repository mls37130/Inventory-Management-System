using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            if (newPasswordTextBox.Text == reEnterTextBox.Text)
            {
                User u1 = new User(newUserNameTextBox.Text,newPasswordTextBox.Text, emailTextBox.Text);
                this.Hide();
                var createUser = new CreateUserForm();
                createUser.Closed += (s, args) => this.Close();
                OrderForm orderForm = new OrderForm();
                orderForm.Show();
            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var createUser = new CreateUserForm();
            createUser.Closed += (s, args) => this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
