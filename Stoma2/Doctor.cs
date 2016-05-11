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
            UpdateDoctorList();
		}

        private void button8_Click(object sender, EventArgs e)
        {
            NewDoctor form = new NewDoctor();
            form.ShowDialog();

            if (form.BaseModified)
            {
                UpdateDoctorList();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NewDoctor form = new NewDoctor();
			form.RecordForEditing = (DoctorRecord)doctorListView.SelectedItems[0].Tag;
            form.ShowDialog();

			if (form.BaseModified)
			{
				UpdateDoctorList();
			}
        }

        private void UpdateDoctorList()
        {
            doctorListView.Items.Clear();

			foreach (DoctorRecord rec in StomaDB.GetDoctors(searchBox.Text))
			{
				var item = new ListViewItem(new string[] {
                    rec.Data.LastName,
					rec.Data.FirstName
                });
				item.Tag = rec;
				doctorListView.Items.Add(item);
			}
        }

        private void doctorListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doctorListView.SelectedItems.Count == 0)
            {
                doctorName.Clear();
                doctorSpeciality.Clear();

                editBtn.Enabled = false;
                delBtn.Enabled = false;

                return;
            }

			DoctorRecord rec = (DoctorRecord)doctorListView.SelectedItems[0].Tag;
			doctorName.Text = rec.GetFullName();
            doctorSpeciality.Text = rec.Data.Speciality;

            editBtn.Enabled = true;
            delBtn.Enabled = true;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
			DoctorRecord rec = (DoctorRecord)doctorListView.SelectedItems[0].Tag;
			rec.Delete();
            UpdateDoctorList();
        }

		private void searchBox_TextChanged(object sender, EventArgs e)
		{
			UpdateDoctorList();
		}
    }
}
