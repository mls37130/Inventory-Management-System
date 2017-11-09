using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class Customer: User
    {
        public string CId
        {
            get
            {
                return id.ToString();
            }
            set
            {
                id += counter ;
            }
        }
        public string CFirstName { get; set; }
        public string CLastName { get; set; }
        public string Email { get; set; }


        private int id = 1000; 

        private int counter = 0; 


        public Customer(string cUserName, string cPassword, string cId, string cFirstName, string cLastName, string email): base(cUserName, cPassword)
        {
            CId = CId;
            CFirstName = cFirstName;
            CLastName = cLastName;
            Email = email; 
            counter++; 
        }



        public bool CheckForDiscount()
        {
            bool status = false; 
            //method would search through order table to find matches for CID. 
            //if CID matches to more than 10 sales, for example, it returns true that they qualify for a discount code. 
            //discount code is created (random num generator?), put in database, and emailed to them (or we would email it to them, maybe can display in a listbox for our purposes). 
            //then when discount code is entered via order form, get's applied to order, and deleted from active discounts database??
        
            // if (CId.Orders > 10)
            //{
            //    createDiscount(CID);

            //    status = true; 

            //}


            return status; 
        }


        public void createDiscount(string customerID)
        {


             Discount D1 = new Discount(customerID);

             //some statememnt that now adds created discount to the database table "Discount" 


        }



    }
}
