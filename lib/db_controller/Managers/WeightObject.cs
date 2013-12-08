using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Grade_Manager_DB_Controller
{
    public class WeightObject : iObject
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int RelationID { get; set; }
        public int Amount { get; set; }
        public bool isLinkWith { get; set; }

        public WeightObject() { }

        /// <summary>
        /// Copy Constructor
        /// </summary>
        /// <param name="wo"></param>
        public WeightObject(WeightObject wo)
        {
            Name = wo.Name;
            Weight = wo.Weight;
            RelationID = wo.RelationID;
            Amount = wo.Amount;
            isLinkWith = wo.isLinkWith;
        }

        /// <summary>
        /// Create a new WeightObject by reading data from the SQLiteDataReader
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static implicit operator WeightObject(SQLiteDataReader reader)
        {
            WeightObject w = new WeightObject();
            w.Name = Convert.ToString(reader["assess_type"]);
            w.ID = Convert.ToInt32(reader["assess_type_id"]);
            w.isLinkWith = (Convert.ToInt32(reader["assess_is_linked"]) == 1 ? true : false);
            w.RelationID = Convert.ToInt32(reader["assess_type_id_relational"]);
            w.Weight = Convert.ToDouble(reader["assess_type_weight"]);


            return w;
        }

        public override string ToString()
        {
            return this.Name + " => " +
                "Weight: " + Weight.ToString()  + " => " +
                "Amount: " + Amount.ToString() + " => " +
                "Link: " + isLinkWith.ToString() + " => " +
                "Relation: " + RelationID.ToString();
        }
    }

    public class WeightObjectList : iObjectList
    {
        public WeightObjectList()
            : base()
        {

        }
    }
}
