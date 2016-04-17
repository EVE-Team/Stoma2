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

			Program.SetPanelForm(pnlPatientInfo, Program.SetupForm(new PatientInfo()));
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
                patientListView.Items.Add(new ListViewItem(new string[] {
                    reader["name_last"].ToString(),
                    reader["name_first"].ToString()
                }));
            }
        }
	}
}
