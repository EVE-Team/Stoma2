using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Windows.Forms;

namespace Stoma2
{
	class BackupManager
	{
		private static object lockObj = new Object();
		private static BackupManager instance = null;

		public static BackupManager Instance
		{
			get
			{
				lock (lockObj)
				{
					if (instance == null)
					{
						instance = new BackupManager();
					}
					return instance;
				}
			}
		}

		private static readonly int MAXIMUM_NUMBER_OF_BACKUPS = 30;
		private static readonly string BACKUP_DIRECTORY_NAME = "Backup";

		private string ProgramDirectory, BackupDirectory;

		public BackupManager()
		{
			ProgramDirectory = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
			BackupDirectory = Path.Combine(ProgramDirectory, BACKUP_DIRECTORY_NAME);
			if (!Directory.Exists(BackupDirectory))
			{
				Directory.CreateDirectory(BackupDirectory);
			}

			var backups = GetBackupList();
			if (backups.Count > MAXIMUM_NUMBER_OF_BACKUPS)
			{
				// this assumes oldest backups are last in the list
				for (int i = backups.Count - 1; i >= MAXIMUM_NUMBER_OF_BACKUPS; i--)
				{
					backups[i].Remove();
				}
			}
		}

		private string FormatBackupName(DateTime date)
		{
			string fileName = String.Format("Backup_{0}.db", date.ToString("yyyy-MM-dd"));
			return Path.Combine(BackupDirectory, fileName);
		}

		public class BackupInfo
		{
			public string FileName { get { return m_fileName; } }
			public Int64 FileSize { get { return m_fileSize; } }
			public DateTime BackupDate { get { return m_backupDate; } }

			private string m_fileName;
			private Int64 m_fileSize;
			private DateTime m_backupDate;

			public BackupInfo(string fileName)
			{
				m_fileName = fileName;
				var fileInfo = new FileInfo(fileName);
				m_fileSize = fileInfo.Length;


				if (!TryParseBackupName(fileInfo.Name, ref m_backupDate))
				{
					throw new ArgumentException("Invalid backup file name");
				}
			}

			public void Restore()
			{
				Program.backupToRestore = m_fileName;
				Program.mainForm.Close();
			}

			public void Remove()
			{
				File.Delete(m_fileName);
			}
		}

		private static bool TryParseBackupName(string fileName, ref DateTime backupDate)
		{
			try
			{
				fileName = Path.GetFileName(fileName);

				if (fileName.Substring(0, 7) != "Backup_")
				{
					return false;
				}
				if (fileName.Substring(fileName.Length - 3, 3) != ".db")
				{
					return false;
				}

				string dateString = fileName.Substring(7, fileName.Length - 10);
				backupDate = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);

				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public void PerformBackup()
		{
			string backupName = FormatBackupName(DateTime.Now);
			File.Copy(StomaDB.DB_FILE_NAME, backupName, true);
		}

		// Returns list of all available backups, sorted by backup date
		// Newest backups first, oldest last
		public List<BackupInfo> GetBackupList()
		{
			var result = new List<BackupInfo>();

			string[] fileEntries = Directory.GetFiles(BackupDirectory);
			foreach (string fileName in fileEntries)
			{
				DateTime temp = new DateTime();
				if (TryParseBackupName(fileName, ref temp))
				{
					result.Add(new BackupInfo(fileName));
				}
			}

			result.Sort(Comparer<BackupInfo>.Create((i1, i2) => i2.BackupDate.CompareTo(i1.BackupDate)));
			return result;
		}

		// Copy entire proogram directory (executable, database, backups)
		// to destinationDirectory
		public void PerformFullBackup(string destinationDirectory)
		{
			Utils.DirectoryCopy(ProgramDirectory, Path.Combine(destinationDirectory, "Stoma"), true);
		}
	}
}
