using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Grade_Manager_DB_Controlle
{
   /* public class WeightObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int RelationID { get; set; }
        public int Amount { get; set; }
        public bool isLinkWith { get; set; }

        public static bool operator ==(WeightObject a, WeightObject b)
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

        public static bool operator !=(WeightObject a, WeightObject b)
        {

            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            return this == (WeightObject)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }

        public static implicit operator WeightObject(SQLiteDataReader reader)
        {
            WeightObject w = new WeightObject();
            w.Name = Convert.ToString(reader["Name"]);
            w.ID = Convert.ToInt32(reader["ID"]);
            w.isLinkWith = (Convert.ToInt32(reader["isLinkWith"]) == 1 ? true : false);
            w.RelationID = Convert.ToInt32(reader["RelationID"]);
            w.Weight = Convert.ToDouble(reader["Weight"]);

            return w;
        }
    }

    public class WeightObjecttList : ICollection<WeightObject>
    {
        private List<WeightObject> weight_object_list;
        public WeightObjecttList()
        {
            weight_object_list = new List<WeightObject>();
        }

        public virtual WeightObject this[int index]
        {
            get
            {
                var buffer = weight_object_list.Where(x => x.ID == index).Select(x => x);
                if (buffer.Count() > 0)
                    return buffer.First();
                else
                    return null;
            }

            set
            {
                //this[index] = value;
            }
        }

        public virtual int Count
        {
            get
            {
                return weight_object_list.Count;
            }
        }

        public virtual void Add(WeightObject weight_obj)
        {
            weight_object_list.Add(weight_obj);

        }

        public virtual bool IsReadOnly
        {
            get { return false; }
        }

        public virtual bool Remove(int id)
        {
            return weight_object_list.Remove(this[id]);
        }

        public virtual bool Remove(WeightObject w)
        {
            return weight_object_list.Remove(w);
        }

        public virtual void Clear()
        {
            weight_object_list.Clear();
        }

        public virtual void Insert(int index, WeightObject w)
        {
            weight_object_list.Insert(index, w);
        }

        public virtual int IndexOf(WeightObject w)
        {
            return weight_object_list.IndexOf(w);
        }

        public virtual void Reverse()
        {
            weight_object_list.Reverse();
            
        }

        public virtual void CopyTo(WeightObject[] wl)
        {
            weight_object_list.CopyTo(wl);
        }

        public virtual void CopyTo(WeightObject[] wl, int index)
        {
            weight_object_list.CopyTo(wl, index);
        }

        public virtual IEnumerator<WeightObject> GetEnumerator()
        {
            foreach (WeightObject w in weight_object_list)
                yield return w;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (WeightObject w in weight_object_list)
                yield return w;
        }

        public virtual bool Contains(WeightObject w)
        {
            return weight_object_list.Contains(w);
               
        }


    }



    public class WeightManager : BaseManager
    {
        private WeightObjecttList wol;
        private List<Subject> subjects;

        public WeightManager(string connection_string)
            : base(connection_string)
        {
            wol = new WeightObjecttList();
            subjects = new SubjectManager(ConnectionString).GetSubjects(SemesterManager.CurrentSemester.Id);
            
        }

        public void FetchAll(int account_id)
        {
            //List<WeightObject> wol = new List<WeightObject>();

            wol.Clear();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_GET_ASSESSMENT_WEIGHTS, connection))
                {
                    command.Parameters.AddWithValue("@account_id", account_id);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            wol.Add(reader);
                        }
                    }
                }

                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_GET_ASSESSMENT_COUNT, connection))
                {
                    command.Parameters.AddWithValue("@account_id", account_id);

                    //Don't have to open the connection again
                    //connection.Open();
                    WeightObject temp;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Subject s = subjects.Where(x => x.Id == Convert.ToInt32(reader["subject_id"])).Select(x => x).First(); //working on this subject
                            temp = wol[Convert.ToInt32(reader["assess_type_id"])]; //fetch the WeightObject for reader[assess_type_id]
                            temp.Amount = Convert.ToInt32(reader["Count"]);
                            s.Weights.Add(temp);
                            
                        }
                    }
                }
            }



            //return wol;
        }

        public double CalculateAverage(Dictionary<int, List<double>> grades)
        {
            double average = 0;

            foreach (KeyValuePair<int, List<double>> g in grades)
            {
                //Change up the way the grades are fetched.
                average += wol[g.Key].Weight * (g.Value.Average() / 100);

            }

            return average;
        }

        public WeightObject Get(int id)
        {
            var buffer = wol.Where(x => x.ID == id).Select(x => x);
            if (buffer.Count() > 0)
                return buffer.First();
            else
                return null;
        }

        public WeightObject GetFromDatabase(int id)
        {
            WeightObject return_object = null;

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_GET_ASSESSMENT_WEIGHTS_WHERE, connection))
                {
                    command.Parameters.AddWithValue("@account_id", UserManager.CurrentUser.Id);
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                            return_object = reader;
                    }
                }
            }

            return return_object;
        }

        public WeightObject this[int index]
        {
            get
            {
                return Get(index);
            }
        }

        public void CalculateWeighting()
        {
            foreach (Subject s in subjects)
            {
                Dictionary<int, int> relationships = new Dictionary<int, int>();
                double remaining_points = 100;

                foreach (WeightObject w in wol)
                {
                    if (w.isLinkWith)
                    {
                        relationships.Add(w.ID, w.RelationID);
                    }
                    else
                    {
                        remaining_points -= w.Weight;
                    }
                }

                if (relationships.Count > 0)
                {
                    WeightObject b;
                    //List<WeightObject> links = new List<WeightObject>();
                    WeightObjecttList links = s.Weights;
                    foreach (KeyValuePair<int, int> kv in relationships)
                    {
                        WeightObject index = wol[kv.Key];
                        if (kv.Value >= 0)
                        {
                            WeightObject relation = wol[kv.Value];
                            int relation_index;
                            if ((relation_index = links.IndexOf(relation)) >= 0)
                            {
                                links.Insert(relation_index + 1, index);
                            }
                            else
                            {
                                WeightObject buffer = wol[index.ID];
                                if (buffer != null)
                                {
                                    links.Insert(links.IndexOf(buffer), index);
                                }
                                else
                                    links.Add(index);
                            }

                            //Console.WriteLine("{0} {1} is equal to {2} {3}", index.Amount, index.Name, index.Weight, relation.Name);
                        }
                        else
                        {
                            b = index;
                            //links.Insert(0, wol.Where(w => w.ID == relationships.Where(x => x.Value < 0).Select(x => x.Key).First()).Select(x => x).First());
                            links.Insert(0, index);
                            //Console.WriteLine("{0} is apart of a link", index.Name);
                        }

                    }

                    Dictionary<int, double> conversion_dict = new Dictionary<int, double>();
                    links.Reverse();
                    WeightObject subject_of_equation = links.First();

                    foreach (WeightObject w in links)
                    {
                        if (conversion_dict.ContainsKey(w.ID))
                            continue;

                        //amount * relation / index amount
                        if (w == subject_of_equation)
                            conversion_dict.Add(w.ID, w.Weight);
                        else
                        {
                            
                            WeightObject relative = wol.Where(x => x.RelationID == w.ID).Select(x => x).First();
                            conversion_dict.Add(w.ID, (w.Amount * conversion_dict[relative.ID]) / relative.Weight);
                        }

                        //Console.Write(w.Name + (w != links.Last() ? " <= " : "\n\n"));
                    }

                    //Console.WriteLine("Remaining points allocated to links: {0}", remaining_points);

                    double lowest_value = remaining_points / (conversion_dict.Select(x => x.Value).Sum());

                    foreach (KeyValuePair<int, double> kv in conversion_dict)
                    {
                        WeightObject obj = wol[kv.Key];
                        obj.Weight = lowest_value * kv.Value;
                        //s.Weights[kv.Key] = obj;
                    }


                }

            }
        }
    }*/
}
