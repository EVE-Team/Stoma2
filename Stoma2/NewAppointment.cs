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
        public ClientRecord clientRecord = null;
        public AppointmentRecord EditRecord = null; 

        public NewAppointment()
		{
			InitializeComponent();           
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
            AppointmentFields newRecord = new AppointmentFields();
            newRecord.Date = DateUtils.GetCurrentTimestamp();
            newRecord.Diagnosis = diagnosisTextBox.Text;
            newRecord.Tooth = Int64.Parse(txtTooth.Text);
            newRecord.DoctorId = doctorRecords[doctorCategory.SelectedIndex].ID;
            if (clientRecord != null)
            {
                newRecord.ClientId = clientRecord.ID;
            }           
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
            if (EditRecord != null)
            {
                this.Text = "Редактирование приема";
                diagnosisTextBox.Text = EditRecord.Data.Diagnosis;
                txtTooth.Text = EditRecord.Data.Tooth.ToString();
                doctorCategory.SelectedIndex = (int)EditRecord.Data.DoctorId - 1;
            }
        }
	}
}
