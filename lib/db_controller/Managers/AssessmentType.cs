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

        /// <summary>
        /// Save an assessmentType and its weighting
        /// </summary>
        /// <param name="assessTypeObject"></param>
        public bool Save(AssessmentType assessTypeObject)
        {
            bool saved = false;

            using (var connection = new SQLiteConnection(GradeManager_SQLite_DB_Controller.CONNECTION_STRING))
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_INSERT_ASSESSMENT_TYPE, connection))
                {
                    command.Parameters.AddWithValue("@assess_type", assessTypeObject.Name);

                    command.Connection.Open();

                    if (command.ExecuteNonQuery() > 0)
                    {
                        object last_id = GradeManager_SQLite_DB_Controller.GetLastRowInserted(connection);
                        if (last_id != null)
                        {

                            using (var secondary_command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_INSERT_ASSESSMENTTYPE_WEIGHT, connection))
                            {
                                secondary_command.Parameters.AddWithValue("@assess_type_id", last_id);
                                secondary_command.Parameters.AddWithValue("@assess_type_weight", assessTypeObject.Weight.Weight);
                                secondary_command.Parameters.AddWithValue("@assess_type_relational_id", assessTypeObject.Weight.Type_Relational);
                                secondary_command.Parameters.AddWithValue("@assess_type_is_linked", assessTypeObject.IsLinked ? 1 : 0);
                                secondary_command.Parameters.AddWithValue("@account_id", UserManager.CurrentUser.Id);

                                if (secondary_command.ExecuteNonQuery() > 0)
                                    saved = true;
                            }
                        }
                    }
                }
            }

            return saved;
        }

        public bool Delete(int assess_type_id)
        {
            bool deleted = false;

            using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_DELETE_ASSESSMENT_TYPE, GradeManager_SQLite_DB_Controller.GetConnection()))
            {
                command.Parameters.AddWithValue("@assess_type_id", assess_type_id);

                command.Connection.Open();

                if (command.ExecuteNonQuery() > 0)
                    deleted = true;
            }

            return deleted;
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
