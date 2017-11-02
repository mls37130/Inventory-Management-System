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
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private string managerPass = "Manager1";

        private void managerLoginButton_Click(object sender, EventArgs e)
        {
            if(passwordTextBox.Text==managerPass)
            {
                this.Hide();
                var managerForm = new ManagerLogin();
                managerForm.Closed += (s, args) => this.Close();
                Form1 mgr = new Form1();
                mgr.Show();
            }
        }
    }
}
