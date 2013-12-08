using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Grade_Manager_DB_Controller
{
    abstract public class iObject
    {
        public iObject() { }

        public iObject(iObject iobject)
        {
            this.ID = iobject.ID;
        }

        //Object's ID
        public int ID { get; set; }

        /// <summary>
        /// Equality Check. Checking the ID of the object
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(iObject a, iObject b)
        {
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            return a.ID == b.ID;
        }

        /// <summary>
        /// Test for inequality
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(iObject a, iObject b)
        {

            return !(a == b);
        }

        /// <summary>
        /// Test for equality
        /// </summary>
        /// <param name="Object"></param>
        /// <returns></returns>
        public override bool Equals(object Object)
        {
            return this == (iObject)Object;
        }

        /// <summary>
        /// Hash Code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Must be overriden
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static implicit operator iObject(SQLiteDataReader reader)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Abstract ToString() method
        /// </summary>
        /// <returns></returns>
        public abstract override string ToString();

    }
}
