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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }


        public static List<Item> items = new List<Item>();

        private int counter = 0; 


        private void button1_Click(object sender, EventArgs e)
        {
            int id = 5000 + counter; 
             
            Item I1 = new Item();
            I1.Id = id.ToString(); 
            I1.Name = itemNameTextBox.Text;
            I1.Category = categoryListBox.SelectedItem.ToString();
            I1.WholesalePrice = double.Parse(wholeSaleCostTextBox.Text);
            I1.RetailPrice = double.Parse(priceTextBox.Text);
            I1.CurrentQuantity = int.Parse(currentAmtTextBox.Text);
            I1.MaxQuantity = int.Parse(reorderMaxAmtTextBox.Text);
            I1.MinQuatitiy = int.Parse(reorderMinAmountTextBox.Text);
            I1.AddedDate = DateTime.Today; 
            I1.MaxItemSold = int.Parse(maxSoldAmtTextBox.Text);
            I1.MinItemSold = int.Parse(minSoldAmtTextBox.Text);
            I1.DaysThreshold = int.Parse(daysThresholdTextBox.Text);
            I1.SaleDiscountAmt = double.Parse(discountAmtTextBox.Text);

            items.Add(I1); 
            counter++; 
    }










    }
}
