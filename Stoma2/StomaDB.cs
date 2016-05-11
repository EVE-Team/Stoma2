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
        abstract public object[] ToStrArray();
        abstract public void FromStrArray(object[] strArray);
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

        public override object[] ToStrArray()
        {
            return new object[] {
                DatabaseUtils.EncodeString(FirstName),
                DatabaseUtils.EncodeString(LastName),
				DatabaseUtils.EncodeString(Patronymic),
				Speciality
            };
        }

        public override void FromStrArray(object[] strArray)
        {
            FirstName = DatabaseUtils.DecodeString(strArray[0].ToString());
            LastName = DatabaseUtils.DecodeString(strArray[1].ToString());
            Patronymic = DatabaseUtils.DecodeString(strArray[2].ToString());
            Speciality = strArray[3].ToString();
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

    public class ClientFields : DataFields
    {
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

        public override object[] ToStrArray()
        {
            return new object[] {
                DatabaseUtils.EncodeString(NameFirst),
                DatabaseUtils.EncodeString(NameLast),
                DatabaseUtils.EncodeString(NamePatronymic),
                Birthday,
                AddressSubject,
                AddressCity,
                AddressStreet,
                AddressBuilding,
                AddressApartment,
                Workplace,
                Position,
                Phone,
                Notes,
                LastInvite
            };
        }

        public override void FromStrArray(object[] strArray)
        {
            NameFirst = DatabaseUtils.DecodeString(strArray[0].ToString());
            NameLast = DatabaseUtils.DecodeString(strArray[1].ToString());
            NamePatronymic = DatabaseUtils.DecodeString(strArray[2].ToString());
            Birthday = strArray[3].ToString();
            AddressSubject = strArray[4].ToString();
            AddressCity = strArray[5].ToString();
            AddressStreet = strArray[6].ToString();
            AddressBuilding = strArray[7].ToString();
            AddressApartment = strArray[8].ToString();
            Workplace = strArray[9].ToString();
            Position = strArray[10].ToString();
            Phone = strArray[11].ToString();
            Notes = strArray[12].ToString();
            LastInvite = strArray[13].ToString();
        }

        public override string GetTableName()
        {
            return StomaDB.CLIENT_TABLE;
        }

        public override string[] GetRows()
        {
            return StomaDB.CLIENT_ROWS;
        }
    }

    public class ServiceListFields : DataFields
    {
        public string Name { get; set; }
        public Int64 Price { get; set; }
        public Int64 CategoryId { get; set; }

        public override object[] ToStrArray()
        {
            return new object[] {
                Name,
                Price,
                CategoryId
            };
        }

        public override void FromStrArray(object[] strArray)
        {
            if (!Utils.IsInt64(strArray[1]) || !Utils.IsInt64(strArray[2]))
            {
                throw new Exception("Type mismatch");
            }

            Name = strArray[0].ToString();
            Price = (Int64)strArray[1];
            CategoryId = (Int64)strArray[2];
        }

        public override string GetTableName()
        {
            return StomaDB.SERVICE_LIST_TABLE;
        }

        public override string[] GetRows()
        {
            return StomaDB.SERVICE_LIST_ROWS;
        }
    }

    public abstract class DatabaseIterator : IEnumerable
	{
		protected SQLiteDataReader m_reader;

        public DatabaseIterator(string table_name, string search_query, string[] search_columns, string additional_where_statement = "1")
		{
			string query = "SELECT * FROM " + DatabaseUtils.SanitizeString(table_name) + " WHERE (";

            if (search_query.Length > 0)
            {
                for (int i = 0; i < search_columns.Length; i++)
                {
                    if (i > 0 && i < search_columns.Length)
                    {
                        query += " OR ";
                    }

                    query += search_columns[i] + " LIKE '%" + DatabaseUtils.EncodeString(search_query) + "%'";
                }
            }
            else
            {
                query += "1";
            }

            query += ") AND (" + additional_where_statement + ");";

            m_reader = StomaDB.Instance.Query(query);
		}

        public IEnumerator GetEnumerator()
        {
            while (m_reader.Read())
            {
                yield return CreateRecord();
            }
        }

        protected object[] GetDataArray(int count)
        {
            List<object> result = new List<object>();

            for (int i = 1; i <= count; ++i)
            {
                // Do not remove this workaround yet
                // http://stackoverflow.com/questions/11414399/sqlite-throwing-a-string-not-recognized-as-a-valid-datetime

                string type = m_reader.GetDataTypeName(i);
                if (type == "DATE")
                {
                    result.Add(m_reader.GetString(i));
                }
                else
                {
                    result.Add(m_reader.GetValue(i));
                }
            }

            return result.ToArray();
        }

        abstract protected DatabaseRecordFactory.Type GetFactoryType();
        abstract protected int GetDataColumnCount();

        protected DatabaseRecord CreateRecord()
        {
            return DatabaseRecordFactory.Create(GetFactoryType(), m_reader.GetInt64(0), GetDataArray(GetDataColumnCount()));
        }
    }

	public abstract class DatabaseRecord
	{
        public static readonly string ID_ROW = "id";

		// every record has an ID
		private Int64 m_record_id;
		public Int64 ID { get { return m_record_id; } }

        public DatabaseRecord(Int64 id, object[] data)
		{
            m_record_id = id;
            this.data = CreateData();
            this.data.FromStrArray(data);
		}

        protected DataFields data;

        abstract protected DataFields CreateData();

        public void Save()
        {
            StomaDB.Instance.NonQuery(StomaDB.UpdateGen(data.GetTableName(), ID_ROW, ID, data.GetRows(), data.ToStrArray()));
        }

        public void Delete()
        {
            StomaDB.Instance.NonQuery("DELETE FROM " + data.GetTableName() + " WHERE " + ID_ROW + "=" + ID + ";");
        }
	}

	public class DoctorRecord : DatabaseRecord
	{
        protected override DataFields CreateData()
        {
            return new DoctorFields();
        }

        public DoctorRecord(Int64 id, object[] data)
            : base(id, data)
		{}

        public DoctorFields Data { get { return (DoctorFields)data; } }

        public string GetFullName()
		{
            return String.Format("{0} {1} {2}", Data.LastName, Data.FirstName, Data.Patronymic);
		}
	}

    public class ClientRecord : DatabaseRecord
    {
        protected override DataFields CreateData()
        {
            return new ClientFields();
        }

        public ClientRecord(Int64 id, object[] data)
            : base(id, data)
		{}

        public ClientFields Data { get { return (ClientFields)data; } }

        public string GetFullName()
        {
            return String.Format("{0} {1} {2}", Data.NameLast, Data.NameFirst, Data.NamePatronymic);
        }
    }

    public class ServiceListRecord : DatabaseRecord
    {
        protected override DataFields CreateData()
        {
            return new ServiceListFields();
        }

        public ServiceListRecord(Int64 id, object[] data)
            : base(id, data)
        {}

        public ServiceListFields Data { get { return (ServiceListFields)data; } }
    }

    public class DatabaseRecordFactory
    {
        public enum Type { DOCTOR, CLIENT, SERVICE_LIST };

        public static DatabaseRecord Create(Type type, Int64 id, object[] data)
        {
            switch (type)
            {
                case Type.DOCTOR:
                    return new DoctorRecord(id, data);
                case Type.CLIENT:
                    return new ClientRecord(id, data);
                case Type.SERVICE_LIST:
                    return new ServiceListRecord(id, data);
                default:
                    throw new Exception("Unknown type");
            }
        }
    }

    public class DoctorIterator : DatabaseIterator
	{
		public DoctorIterator(string search_query = "")
            : base(StomaDB.DOCTOR_TABLE, search_query, Utils.SliceArray(StomaDB.DOCTOR_ROWS_ALL, new int[] { 1, 2, 3 }))
		{}

        protected override DatabaseRecordFactory.Type GetFactoryType()
        {
            return DatabaseRecordFactory.Type.DOCTOR;
        }

        protected override int GetDataColumnCount()
        {
            return 4;
        }
	}

    public class ClientIterator : DatabaseIterator
    {
        public ClientIterator(string search_query = "")
            : base(StomaDB.CLIENT_TABLE, search_query, Utils.SliceArray(StomaDB.CLIENT_ROWS_ALL, new int[] { 1, 2, 3 }))
        {}

        protected override DatabaseRecordFactory.Type GetFactoryType()
        {
            return DatabaseRecordFactory.Type.CLIENT;
        }

        protected override int GetDataColumnCount()
        {
            return 14;
        }
    }

    public class ServiceListIterator : DatabaseIterator
    {
        public ServiceListIterator(Int64 categoryId)
            : base(StomaDB.SERVICE_LIST_TABLE, "", null, StomaDB.SERVICE_LIST_ROWS_ALL[3] + "=" + categoryId)
        {}

        protected override DatabaseRecordFactory.Type GetFactoryType()
        {
            return DatabaseRecordFactory.Type.SERVICE_LIST;
        }

        protected override int GetDataColumnCount()
        {
            return 3;
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

        public static readonly string SERVICE_LIST_TABLE = "service_list";
        public static readonly string[] SERVICE_LIST_ROWS_ALL = new string[] { "id", "name", "price", "category_id" };
        public static readonly string[] SERVICE_LIST_ROWS = Utils.SliceArray(SERVICE_LIST_ROWS_ALL, new int[] { 1, 2, 3 });
        public static readonly string[] SERVICE_LIST_TYPES = new string[] { "INTEGER PRIMARY KEY", "TEXT NOT NULL", "INTEGER NOT NULL", "INTEGER REFERENCES categories(id)" };

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

        public static ServiceListIterator GetServiceList(Int64 categoryId)
        {
            return new ServiceListIterator(categoryId);
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

                NonQuery(CreateGen(SERVICE_LIST_TABLE, SERVICE_LIST_ROWS_ALL, SERVICE_LIST_TYPES));
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

        public static string InsertGen(string tableName, string[] rows, object[] values)
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

        public static string UpdateGen(string tableName, string idRow, Int64 id, string[] rows, object[] values)
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

        public SQLiteDataReader GetCategoriesReader()
        {
            return Query("select * from categories");
        }

        public void DeleteCategory(int id)
        {
            NonQuery("delete from categories where id = " + id + ";");
        }
    }
}
