using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Grade_Manager_DB_Controller
{
    public class SubjectWeightObject : iObject
    {
        protected WeightObjectList _WeightList;

        public string Name { get; set; }
        public WeightObjectList WeightList { get { return _WeightList; } }

        /// <summary>
        /// Intialize
        /// </summary>
        /// <param name="subject"></param>
        public SubjectWeightObject(int subject) : base()
        {
            ID = subject;
            _WeightList = new WeightObjectList();
        }

        /// <summary>
        /// Adds a WeightObject to the list
        /// </summary>
        /// <param name="w"></param>
        public void Append(WeightObject w)
        {
            _WeightList.Add(w);
        }

        /// <summary>
        /// Reference WeightObjects by their ID
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public virtual WeightObject this[int index]
        {
            get
            {
                return (WeightObject)_WeightList[index];
            }
        }

        /// <summary>
        /// Makes SubjectWeightObject swo = reader possible
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static implicit operator SubjectWeightObject(SQLiteDataReader reader)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ToString override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string buffer = Name + Environment.NewLine;

            foreach (WeightObject w in _WeightList)
            {
                buffer += "   " + w.ToString() + Environment.NewLine;
            }

            return buffer;
        }
    }
}
