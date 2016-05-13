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
	public partial class NewTreatment : Form
	{
        private AppointmentRecord appointment;
        private List<CategoryRecord> categoryRecords = new List<CategoryRecord>();
        private List<ServiceListRecord> serviceListRecords = new List<ServiceListRecord>();

        public NewTreatment(AppointmentRecord appointment)
		{
			InitializeComponent();
            this.appointment = appointment;

            foreach (CategoryRecord rec in StomaDB.GetCategories())
            {
                cbCategory.Items.Add(rec.Data.Name);
                categoryRecords.Add(rec);
            }
        }

		private void btnOk_Click(object sender, EventArgs e)
		{
            TreatmentFields newRecord = new TreatmentFields();
            newRecord.ServiceId = serviceListRecords[cbService.SelectedIndex].ID;
            newRecord.VisitId = appointment.ID;
            newRecord.Count = Convert.ToInt64(countNum.Value);
            newRecord.Create();
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void NewTreatment_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(cbCategory.Location.X - 1, cbCategory.Location.Y - 1,
				cbCategory.Size.Width + 1, cbCategory.Size.Height + 1));
		}

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbService.Items.Clear();
            serviceListRecords.Clear();

            if (cbCategory.SelectedIndex >= 0)
            {
                CategoryRecord catRec = categoryRecords[cbCategory.SelectedIndex];

                foreach (ServiceListRecord rec in StomaDB.GetServiceList(catRec.ID))
                {
                    cbService.Items.Add(rec.Data.Name);
                    serviceListRecords.Add(rec);
                }
            }
        }
	}
}
