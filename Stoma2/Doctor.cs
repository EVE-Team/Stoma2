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
            AddDoctor form = new AddDoctor();
            form.ShowDialog();

            if (form.BaseModified)
            {
                UpdateDoctorList();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddDoctor form = new AddDoctor();
            form.Text = "Редактировать доктора";
			form.btnApply.Text = "Сохранить";
            form.ShowDialog();
        }

        private void UpdateDoctorList()
        {
            doctorListView.Items.Clear();
            var reader = StomaDB.Instance.GetDoctorsReader();

            while (reader.Read())
            {
                var item = new ListViewItem(new string[] {
                    reader["name_last"].ToString(),
                    reader["name_first"].ToString()
                });
                item.Tag = new Utils.IdObject(Convert.ToInt32(reader["id"].ToString()));
                doctorListView.Items.Add(item);
            }
        }

        private void doctorListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doctorListView.SelectedItems.Count == 0)
            {
                doctorName.Clear();
                doctorSpeciality.Clear();
                return;
            }

            int id = ((Utils.IdObject)(doctorListView.SelectedItems[0].Tag)).id;
            var data = StomaDB.Instance.GetDoctorReader(id);

            doctorName.Text = data["name_last"].ToString() +
                data["name_first"].ToString() +
                data["name_patronymic"].ToString();

            doctorSpeciality.Text = data["speciality"].ToString();
        }
    }
}
