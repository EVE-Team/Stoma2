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
        private ContextMenu ctxMenu;
		public Patient()
		{
			InitializeComponent();
            Utils.SetPanelForm(pnlPatientInfo, Utils.SetupForm(new PatientInfo()));
			searchBox.TextChanged += searchBox_TextChanged;

            ctxMenu = new ContextMenu();
            MenuItem patientMenuEdit = new MenuItem("Редактировать");
            MenuItem patientMenuDelete = new MenuItem("Удалить");
            patientMenuEdit.Click += new EventHandler(patientMenuEdit_Click);
            patientMenuDelete.Click += new EventHandler(patientMenuDelete_Click);
            ctxMenu.MenuItems.Add(patientMenuEdit);
            ctxMenu.MenuItems.Add(patientMenuDelete);           
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
            if (MessageBox.Show("Вы действительно хотите удалить пациента?\n" +
                "(вместе с ним удалятся все его приемы)",
                "Удаление пациента", MessageBoxButtons.YesNo,
				MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                ClientRecord rec = (ClientRecord)patientListView.SelectedItems[0].Tag;
                rec.Delete();
                Program.mainForm.OnClientUpdate();
            }
        }

        private void toTreatmentBtn_Click(object sender, EventArgs e)
        {
            ClientRecord rec = (ClientRecord)patientListView.SelectedItems[0].Tag;
            Program.mainForm.goToTreatment(rec);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            UpdatePatientList();
        }

<<<<<<< HEAD
		private void patientListView_DoubleClick(object sender, EventArgs e)
		{
			if (patientListView.SelectedItems.Count > 0)
			{
				toTreatmentBtn_Click(sender, e);
			}
		}
=======
        private void patientListView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {  
                ListViewItem item = patientListView.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    ctxMenu.Show(patientListView, e.Location);
                }
            }
        }

        private void patientMenuDelete_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }

        private void patientMenuEdit_Click(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);           
        }
>>>>>>> origin/master
	}
}
