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
        public AppointmentRecord appointment;
        public TreatmentRecord editRecord;

        private List<CategoryRecord> categoryRecords = new List<CategoryRecord>();
        private List<ServiceListRecord> serviceListRecords = new List<ServiceListRecord>();

        public NewTreatment()
		{
			InitializeComponent();

            foreach (CategoryRecord rec in StomaDB.GetCategories())
            {
                cbCategory.Items.Add(rec.Data.Name);
                categoryRecords.Add(rec);
            }
        }

        private void NewTreatment_Load(object sender, EventArgs e)
        {
            if (editRecord != null)
            {
                Text = "Редактировать работу";
                btnOk.Text = "Сохранить";
				btnOk.Size = new Size(134, 37);

                FieldsToFormData(editRecord.Data);
            }
        }

		private void btnOk_Click(object sender, EventArgs e)
		{
            if (editRecord == null)
            {
                TreatmentFields newRecord = new TreatmentFields();
                newRecord.VisitId = appointment.ID;
                FormDataToFields(newRecord);
                newRecord.Create();
            }
            else
            {
                FormDataToFields(editRecord.Data);
                editRecord.Save();
            }

            Close();
		}

        private void FormDataToFields(TreatmentFields fields)
        {
            fields.ServiceId = serviceListRecords[cbService.SelectedIndex].ID;
            fields.Count = Convert.ToInt64(countNum.Value);
        }

        private void FieldsToFormData(TreatmentFields fields)
        {
            Int64 catId = StomaDB.Instance.GetCategoryIdByServiceId(fields.ServiceId);

			int index = 0;
			if (cbCategory.Items.Count > 0 && GetIndexOfRecord(categoryRecords, catId, ref index))
			{
				cbCategory.SelectedIndex = index;
			}
			if (cbService.Items.Count > 0 && GetIndexOfRecord(serviceListRecords, fields.ServiceId, ref index))
			{
				cbService.SelectedIndex = index;
			}

            countNum.Value = fields.Count;
        }

        private static bool GetIndexOfRecord<T>(List<T> list, Int64 id, ref int result) where T : DatabaseRecord
        {
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].ID == id)
                {
					result = i;
                    return true;
                }
            }

			return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void NewTreatment_Paint(object sender, PaintEventArgs e)
		{
			var gr = e.Graphics;
			Utils.DrawBorderAroundControl(gr, cbCategory);
			Utils.DrawBorderAroundControl(gr, cbService);
		}

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbService.Items.Clear();
            serviceListRecords.Clear();

            if (cbCategory.SelectedIndex >= 0)
            {
                CategoryRecord catRec = categoryRecords[cbCategory.SelectedIndex];

                foreach (ServiceListRecord rec in StomaDB.GetServiceList(catRec.ID, 0))
                {
                    cbService.Items.Add(rec.Data.Name);
                    serviceListRecords.Add(rec);
                }
            }

			UpdateAcceptButtonState();
        }

		private void UpdateAcceptButtonState()
		{
			btnOk.Enabled = (cbCategory.SelectedIndex >= 0) && (cbService.SelectedIndex >= 0);
		}

		private void cbService_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateAcceptButtonState();
		}
	}
}
