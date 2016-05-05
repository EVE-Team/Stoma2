using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace Stoma2
{
    class StomaDB : IDisposable
    {
        private static StomaDB instance = null;

        public static StomaDB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StomaDB();
                }
                return instance;
            }
        }

        private static readonly string DB_FILE_NAME = "Stoma2.db";
        private readonly SQLiteConnection m_dbConnection;

        public StomaDB()
        {
            bool newDB = !File.Exists(DB_FILE_NAME);

            if (newDB)
            {
                SQLiteConnection.CreateFile(DB_FILE_NAME);
            }

            m_dbConnection = new SQLiteConnection("Data Source=" + DB_FILE_NAME + ";Version=3;");
            m_dbConnection.Open();

            if (newDB)
            {
                NonQuery("CREATE TABLE clients (" +
                    "id INTEGER PRIMARY KEY, " +
                    "name_first TEXT NOT NULL, " +
                    "name_last TEXT NOT NULL, " +
                    "name_patronymic TEXT, " +
                    "birthday DATE, " +
                    "address_subject TEXT, " +
                    "address_city TEXT, " +
                    "address_street TEXT, " +
                    "address_building TEXT, " +
                    "address_apartment TEXT, " +
                    "workplace TEXT, " +
                    "position TEXT, " +
                    "phone TEXT, " +
                    "notes TEXT, " +
                    "last_invite DATE);");

                NonQuery("CREATE TABLE doctors (" +
                    "id INTEGER PRIMARY KEY, " +
                    "name_first TEXT NOT NULL, " +
                    "name_last TEXT NOT NULL, " +
                    "name_patronymic TEXT, " +
                    "speciality TEXT);");

                NonQuery("CREATE TABLE categories (" +
                    "id INTEGER PRIMARY KEY, " +
                    "name TEXT NOT NULL);");
            }
        }

        public void Dispose()
        {
            m_dbConnection.Close();
        }

        private int NonQuery(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, m_dbConnection);
            return command.ExecuteNonQuery();
        }

        private SQLiteDataReader Query(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, m_dbConnection);
            return command.ExecuteReader();
        }

        private static string QueryGen(string prefix, string infix, string suffix, Dictionary<string, string> data)
        {
            StringBuilder keys = new StringBuilder();
            StringBuilder values = new StringBuilder();

            foreach (var pair in data)
            {
                if (keys.Length != 0)
                {
                    keys.Append(',');
                    values.Append(',');
                }

                keys.Append(pair.Key);

                values.Append('"');
                values.Append(pair.Value);
                values.Append('"');
            }

            return prefix + keys.ToString() + infix + values.ToString() + suffix;
        }

        public void AddClient(Dictionary<string, string> data)
        {
            NonQuery(QueryGen("insert into clients(", ") values(", ");", data));
        }

        public void AddDoctor(Dictionary<string, string> data)
        {
            NonQuery(QueryGen("insert into doctors(", ") values(", ");", data));
        }

        public void AddCategory(Dictionary<string, string> data)
        {
            NonQuery(QueryGen("insert into categories(", ") values(", ");", data));
        }

        public SQLiteDataReader GetClientsReader()
        {
            return Query("select * from clients");
        }

        public SQLiteDataReader GetDoctorsReader()
        {
            return Query("select * from doctors");
        }

        public SQLiteDataReader GetCategoriesReader()
        {
            return Query("select * from categories");
        }

        public SQLiteDataReader GetClientReader(int id)
        {
            var reader = Query("select * from clients where id = " + id + ";");
            reader.Read();
            return reader;
        }

        public SQLiteDataReader GetDoctorReader(int id)
        {
            var reader = Query("select * from doctors where id = " + id + ";");
            reader.Read();
            return reader;
        }

        public void DeleteClient(int id)
        {
            NonQuery("delete from clients where id = " + id + ";");
        }

        public void DeleteDoctor(int id)
        {
            NonQuery("delete from doctors where id = " + id + ";");
        }

        public void DeleteCategory(int id)
        {
            NonQuery("delete from categories where id = " + id + ";");
        }
    }
}
