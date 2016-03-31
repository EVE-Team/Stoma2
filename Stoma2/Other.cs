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
	public partial class Other : Form
	{
		Control priceListForm = Program.SetupForm(new PriceList());
		Control reportForm = Program.SetupForm(new MonthlyReport());
		Control patientForm = Program.SetupForm(new Patient());
		Control doctorForm = Program.SetupForm(new Doctor());
		Control backupForm = Program.SetupForm(new BackUp());

		public Other()
		{
			InitializeComponent();

			radioButton7_CheckedChanged(null, null);
		}

		private void radioButton7_CheckedChanged(object sender, EventArgs e)
		{
			Program.SetPanelForm(pnlContent, priceListForm);
		}

		private void radioButton8_CheckedChanged(object sender, EventArgs e)
		{
			Program.SetPanelForm(pnlContent, patientForm);
		}

		private void radioButton9_CheckedChanged(object sender, EventArgs e)
		{
			Program.SetPanelForm(pnlContent, doctorForm);
		}

		private void radioButton11_CheckedChanged(object sender, EventArgs e)
		{
			Program.SetPanelForm(pnlContent, reportForm);
		}

		private void radioButton10_CheckedChanged(object sender, EventArgs e)
		{
			Program.SetPanelForm(pnlContent, backupForm);
		}
	}
}
