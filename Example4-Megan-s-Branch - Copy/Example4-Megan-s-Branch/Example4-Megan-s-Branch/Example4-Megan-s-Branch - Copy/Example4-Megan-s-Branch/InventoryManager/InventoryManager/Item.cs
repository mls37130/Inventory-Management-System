using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class Item
    {
        //I feel like there's some datatype that allows for the creation of unique ID's....
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double WholesalePrice { get; set;}
        public double RetailPrice { get; set; }
        public int CurrentQuantity { get; set; }
        public int MaxQuantity { get; set; }
        public int MinQuatitiy { get; set; }
        public DateTime AddedDate { get; set; }
        public int MaxItemSold { get; set; }
        public int MinItemSold { get; set; }
        public int DaysThreshold { get; set; }
        public double SaleDiscountAmt { get; set; }

        public DateTime DateToDiscount
        {

            get
            { return dateToDiscount; }
            set
            {
                dateToDiscount = AddedDate.AddDays((Double)DaysThreshold); 
            }
        }

        private DateTime dateToDiscount; 


        public Item()
        {         
        }

        public Item(string i, string n, string c)
        {
            Id = i;
            Name = n;
            Category = c;
        }



     public double CalculateROI()
        {

            //some logic used to calculate the ROI...could be based on sales or maybe profit margin??

            return 0; 
        }

      public static void CalculateDiscount(DateTime dateApplied)
        {
            //iterates through all inventory items. 
            // if date this method is run matches the date preset pricing solution is supposed to be applied for an item (if statement), 
            // it calculates the discounted price using discount rate and sets new price to discount price.
            foreach(var item in AddItem.items)
            {
                if(item.DateToDiscount == dateApplied)
                {
                    double discountAmt = item.RetailPrice * (item.SaleDiscountAmt / 100);
                    double newprice = item.RetailPrice - discountAmt;
                    item.RetailPrice = newprice; 
                }


            }
            
           

            
        }

        public override string ToString()
        {


            //probably better to have an option on the inventory page for showing "item detail" instead of showing all info
            //return $"{Id}, {Name}, {Category}, WP: {WholesalePrice}, RP: {RetailPrice}, CurQ: {CurrentQuantity}, MaxQ: {MaxQuantity}, MinQ: {MinQuatitiy}, Added: {AddedDate}, MaxQSold: {MaxItemSold}, MinQSold: {MinItemSold}, DaysThres: {DaysThreshold}, Dis: {SaleDiscountAmt}";
            return $"{Id}, {Name}, {Category}, WP: {WholesalePrice}, RP: {RetailPrice}"; 
        }


    

    }
}
