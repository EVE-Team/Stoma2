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
    public partial class NewCategory : Form
    {
        private bool m_baseModified = false;
        public CategoryRecord RecordForEditing = null;

        public NewCategory()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (RecordForEditing == null)
            {
                CategoryFields newRecord = new CategoryFields();
                FormDataToFields(newRecord);
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

        public bool BaseModified
        {
            get { return m_baseModified; }
        }

        private void FormDataToFields(CategoryFields fields)
        {
            fields.Name = categoryNameTxt.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            if (RecordForEditing != null)
            {
                Text = "Редактировать пациента";
                btnApply.Text = "Сохранить";
                FieldsToFormData(RecordForEditing.Data);
            }
        }

        private void FieldsToFormData(CategoryFields fields)
        {
            categoryNameTxt.Text = fields.Name;
        }
    }
}
