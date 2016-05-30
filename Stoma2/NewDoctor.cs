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
    public partial class NewDoctor : Form
    {
        private bool m_baseModified = false;
		public DoctorRecord RecordForEditing = null;

        public NewDoctor()
        {
            InitializeComponent();
			Utils.SetFontForTextBoxes(this);
			nameFirstBox.ValidationType = ValidatedTextBox.EValidationType.Name;
			nameLastBox.ValidationType = ValidatedTextBox.EValidationType.Name;
			patronymicBox.ValidationType = ValidatedTextBox.EValidationType.NoValidation;
			specialityBox.ValidationType = ValidatedTextBox.EValidationType.NoValidation;
        }

		private void btnApply_Click(object sender, EventArgs e)
		{
			if (!nameFirstBox.Validate() ||
				!nameLastBox.Validate() ||
				!patronymicBox.Validate() ||
				!specialityBox.Validate())
			{
				Utils.ShowInvalidDataWarning(this);
				return;
			}

			if (RecordForEditing == null)
			{
                DoctorFields newRecord = new DoctorFields();
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

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void NewDoctor_Load(object sender, EventArgs e)
		{
			if (RecordForEditing != null)
			{
				Text = "Редактировать доктора";
				btnApply.Text = "Сохранить";
                FieldsToFormData(RecordForEditing.Data);
			}
		}

        private void FormDataToFields(DoctorFields fields)
        {
            fields.FirstName = nameFirstBox.Text;
            fields.LastName = nameLastBox.Text;
            fields.Patronymic = patronymicBox.Text;
            fields.Speciality = specialityBox.Text;
        }

        private void FieldsToFormData(DoctorFields fields)
        {
            nameFirstBox.Text = fields.FirstName;
            nameLastBox.Text = fields.LastName;
            patronymicBox.Text = fields.Patronymic;
            specialityBox.Text = fields.Speciality;
        }
    }
}
