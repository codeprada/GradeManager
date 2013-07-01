using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grade_Manager
{
    class BaseManager
    {
        public BaseManager(string connection_string)
        {
            ConnectionString = connection_string;
        }

        public string ConnectionString
        {
            get;
            protected set;
        }
    }


}
