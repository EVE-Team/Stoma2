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
		Control priceListForm = Utils.SetupForm(new PriceList());
        Control reportForm = Utils.SetupForm(new MonthlyReport());
        Control doctorForm = Utils.SetupForm(new Doctor());
        Control backupForm = Utils.SetupForm(new BackUp());
        Control visitForm = Utils.SetupForm(new Visit());

		public Other()
		{
			InitializeComponent();

			radioButton7_CheckedChanged(null, null);
		}

		private void radioButton7_CheckedChanged(object sender, EventArgs e)
		{
            Utils.SetPanelForm(pnlContent, priceListForm);
		}

		private void radioButton9_CheckedChanged(object sender, EventArgs e)
		{
            Utils.SetPanelForm(pnlContent, doctorForm);
		}

		private void radioButton11_CheckedChanged(object sender, EventArgs e)
		{
            Utils.SetPanelForm(pnlContent, reportForm);
		}

		private void radioButton10_CheckedChanged(object sender, EventArgs e)
		{
            Utils.SetPanelForm(pnlContent, backupForm);
		}

		private void rbVisits_CheckedChanged(object sender, EventArgs e)
		{
            Utils.SetPanelForm(pnlContent, visitForm);
		}
	}
}
