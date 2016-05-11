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
        }

		private void btnApply_Click(object sender, EventArgs e)
		{
			if (RecordForEditing == null)
			{
                DoctorFields f = new DoctorFields();
                f.FirstName = nameFirstBox.Text;
                f.LastName = nameLastBox.Text;
                f.Patronymic = patronymicBox.Text;
                f.Speciality = specialityBox.Text;
                f.Create();
			}
			else
			{
                RecordForEditing.Data.FirstName = nameFirstBox.Text;
                RecordForEditing.Data.LastName = nameLastBox.Text;
                RecordForEditing.Data.Patronymic = patronymicBox.Text;
                RecordForEditing.Data.Speciality = specialityBox.Text;
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

                nameFirstBox.Text = RecordForEditing.Data.FirstName;
                nameLastBox.Text = RecordForEditing.Data.LastName;
                patronymicBox.Text = RecordForEditing.Data.Patronymic;
                specialityBox.Text = RecordForEditing.Data.Speciality;
			}
		}
    }
}
