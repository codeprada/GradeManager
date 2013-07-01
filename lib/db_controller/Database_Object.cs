using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Grade_Manager_DB_Controller
{
    public class Database_Object
    {
        public bool isFilled()
        {
            bool filled = true;

            Type type = this.GetType();

            foreach (PropertyInfo pi in type.GetProperties())
            {
                if (pi.GetValue(this) == null)
                {
                    filled = false;
                    break;
                }

            }

            return filled;
        }
    }
}
