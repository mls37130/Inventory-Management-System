using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//currently the edit item form only removes items. Plan would be to add other functions as well. Maybe change name or price? 
namespace InventoryManager
{
    public partial class EditItemForm : Form
    {
        public EditItemForm()
        {
            InitializeComponent();
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {

            string itemID = itemIDTextBox.Text; 
            
            //linq statement here that searches list or database and removes item based on ID. 
            


        }
    }
}
