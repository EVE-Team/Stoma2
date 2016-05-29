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

				try
				{
					mainForm = new MainForm();
					Application.Run(mainForm);
					BackupManager.Instance.PerformBackup();
				}
				catch (BackupManager.BackupRestoreException ex)
				{
					restartApp = true;

					File.Copy(ex.BackupName, StomaDB.DB_FILE_NAME, true);
				}
			} while (restartApp);
		}
	}
}
