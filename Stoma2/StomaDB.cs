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
    public abstract class DataFields
    {
        abstract public string[] ToStrArray();
        abstract public void FromStrArray(string[] strArray);
        abstract public string GetTableName();
        abstract public string[] GetRows();

        public void Create()
        {
            StomaDB.Instance.NonQuery(StomaDB.InsertGen(GetTableName(), GetRows(), ToStrArray()));
        }
    }

    public class DoctorFields : DataFields
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Speciality { get; set; }

        public override string[] ToStrArray()
        {
            return new string[] {
			    	DatabaseUtils.EncodeString(FirstName),
    				DatabaseUtils.EncodeString(LastName),
				    DatabaseUtils.EncodeString(Patronymic),
				    DatabaseUtils.EncodeString(Speciality)
                };
        }

        public override void FromStrArray(string[] strArray)
        {
            FirstName = DatabaseUtils.DecodeString(strArray[0]);
            LastName = DatabaseUtils.DecodeString(strArray[1]);
            Patronymic = DatabaseUtils.DecodeString(strArray[2]);
            Speciality = DatabaseUtils.DecodeString(strArray[3]);
        }

        public override string GetTableName()
        {
            return StomaDB.DOCTOR_TABLE;
        }

        public override string[] GetRows()
        {
            return StomaDB.DOCTOR_ROWS;
        }
    }

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
        public static readonly string ID_ROW = "id";

		// every record has an ID
		private Int64 m_record_id;
		public Int64 ID { get { return m_record_id; } }

        public DatabaseRecord(Int64 record_id)
        {
            m_record_id = record_id;
        }

        abstract protected DataFields GetData();

        abstract public void Save();

        public void Delete()
        {
            StomaDB.Instance.NonQuery("DELETE FROM " + GetData().GetTableName() + " WHERE id=" + ID + ";");
        }
	}

	public class DoctorRecord : DatabaseRecord
	{
        protected override DataFields GetData()
        {
            return data;
        }

		// this constructor should be private, but C# lacks friend keyword
		public DoctorRecord(Int64 id, string[] data)
            : base(id)
		{
            this.data = new DoctorFields();
            this.data.FromStrArray(data);
		}

		// This will add a new doctor to DB
		// It should return DoctorRecord, but good luck finding id of last inserted record
        public DoctorFields data;
        

		public string GetFullName()
		{
            return String.Format("{0} {1} {2}", data.LastName, data.FirstName, data.Patronymic);
		}

		public override void Save()
		{
            StomaDB.Instance.NonQuery(StomaDB.UpdateGen(data.GetTableName(), DatabaseRecord.ID_ROW, ID, data.GetRows(), data.ToStrArray()));
		}
	}

    public class ClientRecord : DatabaseRecord
    {
        protected override DataFields GetData()
        {
            throw new NotImplementedException();
        }

        private static readonly string TABLE_NAME = StomaDB.CLIENT_TABLE;

        public ClientRecord(Int64 id, string name_first, string name_last, string name_patronymic, string birthday,
            string address_subject, string address_city, string address_street, string address_building, string address_apartment,
            string workplace, string position, string phone, string notes, string last_invite)
            : base(id)
        {
            NameFirst = DatabaseUtils.DecodeString(name_first);
            NameLast = DatabaseUtils.DecodeString(name_last);
            NamePatronymic = DatabaseUtils.DecodeString(name_patronymic);
            Birthday = DatabaseUtils.DecodeString(birthday);
            AddressSubject = DatabaseUtils.DecodeString(address_subject);
            AddressCity = DatabaseUtils.DecodeString(address_city);
            AddressStreet = DatabaseUtils.DecodeString(address_street);
            AddressBuilding = DatabaseUtils.DecodeString(address_building);
            AddressApartment = DatabaseUtils.DecodeString(address_apartment);
            Workplace = DatabaseUtils.DecodeString(workplace);
            Position = DatabaseUtils.DecodeString(position);
            Phone = DatabaseUtils.DecodeString(phone);
            Notes = DatabaseUtils.DecodeString(notes);
            LastInvite = DatabaseUtils.DecodeString(last_invite);
        }

        public static void Create(string name_first, string name_last, string name_patronymic, string birthday,
            string address_subject, string address_city, string address_street, string address_building, string address_apartment,
            string workplace, string position, string phone, string notes, string last_invite)
        {
            StomaDB.Instance.NonQuery(StomaDB.InsertGen(TABLE_NAME, StomaDB.CLIENT_ROWS, new string[] {
                DatabaseUtils.EncodeString(name_first),
				DatabaseUtils.EncodeString(name_last),
				DatabaseUtils.EncodeString(name_patronymic),
				DatabaseUtils.EncodeString(birthday),
				DatabaseUtils.EncodeString(address_subject),
				DatabaseUtils.EncodeString(address_city),
				DatabaseUtils.EncodeString(address_street),
				DatabaseUtils.EncodeString(address_building),
				DatabaseUtils.EncodeString(address_apartment),
				DatabaseUtils.EncodeString(workplace),
				DatabaseUtils.EncodeString(position),
				DatabaseUtils.EncodeString(phone),
				DatabaseUtils.EncodeString(notes),
				DatabaseUtils.EncodeString(last_invite)
            }));
        }

        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public string NamePatronymic { get; set; }
        public string Birthday { get; set; }
        public string AddressSubject { get; set; }
        public string AddressCity { get; set; }
        public string AddressStreet { get; set; }
        public string AddressBuilding { get; set; }
        public string AddressApartment { get; set; }
        public string Workplace { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Notes { get; set; }
        public string LastInvite { get; set; }

        public string GetFullName()
        {
            return String.Format("{0} {1} {2}", NameLast, NameFirst, NamePatronymic);
        }

        public override void Save()
        {
            StomaDB.Instance.NonQuery(StomaDB.UpdateGen(TABLE_NAME, StomaDB.CLIENT_ROWS_ALL[0], ID, StomaDB.CLIENT_ROWS, new string[] {
                DatabaseUtils.EncodeString(NameFirst),
                DatabaseUtils.EncodeString(NameLast),
                DatabaseUtils.EncodeString(NamePatronymic),
                DatabaseUtils.EncodeString(Birthday),
                DatabaseUtils.EncodeString(AddressSubject),
                DatabaseUtils.EncodeString(AddressCity),
                DatabaseUtils.EncodeString(AddressStreet),
                DatabaseUtils.EncodeString(AddressBuilding),
                DatabaseUtils.EncodeString(AddressApartment),
                DatabaseUtils.EncodeString(Workplace),
                DatabaseUtils.EncodeString(Position),
                DatabaseUtils.EncodeString(Phone),
                DatabaseUtils.EncodeString(Notes),
                DatabaseUtils.EncodeString(LastInvite)
            }));
        }
    }

    public class DoctorIterator : DatabaseIterator
	{
		public DoctorIterator(string search_query = "")
            : base(StomaDB.DOCTOR_TABLE, search_query, Utils.SliceArray(StomaDB.DOCTOR_ROWS_ALL, new int[] { 1, 2, 3 }))
		{}

		public override IEnumerator GetEnumerator()
		{
			while (m_reader.Read())
			{
				yield return new DoctorRecord(m_reader.GetInt64(0), new string[] { m_reader.GetString(1),
					m_reader.GetString(2), m_reader.GetString(3), m_reader.GetString(4) });
			}
		}
	}

    public class ClientIterator : DatabaseIterator
    {
        public ClientIterator(string search_query = "")
            : base(StomaDB.CLIENT_TABLE, search_query, Utils.SliceArray(StomaDB.CLIENT_ROWS_ALL, new int[] { 1, 2, 3 }))
        {}

        public override IEnumerator GetEnumerator()
        {
            while (m_reader.Read())
            {
                yield return new ClientRecord(m_reader.GetInt64(0), m_reader.GetString(1), m_reader.GetString(2), m_reader.GetString(3), m_reader.GetString(4),
                    m_reader.GetString(5), m_reader.GetString(6), m_reader.GetString(7), m_reader.GetString(8), m_reader.GetString(9),
                    m_reader.GetString(10), m_reader.GetString(11), m_reader.GetString(12), m_reader.GetString(13), m_reader.GetString(14));
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
        public static readonly string[] DOCTOR_ROWS = Utils.SliceArray(DOCTOR_ROWS_ALL, new int[] { 1, 2, 3, 4 } );
        public static readonly string[] DOCTOR_TYPES = new string[] { "INTEGER PRIMARY KEY", "TEXT NOT NULL", "TEXT NOT NULL", "TEXT", "TEXT" };

        public static readonly string CLIENT_TABLE = "clients";
        public static readonly string[] CLIENT_ROWS_ALL = new string[] {
            "id", "name_first", "name_last", "name_patronymic", "birthday",
            "address_subject", "address_city", "address_street", "address_building", "address_apartment",
            "workplace", "position", "phone", "notes", "last_invite"
        };
        public static readonly string[] CLIENT_ROWS = Utils.SliceArray(CLIENT_ROWS_ALL, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 });
        public static readonly string[] CLIENT_TYPES = new string[] {
            "INTEGER PRIMARY KEY", "TEXT NOT NULL", "TEXT NOT NULL", "TEXT", "DATE", 
            "TEXT", "TEXT", "TEXT", "TEXT", "TEXT", 
            "TEXT", "TEXT", "TEXT", "TEXT", "DATE"
        };

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

		public static DoctorIterator GetDoctors(string search = "")
		{
			return new DoctorIterator(search);
		}

        public static ClientIterator GetClients(string search = "")
        {
            return new ClientIterator(search);
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
                NonQuery(CreateGen(CLIENT_TABLE, CLIENT_ROWS_ALL, CLIENT_TYPES));
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

        public void AddCategory(Dictionary<string, string> data)
        {
            NonQuery(QueryGen("insert into categories(", ") values(", ");", data));
        }

        public void AddService(Dictionary<string, string> data)
        {
            NonQuery(QueryGen("insert into service_list(", ") values(", ");", data));
        }

        public SQLiteDataReader GetCategoriesReader()
        {
            return Query("select * from categories");
        }

        public SQLiteDataReader GetServicesReader(int catId)
        {
            return Query("select * from service_list where category_id = " + catId + ";");
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
