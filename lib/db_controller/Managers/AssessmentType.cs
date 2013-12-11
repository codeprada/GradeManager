using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Grade_Manager_DB_Controller
{
    public class AssessmentTypeManager : BaseManager
    {
        public AssessmentTypeManager(string connection)
            : base(connection)
        {

        }

        public AssessmentTypeObjectList GetTypesWeights(int account_id)
        {
            AssessmentTypeObjectList atol = new AssessmentTypeObjectList();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_GET_ASSESSMENTTYPE_AND_WEIGHTS, connection))
                {
                    command.Parameters.AddWithValue("@account_id", account_id);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AssessmentType at = reader;
                            atol.Add(at);
                        }
                    }
                }
            }

            return atol;
        }
    }

    /// <summary>
    /// Assessment Type Object
    /// </summary>
    public class AssessmentType : iObject
    {
        public AssessmentType()
            : base()
        {

        }

        public string Name { get; set; }
        public AssessmentWeight Weight { get; set; }
        public bool IsLinked { get; set; }

        public static implicit operator AssessmentType(SQLiteDataReader reader)
        {
            AssessmentType a_type = new AssessmentType();

            a_type.ID = Convert.ToInt32(reader["assess_type_id"]);
            a_type.Name = Convert.ToString(reader["assess_type"]);

            try
            {
                a_type.Weight = reader;
                a_type.IsLinked = (Convert.ToInt32(reader["assess_is_linked"]) == 0 ? false : true);
            }
            catch (Exception e)
            {
                a_type.Weight = null;
                a_type.IsLinked = false;
            }

            return a_type;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class AssessmentTypeObjectList : iObjectList
    {

    }
}
