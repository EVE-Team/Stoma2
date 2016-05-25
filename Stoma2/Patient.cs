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
            Utils.SetPanelForm(pnlPatientInfo, Utils.SetupForm(new PatientInfo()));
		}

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NewPatient form = new NewPatient();
            form.RecordForEditing = (ClientRecord)patientListView.SelectedItems[0].Tag;
            form.ShowDialog();

            if (form.BaseModified)
            {
                Program.mainForm.OnClientUpdate();
            }
        }

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var form = new NewPatient();
			form.ShowDialog(this);

            if (form.BaseModified)
            {
                Program.mainForm.OnClientUpdate();
            }
		}

        public void UpdatePatientList()
        {
            patientListView.Items.Clear();

            foreach (ClientRecord rec in StomaDB.GetClients(searchBox.Text))
            {
                var item = new ListViewItem(new string[] {
                    rec.Data.NameLast,
					rec.Data.NameFirst,
                    rec.Data.NamePatronymic
                });
                item.Tag = rec;
                patientListView.Items.Add(item);
            }

            patientListView_SelectedIndexChanged();
        }

        private void patientListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            patientListView_SelectedIndexChanged();
        }

        private void patientListView_SelectedIndexChanged()
        {
            PatientInfo piForm = (PatientInfo)Utils.GetPanelForm(pnlPatientInfo);

            if (patientListView.SelectedItems.Count == 0)
            {
                piForm.ClearInfo();
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                toTreatmentBtn.Enabled = false;
                return;
            }

            ClientRecord rec = (ClientRecord)patientListView.SelectedItems[0].Tag;
            piForm.SetInfo(rec);
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            toTreatmentBtn.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить пациента" +
                "(вместе с ним удалятся все его приемы)?",
                "Удаление пациента", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                ClientRecord rec = (ClientRecord)patientListView.SelectedItems[0].Tag;
                rec.Delete();
                Program.mainForm.OnClientUpdate();
            }
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

            /*if (patientListView.SelectedItems.Count != 0)
            {
                string patient = pnlPatientInfo.Controls[0].Controls[0].Text.ToString();
                Program.mainForm.goToTreatment(patient);
            }*/

            ClientRecord rec = (ClientRecord)patientListView.SelectedItems[0].Tag;
            Program.mainForm.goToTreatment(rec);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            UpdatePatientList();
        }
	}
}
