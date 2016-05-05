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
        private List<int> idList = new List<int>();
        private int patientId;

        public NewAppointment(int patientId)
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

		private void button8_Click(object sender, EventArgs e)
		{
			Close();
		}

        private void NewAppointment_Load(object sender, EventArgs e)
        {
            var reader = StomaDB.Instance.GetDoctorsReader();

            while (reader.Read())
            {
                idList.Add(Convert.ToInt32(reader["id"].ToString()));
                doctorCategory.Items.Add(reader["name_last"].ToString() + " " + reader["name_first"].ToString());
            }
        }
	}
}
