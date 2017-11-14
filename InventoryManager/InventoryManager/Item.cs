using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double WholesalePrice { get; set;}
        public double RetailPrice { get; set; }
        public int MaxQuantity { get; set; }
        public int MinQuatitiy { get; set; }
        public DateTime AddedDate { get; set; }
        public int MaxItemSold { get; set; }
        public int MinItemSold { get; set; }
        public DateTime DaysThreshold { get; set; }
        public double SaleDiscountAmt { get; set; }


        public Item()
        {         
        }

        public Item(string i, string n, string c, double w, double r, int maxq, int minq, DateTime ad)
        {
            Id = i;
            Name = n;
            Category = c;
            WholesalePrice = w;
            MaxQuantity = maxq;
            MinQuatitiy = minq;
            AddedDate = ad;

        }

        ////public CreateItem()
        //{

        //}






    }
}
