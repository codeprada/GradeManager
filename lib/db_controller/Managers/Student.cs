﻿using System;
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
                DateOfBirth = Convert.ToDateTime(reader["student_dob"])
            };

            return student;
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
                        command.Parameters.AddWithValue("@dob", student.DateOfBirth.ToString("yyyy-MM-dd"));


                        connection.Open();

                        if (command.ExecuteNonQuery() > 0)
                            row = Convert.ToInt32(GradeManager_SQLite_DB_Controller.GetLastRowInserted(connection));
                    }
                }
            }

            return row;
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