using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Stoma2
{
	static class Program
	{
		public static MainForm mainForm;
		public static string backupToRestore = null;

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool SetForegroundWindow(IntPtr hWnd);

		static private bool IsOtherInstanceOpen()
		{
			Process current = Process.GetCurrentProcess();
			foreach (Process process in Process.GetProcessesByName(current.ProcessName))
			{
				if (process.Id != current.Id)
				{
					SetForegroundWindow(process.MainWindowHandle);
					return true;
				}
			}
			return false;
		}

        /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			if (IsOtherInstanceOpen())
			{
				return;
			}

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
