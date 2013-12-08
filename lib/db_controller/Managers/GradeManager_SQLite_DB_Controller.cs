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
        string[] TABLE_NAMES = 
        {
            "Accounts",
            "Students",
            "SubjectClass",
            "Classes",
            "Semester",
            "Subjects",
            "Assessment_Type",
            "Assessment_Type_Weights",
            "Assessments",
            "Grades",
            "StudentClass",
            "sqlite_sequence"
        };

        #region Initialization Code
        private const string DATABASE_CREATION_SQL = @"
pragma foreign_keys=on;
CREATE TABLE [Accounts] (
	[account_id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	[account_name] CHAR(30) NOT NULL,
	[account_password] CHAR(128) NOT NULL,
    [account_first_name] CHAR(30) NOT NULL,
    [account_last_name] CHAR(30) NOT NULL,
    UNIQUE (account_name)
	);

CREATE TABLE [Students] (
	[student_id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	[student_first_name] CHAR(20) NOT NULL,
	[student_last_name] CHAR(20) NOT NULL,
	[student_middle_name] CHAR(20),
    [student_gender] CHAR(1) NOT NULL,
	[student_dob] DATETIME NOT NULL,
	[account_id] INTEGER NOT NULL,
	FOREIGN KEY ([account_id]) REFERENCES [Accounts](account_id) ON UPDATE CASCADE ON DELETE CASCADE,
	UNIQUE (student_first_name, student_last_name, student_middle_name, student_dob, account_id)
	);
	
CREATE TABLE Classes (
	class_id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	class_name CHAR(30) NOT NULL,
	account_id INTEGER NOT NULL,
	FOREIGN KEY ([account_id]) REFERENCES [Accounts](account_id) ON UPDATE CASCADE ON DELETE CASCADE,
	UNIQUE (class_name, account_id)
	);
	
CREATE TABLE Semester (
	semester_id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	account_id INTEGER NOT NULL,
	current_term INTEGER NOT NULL,
	class_id INTEGER NOT NULL,
	ending_school_year INTEGER NOT NULL,
	starting_school_year INTEGER NOT NULL,
	semester_description CHAR(255) DEFAULT '',
	UNIQUE (account_id, current_term, class_id, starting_school_year),
	FOREIGN KEY ([account_id]) REFERENCES [Accounts](account_id) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY ([class_id]) REFERENCES [Classes](class_id) ON UPDATE CASCADE ON DELETE CASCADE
	);

CREATE TABLE [Subjects] (
	[subject_id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	[subject_name] CHAR(50) UNIQUE COLLATE NOCASE,
	UNIQUE (subject_name)
	);

CREATE TABLE [Assessment_Type] (
    [assess_type_id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    [assess_type] CHAR(12) NOT NULL,
    UNIQUE (assess_type)
);

CREATE TABLE [Assessment_Type_Weights]
(
	[assess_type_weight_id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	[assess_type_id] INTEGER NOT NULL,
	[assess_type_weight] FLOAT NOT NULL,
	[assess_type_id_relational] INTEGER,
	[assess_is_linked] INTEGER NOT NULL DEFAULT 0,
	[account_id] INTEGER NOT NULL,
	FOREIGN KEY ([assess_type_id]) REFERENCES [Assessment_Type] ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY ([assess_type_id_relational]) REFERENCES [Assessment_Type] ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY ([account_id]) REFERENCES [Accounts] ON UPDATE CASCADE ON DELETE CASCADE,
	UNIQUE ([assess_type_id], [account_id])
);
	
CREATE TABLE [Assessments] (
	assess_id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	assess_name CHAR(30) NOT NULL,
	assess_date DATETIME NOT NULL,
    assess_type_id INTEGER NOT NULL,
	subject_id INTEGER NOT NULL,
	semester_id INTEGER NOT NULL,
	FOREIGN KEY ([semester_id]) REFERENCES [Semester](semester_id) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY ([subject_id]) REFERENCES [Subjects](subject_id) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY ([assess_type_id]) REFERENCES [Assessment_Type](assess_type_id) ON UPDATE CASCADE ON DELETE CASCADE
	);

CREATE TABLE [Grades] (
	[grade_id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	[student_id] INTEGER NOT NULL,
	[assess_id] INTEGER NOT NULL,
	[grade_mark] FLOAT NOT NULL DEFAULT 0.0,
	FOREIGN KEY ([assess_id]) REFERENCES [Assessments]([assess_id]) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY ([student_id]) REFERENCES [Students]([student_id]) ON UPDATE CASCADE ON DELETE CASCADE,
	UNIQUE (student_id, assess_id)
	);
	
CREATE TABLE [StudentClass] (
	[stu_cla_id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	[student_id] INTEGER NOT NULL,
	[class_id] INTEGER NOT NULL,
	FOREIGN KEY ([class_id]) REFERENCES [Classes]([class_id]) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY ([student_id]) REFERENCES [Students]([student_id]) ON UPDATE CASCADE ON DELETE CASCADE,
	UNIQUE (student_id, class_id)
	);

CREATE TABLE [SubjectClass] (
	[sub_pro_id] INTEGER PRIMARY KEY NOT NULL,
	[subject_id] INTEGER NOT NULL,
	[class_id] INTEGER NOT NULL,
	[semester_id] INTEGER NOT NULL,
	FOREIGN KEY ([class_id]) REFERENCES [Classes]([class_id]) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY ([subject_id]) REFERENCES [Subjects]([subject_id]) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY ([semester_id]) REFERENCES [Semester]([semester_id]) ON UPDATE CASCADE ON DELETE CASCADE,
	UNIQUE (subject_id, class_id, semester_id)
	);
            ";
        #endregion

        public const string DBQ_GET_ACCOUNT_DETAILS_LOG_IN = "SELECT * FROM [Accounts] WHERE [account_name] = @name AND [account_password] = @password",
                            DBQ_GET_ACCOUNT_DETAILS_ID = "SELECT * FROM [Accounts] WHERE [account_id] = @id",
                            DBQ_GET_SEMESTER = "SELECT * FROM [Semester] WHERE [semester_id] = @id",
                            DBQ_GET_ALL_SEMESTERS = "SELECT [semester_id], ('Term:' || [current_term] || ', ' || [starting_school_year] || '-' || [ending_school_year] || ', ' || [Classes].[class_name]) AS [name] FROM [Semester] INNER JOIN [Classes] ON [Semester].[class_id] = [Classes].[class_id] WHERE [Semester].[account_id] = @account_id ORDER BY [starting_school_year], [ending_school_year] ASC",
                            DBQ_GET_ALL_SEMESTERS_TREE = "SELECT [semester_id], [Classes].[class_name], [starting_school_year], [ending_school_year], [current_term] FROM [Semester] INNER JOIN [Classes] ON [Semester].[class_id] = [Classes].[class_id] WHERE [Semester].[account_id] = @account_id ORDER BY [Classes].[class_id] ASC",
                            DBQ_GET_SEMESTER_ID = "SELECT * FROM [Semester] WHERE [semester_id] = @id",
                            DBQ_INSERT_SEMESTER = "pragma foreign_keys=on; INSERT INTO [Semester] (ending_school_year, starting_school_year, account_id, current_term, semester_description, class_id) VALUES (@endingschoolyear, @startingschoolyear, @account_id, @term, @descrip, @class)",
                            DBQ_GET_ALL_CLASSES = "SELECT [class_id], [class_name] FROM [Classes] WHERE [account_id] = @account_id ORDER BY [class_name] ASC",
                            DBQ_INSERT_CLASS = "pragma foreign_keys=on; INSERT INTO [Classes] ([class_name], [account_id]) VALUES (@class_name, @account_id)",
                            DBQ_GET_ALL_SUBJECTS = "SELECT * FROM [Subjects] ORDER BY [subject_name] ASC",
                            DBQ_GET_ALL_SUBJECTS_FOR_SEMESTER = "SELECT * FROM [Subjects] S INNER JOIN [SubjectClass] SC ON S.subject_id = SC.subject_id WHERE semester_id = @semester_id ORDER BY [subject_name] ASC",

                            /* General Purpose */
                            DBQ_GET_LAST_ROW_INSERTED = "SELECT last_insert_rowid() [last]",

                            /* Students */

                            //@account_id - Account ID
                            DBQ_GET_ALL_STUDENTS_TIDY = "SELECT [Students].[student_id] [Student ID], [student_first_name] [First Name], [student_middle_name] [Middle Name], [student_last_name] [Last Name], (strftime('%Y', 'now') - strftime('%Y', [student_dob]) || ' years') [Age], [student_gender] [Gender], [class_name] [Class] FROM [Students] LEFT JOIN [StudentClass] ON [Students].[student_id] = [StudentClass].[student_id] LEFT JOIN [Classes] ON [StudentClass].[class_id] = [Classes].[class_id] WHERE [Students].[account_id] = @account_id ORDER BY [class_name], [student_first_name], [student_last_name] ASC",
                            DBQ_GET_ALL_STUDENTS_RAW = "SELECT * FROM [Students] LEFT JOIN [StudentClass] ON [Students].[student_id] = [StudentClass].[student_id] LEFT JOIN [Classes] ON [StudentClass].[class_id] = [Classes].[class_id] WHERE [Students].[account_id] = @account_id ORDER BY [class_name], [student_first_name], [student_last_name] ASC",
                            DBQ_GET_STUDENT = "SELECT * FROM [Students] WHERE [student_id] = @student_id",
                            DBQ_GET_CLASS_OF_STUDENT = "SELECT C.[class_id], [class_name] FROM [Classes] C INNER JOIN [StudentClass] SC ON C.[class_id] = SC.[class_id] INNER JOIN [Students] S ON SC.[student_id] = S.[student_id] WHERE S.[student_id] = @student_id",
                            DBQ_INSERT_STUDENT = "pragma foreign_keys=on; INSERT INTO [Students] ([student_first_name], [student_last_name], [student_middle_name], [student_gender], [student_dob], [account_id]) VALUES (@first_name, @last_name, @middle_name, @gender, @dob, @account_id)",
                            DBQ_UPDATE_STUDENT = "pragma foreign_keys=on; UPDATE [Students] SET [student_first_name] = @first_name, [student_last_name] = @last_name, [student_middle_name] = @middle_name, [student_gender] = @gender, [student_dob] = @dob WHERE [student_id] = @student_id",
                            DBQ_STUDENT_EXIST = "SELECT COUNT([student_id]) [count] FROM [Students] WHERE [account_id] = @account_id",
                            DBQ_STUDENT_ASSIGN_GRADE = "pragma foreign_keys=on; INSERT OR REPLACE INTO [StudentClass] ([class_id], [student_id]) VALUES (@class_id, @student_id)",
                            DBQ_STUDENT_DELETE = "pragma foreign_keys=on; DELETE FROM [Students] WHERE [student_id] = @student_id",

                            DBQ_INSERT_SUBJECT = "INSERT INTO [Subjects] ([subject_name]) VALUES (@subject_name)",
                            DBQ_GET_SUBJECT_CURRENT_SEMESTER = "SELECT  DISTINCT [subject_name], [Subjects].[subject_id] FROM [SubjectClass] JOIN [Subjects] ON [SubjectClass].[subject_id] = [Subjects].[subject_id] WHERE [semester_id] = @semester_id ORDER BY [subject_name] ASC",
                            DBQ_CLEAR_SUBJECTS_ON_CLASS = "pragma foreign_keys=on; DELETE FROM [SubjectClass] WHERE [semester_id] = @semester_id AND [class_id] = @class_id",
                            DBQ_INSERT_SUBJECT_ON_CLASS = "pragma foreign_keys=on; INSERT INTO [SubjectClass] ([subject_id], [class_id], [semester_id]) VALUES (@subject_id, @class_id, @semester_id)",


                            DBQ_SELECT_ASSESSMENTS_SUBJECTS = "SELECT assess_id ID, assess_date [Date], assess_name [Name], subject_name [Subject], class_name [Class], current_term [Semester] FROM [Assessments] A INNER JOIN [Subjects] S ON A.subject_id = S.subject_id INNER JOIN [Semester] P ON p.semester_id = A.semester_id INNER JOIN [Classes] C ON P.class_id = C.class_id INNER JOIN [Assessment_Type] AT ON a.assess_type_id = AT.assess_type_id WHERE A.semester_id = @semester_id ORDER BY starting_school_year, Semester, Date",
                            DBQ_SELECT_ASSESSMENTS = "SELECT * FROM [Assessments] WHERE semester_id = @semester_id",
                            DBQ_SELECT_ASSESSMENTS_WHERE = "SELECT * FROM [Assessments] WHERE [assess_id] = @assess_id",
                            DBQ_INSERT_ASSESSMENT = @"pragma foreign_keys=on; INSERT INTO [Assessments] ([assess_name], [assess_date], [assess_type_id], [subject_id], [semester_id])
VALUES
(
	(SELECT assess_type || ' #' FROM [Assessment_Type] WHERE assess_type_id = @assess_type_id) || (SELECT COUNT(assess_id) + 1 FROM [Assessments] WHERE [subject_id] = @subject_id AND [semester_id] = @semester_id AND [assess_type_id] = @assess_type_id),
	@date,
	@assess_type_id,
	@subject_id,
	@semester_id
)",
                            DBQ_SELECT_ASSESSMENT_FROM_SUBJECT = "SELECT assess_id, assess_name FROM [Assessments] A WHERE [semester_id] = @semester_id AND [subject_id] = @subject_id ORDER BY assess_name ASC",
                            DBQ_SELECT_ASSESSMENT_TYPE = "SELECT * FROM [Assessment_Type] ORDER BY assess_type ASC",
                            DBQ_GET_ASSESSMENT_COUNT = @"SELECT
	[Assessments].assess_type_id,
	Subjects.subject_name,
	Subjects.subject_id,
	Assessment_Type.assess_type,
	COUNT([Assessments].assess_id) [Count]
FROM
	Assessments
	INNER JOIN Assessment_Type ON Assessments.assess_type_id = Assessment_Type.assess_type_id
	INNER JOIN Subjects ON Assessments.subject_id = Subjects.subject_id
	INNER JOIN Semester ON Semester.semester_id = Assessments.semester_id
WHERE account_id = @account_id
GROUP BY Assessments.assess_type_id, Assessments.subject_id",
                            DBQ_INSERT_ASSESSMENT_TYPE = "pragma foreign_keys=on; INSERT INTO [Assessment_Type] (assess_type) VALUES (@assess_type)",

                            DBQ_SELECT_DEFAULT_VALUES_GRADES = "SELECT DISTINCT [class_name], [starting_school_year], [ending_school_year], [current_term] FROM [Assessments] A LEFT JOIN [Grades] G ON A.assess_id = G.assess_id INNER JOIN [Semester] S ON A.semester_id = S.semester_id INNER JOIN [Students] ST ON G.student_id = ST.student_id INNER JOIN Classes C ON C.class_id = S.class_id WHERE S.semester_id = @semester_id",
                            DBQ_SELECT_SUBJECT_GRADES = "SELECT DISTINCT S.subject_id, S.subject_name FROM [Assessments] A INNER JOIN [Subjects] S ON A.subject_id = S.subject_id WHERE semester_id = @semester_id",
                            DBQ_SELECT_ASSESSMENT_STUDENT = "SELECT DISTINCT S.[student_id] ID, [student_last_name] [Last Name], [student_first_name] [First Name], [student_middle_name] [Middle Name(s)], (SELECT [grade_mark] FROM [Grades] WHERE [assess_id] = @assess_id AND S.[student_id] = [Grades].[student_id]) [Grade] FROM [Students] S ORDER BY [student_last_name], [student_first_name] ASC",
                            DBQ_INSERT_GRADE = "pragma foreign_keys=on; INSERT OR REPLACE INTO [Grades] ([student_id], [assess_id], [grade_mark]) VALUES (@student_id, @assess_id, @grade);",
                            
                            DBQ_GENERATE_REPORT = @"
SELECT DISTINCT
*,  
(((SELECT SUM([grade_mark]) FROM Grades G2 INNER JOIN Assessments A2 ON A2.assess_id = G2.assess_id INNER JOIN Assessment_Type AT2 ON A2.assess_type_id = AT2.assess_type_id INNER JOIN Semester ON Semester.semester_id = A2.semester_id WHERE 
G2.[student_id] = S.[student_id] AND A2.subject_id = SJ.[subject_id] AND AT2.[assess_type] = 'Test' AND Semester.semester_id = @semester_id)) +
((SELECT AVG([grade_mark]) FROM Grades G2 INNER JOIN Assessments A2 ON A2.assess_id = G2.assess_id INNER JOIN Assessment_Type AT2 ON A2.assess_type_id = AT2.assess_type_id INNER JOIN Semester ON Semester.semester_id = A2.semester_id WHERE 
G2.[student_id] = S.[student_id] AND A2.subject_id = SJ.[subject_id] AND AT2.[assess_type] = 'Quiz' AND Semester.semester_id = @semester_id))) /
(SELECT COUNT(grade_mark) + 1 FROM Grades G2 INNER JOIN Assessments A2 ON A2.assess_id = G2.assess_id INNER JOIN Assessment_Type AT2 ON A2.assess_type_id = AT2.assess_type_id INNER JOIN Semester ON Semester.semester_id = A2.semester_id WHERE 
G2.[student_id] = S.[student_id] AND A2.subject_id = SJ.[subject_id] AND AT2.[assess_type] = 'Test' AND Semester.semester_id = @semester_id) [average]
FROM [Students] S 
INNER JOIN [StudentClass] SC ON S.[student_id] = SC.[student_id] 
INNER JOIN [Semester] SM ON SC.[class_id] = SM.[class_id] 
INNER JOIN [Classes] C ON C.[class_id] = SM.[class_id] 
INNER JOIN [Assessments] A ON A.[semester_id] = SM.[semester_id]
INNER JOIN [Assessment_Type] AT ON AT.assess_type_id = A.assess_type_id  
INNER JOIN [Grades] G ON G.[assess_id] = A.[assess_id]
INNER JOIN [Subjects] SJ ON SJ.subject_id = A.subject_id
WHERE SM.[semester_id] = @semester_id
GROUP BY S.[student_id], SJ.[subject_id], SM.[semester_id]
ORDER BY S.[student_last_name], S.[student_first_name], S.[student_dob] ASC
",
                            DBQ_GET_STATS = "SELECT [assess_name] [Name], [grade_mark] [Grade] FROM [Grades] INNER JOIN [Students] ON [Grades].student_id = [Students].student_id INNER JOIN [Assessments] ON [Grades].assess_id = [Assessments].assess_id WHERE [subject_id] = @subject_id AND [assess_type_id] = @assess_type_id AND [Students].student_id = @student_id AND [Assessments].[semester_id] = @semester_id ORDER BY [Assessments].[assess_id] ASC",
                            DBQ_GET_STATS_AVG = "SELECT [Assessments].[assess_name] [Name], AVG([grade_mark]) [Grade] FROM [Grades] INNER JOIN [Students] ON [Grades].student_id = [Students].student_id INNER JOIN [Assessments] ON [Grades].assess_id = [Assessments].assess_id WHERE [subject_id] = @subject_id AND [assess_type_id] = @assess_type_id AND [Assessments].semester_id = @semester_id GROUP BY [Assessments].assess_id ORDER BY [Assessments].[assess_id] ASC",
                            DBQ_GET_RANKINGS = @"
SELECT
Z.student_first_name,
Z.student_last_name,
AVG(Z.average) [overall]
FROM
(
SELECT DISTINCT
*,  
(((SELECT SUM([grade_mark]) FROM Grades G2 INNER JOIN Assessments A2 ON A2.assess_id = G2.assess_id INNER JOIN Assessment_Type AT2 ON A2.assess_type_id = AT2.assess_type_id INNER JOIN Semester ON Semester.semester_id = A2.semester_id WHERE 
G2.[student_id] = S.[student_id] AND A2.subject_id = SJ.[subject_id] AND AT2.[assess_type] = 'Test' AND Semester.semester_id = @semester_id)) +
((SELECT AVG([grade_mark]) FROM Grades G2 INNER JOIN Assessments A2 ON A2.assess_id = G2.assess_id INNER JOIN Assessment_Type AT2 ON A2.assess_type_id = AT2.assess_type_id INNER JOIN Semester ON Semester.semester_id = A2.semester_id WHERE 
G2.[student_id] = S.[student_id] AND A2.subject_id = SJ.[subject_id] AND AT2.[assess_type] = 'Quiz' AND Semester.semester_id = @semester_id))) /
(SELECT COUNT(grade_mark) + 1 FROM Grades G2 INNER JOIN Assessments A2 ON A2.assess_id = G2.assess_id INNER JOIN Assessment_Type AT2 ON A2.assess_type_id = AT2.assess_type_id INNER JOIN Semester ON Semester.semester_id = A2.semester_id WHERE 
G2.[student_id] = S.[student_id] AND A2.subject_id = SJ.[subject_id] AND AT2.[assess_type] = 'Test' AND Semester.semester_id = @semester_id) [average]
FROM [Students] S 
INNER JOIN [StudentClass] SC ON S.[student_id] = SC.[student_id] 
INNER JOIN [Semester] SM ON SC.[class_id] = SM.[class_id] 
INNER JOIN [Classes] C ON C.[class_id] = SM.[class_id] 
INNER JOIN [Assessments] A ON A.[semester_id] = SM.[semester_id]
INNER JOIN [Assessment_Type] AT ON AT.assess_type_id = A.assess_type_id  
INNER JOIN [Grades] G ON G.[assess_id] = A.[assess_id]
INNER JOIN [Subjects] SJ ON SJ.subject_id = A.subject_id
WHERE SM.[semester_id] = @semester_id {0}
GROUP BY S.[student_id], SJ.[subject_id], SM.[semester_id]) [Z]
GROUP BY Z.student_id
ORDER BY [overall] DESC
",
                            DBQ_GET_ASSESSMENT_WEIGHTS = @"
SELECT
	[Assessments].assess_type_id,
	Subjects.subject_name,
	Subjects.subject_id,
	Assessment_Type.assess_type,
	Assessment_Type_Weights.*,
	COUNT([Assessments].assess_id) [Amount]
FROM
	Assessments
	INNER JOIN Assessment_Type ON Assessments.assess_type_id = Assessment_Type.assess_type_id
	INNER JOIN Assessment_Type_Weights ON Assessment_Type_Weights.assess_type_id = Assessments.assess_type_id
	INNER JOIN Subjects ON Assessments.subject_id = Subjects.subject_id
	INNER JOIN Semester ON Semester.semester_id = Assessments.semester_id
WHERE Semester.account_id = @account_id
GROUP BY Assessments.assess_type_id, Assessments.subject_id",
                            DBQ_GET_ASSESSMENT_WEIGHTS_WHERE = "SELECT DISTINCT [AT].[assess_type_id] [ID], [assess_type] [Name], [assess_type_weight] [Weight], [assess_type_id_relational] [RelationID], [assess_is_linked] [isLinkWith] FROM [Assessment_Type_Weights] [ATW] INNER JOIN [Assessment_Type] [AT] ON [ATW].assess_type_id = [AT].assess_type_id WHERE [account_id] = @account_id AND [ID] = @id",
                            DBQ_GET_STUDENT_SUBJECT_ASSESS_GRADES = @"select Students.student_id, student_first_name, student_last_name, subject_name, Subjects.subject_id, assess_type_id, avg(grade_mark) [Average] from Grades inner join Assessments on Assessments.assess_id = Grades.assess_id inner join Students on Grades.student_id = Students.student_id inner join Subjects on Subjects.subject_id = Assessments.subject_id where Students.student_id = @student_id group by Students.student_id, Assessments.assess_type_id, Subjects.subject_id";


        private static string DB_PATH = Environment.GetEnvironmentVariable("LOCALAPPDATA") + @"\Grade Manager\gm_storage.db";
        public static string CONNECTION_STRING = "Data Source=" + DB_PATH + ";Pooling=true;FailIfMissing=false";//"Data Source=" + DB_PATH + "; Version=3";

        public GradeManager_SQLite_DB_Controller() { }

        /// <summary>
        /// 
        /// </summary>
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

            InsertDefaultValues();
        }

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(CONNECTION_STRING);
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

        public void InsertDefaultValues()
        {
            #region Default Values
            string[] assessment_types = { "Quiz", "Test" };
            #endregion

            using (var connection = new SQLiteConnection(CONNECTION_STRING))
            {
                using (var command = new SQLiteCommand(DBQ_INSERT_ASSESSMENT_TYPE, connection))
                {
                    connection.Open();

                    foreach (string a_type in assessment_types)
                    {
                        command.Parameters.AddWithValue("@assess_type", a_type);

                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch(Exception) {}

                    }
                }
            }
        }

        public bool IntegrityTest()
        {
            bool pass = false;

            if (File.Exists(DB_PATH))
            {
                List<string> tables = new List<string>(TABLE_NAMES);

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
