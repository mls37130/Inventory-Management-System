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
        public string Type { get; set; }


        public User(string un, string p, string t)
        {
            UserName = un;
            Password = p;
            Type = t;
        }

    }
}
