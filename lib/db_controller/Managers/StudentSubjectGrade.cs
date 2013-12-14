using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Grade_Manager_DB_Controller
{
    public class StudentSubjectGradeObject : iObject
    {
        private Dictionary<int, double> _AssessmentAverage;

        public StudentSubjectGradeObject(int subject_id)
        {
            ID = subject_id;

            _AssessmentAverage = new Dictionary<int, double>();
        }

        public void Add(int type, double average)
        {
            if (!_AssessmentAverage.ContainsKey(type))
                _AssessmentAverage.Add(type, average);
            else
                _AssessmentAverage[type] = average;
        }

        public double this[int type]
        {
            get
            {
                if (_AssessmentAverage.ContainsKey(type))
                    return _AssessmentAverage[type];
                else
                    throw new IndexOutOfRangeException();
            }

            set
            {
                Add(type, value);
            }
        }

        public virtual IEnumerator<KeyValuePair<int, double>> GetEnumerator()
        {
            foreach (KeyValuePair<int, double> w in _AssessmentAverage)
                yield return w;
        }

        /*System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (KeyValuePair<int, double> w in _AssessmentAverage)
                yield return w;
        }*/

        public override string ToString()
        {
            throw new NotImplementedException();
        }
        
    }

    public class StudentSubjectGradeObjectList : iObjectList
    {
        public StudentSubjectGradeObjectList() : base() { }
    }

    public class StudentSubjectGradeObjectListManager : BaseManager
    {
        public StudentSubjectGradeObjectListManager(string connection) : base(connection) { }

        /// <summary>
        /// Returns the average grade for students
        /// </summary>
        /// <param name="student_id">Student ID</param>
        /// <param name="_SubjectWeightObjectList">Weight Object List</param>
        /// <param name="subject_id">Subject ID (Optional)</param>
        /// <returns>(int, double) => Subject ID, Grade</returns>
        public Dictionary<int, double> CalculateOverallAverage(int student_id, SubjectWeightObjectList _SubjectWeightObjectList, int subject_id = -1)
        {
            Dictionary<int, double> grades = new Dictionary<int, double>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (var command = new SQLiteCommand(String.Format(GradeManager_SQLite_DB_Controller.DBQ_GET_STUDENT_SUBJECT_ASSESS_GRADES, (subject_id < 0 ? String.Empty : " AND Subjects.subject_id = @subject_id ")), connection))
                {
                    command.Parameters.AddWithValue("@student_id", student_id);

                    if (subject_id >= 0)
                        command.Parameters.AddWithValue("@subject_id", subject_id);
                    

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        //Create list to house the subject and averages
                        StudentSubjectGradeObjectList ssgo_list = new StudentSubjectGradeObjectList();

                        while (reader.Read())
                        {
                            int subject = Convert.ToInt32(reader["subject_id"]);

                            //if our Object does not exist then we create it
                            StudentSubjectGradeObject ssgo;
                            if ((ssgo = (StudentSubjectGradeObject)ssgo_list[subject]) == null)
                            {
                                ssgo = new StudentSubjectGradeObject(subject);
                                ssgo_list.Add(ssgo);
                            }
                            

                            //add the average here
                            ssgo.Add(Convert.ToInt32(reader["assess_type_id"]), Convert.ToDouble(reader["Average"]));

                        }

                        foreach (StudentSubjectGradeObject ssgo in ssgo_list) //Processing a subject object
                        {
                            double total = 0;

                            foreach (KeyValuePair<int, double> kv in ssgo) //Processing the assessment types e.g. Quiz, Test
                            {
                                total += ((SubjectWeightObject)_SubjectWeightObjectList[ssgo.ID])[kv.Key].Weight * (kv.Value / 100);
                            }

                            grades.Add(ssgo.ID, total);
                        }
                    }
                }
            }


            return grades;
        }
    }

    
}
