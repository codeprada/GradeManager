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
CREATE TABLE [Accounts] (
	[account_id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	[account_name] CHAR(30) NOT NULL COLLATE NOCASE,
	[account_password] CHAR(128) NOT NULL COLLATE NOCASE
	);

CREATE TABLE [Students] (
	[student_id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	[student_first_name] CHAR(20) NOT NULL,
	[student_last_name] CHAR(20) NOT NULL,
	[student_middle_name] CHAR(20),
	[student_dob] DATETIME NOT NULL,
	[account_id] INTEGER NOT NULL,
	FOREIGN KEY ([account_id]) REFERENCES [Accounts](account_id),
	UNIQUE (student_first_name, student_last_name, student_middle_name, student_dob, account_id)
	);
	
CREATE TABLE Classes (
	class_id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	class_name CHAR(30) NOT NULL,
	account_id INTEGER NOT NULL,
	FOREIGN KEY ([account_id]) REFERENCES [Accounts](account_id),
	UNIQUE (class_name, account_id)
	);
	
CREATE TABLE Profiles (
	profile_id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	account_id INTEGER NOT NULL,
	current_term INTEGER NOT NULL,
	class_id INTEGER NOT NULL,
	ending_school_year INTEGER NOT NULL,
	starting_school_year INTEGER NOT NULL,
	profile_description CHAR(255),
	UNIQUE (account_id, current_term, class_id, starting_school_year),
	FOREIGN KEY ([account_id]) REFERENCES [Accounts](account_id),
	FOREIGN KEY ([class_id]) REFERENCES [Classes](class_id)
	);

CREATE TABLE [Subjects] (
	[subject_id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	[subject_name] CHAR(50) UNIQUE COLLATE NOCASE,
	UNIQUE (subject_name)
	);
	
CREATE TABLE Assessments (
	assess_id INTEGER PRIMARY KEY,
	assess_name CHAR(30) NOT NULL,
	assess_date DATETIME NOT NULL,
	subject_id INTEGER NOT NULL,
	profile_id INTEGER NOT NULL,
	FOREIGN KEY ([profile_id]) REFERENCES [Profiles](profile_id),
	FOREIGN KEY ([subject_id]) REFERENCES [Subjects](subject_id),
	);



CREATE TABLE [Grades] (
	[grade_id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	[student_id] INTEGER NOT NULL,
	[assess_id] INTEGER NOT NULL,
	[grade_mark] FLOAT NOT NULL,
	FOREIGN KEY ([assess_id]) REFERENCES [Assessments]([assess_id]),
	FOREIGN KEY ([student_id]) REFERENCES [Students]([student_id]),
	UNIQUE (student_id, assess_id)
	);



	
CREATE TABLE [StudentClass] (
	[stu_cla_id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	[student_id] INTEGER NOT NULL,
	[class_id] INTEGER NOT NULL,
	FOREIGN KEY ([class_id]) REFERENCES [Classes]([class_id]),
	FOREIGN KEY ([student_id]) REFERENCES [Students]([student_id]),
	UNIQUE (student_id, class_id)
	);



CREATE TABLE [SubjectClass] (
	[sub_pro_id] INTEGER PRIMARY KEY NOT NULL,
	[subject_id] INTEGER NOT NULL,
	[class_id] INTEGER NOT NULL,
	[profile_id] INTEGER NOT NULL,
	FOREIGN KEY ([class_id]) REFERENCES [Classes]([class_id]),
	FOREIGN KEY ([subject_id]) REFERENCES [Subjects]([subject_id]),
	FOREIGN KEY ([profile_id]) REFERENCES [Profiles]([profile_id]),
	UNIQUE (subject_id, class_id, profile_id)
	);


CREATE TABLE sqlite_sequence (
	NAME,
	seq
	);
            ";
        #endregion

        public const string DBQ_LOG_IN = "SELECT [account_id] FROM [Accounts] WHERE [account_name] = @name AND [account_password] = @password",
                            DBQ_GET_PROFILE = "SELECT * FROM [Profiles] WHERE [profile_id] = @id", 
                            DBQ_GET_ALL_PROFILES = "SELECT [profile_id], ('Term:' || [current_term] || ', ' || [starting_school_year] || '-' || [ending_school_year] || ', ' || [Classes].[class_name]) AS [name] FROM [Profiles] INNER JOIN [Classes] ON [Profiles].[class_id] = [Classes].[class_id] WHERE [Profiles].[account_id] = @account_id ORDER BY [starting_school_year], [ending_school_year] ASC",
                            DBQ_GET_ALL_PROFILES_TREE = "SELECT [profile_id], [Classes].[class_name], [starting_school_year], [ending_school_year], [current_term] FROM [Profiles] INNER JOIN [Classes] ON [Profiles].[class_id] = [Classes].[class_id] WHERE [Profiles].[account_id] = @account_id ORDER BY [Classes].[class_id] ASC",
                            DBQ_GET_PROFILE_ID = "SELECT * FROM [Profiles] WHERE [profile_id] = @id",
                            DBQ_INSERT_PROFILE = "INSERT INTO [Profiles] (ending_school_year, starting_school_year, account_id, current_term, profile_description, class_id) VALUES (@endingschoolyear, @startingschoolyear, @account_id, @term, @descrip, @class)",
                            DBQ_GET_ALL_CLASSES = "SELECT [class_id], [class_name] FROM [Classes] WHERE [account_id] = @account_id ORDER BY [class_name] ASC",
                            DBQ_INSERT_CLASS = "INSERT INTO [Classes] ([class_name], [account_id]) VALUES (@class_name, @account_id)",
                            DBQ_INSERT_SUBJECT = "INSERT INTO Subjects ([subject_name]) VALUES (@subject_name)",
                            DBQ_GET_ALL_SUBJECTS = "SELECT * FROM [Subjects] ORDER BY [subject_name] ASC",

                            /* General Purpose */
                            DBQ_GET_LAST_ROW_INSERTED = "SELECT last_insert_rowid() [last]",

                            /* Students */
                      
                            //@account_id - Account ID
                            DBQ_GET_ALL_STUDENTS = "SELECT [Students].[student_id] [Student ID], [student_first_name] [First Name], [student_last_name] [Last Name], (strftime('%Y', 'now') - strftime('%Y', [student_dob]) || ' years') [Age], [class_name] [Class] FROM [Students] INNER JOIN [StudentClass] ON [Students].[student_id] = [StudentClass].[student_id] INNER JOIN [Classes] ON [StudentClass].[class_id] = [Classes].[class_id] WHERE [Students].[account_id] = @account_id ORDER BY [class_name], [student_first_name], [student_last_name] ASC",
                            //@first_name @last_name @dob @account_id
                            DBQ_INSERT_STUDENT = "INSERT INTO [Students] ([student_first_name], [student_last_name], [student_dob], [account_id]) VALUES (@first_name, @last_name, @dob, @account_id)",
                            DBQ_STUDENT_EXIST = "SELECT COUNT([student_id]) [count] FROM [Students] WHERE [account_id] = @account_id",
                            DBQ_STUDENT_ASSIGN_GRADE = "INSERT INTO [StudentClass] ([class_id], [student_id]) VALUES (@class_id, @student_id)",
                            
                            DBQ_GET_SUBJECT_WHERE = "SELECT [subject_name], [Subjects].[subject_id] FROM [SubjectClass] JOIN [Subjects] ON [SubjectClass].[subject_id] = [Subjects].[subject_id] WHERE [profile_id] = @profile_id AND [class_id] = @class_id ORDER BY [subject_name] ASC",
                            DBQ_CLEAR_SUBJECTS_ON_CLASS = "DELETE FROM [SubjectClass] WHERE [profile_id] = @profile_id AND [class_id] = @class_id",
                            DBQ_INSERT_SUBJECT_ON_CLASS = "INSERT INTO [SubjectClass] ([subject_id], [class_id], [profile_id]) VALUES (@subject_id, @class_id, @profile_id)";


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

        /// <summary>
        /// Return the last row ID inserted with this connection
        /// </summary>
        /// <param name="connection">SQLiteConnection (should be opened)</param>
        /// <returns></returns>
        public static object GetLastRowInserted(SQLiteConnection connection)
        {
            object row_id = null;

            using (var command = new SQLiteCommand(DBQ_GET_LAST_ROW_INSERTED, connection))
            {
                command.CommandType = CommandType.Text;

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        row_id = reader["last"];
                }

            }

            return row_id;
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
