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
        PriceList priceListForm = Utils.SetupForm(new PriceList());
        MonthlyReport reportForm = Utils.SetupForm(new MonthlyReport());
        Doctor doctorForm = Utils.SetupForm(new Doctor());
        BackUp backupForm = Utils.SetupForm(new BackUp());
        Visit visitForm = Utils.SetupForm(new Visit());

        public void OnDoctorUpdate()
        {
            doctorForm.UpdateDoctorList();
            reportForm.UpdateReportListView();
        }

        public Other()
		{
			InitializeComponent();

            rbPriceList_CheckedChanged(null, null);
		}

        private void rbPriceList_CheckedChanged(object sender, EventArgs e)
		{
            Utils.SetPanelForm(pnlContent, priceListForm);
		}

        private void rbDoctors_CheckedChanged(object sender, EventArgs e)
		{
            Utils.SetPanelForm(pnlContent, doctorForm);
		}

        private void rbDoctorReport_CheckedChanged(object sender, EventArgs e)
		{
            Utils.SetPanelForm(pnlContent, reportForm);
		}

        private void rbBackup_CheckedChanged(object sender, EventArgs e)
		{
            Utils.SetPanelForm(pnlContent, backupForm);
		}

		private void rbVisits_CheckedChanged(object sender, EventArgs e)
		{
            Utils.SetPanelForm(pnlContent, visitForm);
		}
	}
}
