using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class Discount
    {

        public string DID
        {
            get
            {
                return dId;
            }

            set
            {
               dId = (7000 + counter).ToString();
            }
        }
        public string DCode
        {
            get
            {
                return dCode; 
            }
            set
            {
                Random r1 = new Random();
                dCode = r1.ToString(); 


            }

        }

        public string CId; 

        private string dCode;
        private string dId; 
        private int counter = 0; 

        public Discount(string cid)
            {

                 CId = cid;
                 counter++; 

            }

       


    }
}
