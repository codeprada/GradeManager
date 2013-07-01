using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using System.Data;

namespace Grade_Manager_DB_Controller
{
    public class GradeManager_SQLite_DB_Controller
    {
        #region Initialization Code
        private const string DATABASE_CREATION_SQL = @"
            CREATE TABLE [Accounts] (	            [account_id]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,	            [account_name]	char(30) NOT NULL COLLATE NOCASE,	            [account_password]	char(128) NOT NULL COLLATE NOCASE            );
CREATE TABLE [Assessment_Weight] (	            [assessw_id]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,	            [assessw_type]	char(12) COLLATE NOCASE,	            [assessw_weight]	numeric            );
CREATE TABLE Assessments (account_id integer, assess_id integer PRIMARY KEY, assess_name char(30), assessw_id integer, assess_date datetime, subject_id integer, profile_id integer);
CREATE TABLE Classes (account_id integer, class_id integer PRIMARY KEY, class_name char(30));
CREATE TABLE [Grades] (	            [grade_id]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,	            [student_id]	integer NOT NULL,	            [assess_id]	integer NOT NULL,	            [grade_mark]	float NOT NULL            ,                FOREIGN KEY ([assess_id])                    REFERENCES [Assessments]([assess_id]),                FOREIGN KEY ([student_id])                    REFERENCES [Students]([student_id])            );
CREATE TABLE Profiles (class_id integer, ending_school_year integer, starting_school_year integer, profile_id integer PRIMARY KEY, account_id integer, current_term integer, profile_description char(255));
CREATE TABLE [StudentClass] (	            [stu_cla_id]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,	            [student_id]	integer NOT NULL,	            [class_id]	integer NOT NULL            ,                FOREIGN KEY ([class_id])                    REFERENCES [Classes]([class_id]),                FOREIGN KEY ([student_id])                    REFERENCES [Students]([student_id])            );
CREATE TABLE Students (account_id integer, student_id integer PRIMARY KEY, student_first_name char(20), student_last_name char(20), student_dob datetime, stu_cla_id integer);
CREATE TABLE [Subjects] (	            [subject_id]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,	            [subject_name]	char(50) COLLATE NOCASE            );
CREATE TABLE sqlite_sequence(name,seq);
CREATE UNIQUE INDEX [Accounts_UQ__Accounts__6894C54A30F848ED]            ON [Accounts]            ([account_name] DESC);
CREATE UNIQUE INDEX [Assessment_Weight_UQ__Assessme__E03FEF6F0F975522]            ON [Assessment_Weight]            ([assessw_type] DESC);
CREATE UNIQUE INDEX [Grades_UQ__Grades__B605D1292A4B4B5E]            ON [Grades]            ([student_id] DESC, [assess_id] DESC);
CREATE UNIQUE INDEX Profiles_UQ__Profiles__45R35JDGFD ON Profiles(class_id ASC);
CREATE UNIQUE INDEX [StudentClass_UQ__StudentC__55EC41031CF15040]            ON [StudentClass]            ([student_id] DESC, [class_id] DESC);
CREATE UNIQUE INDEX [Subjects_UQ__Subjects__4081766108EA5793]            ON [Subjects]            ([subject_name] DESC);
            ";
        #endregion

        public const string DBQ_LOG_IN = "SELECT [account_id] FROM [Accounts] WHERE [account_name] = @name AND [account_password] = @password",
                            DBQ_GET_PROFILE_NAME = "SELECT * FROM [Profiles] WHERE [profile_name] = @name",
                            DBQ_GET_ALL_PROFILES = "SELECT [profile_id], ('Term:' || [current_term] || ', ' || [starting_school_year] || '-' || [ending_school_year] || ', ' || [Classes].[class_name]) AS [name] FROM [Profiles] INNER JOIN [Classes] ON [Profiles].[class_id] = [Classes].[class_id] WHERE [Profiles].[account_id] = @account_id ORDER BY [starting_school_year], [ending_school_year] ASC",
                            DBQ_GET_ALL_PROFILES_TREE = "SELECT [profile_id], [Classes].[class_name], [starting_school_year], [ending_school_year], [current_term] FROM [Profiles] INNER JOIN [Classes] ON [Profiles].[class_id] = [Classes].[class_id] WHERE [Profiles].[account_id] = @account_id",
                            DBQ_GET_PROFILE_ID = "SELECT * FROM [Profiles] WHERE [profile_id] = @id",
                            DBQ_INSERT_PROFILE = "INSERT INTO [Profiles] (ending_school_year, starting_school_year, account_id, current_term, profile_description, class_id) VALUES (@endingschoolyear, @startingschoolyear, @account_id, @term, @descrip, @class)",
                            DBQ_GET_ALL_CLASSES = "SELECT [class_id], [class_name] FROM [Classes] WHERE [account_id] = @account_id ORDER BY [class_name] ASC",
                            DBQ_INSERT_CLASS = "INSERT INTO [Classes] ([class_name], [account_id]) VALUES (@class_name, @account_id)";

        private static string DB_PATH = Environment.GetEnvironmentVariable("LOCALAPPDATA") + @"\Grade Manager\gm_storage.db";
        public static string CONNECTION_STRING = "Data Source=" + DB_PATH + "; Version=3";

        public GradeManager_SQLite_DB_Controller() { }

        public void CreateDatabase()
        {
            if (!Directory.Exists(Environment.GetEnvironmentVariable("LOCALAPPDATA") + @"\Grade Manager"))
                Directory.CreateDirectory(Environment.GetEnvironmentVariable("LOCALAPPDATA") + @"\Grade Manager");

            using (var connection = new SQLiteConnection(CONNECTION_STRING))
            {
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandType = CommandType.Text;

                    connection.Open();
                    string[] commands = DATABASE_CREATION_SQL.Replace(Environment.NewLine, String.Empty).Split(new char[] { ';' });

                    foreach (string c in commands)
                    {
                        command.CommandText = c.Trim();

                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public bool IntegrityTest()
        {
            bool pass = false;

            if (File.Exists(DB_PATH))
            {
                List<string> tables = new List<string>();

                MatchCollection matches = Regex.Matches(DATABASE_CREATION_SQL, @"create table (if not exists)? \[([^\]].+?)\]", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                
                foreach (Match m in matches)
                    tables.Add(m.Groups[2].Value);
                


                try
                {
                    using (var connection = new SQLiteConnection(CONNECTION_STRING))
                    {
                        using (var command = new SQLiteCommand(connection))
                        {
                            command.CommandType = CommandType.Text;
                            command.CommandText = @"SELECT name FROM sqlite_master WHERE type = @type";
                            command.Parameters.AddWithValue("type", "table");

                            connection.Open();
                            using (var reader = command.ExecuteReader())
                            {
                                while(reader.Read())
                                    tables.Remove(reader.GetString(0));
                            }

                        }
                    }

                    pass = (tables.Count == 0);
                }
                catch (Exception)
                {

                }

            }

            return pass;
        }
    }

    public class ComboItem
    {
        public object Text { get; set; }
        public object Id { get; set; }

        public static implicit operator int(ComboItem i)
        {
            return (int)i.Id;
        }

        public static implicit operator string(ComboItem i)
        {
            return (string)i.Text;
        }
    }
}
