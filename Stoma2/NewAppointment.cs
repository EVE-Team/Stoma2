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
		public NewAppointment()
		{
			InitializeComponent();

			Program.SetPanelForm(pnlPatientInfo, Program.SetupForm(new PatientInfo()));
		}

		private void btnNewPatient_Click(object sender, EventArgs e)
		{
			var form = new NewPatient();
			form.ShowDialog(this);
		}
	}
}
