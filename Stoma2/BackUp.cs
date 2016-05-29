using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Stoma2
{
	public partial class BackUp : Form
	{
		public BackUp()
		{
			InitializeComponent();
		}

		private void BackUp_Load(object sender, EventArgs e)
		{
			UpdateBackupList();
		}

		private void UpdateBackupList()
		{
			backupListView.Items.Clear();

			var backups = BackupManager.Instance.GetBackupList();
			foreach (BackupManager.BackupInfo backup in backups)
			{
				var item = new ListViewItem(new string[] {
					backup.BackupDate.ToString("d MMMM yyyy"),
					Utils.FormatFileSize(backup.FileSize)
				});
				item.Tag = backup;

				backupListView.Items.Add(item);
			}
		}

		private void backupListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			restoreBtn.Enabled = backupListView.SelectedItems.Count > 0;
		}

		private void restoreBtn_Click(object sender, EventArgs e)
		{
			(backupListView.SelectedItems[0].Tag as BackupManager.BackupInfo).Restore();
		}

		private void offloadBtn_Click(object sender, EventArgs e)
		{
			var folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.Description = "Выберите каталог, куда необходимо скопировать программу";
			folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
			folderBrowserDialog.SelectedPath = Directory.GetDirectoryRoot(Environment.CurrentDirectory);
			folderBrowserDialog.ShowNewFolderButton = true;

			if (folderBrowserDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
			{
				BackupManager.Instance.PerformFullBackup(folderBrowserDialog.SelectedPath);
			}
		}
	}
}
