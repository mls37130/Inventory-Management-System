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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //everytime form loads it runs the discount price method. 
            Item.CalculateDiscount(DateTime.Today); 
        }

        private void addItemsButton_Click(object sender, EventArgs e)
        {
            AddItem newItem = new AddItem();
            newItem.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditItemForm editItem = new EditItemForm();
            editItem.Show(); 
        }

        private void viewInventoryButton_Click(object sender, EventArgs e)
        {
            ViewInventoryFormcs viewInventory = new ViewInventoryFormcs();
            viewInventory.Show(); 
        }
    }
}
