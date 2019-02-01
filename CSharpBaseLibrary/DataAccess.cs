using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace CSharpBase.Data
{
    public static class DataAccess
    {

        public static String Plop()
        {
            return "plop";
        }
        public static void InitializeDatabase()
        {
            using (SQLiteConnection db =
                new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; "))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS MyTable (Primary_Key INTEGER PRIMARY KEY, " +
                    "Text_Entry NVARCHAR(2048) NULL)";

                SQLiteCommand createTable = new SQLiteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }

        public static void AddData(string inputText)
        {
            using (SQLiteConnection db =
                new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; "))
            {
                db.Open();

                SQLiteCommand insertCommand = new SQLiteCommand();
                insertCommand.Connection = db;

                // Use parameterized query to prevent SQL injection attacks
                insertCommand.CommandText = "INSERT INTO MyTable VALUES (NULL, @Entry);";
                insertCommand.Parameters.AddWithValue("@Entry", inputText);

                insertCommand.ExecuteReader();

                db.Close();
            }

        }

        public static List<String> GetData()
        {
            List<String> entries = new List<string>();

            using (SQLiteConnection db =
                new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; "))
            {
                db.Open();

                SQLiteCommand selectCommand = new SQLiteCommand
                    ("SELECT Text_Entry from MyTable", db);

                SQLiteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                }

                db.Close();
            }

            return entries;
        }

        public static bool IsCorrectString(String insertString)
        {
            if ( String.IsNullOrWhiteSpace(insertString) || insertString.Length > 127)
            {
                // EXCEPTION
                throw new InvalidStringException("");
            }
            else
            {
                return true;
            }     
        }
    }

    public class InvalidStringException : Exception
    {
        public string errorMessage;
        public InvalidStringException(string message)
           : base(message)
        {
            errorMessage = message;
        }
    }
}
