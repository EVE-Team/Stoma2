using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Stoma2
{
    class Utils
    {
        public static T SetupForm<T>(T form) where T : Form
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            return form;
        }

        public static void SetPanelForm(Panel panel, Control form)
        {
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

        public static Control GetPanelForm(Panel panel)
        {
            if (panel.Controls.Count != 1)
                throw new Exception("Unexpected control count");
            return panel.Controls[0];
        }

        public static string[] SliceArray(string[] array, int[] indices)
        {
            List<string> result = new List<string>();

            foreach (int index in indices)
            {
                result.Add(array[index]);
            }

            return result.ToArray();
        }

        public static bool IsInt64(object obj)
        {
            return obj.GetType().FullName == "System.Int64";
        }

        public static string DateToString(DateTime date)
        {
            if (date != DateTime.MinValue)
            {
                return date.ToString("d");
            }
            else
            {
                return "";
            }
        }

		public static string FormatFileSize(Int64 fileSize)
		{
			string[] sizes = { "Байт", "КБ", "МБ", "ГБ", "ТБ" };
			double len = fileSize;
			int order = 0;
			while (len >= 1024 && order + 1 < sizes.Length)
			{
				order++;
				len = len / 1024;
			}

			// Adjust the format string to your preferences. For example "{0:0.#}{1}" would
			// show a single decimal place, and no space.
			return String.Format("{0:0.##} {1}", len, sizes[order]);
		}

		// From https://msdn.microsoft.com/en-us/library/bb762914.aspx
		public static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
		{
			// Get the subdirectories for the specified directory.
			DirectoryInfo dir = new DirectoryInfo(sourceDirName);

			if (!dir.Exists)
			{
				throw new DirectoryNotFoundException(
					"Source directory does not exist or could not be found: "
					+ sourceDirName);
			}

			DirectoryInfo[] dirs = dir.GetDirectories();
			// If the destination directory doesn't exist, create it.
			if (!Directory.Exists(destDirName))
			{
				Directory.CreateDirectory(destDirName);
			}

			// Get the files in the directory and copy them to the new location.
			FileInfo[] files = dir.GetFiles();
			foreach (FileInfo file in files)
			{
				string temppath = Path.Combine(destDirName, file.Name);
				file.CopyTo(temppath, false);
			}

			// If copying subdirectories, copy them and their contents to new location.
			if (copySubDirs)
			{
				foreach (DirectoryInfo subdir in dirs)
				{
					string temppath = Path.Combine(destDirName, subdir.Name);
					DirectoryCopy(subdir.FullName, temppath, copySubDirs);
				}
			}
		}
    }

    class DateUtils
    {
        public static readonly string INNER_DATE_FORMAT = "yyyy-MM-dd HH:mm";
        public static readonly string EXTERNAL_DATE_FORMAT = "dd-MM-yyyy HH:mm";
        public static readonly string WITHOUT_TIME_DATE_FORMAT = "dd-MM-yyyy";
        
        public static string GetCurrentTimestamp()
        {
            return DateTime.Now.ToString(INNER_DATE_FORMAT);
        }

        public static string ToDateFormat(string date, string DATE_FORMAT)
        {
            string res;
            try
            {
                res = DateTime.Parse(date).ToString(DATE_FORMAT);
            }
            catch (Exception)
            {
                res = "";
            }
            return res;
        }
    }
}
