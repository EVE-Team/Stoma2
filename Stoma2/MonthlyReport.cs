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
	public partial class MonthlyReport : Form
	{
		public MonthlyReport()
		{
			InitializeComponent();
            UpdateReportListView();
		}

        public void UpdateReportListView()
        {
            reportListView.Items.Clear();
            foreach (ReportRecord rec in StomaDB.GetDoctorAndAmountOfPatients())
            {
                var item = new ListViewItem(new string[] {
                    rec.GetFullName(),
                    rec.PatientAmount.ToString()
                });
                reportListView.Items.Add(item);
            }
        }

        private void MonthlyReport_Paint(object sender, PaintEventArgs e)
        {
            UpdateReportListView();
        }
	}
}
