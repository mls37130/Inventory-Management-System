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
    public partial class ViewInventoryFormcs : Form
    {
        public ViewInventoryFormcs()
        {
            InitializeComponent();


        }

        private void ViewInventoryFormcs_Load(object sender, EventArgs e)
        {
            foreach (Item item in AddItem.items)
            {

                inventoryListBox.Items.Add(item.ToString());

            }
        }
    }
}
