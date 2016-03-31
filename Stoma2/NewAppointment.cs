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
		}

		private void Appointment_Load(object sender, EventArgs e)
		{
			Program.SetPanelForm(pnlContents, Program.SetupForm(new Appointment()));
		}
	}
}
