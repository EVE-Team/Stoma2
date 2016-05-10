using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using System.Collections;
using System.Windows.Forms;

namespace Stoma2
{
	public abstract class DatabaseIterator : IEnumerable
	{
		protected SQLiteDataReader m_reader;

		public DatabaseIterator(string table_name, string search_query, string[] search_columns)
		{
			string query = "SELECT * FROM " + DatabaseUtils.SanitizeString(table_name);
			if (search_query.Length > 0)
			{
				query += " WHERE ";
				
				for (int i = 0; i < search_columns.Length; i++)
				{
					if (i > 0 && i < search_columns.Length)
					{
						query += " OR ";
					}

					query += search_columns[i] + " LIKE '%" + DatabaseUtils.EncodeString(search_query) + "%'";
				}
			}
			query += ";";

			m_reader = StomaDB.Instance.Query(query);
		}

		abstract public IEnumerator GetEnumerator();
	}

	public abstract class DatabaseRecord
	{
		// every record has an ID
		protected Int64 m_record_id;
		public Int64 ID { get { return m_record_id; } }

        abstract protected string GetTableName();
        abstract public void Save();

        public void Delete()
        {
            StomaDB.Instance.NonQuery("DELETE FROM " + GetTableName() + " WHERE id=" + ID + ";");
        }
	}

	public class DoctorRecord : DatabaseRecord
	{
        private static readonly string TABLE_NAME = StomaDB.DOCTOR_TABLE;

		// this constructor should be private, but C# lacks friend keyword
		public DoctorRecord(Int64 id, string first_name, string last_name, string patronymic, string speciality)
		{
			m_record_id = id;
			FirstName = DatabaseUtils.DecodeString(first_name);
			LastName = DatabaseUtils.DecodeString(last_name);
			Patronymic = DatabaseUtils.DecodeString(patronymic);
			Speciality = DatabaseUtils.DecodeString(speciality);
		}

		// This will add a new doctor to DB
		// It should return DoctorRecord, but good luck finding id of last inserted record
		public static void Create(string first_name, string last_name, string patronymic, string speciality)
		{
            StomaDB.Instance.NonQuery(StomaDB.InsertGen(TABLE_NAME, StomaDB.DOCTOR_ROWS, new string[] {
                DatabaseUtils.EncodeString(first_name),
				DatabaseUtils.EncodeString(last_name),
				DatabaseUtils.EncodeString(patronymic),
				DatabaseUtils.EncodeString(speciality)
            }));

			// get ID of newly inserted record
			// AND 'name_patronymic'='{2}' AND 'speciality'='{3}'
			// , patronymic, speciality
			//query = String.Format("SELECT * FROM doctors WHERE 'name_first'='{0}' AND 'name_last'='{1}';",
			//	first_name, last_name);
			//var reader = StomaDB.Instance.Query(query);
			//reader.Read();

			//return new DoctorRecord(reader.GetInt64(0), reader.GetString(1),
			//		reader.GetString(2), reader.GetString(3), reader.GetString(4));
		}

		// Имя (name_first)
		public string FirstName { get; set; }
		// Фамилия (name_last)
		public string LastName { get; set; }
		// Отчество (name_patronymic)
		public string Patronymic { get; set; }
		// Специальность (терапевт, хирург, ортопед) (speciality)
		public string Speciality { get; set; }

		public string GetFullName()
		{
			return String.Format("{0} {1} {2}", LastName, FirstName, Patronymic);
		}

        protected override string GetTableName()
        {
            return TABLE_NAME;
        }

		public override void Save()
		{
            StomaDB.Instance.NonQuery(StomaDB.UpdateGen(TABLE_NAME, StomaDB.DOCTOR_ROWS_ALL[0], ID, StomaDB.DOCTOR_ROWS, new string[] {
				DatabaseUtils.EncodeString(FirstName),
				DatabaseUtils.EncodeString(LastName),
				DatabaseUtils.EncodeString(Patronymic),
				DatabaseUtils.EncodeString(Speciality)
            }));
		}
	}

