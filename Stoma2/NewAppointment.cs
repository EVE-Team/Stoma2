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
	public partial class NewAppointment : Form
	{
        private List<DoctorRecord> doctorRecords = new List<DoctorRecord>();
        private ClientRecord clientRecord;

        public NewAppointment(ClientRecord clientRecord)
		{
			InitializeComponent();
            this.clientRecord = clientRecord;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
            AppointmentFields newRecord = new AppointmentFields();
            newRecord.Date = StomaDB.Instance.GetCurrentTimestamp();
            newRecord.Diagnosis = diagnosisTextBox.Text;
            newRecord.Tooth = Int64.Parse(txtTooth.Text);
            newRecord.DoctorId = doctorRecords[doctorCategory.SelectedIndex].ID;
            newRecord.ClientId = clientRecord.ID;
            newRecord.Create();
			Close();
		}

        private void NewAppointment_Load(object sender, EventArgs e)
        {
            foreach (DoctorRecord rec in StomaDB.GetDoctors())
            {
                doctorCategory.Items.Add(rec.GetFullName());
                doctorRecords.Add(rec);
            }
        }
	}
}
