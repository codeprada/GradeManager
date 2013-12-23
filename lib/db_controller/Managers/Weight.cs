using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Grade_Manager_DB_Controller
{
    public class WeightManager : BaseManager
    {
        private SubjectWeightObjectList _SubWeightObjList;
        public WeightManager(string connection_string, int account_id)
            : base(connection_string)
        {
            _SubWeightObjList = FetchAll(account_id);
        }

        public SubjectWeightObjectList SubjectWeightObjList { get { return _SubWeightObjList; } }

        /// <summary>
        /// Get Assessment Type Weight
        /// </summary>
        /// <param name="account_id"></param>
        /// <param name="assess_type_id"></param>
        /// <returns></returns>
        public WeightObject GetWeight(int account_id, int assess_type_id)
        {
            WeightObject wo = null;

            using (var connection = new SQLiteConnection(GradeManager_SQLite_DB_Controller.CONNECTION_STRING))
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_SELECT_ASSESSMENT_TYPE_WEIGHT, connection))
                {
                    command.Parameters.AddWithValue("@account_id", account_id);
                    command.Parameters.AddWithValue("@assess_type_id", assess_type_id);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                            wo = reader;
                    }
                }
            }

            return wo;
        }

        /// <summary>
        /// Fetch all the information pertaining to Subject Weightings and their Amounts
        /// </summary>
        /// <param name="account_id">Account ID</param>
        /// <returns></returns>
        private SubjectWeightObjectList FetchAll(int account_id)
        {
            SubjectWeightObjectList swo_list = new SubjectWeightObjectList();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_GET_ASSESSMENT_WEIGHTS, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@account_id", account_id);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SubjectWeightObject swo;
                            WeightObject wo = reader;

                            int subject = Convert.ToInt32(reader["subject_id"]); //Subject ID


                            wo.Amount = Convert.ToInt32(reader["Amount"]); //Amount will be added seperately since not initialized with WeightObject

                            if (!swo_list.Contains(subject)) //Should we make a new SubjectWeightObject???
                            {
                                swo = new SubjectWeightObject(subject);
                                swo.Name = Convert.ToString(reader["subject_name"]);
                                swo_list.Add(swo);
                            }
                            else
                                swo = (SubjectWeightObject)swo_list[subject];

                            
                            swo.Append(wo);
                        }
                    }
                }
            }

            return swo_list;
        }

        /// <summary>
        /// Calculate the weighting of each assessment based on each subject
        /// </summary>
        public void CalculateWeighting()
        {
            foreach (SubjectWeightObject s in _SubWeightObjList)
            {
                Dictionary<int, int> relationships = new Dictionary<int, int>();
                double remaining_points = 100;

                foreach (WeightObject w in s.WeightList)
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
                    WeightObjectList links = new WeightObjectList();
                    s.WeightList.CopyTo(links);


                    foreach (KeyValuePair<int, int> kv in relationships)
                    {
                        WeightObject index = (WeightObject)s.WeightList[kv.Key];
                        if (kv.Value >= 0)
                        {
                            WeightObject relation = (WeightObject)s.WeightList[kv.Value];
                            int relation_index;
                            if ((relation_index = links.IndexOf(relation)) >= 0)
                            {
                                links.Move(relation_index + 1, index.ID);
                                //links.Insert(relation_index + 1, index);
                            }
                            else
                            {
                                WeightObject buffer = (WeightObject)s.WeightList[index.ID];
                                if (buffer != null)
                                {
                                    //links.Insert(links.IndexOf(buffer), index);
                                    links.Move(links.IndexOf(buffer), index.ID);
                                }
                                else
                                    links.Add(index);
                            }

                            //Console.WriteLine("{0} {1} is equal to {2} {3}", index.Amount, index.Name, index.Weight, relation.Name);
                        }
                        else
                        {
                            
                            links.Move(0, index.ID);
                            //Console.WriteLine("{0} is apart of a link", index.Name);
                        }

                    }

                    Dictionary<int, double> conversion_dict = new Dictionary<int, double>();

                    //Algorithm to remove useless Objects from Links.
                    int counter = links.Count;
                    for (int i = 0; i < counter; i++)
                    {

                        if (!((WeightObject)links.IndexOf(i)).isLinkWith)
                        {
                            links.Remove((WeightObject)links.IndexOf(i));
                            i--;
                            counter--;
                        }
                    }

                    links.Reverse();
                    WeightObject subject_of_equation = (WeightObject)links.First();

                    foreach (WeightObject w in links)
                    {
                        if (conversion_dict.ContainsKey(w.ID))
                            continue;

                        //amount * relation / index amount
                        if (w == subject_of_equation)
                            conversion_dict.Add(w.ID, w.Weight);
                        else
                        {

                            WeightObject relative = (WeightObject)s.WeightList.Where(x => ((WeightObject)x).RelationID == w.ID).Select(x => x).First();
                            conversion_dict.Add(w.ID, (w.Amount * conversion_dict[relative.ID]) / relative.Weight);
                        }

                        //Console.Write(w.Name + (w != links.Last() ? " <= " : "\n\n"));
                    }

                    //Console.WriteLine("Remaining points allocated to links: {0}", remaining_points);

                    double lowest_value = remaining_points / (conversion_dict.Select(x => x.Value).Sum());

                    foreach (KeyValuePair<int, double> kv in conversion_dict)
                    {
                        WeightObject obj = (WeightObject)s.WeightList[kv.Key];
                        obj.Weight = lowest_value * kv.Value;
                        //s.Weights[kv.Key] = obj;
                    }


                }

            }
        }
    }
}
