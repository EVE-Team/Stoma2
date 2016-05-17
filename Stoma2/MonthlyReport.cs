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
            var reader = StomaDB.Instance.GetDoctorAndAmountOfPatients();
            while (reader.Read())
            {                
                var item = new ListViewItem(new string[] {                    
                    DatabaseUtils.DecodeString(reader.GetString(0)),
                    reader.GetValue(1).ToString()                   
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
