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
            monthReport.Checked = true;
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (changingReport.Checked == true)
            {
                dateTimePicker2.Visible = true;
            }
            else
            {
                dateTimePicker2.Visible = false;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (monthReport.Checked)
            {
                DateTime firstDayOfMonth = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
                DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
                return;
            }
            if (yearReport.Checked)
            {
                DateTime firstDayOfYear = new DateTime(dateTimePicker1.Value.Year, 1, 1);
                DateTime lastDayOfYear = firstDayOfYear.AddYears(1).AddDays(-1);
                return;
            }
            if (changingReport.Checked)
            {
                DateTime firstDayOfReport = dateTimePicker1.Value;
                DateTime lastDayOfReport = dateTimePicker2.Value;

                if (firstDayOfReport < lastDayOfReport)
                {
                    return;
                }

                return;
            }
        }

        //private DateTime GetStartDateReportWeek(DateTime value)
        //{
        //    int diff = value.DayOfWeek - DayOfWeek.Monday;
        //    if (diff < 0)
        //    {
        //        diff += 7;
        //    }
        //    return value.AddDays(-1 * diff).Date;
        //}

        //private DateTime GetEndDateReportWeek(DateTime value)
        //{
        //    int diff = value.DayOfWeek - DayOfWeek.Sunday;
        //    if (diff > 0)
        //    {
        //        diff -= 7;
        //    }
        //    return value.AddDays(-1 * diff).Date;
        //}
	}
}
