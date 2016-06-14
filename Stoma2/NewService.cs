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
    public partial class NewService : Form
    {
        public ServiceListRecord RecordForEditing = null;

		private Int64 m_categoryID;
        private bool m_baseModified = false;

		public NewService(Int64 categoryID)
        {
            InitializeComponent();
			Utils.SetFontForTextBoxes(this);
			serviceNameTxt.ValidationType = ValidatedTextBox.EValidationType.NotEmpty;

			m_categoryID = categoryID;
        }

        public bool BaseModified
        {
            get { return m_baseModified; }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
			if (!serviceNameTxt.Validate())
			{
				Utils.ShowInvalidDataWarning(this);
				return;
			}

            if (RecordForEditing == null)
            {
                ServiceListFields newRecord = new ServiceListFields();
                FormDataToFields(newRecord);
                newRecord.Create();
            }
            else
            {
                ServiceListFields newRecord = new ServiceListFields();
                FormDataToFields(newRecord);
                newRecord.Create();

                RecordForEditing.Data.Obsolete = true;
                RecordForEditing.Save();
            }

            m_baseModified = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            if (RecordForEditing != null)
            {
                Text = "Редактировать услугу";
                btnApply.Text = "Сохранить";
				FormFieldsToData(RecordForEditing.Data);
            }
        }

        private void FormDataToFields(ServiceListFields fields)
        {
            fields.Name = serviceNameTxt.Text;
            fields.Price = (long)servicePrice.Value;
			fields.CategoryId = m_categoryID;
        }

		private void FormFieldsToData(ServiceListFields fields)
        {
            serviceNameTxt.Text = fields.Name;
            servicePrice.Value = fields.Price;
        }
    }
}