	public class DoctorIterator : DatabaseIterator
	{
		public DoctorIterator(string search_query = "")
            : base(StomaDB.DOCTOR_TABLE, search_query, new string[] { StomaDB.DOCTOR_ROWS_ALL[1], StomaDB.DOCTOR_ROWS_ALL[2], StomaDB.DOCTOR_ROWS_ALL[3] })
		{}

		public override IEnumerator GetEnumerator()
		{
			while (m_reader.Read())
			{
				yield return new DoctorRecord(m_reader.GetInt64(0), m_reader.GetString(1),
					m_reader.GetString(2), m_reader.GetString(3), m_reader.GetString(4));
			}
		}
	}

	public class DatabaseUtils
	{
		public static string SanitizeString(string str)
		{
			// should also remove ' ; "
			return str.Trim();
		}

		static Dictionary<char, string> translit = new Dictionary<char, string>
		{
			{ 'ё', "yo" },
			{ 'й', "yy" },
			{ 'ц', "ts" },
			{ 'у', "uu" },
			{ 'к', "kk" },
			{ 'е', "ye" },
			{ 'н', "nn" },
			{ 'г', "gg" },
			{ 'ш', "sh" },
			{ 'щ', "sx" },
			{ 'з', "zz" },
			{ 'х', "hh" },
			{ 'ъ', "xh" },
			{ 'ф', "ff" },
			{ 'ы', "xi" },
			{ 'в', "vv" },
			{ 'а', "aa" },
			{ 'п', "pp" },
			{ 'р', "rr" },
			{ 'о', "oo" },
			{ 'л', "ll" },
			{ 'д', "dd" },
			{ 'ж', "zh" },
			{ 'э', "xe" },
			{ 'я', "ya" },
			{ 'ч', "ch" },
			{ 'с', "ss" },
			{ 'м', "mm" },
			{ 'и', "ii" },
			{ 'т', "tt" },
			{ 'ь', "xs" },
			{ 'б', "bb" },
			{ 'ю', "yu" }
		};

		static Dictionary<string, char> itranslit = CreateReverseDictionary(translit);

		private static Dictionary<string, char> CreateReverseDictionary(Dictionary<char, string> dict)
		{
			Dictionary<string, char> result = new Dictionary<string, char>();

			foreach (char key in dict.Keys)
			{
				result[dict[key]] = key;
			}

			return result;
		}

		public static string EncodeString(string russian)
		{
			russian = SanitizeString(russian);

			string result = "";
			foreach (char ch in russian)
			{
				if (translit.ContainsKey(ch))
				{
					result += translit[ch];
				} else if (translit.ContainsKey(ch.ToString().ToLower()[0])) {
					result += translit[ch.ToString().ToLower()[0]].ToUpper();
				} else {
					result += ch.ToString() + "~";
				}
			}
			return result;
		}

		public static string DecodeString(string encoded)
		{
			if (encoded.Length % 2 != 0)
			{
				throw new ArgumentException("DecodeString: invalid input");
			}

			string result = "";
			for (int i = 0; i < encoded.Length; i += 2)
			{
				string pair = encoded[i].ToString() + encoded[i + 1].ToString();

				if (encoded[i + 1] == '~')
				{
					result += encoded[i];
				}
				else if (itranslit.ContainsKey(pair))
				{
					result += itranslit[pair].ToString();
				}
				else if (itranslit.ContainsKey(pair.ToLower()))
				{
					result += itranslit[pair.ToLower()].ToString().ToUpper();
				}
				else
				{
					throw new ArgumentException("DecodeString: invalid input");
				}
			}
			return result;
		}
	}

	// -=-=-=-=-=-=-=-=-=-=-=-

    public class StomaDB : IDisposable
    {
        public static readonly string DOCTOR_TABLE = "doctors";
        public static readonly string[] DOCTOR_ROWS_ALL = new string[] { "id", "name_first", "name_last", "name_patronymic", "speciality" };
        public static readonly string[] DOCTOR_ROWS = new string[] { DOCTOR_ROWS_ALL[1], DOCTOR_ROWS_ALL[2], DOCTOR_ROWS_ALL[3], DOCTOR_ROWS_ALL[4] };
        public static readonly string[] DOCTOR_TYPES = new string[] { "INTEGER PRIMARY KEY", "TEXT NOT NULL", "TEXT NOT NULL", "TEXT", "TEXT" };

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

