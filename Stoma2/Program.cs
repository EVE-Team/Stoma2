using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Stoma2
{
	static class Program
	{
		public static MainForm mainForm;
		public static string backupToRestore = null;

        /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			bool restartApp;
			do
			{
				restartApp = false;

				{
					mainForm = new MainForm();
					Application.Run(mainForm);
				}

				if (backupToRestore != null)
				{
					restartApp = true;
					File.Copy(backupToRestore, StomaDB.DB_FILE_NAME, true);
					backupToRestore = null;
				}
				else
				{
					BackupManager.Instance.PerformBackup();
				}
			} while (restartApp);
		}
	}
}
