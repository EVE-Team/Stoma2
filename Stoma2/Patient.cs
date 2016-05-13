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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NewPatient form = new NewPatient();
            form.RecordForEditing = (ClientRecord)patientListView.SelectedItems[0].Tag;
            form.ShowDialog();

            if (form.BaseModified)
            {
                UpdatePatientList();
            }
        }

		private void btnAdd_Click(object sender, EventArgs e)
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

            foreach (ClientRecord rec in StomaDB.GetClients(searchBox.Text))
            {
                var item = new ListViewItem(new string[] {
                    rec.Data.NameLast,
					rec.Data.NameFirst
                });
                item.Tag = rec;
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
                //btnAddAppointment.Enabled = false;
                return;
            }

            ClientRecord rec = (ClientRecord)patientListView.SelectedItems[0].Tag;
            piForm.SetInfo(rec);
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            //btnAddAppointment.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClientRecord rec = (ClientRecord)patientListView.SelectedItems[0].Tag;
            rec.Delete();
            UpdatePatientList();
        }

        private void toTreatmentBtn_Click(object sender, EventArgs e)
        {
            //Program.mainForm.goToTreatment();
            //Control.ControlCollection col = pnlPatientInfo.Controls[0].Controls[0].Text.ToString();
            //Control panel = col[0];
            //Control.ControlCollection col1 = panel.Controls;
            //Control textBox = col1[0];
            //string t = textBox.Text.ToString();
            //ListViewItem.ListViewSubItemCollection temp = patientListView.FocusedItem.SubItems;

            if (patientListView.SelectedItems.Count != 0)
            {
                string patient = pnlPatientInfo.Controls[0].Controls[0].Text.ToString();
                Program.mainForm.goToTreatment(patient);
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            UpdatePatientList();
        }
	}
}
