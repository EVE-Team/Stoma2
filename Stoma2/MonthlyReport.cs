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
            monthReport.Checked = true;
            ShowReportForTheMonth();
		}

        public void UpdateReportListView(string begin, string end)
        {
            reportListView.Items.Clear();
            foreach (ReportRecord rec in StomaDB.GetDoctorAndAmountOfPatients(begin, end))
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
            //UpdateReportListView("", "");
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
                ShowReportForTheMonth();
                return;
            }
            if (yearReport.Checked)
            {
                ShowReportForTheYear();
                return;
            }
            if (changingReport.Checked)
            {
                ShowReportForThePeriod();
                return;
            }
        }

        private void ShowReportForTheMonth()
        {
            DateTime firstDayOfMonth = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
            string fisrtDay = firstDayOfMonth.ToString(DateUtils.INNER_DATE_FORMAT);
            string lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddSeconds(-1).ToString(DateUtils.INNER_DATE_FORMAT);
            UpdateReportListView(fisrtDay, lastDayOfMonth);
        }


        private void ShowReportForTheYear()
        {
            DateTime firstDayOfYear = new DateTime(dateTimePicker1.Value.Year, 1, 1);
            string fisrtDay = firstDayOfYear.ToString(DateUtils.INNER_DATE_FORMAT);
            DateTime lastDayOfYear = firstDayOfYear.AddYears(1).AddSeconds(-1);
            string lastDay = lastDayOfYear.ToString(DateUtils.INNER_DATE_FORMAT);
            UpdateReportListView(fisrtDay, lastDay);
        }


        private void ShowReportForThePeriod()
        {
            DateTime firstDayOfReport = dateTimePicker1.Value;
            string fisrtDay = firstDayOfReport.ToString(DateUtils.INNER_DATE_FORMAT);
            DateTime lastDayOfReport = dateTimePicker2.Value;
            string lastDay = lastDayOfReport.AddDays(1).AddSeconds(-1).ToString(DateUtils.INNER_DATE_FORMAT);

            if (firstDayOfReport < lastDayOfReport)
            {
                UpdateReportListView(fisrtDay, lastDay);
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
