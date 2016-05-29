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
    public abstract class TableInfo
    {
        public readonly string table;
        public readonly string[] rows;
        public readonly string[] types;
        public readonly int rowCount;

        public TableInfo(string table, string[] rows, string[] types)
        {
            this.table = table;
            this.rows = rows;
            this.types = types;

            if (rows.Length != types.Length)
            {
                throw new Exception("Wrong data");
            }

            rowCount = rows.Length;

            if (rowCount == 0)
            {
                throw new Exception("Insufficient data amount");
            }
        }

        public string FullIdRowName()
        {
            return table + "." + TableInfoHolder.ID_ROW;
        }

        public string FullRowName(int rowInd)
        {
            return table + "." + rows[rowInd];
        }

        abstract public DatabaseRecord CreateDatabaseRecord(Int64 id, object[] data);
    }

    public class DoctorTableInfo : TableInfo
    {
        public DoctorTableInfo()
            : base(
                "doctors",
                new string[] { "name_first", "name_last", "name_patronymic", "speciality", "obsolete" },
                new string[] { "TEXT NOT NULL", "TEXT NOT NULL", "TEXT", "TEXT", "INTEGER NOT NULL" }
            )
        {}

        public override DatabaseRecord CreateDatabaseRecord(Int64 id, object[] data)
        {
            return new DoctorRecord(id, data);
        }
    }

    public class ClientTableInfo : TableInfo
    {
        public ClientTableInfo()
            : base(
                "clients",
                new string[] {
                    "name_first", "name_last", "name_patronymic", "birthday",
                    "address_subject", "address_city", "address_street", "address_building", "address_apartment",
                    "workplace", "position", "phone", "notes", "last_invite"
                },
                new string[] {
                    "TEXT NOT NULL", "TEXT NOT NULL", "TEXT", "DATE", 
                    "TEXT", "TEXT", "TEXT", "TEXT", "TEXT", 
                    "TEXT", "TEXT", "TEXT", "TEXT", "DATE"
                }
            )
        {}

        public override DatabaseRecord CreateDatabaseRecord(Int64 id, object[] data)
        {
            return new ClientRecord(id, data);
        }
    }

    public class ServiceListTableInfo : TableInfo
    {
        public ServiceListTableInfo()
            : base(
                "service_list",
                new string[] { "name", "price", "category_id", "obsolete" },
                new string[] { "TEXT NOT NULL", "INTEGER NOT NULL", "INTEGER REFERENCES " + TableInfoHolder.CATEGORY.table + "(id)", "INTEGER NOT NULL" }
            )
        {}

        public override DatabaseRecord CreateDatabaseRecord(Int64 id, object[] data)
        {
            return new ServiceListRecord(id, data);
        }
    }

    public class CategoryTableInfo : TableInfo
    {
        public CategoryTableInfo()
            : base(
                "categories",
                new string[] { "name", "obsolete" },
                new string[] { "TEXT NOT NULL", "INTEGER NOT NULL" }
            )
        {}

        public override DatabaseRecord CreateDatabaseRecord(Int64 id, object[] data)
        {
            return new CategoryRecord(id, data);
        }
    }

    public class AppointmentTableInfo : TableInfo
    {
        public AppointmentTableInfo()
            : base(
                "appointments",
                new string[] {
                    "date", "diagnosis", "tooth", "doctor_id", "client_id"
                },
                new string[] {
                    "DATE", "TEXT NOT NULL", "INTEGER NOT NULL",
                    "INTEGER REFERENCES " + TableInfoHolder.DOCTOR.table + "(id)",
                    "INTEGER REFERENCES " + TableInfoHolder.CLIENT.table + "(id) ON DELETE CASCADE"
                }
            )
        {}

        public override DatabaseRecord CreateDatabaseRecord(Int64 id, object[] data)
        {
            return new AppointmentRecord(id, data);
        }
    }

    public class TreatmentTableInfo : TableInfo
    {
        public TreatmentTableInfo()
            : base(
                "treatments",
                new string[] { "service_id", "visit_id", "count" },
                new string[] {
                    "INTEGER REFERENCES " + TableInfoHolder.SERVICE_LIST.table + "(id)",
                    "INTEGER REFERENCES " + TableInfoHolder.APPOINTMENT.table + "(id) ON DELETE CASCADE",
                    "INTEGER NOT NULL"
                }
            )
        {}

        public override DatabaseRecord CreateDatabaseRecord(Int64 id, object[] data)
        {
            return new TreatmentRecord(id, data);
        }
    }

    public class TableInfoHolder
    {
        public static readonly string ID_ROW = "id";

        public static readonly TableInfo DOCTOR = new DoctorTableInfo();
        public static readonly TableInfo CLIENT = new ClientTableInfo();
        public static readonly TableInfo CATEGORY = new CategoryTableInfo();
        public static readonly TableInfo SERVICE_LIST = new ServiceListTableInfo();
        public static readonly TableInfo APPOINTMENT = new AppointmentTableInfo();
        public static readonly TableInfo TREATMENT = new TreatmentTableInfo();
    }

    public abstract class DataFields
    {
        abstract public object[] ToStrArray();
        abstract public void FromStrArray(object[] strArray);
        abstract public TableInfo GetTableInfo();

        public void Create()
        {
            StomaDB.Instance.NonQuery(StomaDB.InsertGen(GetTableInfo(), ToStrArray()));
        }
    }

    public class DoctorFields : DataFields
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Speciality { get; set; }
        public int obsolete { get; set; }

        public override object[] ToStrArray()
        {
            return new object[] {
                DatabaseUtils.EncodeString(FirstName),
                DatabaseUtils.EncodeString(LastName),
				DatabaseUtils.EncodeString(Patronymic),
				Speciality,
                obsolete
            };
        }

        public override void FromStrArray(object[] strArray)
        {
            FirstName = DatabaseUtils.DecodeString(strArray[0].ToString());
            LastName = DatabaseUtils.DecodeString(strArray[1].ToString());
            Patronymic = DatabaseUtils.DecodeString(strArray[2].ToString());
            Speciality = strArray[3].ToString();
            obsolete = 1;
        }

        public override TableInfo GetTableInfo()
        {
            return TableInfoHolder.DOCTOR;
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

        public ClientFields()
        {
            LastInvite = string.Empty;
        }

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

        public override TableInfo GetTableInfo()
        {
            return TableInfoHolder.CLIENT;
        }
    }

    public class ServiceListFields : DataFields
    {
        public string Name { get; set; }
        public Int64 Price { get; set; }
        public Int64 CategoryId { get; set; }
        public int obsolete { get; set; }

        public override object[] ToStrArray()
        {
            return new object[] {
                Name,
                Price,
                CategoryId,
                obsolete,
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
            obsolete = 1;
        }

        public override TableInfo GetTableInfo()
        {
            return TableInfoHolder.SERVICE_LIST;
        }
    }

    public class CategoryFields : DataFields
    {
        public int obsolete { get; set; }

        public string Name { get; set; }

        public override object[] ToStrArray()
        {
            return new object[] {
                Name,
                obsolete,
            };
        }

        public override void FromStrArray(object[] strArray)
        {
            Name = strArray[0].ToString();
            obsolete = 1;
        }

        public override TableInfo GetTableInfo()
        {
            return TableInfoHolder.CATEGORY;
        }
    }


    public class AppointmentFields : DataFields
    {
        public string Date { get; set; }
        public string Diagnosis { get; set; }
        public Int64 Tooth { get; set; }
        public Int64 DoctorId { get; set; }
        public Int64 ClientId { get; set; }

        public override object[] ToStrArray()
        {
            return new object[] {
                Date,
                Diagnosis,
                Tooth,
                DoctorId,
                ClientId                
            };
        }

        public override void FromStrArray(object[] strArray)
        {
            if (!Utils.IsInt64(strArray[2]) || !Utils.IsInt64(strArray[3]) || !Utils.IsInt64(strArray[4]))
            {
                throw new Exception("Type mismatch");
            }

            Date = strArray[0].ToString();
            Diagnosis = strArray[1].ToString();
            Tooth = (Int64)strArray[2];
            DoctorId = (Int64)strArray[3];
            ClientId = (Int64)strArray[4];
        }

        public override TableInfo GetTableInfo()
        {
            return TableInfoHolder.APPOINTMENT;
        }
    }

    public class TreatmentFields : DataFields
    {
        public Int64 ServiceId { get; set; }
        public Int64 VisitId { get; set; }
        public Int64 Count { get; set; }

        public override object[] ToStrArray()
        {
            return new object[] {
                ServiceId,
                VisitId,
                Count
            };
        }

        public override void FromStrArray(object[] strArray)
        {
            ServiceId = (Int64)strArray[0];
            VisitId = (Int64)strArray[1];
            Count = (Int64)strArray[2];
        }

        public override TableInfo GetTableInfo()
        {
            return TableInfoHolder.TREATMENT;
        }
    }

    public abstract class AbstractDatabaseIterator : IEnumerable
    {
        protected SQLiteDataReader m_reader;

        protected void Init(string query)
        {
            m_reader = StomaDB.Instance.Query(query);            
        }

        public IEnumerator GetEnumerator()
        {
            while (m_reader.Read())
            {
                yield return CreateEnumerator();
            }
        }

        abstract protected object CreateEnumerator();
    }

    public abstract class DatabaseIterator : AbstractDatabaseIterator
    {
        public DatabaseIterator()
        {}

        public DatabaseIterator(string search_query, string[] search_columns, string additional_where_statement = "1")
        {
            string query = "SELECT * FROM " + GetTableInfo().table + " WHERE (";

            if (search_query.Length > 0)
            {
                for (int i = 0; i < search_columns.Length; i++)
                {
                    if (i > 0 && i < search_columns.Length)
                    {
                        query += " OR ";
                    }

					query += search_columns[i] + " LIKE '%" + DatabaseUtils.SanitizeString(DatabaseUtils.EncodeString(search_query)) + "%'";
                }
            }
            else
            {
                query += "1";
            }

            query += ") AND (" + additional_where_statement + ");";

            Init(query);
        }

        protected override object CreateEnumerator()
        {
            object enumerator = GetTableInfo().CreateDatabaseRecord(m_reader.GetInt64(0), GetDataArray());
            AfterCreateEnumerator(enumerator);
            return enumerator;
        }

        virtual protected void AfterCreateEnumerator(object enumerator)
        {}

        protected object[] GetDataArray()
        {
            List<object> result = new List<object>();

            for (int i = 1; i <= GetTableInfo().rowCount; ++i)
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

        abstract protected TableInfo GetTableInfo();
    }

	public abstract class DatabaseRecord
	{
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
            StomaDB.Instance.NonQuery(StomaDB.UpdateGen(data.GetTableInfo(), ID, data.ToStrArray()));
        }

        public void Delete()
        {
            StomaDB.Instance.NonQuery("DELETE FROM " + data.GetTableInfo().table + " WHERE " + TableInfoHolder.ID_ROW + "=" + ID + ";");
        }
	}

	public class DoctorRecord : DatabaseRecord
	{
        public int obsolete;

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
        public int obsolete;

        protected override DataFields CreateData()
        {
            return new ServiceListFields();
        }

        public ServiceListRecord(Int64 id, object[] data)
            : base(id, data)
        {}

        public ServiceListFields Data { get { return (ServiceListFields)data; } }
    }

    public class CategoryRecord : DatabaseRecord
    {
        public int obsolete;

        protected override DataFields CreateData()
        {
            return new CategoryFields();
        }

        public CategoryRecord(Int64 id, object[] data)
            : base(id, data)
        {}

        public CategoryFields Data { get { return (CategoryFields)data; } }
    }

    public class AppointmentRecord : DatabaseRecord
    {
        protected override DataFields CreateData()
        {
            return new AppointmentFields();
        }

        public AppointmentRecord(Int64 id, object[] data)
            : base(id, data)
        {
            doctorData = new DoctorData();
        }

        public AppointmentFields Data { get { return (AppointmentFields)data; } }

        public class DoctorData
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Patronymic { get; set; }

            public string GetFullName()
            {
                return String.Format("{0} {1} {2}", LastName, FirstName, Patronymic);
            }
        };

        public DoctorData doctorData;
    }

    public class TreatmentRecord : DatabaseRecord
    {
        protected override DataFields CreateData()
        {
            return new TreatmentFields();
        }

        public TreatmentRecord(Int64 id, object[] data)
            : base(id, data)
        {
            serviceData = new ServiceData();
        }

        public TreatmentFields Data { get { return (TreatmentFields)data; } }

        public class ServiceData
        {
            public string Name { get; set; }
            public Int64 Price { get; set; }
        };

        public ServiceData serviceData;

        public Int64 GetTotalPrice()
        {
            return serviceData.Price * Data.Count;
        }
    }

    public class DoctorIterator : DatabaseIterator
	{
		public DoctorIterator(string search_query = "")
            : base(search_query, Utils.SliceArray(TableInfoHolder.DOCTOR.rows, new int[] { 0, 1, 2, 3}), "obsolete = 0")
		{}

        protected override TableInfo GetTableInfo()
        {
            return TableInfoHolder.DOCTOR;
        }
	}

    public class ClientIterator : DatabaseIterator
    {
        public ClientIterator(string search_query = "")
            : base(search_query, Utils.SliceArray(TableInfoHolder.CLIENT.rows, new int[] { 0, 1, 2 }))
        {}

        protected override TableInfo GetTableInfo()
        {
            return TableInfoHolder.CLIENT;
        }
    }

    public class ServiceListIterator : DatabaseIterator
    {
        public ServiceListIterator(Int64 categoryId, int obsolete)
            : base("", null, TableInfoHolder.SERVICE_LIST.rows[2] + "=" + categoryId + " AND obsolete = " + obsolete.ToString())
        {}

        protected override TableInfo GetTableInfo()
        {
            return TableInfoHolder.SERVICE_LIST;
        }
    }

    public class CategoryIterator : DatabaseIterator
    {
        public CategoryIterator()
            : base("", null, TableInfoHolder.CATEGORY.rows[1] + "=" + 0)
        {}

        protected override TableInfo GetTableInfo()
        {
            return TableInfoHolder.CATEGORY;
        }
    }

    public class AppointmentIterator : DatabaseIterator
    {
        public AppointmentIterator(ClientRecord client)
        {
            Init("SELECT * FROM " + TableInfoHolder.APPOINTMENT.table + " INNER JOIN " + TableInfoHolder.DOCTOR.table +
                " ON " + TableInfoHolder.APPOINTMENT.rows[3] + " = " + TableInfoHolder.DOCTOR.FullIdRowName() +
                " WHERE " + TableInfoHolder.APPOINTMENT.rows[4] + " = " + client.ID + ";");
        }

        protected override TableInfo GetTableInfo()
        {
            return TableInfoHolder.APPOINTMENT;
        }

        protected override void AfterCreateEnumerator(object enumerator)
        {
            base.AfterCreateEnumerator(enumerator);
            AppointmentRecord rec = (AppointmentRecord)enumerator;
            rec.doctorData.FirstName = DatabaseUtils.DecodeString(m_reader[TableInfoHolder.DOCTOR.rows[0]].ToString());
            rec.doctorData.LastName = DatabaseUtils.DecodeString(m_reader[TableInfoHolder.DOCTOR.rows[1]].ToString());
            rec.doctorData.Patronymic = DatabaseUtils.DecodeString(m_reader[TableInfoHolder.DOCTOR.rows[2]].ToString());
        }
    }

    public class TreatmentIterator : DatabaseIterator
    {
        public TreatmentIterator(AppointmentRecord appointment)
        {
            Init("SELECT * FROM " + TableInfoHolder.TREATMENT.table + " INNER JOIN " + TableInfoHolder.SERVICE_LIST.table +
                " ON " + TableInfoHolder.TREATMENT.rows[0] + " = " + TableInfoHolder.SERVICE_LIST.FullIdRowName() +
                " WHERE " + TableInfoHolder.TREATMENT.rows[1] + "=" + appointment.ID + ";");
        }

        protected override TableInfo GetTableInfo()
        {
            return TableInfoHolder.TREATMENT;
        }

        protected override void AfterCreateEnumerator(object enumerator)
        {
            base.AfterCreateEnumerator(enumerator);
            TreatmentRecord rec = (TreatmentRecord)enumerator;
            rec.serviceData.Name = m_reader[TableInfoHolder.SERVICE_LIST.rows[0]].ToString();
            rec.serviceData.Price = (Int64)m_reader[TableInfoHolder.SERVICE_LIST.rows[1]];
        }
    }

    public class ReportRecord
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public Int64 PatientAmount { get; set; }

        public string GetFullName()
        {
            return String.Format("{0} {1} {2}", LastName, FirstName, Patronymic);
        }
    }

    public class ReportIterator : AbstractDatabaseIterator
    {
        public ReportIterator()
        {
            Init("SELECT " + TableInfoHolder.DOCTOR.FullRowName(0) + "," + TableInfoHolder.DOCTOR.FullRowName(1) + "," + TableInfoHolder.DOCTOR.FullRowName(2) + ", COUNT(client_id) AS amount_patients  FROM " +
                TableInfoHolder.DOCTOR.table + " LEFT JOIN " +
                "(SELECT * FROM " + TableInfoHolder.APPOINTMENT.table + " WHERE strftime('%m', date) = strftime('%m', date()) " +
                "AND strftime('%Y', date) = strftime('%Y', date()) GROUP BY client_id, doctor_id)"
                 + " ON " + TableInfoHolder.DOCTOR.FullIdRowName() + " = doctor_id" +
                " GROUP BY name_last;");
        }

        protected override object CreateEnumerator()
        {
            ReportRecord result = new ReportRecord();
            result.FirstName = DatabaseUtils.DecodeString(m_reader[TableInfoHolder.DOCTOR.rows[0]].ToString());
            result.LastName = DatabaseUtils.DecodeString(m_reader[TableInfoHolder.DOCTOR.rows[1]].ToString());
            result.Patronymic = DatabaseUtils.DecodeString(m_reader[TableInfoHolder.DOCTOR.rows[2]].ToString());
            result.PatientAmount = (Int64)m_reader["amount_patients"];
            return result;
        }
    }


    public class PatientsToInviteIterator : DatabaseIterator
    {
        public PatientsToInviteIterator()
        {
            Init("SELECT * FROM " + TableInfoHolder.CLIENT.table
                + " WHERE " + "last_invite < date('now','-6 month');");
        }

        protected override TableInfo GetTableInfo()
        {
            return TableInfoHolder.CLIENT;
        }
    }



    public class DatabaseUtils
	{
		// Call before concatenating any string to an SQL query
		public static string SanitizeString(string str)
		{
			// Trim spaces and escape single quote
			return str.Trim().Replace("'", "''");
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
        private static object lockObj = new Object();
        private static StomaDB instance = null;

        public static StomaDB Instance
        {
            get
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new StomaDB();
                    }
                    return instance;
                }
            }
        }

        public static readonly string DB_FILE_NAME = "Stoma2.db";
        private readonly SQLiteConnection m_dbConnection;

		public static DoctorIterator GetDoctors(string search = "")
		{
			return new DoctorIterator(search);
		}

        public static ClientIterator GetClients(string search = "")
        {
            return new ClientIterator(search);
        }

        public static ServiceListIterator GetServiceList(Int64 categoryId, int obsolete)
        {
            return new ServiceListIterator(categoryId, obsolete);
        }

        public Int64 GetCategoryIdByServiceId(Int64 id)
        {
            SQLiteDataReader reader = Query("SELECT " + TableInfoHolder.CATEGORY.FullIdRowName() + " FROM " +
                TableInfoHolder.SERVICE_LIST.table + " INNER JOIN " + TableInfoHolder.CATEGORY.table +
                " ON " + TableInfoHolder.CATEGORY.FullIdRowName() + " = " + TableInfoHolder.SERVICE_LIST.rows[2] +
                " WHERE " + TableInfoHolder.SERVICE_LIST.FullIdRowName() + " = " + id + ";");

            if (!reader.Read())
                throw new Exception("No items found");

            return reader.GetInt64(0);
        }

        public static void MarkAsInvited(Int64 id)
        {
            string date = DateUtils.GetCurrentTimestamp();
            StomaDB.Instance.NonQuery("UPDATE " + TableInfoHolder.CLIENT.table + " SET " +
                "last_invite = " + "'" + DatabaseUtils.SanitizeString(date) + "'" +
                " WHERE " + TableInfoHolder.CLIENT.FullIdRowName() + " = " + id.ToString() + ";");
        }

        public bool HavePatientsToInvite()
        {
            SQLiteDataReader reader = Query("SELECT COUNT(id) as number_patients FROM " + TableInfoHolder.CLIENT.table
               + " WHERE " + "last_invite < date('now','-6 month');");
            if (!reader.Read())
                throw new Exception("No items found");
            Int64 number = reader.GetInt64(0);
            return number > 0;
        }


        public static ReportIterator GetDoctorAndAmountOfPatients()
        {
            return new ReportIterator();
        }

        public static PatientsToInviteIterator GetPatientsToInvite()
        {
            return new PatientsToInviteIterator();
        }

        public static CategoryIterator GetCategories()
        {
            return new CategoryIterator();
        }

        public static AppointmentIterator GetAppointments(ClientRecord client)
        {
            return new AppointmentIterator(client);
        }

        public static TreatmentIterator GetTreatments(AppointmentRecord appointment)
        {
            return new TreatmentIterator(appointment);
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
                NonQuery(CreateGen(TableInfoHolder.CLIENT));
                NonQuery(CreateGen(TableInfoHolder.DOCTOR));
                NonQuery(CreateGen(TableInfoHolder.CATEGORY));
                NonQuery(CreateGen(TableInfoHolder.SERVICE_LIST));
                NonQuery(CreateGen(TableInfoHolder.APPOINTMENT));
                NonQuery(CreateGen(TableInfoHolder.TREATMENT));
            }

            NonQuery("PRAGMA foreign_keys = ON");

			BackupManager.Instance.PerformBackup();
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

        private static string CreateGen(TableInfo info)
        {
            StringBuilder result = new StringBuilder("CREATE TABLE " + info.table + " (");
            result.Append(TableInfoHolder.ID_ROW + " INTEGER PRIMARY KEY");

            for (int i = 0; i < info.rowCount; ++i)
            {
                result.Append(",");
                result.Append(info.rows[i] + " " + info.types[i]);
            }

            result.Append(");");
            return result.ToString();
        }

        public static string InsertGen(TableInfo info, object[] values)
        {
            if (info.rowCount != values.Length)
                throw new Exception("Incorrect data");

            StringBuilder result = new StringBuilder("INSERT INTO " + info.table + " (");

            for (int i = 0; i < info.rowCount; ++i)
            {
                if (i != 0)
                    result.Append(",");

                result.Append("'" + info.rows[i] + "'");
            }

            result.Append(") VALUES (");

            for (int i = 0; i < info.rowCount; ++i)
            {
                if (i != 0)
                    result.Append(",");

				result.Append("'" + DatabaseUtils.SanitizeString(values[i].ToString()) + "'");
            }

            result.Append(");");
            return result.ToString();
        }

        public static string UpdateGen(TableInfo info, Int64 id, object[] values)
        {
            if (info.rowCount != values.Length)
                throw new Exception("Incorrect data");

            StringBuilder result = new StringBuilder("UPDATE " + info.table + " SET ");

            for (int i = 0; i < info.rowCount; ++i)
            {
                if (i != 0)
                    result.Append(",");

                result.Append(info.rows[i] + "='" + DatabaseUtils.SanitizeString(values[i].ToString()) + "'");
            }

            result.Append(" WHERE " + TableInfoHolder.ID_ROW + "=" + id + ";");
            return result.ToString();
        }
    }
}
