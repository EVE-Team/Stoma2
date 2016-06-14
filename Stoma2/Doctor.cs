using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stoma2
{
	public partial class Doctor : Form
	{
		public Doctor()
		{
			InitializeComponent();
			searchBox.TextChanged += searchBox_TextChanged;
		}

        private void addBtn_Click(object sender, EventArgs e)
        {
            NewDoctor form = new NewDoctor();
            form.ShowDialog();

            if (form.BaseModified)
            {
                Program.mainForm.OnDoctorUpdate();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            NewDoctor form = new NewDoctor();
			form.RecordForEditing = (DoctorRecord)doctorListView.SelectedItems[0].Tag;
            form.ShowDialog();

			if (form.BaseModified)
			{
                Program.mainForm.OnDoctorUpdate();
			}
        }

        public void UpdateDoctorList()
        {
            doctorListView.Items.Clear();

			foreach (DoctorRecord rec in StomaDB.GetDoctors(searchBox.Text))
			{
				var item = new ListViewItem(new string[] {
                    rec.Data.LastName,
					rec.Data.FirstName,
                    rec.Data.Patronymic,
                    rec.Data.Speciality
                });
				item.Tag = rec;
				doctorListView.Items.Add(item);
			}

            doctorListView_SelectedIndexChanged();
        }

        private void doctorListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            doctorListView_SelectedIndexChanged();
        }

        private void doctorListView_SelectedIndexChanged()
        {
            if (doctorListView.SelectedItems.Count == 0)
            {
                editBtn.Enabled = false;
                delBtn.Enabled = false;

                return;
            }

            editBtn.Enabled = true;
            delBtn.Enabled = true;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Вы действительно хотите удалить данного врача?",
				"Удаление врача", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
			{
				DoctorRecord rec = (DoctorRecord)doctorListView.SelectedItems[0].Tag;
				DoctorFields data = rec.Data;
				data.Obsolete = true;
				rec.Save();

				Program.mainForm.OnDoctorUpdate();
			}
        }

		private void searchBox_TextChanged(object sender, EventArgs e)
		{
			UpdateDoctorList();
		}
    }
}
