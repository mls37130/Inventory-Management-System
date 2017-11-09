using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
  


        public User(string un, string p)
        {
            UserName = un;
            Password = p;
   
        }





    }
}
