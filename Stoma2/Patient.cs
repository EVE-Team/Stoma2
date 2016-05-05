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
	public partial class Patient : Form
	{
		public Patient()
		{
			InitializeComponent();
            UpdatePatientList();

            Utils.SetPanelForm(pnlPatientInfo, Utils.SetupForm(new PatientInfo()));
		}

        private void button7_Click(object sender, EventArgs e)
        {
            var form = new NewPatient();
            form.Text = "Редактирование пациента";
			form.btnApply.Text = "Сохранить";
            form.ShowDialog(this);
        }

		private void button1_Click(object sender, EventArgs e)
		{
			var form = new NewAppointment();
			form.ShowDialog(this);
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			var form = new NewPatient();
			form.ShowDialog(this);

            if (form.BaseModified)
            {
                UpdatePatientList();
            }

		}

        private void UpdatePatientList()
        {
            patientListView.Items.Clear();
            var reader = StomaDB.Instance.GetClientsReader();

            while (reader.Read())
            {
                var item = new ListViewItem(new string[] {
                    reader["name_last"].ToString(),
                    reader["name_first"].ToString()
                });
                item.Tag = new Utils.IdObject(Convert.ToInt32(reader["id"].ToString()));
                patientListView.Items.Add(item);
            }
        }

        private void patientListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            PatientInfo piForm = (PatientInfo)Utils.GetPanelForm(pnlPatientInfo);

            if (patientListView.SelectedItems.Count == 0)
            {
                piForm.ClearInfo();
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                return;
            }

            int id = ((Utils.IdObject)(patientListView.SelectedItems[0].Tag)).id;
            piForm.SetInfo(id);
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = ((Utils.IdObject)(patientListView.SelectedItems[0].Tag)).id;
            StomaDB.Instance.DeleteClient(id);
            UpdatePatientList();
        }
	}
}
