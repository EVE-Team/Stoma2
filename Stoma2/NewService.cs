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
        private Int64 id;
        public ServiceListRecord RecordForEditing = null;
        private bool m_baseModified = false;

        public NewService(Int64 id)
        {
            InitializeComponent();
            this.id = id;
        }

        public bool BaseModified
        {
            get { return m_baseModified; }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (RecordForEditing == null)
            {
                ServiceListFields newRecord = new ServiceListFields();
                FormDataToFields(newRecord);
                newRecord.CategoryId = id;
                newRecord.Create();
            }
            else
            {
                FormDataToFields(RecordForEditing.Data);
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
                FieldsToFormData(RecordForEditing.Data);
            }
        }

        private void FormDataToFields(ServiceListFields fields)
        {
            fields.Name = serviceNameTxt.Text;
            fields.Price = (long)servicePrice.Value;
        }

        private void FieldsToFormData(ServiceListFields fields)
        {
            serviceNameTxt.Text = fields.Name;
            servicePrice.Value = fields.Price;
        }
    }
}
