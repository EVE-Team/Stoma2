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
	public partial class Invite : Form
	{

        private static readonly String DEFAULT_TEXT_FOR_LABEL_NUMBER_OF_PATIENT = " пациента ожидают повторного приглашения";
		public Invite()
		{
			InitializeComponent();

            Utils.SetPanelForm(pnlPatientInfo, Utils.SetupForm(new PatientInfo()));
            UpdatePatientListView();
            btnMarkAsInvited.Enabled = false;
		}

        private void UpdatePatientListView()
        {
            patientListView.Items.Clear();
            int numberOfPatients = 0;
            foreach (ClientRecord rec in StomaDB.GetPatientsToInvite())
            {
                numberOfPatients++;
                var item = new ListViewItem(new string[] {
                    rec.Data.NameLast,
                    rec.Data.NameFirst,
                    rec.Data.NamePatronymic,
                    rec.Data.Phone
                });
                item.Tag = rec;
                patientListView.Items.Add(item);
            }
            try
            {
                if (numberOfPatients == 0)
                {
                    Program.mainForm.DrawInviteImage();
                }
            }
            catch (NullReferenceException)
            {
            }
            lblNumberOfPatient.Text = numberOfPatients.ToString() + DEFAULT_TEXT_FOR_LABEL_NUMBER_OF_PATIENT;
        }

        private void patientListView_SelectedIndexChanged(object sender, EventArgs e)
        {

            PatientInfo piForm = (PatientInfo)Utils.GetPanelForm(pnlPatientInfo);

            if (patientListView.SelectedItems.Count == 0)
            {
                piForm.ClearInfo();
                btnMarkAsInvited.Enabled = false;
                return;
            }

            ClientRecord rec = (ClientRecord)patientListView.SelectedItems[0].Tag;
            piForm.SetInfo(rec);
            btnMarkAsInvited.Enabled = true;
        }

        private void btnMarkAsInvited_Click(object sender, EventArgs e)
        {
            ClientRecord rec = (ClientRecord)patientListView.SelectedItems[0].Tag;
            StomaDB.MarkAsInvited(rec.ID);
            UpdatePatientListView();
            btnMarkAsInvited.Enabled = false;
        }
	}
}
