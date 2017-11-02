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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Closed += (s, args) => this.Close();
            ManagerLogin managerLoginForm = new ManagerLogin();
            managerLoginForm.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userTextBox.Text !="" && passwordTextBox.Text !="")
            {
                this.Hide();
                var loginForm = new LoginForm();
                loginForm.Closed += (s, args) => this.Close();
                OrderForm order = new OrderForm();
                order.Show();
            }
            else
            {
                MessageBox.Show("Enter credintials");
            }
        }

        private void createUserLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Closed += (s, args) => this.Close();
            CreateUserForm cru = new CreateUserForm();
            cru.Show();
        }
    }
}
