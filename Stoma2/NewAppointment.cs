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
        private Int64 patientId;

        public NewAppointment(Int64 patientId)
		{
			InitializeComponent();
            this.patientId = patientId;
		}

		private void btnNewPatient_Click(object sender, EventArgs e)
		{
			var form = new NewPatient();
			form.ShowDialog(this);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
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