		public DoctorIterator GetDoctors(string search = "")
		{
			return new DoctorIterator(search);
		}

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

                NonQuery(CreateGen(DOCTOR_TABLE, DOCTOR_ROWS_ALL, DOCTOR_TYPES));

                NonQuery("CREATE TABLE categories (" +
                    "id INTEGER PRIMARY KEY, " +
                    "name TEXT NOT NULL);");

                NonQuery("CREATE TABLE service_list (" +
                    "id INTEGER PRIMARY KEY, " +
                    "name TEXT NOT NULL, " +
                    "price INTEGER NOT NULL, " +
                    "category_id INTEGER REFERENCES categories(id));");
            }
        }

        public void Dispose()
        {
            m_dbConnection.Close();
        }

        public int NonQuery(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, m_dbConnection);
            return command.ExecuteNonQuery();
        }

        public SQLiteDataReader Query(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, m_dbConnection);
            return command.ExecuteReader();
        }

        private static string CreateGen(string tableName, string[] rows, string[] types)
        {
            if (rows.Length != types.Length)
                throw new Exception("Incorrect data");

            int length = rows.Length;

            if (length == 0)
                throw new Exception("No data");

            StringBuilder result = new StringBuilder("CREATE TABLE " + tableName + " (");

            for (int i = 0; i < length; ++i)
            {
                if (i != 0)
                    result.Append(",");

                result.Append(rows[i] + " " + types[i]);
            }

            result.Append(");");
            return result.ToString();
        }

        public static string InsertGen(string tableName, string[] rows, string[] values)
        {
            if (rows.Length != values.Length)
                throw new Exception("Incorrect data");

            int length = rows.Length;

            if (length == 0)
                throw new Exception("No data");

            StringBuilder result = new StringBuilder("INSERT INTO " + tableName + " (");

            for (int i = 0; i < length; ++i)
            {
                if (i != 0)
                    result.Append(",");

                result.Append("'" + rows[i] + "'");
            }

            result.Append(") VALUES (");

            for (int i = 0; i < length; ++i)
            {
                if (i != 0)
                    result.Append(",");

                result.Append("'" + values[i] + "'");
            }

            result.Append(");");
            return result.ToString();
        }

        public static string UpdateGen(string tableName, string idRow, Int64 id, string[] rows, string[] values)
        {
            if (rows.Length != values.Length)
                throw new Exception("Incorrect data");

            int length = rows.Length;

            if (length == 0)
                throw new Exception("No data");

            StringBuilder result = new StringBuilder("UPDATE " + tableName + " SET ");

            for (int i = 0; i < length; ++i)
            {
                if (i != 0)
                    result.Append(",");

                result.Append(rows[i] + "='" + values[i] + "'");
            }

            result.Append(" WHERE " + idRow + "=" + id + ";");
            return result.ToString();
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

        public void AddCategory(Dictionary<string, string> data)
        {
            NonQuery(QueryGen("insert into categories(", ") values(", ");", data));
        }

        public void AddService(Dictionary<string, string> data)
        {
            NonQuery(QueryGen("insert into service_list(", ") values(", ");", data));
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

        public SQLiteDataReader GetServicesReader(int catId)
        {
            return Query("select * from service_list where category_id = " + catId + ";");
        }

        public SQLiteDataReader GetClientReader(int id)
        {
            var reader = Query("select * from clients where id = " + id + ";");
            reader.Read();
            return reader;
        }

        public void DeleteClient(int id)
        {
            NonQuery("delete from clients where id = " + id + ";");
        }

        public void DeleteCategory(int id)
        {
            NonQuery("delete from categories where id = " + id + ";");
        }

        public void DeleteService(int id)
        {
            NonQuery("delete from service_list where id = " + id + ";");
        }
    }
}
