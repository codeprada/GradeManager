using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;

namespace Grade_Manager_DB_Controller
{
    public class User : Database_Object
    {
        public User() : base() { }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Profile { get; set; }

        public static implicit operator int(User usr)
        {
            return usr.Id;
        }
    }
}
