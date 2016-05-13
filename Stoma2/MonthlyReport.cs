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

        private void UpdateReportListView()
        {
            reportListView.Items.Clear();

            foreach (DoctorRecord rec in StomaDB.GetDoctors())
            {
                var item = new ListViewItem(new string[] {
                    rec.GetFullName(),
					"0"
                });
                item.Tag = rec;
                reportListView.Items.Add(item);
            }
        }
	}
}
