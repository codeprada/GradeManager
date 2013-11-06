using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
namespace Grade_Manager_DB_Controller
{
    public class Student : Database_Object
    {
        public Student()
            : base() 
        {
            ID = -1;
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        public static implicit operator Student(SQLiteDataReader reader)
        {
            //string[] dob = Convert.ToString(reader["student_dob"]).Split(new char[] { '-' });

            Student student = new Student()
            {
                FirstName = Convert.ToString(reader["student_first_name"]),
                LastName = Convert.ToString(reader["student_last_name"]),
                ID = Convert.ToInt32(reader["student_id"]),
                MiddleName = Convert.ToString(reader["student_middle_name"]),
                Gender = Convert.ToString(reader["student_gender"]),
                DateOfBirth = Convert.ToDateTime(reader["student_dob"])
            };

            return student;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

    public class StudentManager : BaseManager
    {
        public StudentManager(string connection_string)
            : base(connection_string)
        {

        }

        public int Save(Student student)
        {
            int row = -1;

            if (student.isFilled())
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    using (var command = new SQLiteCommand())
                    {
                        command.CommandText = GradeManager_SQLite_DB_Controller.DBQ_INSERT_STUDENT;
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue("@account_id", UserManager.CurrentUser.Id);
                        command.Parameters.AddWithValue("@first_name", student.FirstName);
                        command.Parameters.AddWithValue("@last_name", student.LastName);
                        command.Parameters.AddWithValue("@middle_name", student.MiddleName);
                        command.Parameters.AddWithValue("@gender", student.Gender.ToUpper().Substring(0, 1));
                        command.Parameters.AddWithValue("@dob", student.DateOfBirth.ToString("yyyy-MM-dd"));


                        connection.Open();

                        if (command.ExecuteNonQuery() > 0)
                            row = Convert.ToInt32(GradeManager_SQLite_DB_Controller.GetLastRowInserted(connection));
                    }
                }
            }

            return row;
        }

        public bool Update(Student student)
        {
            bool success = false;

            if (student.isFilled())
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    using (var command = new SQLiteCommand())
                    {
                        command.CommandText = GradeManager_SQLite_DB_Controller.DBQ_UPDATE_STUDENT;
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue("@student_id", student.ID);
                        command.Parameters.AddWithValue("@first_name", student.FirstName);
                        command.Parameters.AddWithValue("@last_name", student.LastName);
                        command.Parameters.AddWithValue("@middle_name", student.MiddleName);
                        command.Parameters.AddWithValue("@gender", student.Gender.ToUpper().Substring(0, 1));
                        command.Parameters.AddWithValue("@dob", student.DateOfBirth.ToString("yyyy-MM-dd"));


                        connection.Open();

                        if (command.ExecuteNonQuery() > 0)
                            success = true;
                    }
                }
            }

            return success;
        }

        public Student Get(int id)
        {
            Student student = null;

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_GET_STUDENT, connection))
                {
                    command.Parameters.AddWithValue("@student_id", id);
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            student = reader;
                        }
                    }
                }
            }

            return student;
        }

        public Student[] Get()
        {
            List<Student> students = new List<Student>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_GET_ALL_STUDENTS_RAW, connection))
                {
                    command.Parameters.AddWithValue("@account_id", UserManager.CurrentUser.Id);
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(reader);
                        }
                    }
                }
            }

            return students.ToArray();
        }

        public bool AssignToClass(int class_id, int student_id)
        {
            bool success = false;

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (var command = new SQLiteCommand(GradeManager_SQLite_DB_Controller.DBQ_STUDENT_ASSIGN_GRADE, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@class_id", class_id);
                    command.Parameters.AddWithValue("@student_id", student_id);

                    connection.Open();

                    if (command.ExecuteNonQuery() > 0)
                        success = true;
                }
            }

            return success;
        }
    }
}
