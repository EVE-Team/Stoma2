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
				DoctorRecord.Create(nameFirstBox.Text, nameLastBox.Text, patronymicBox.Text, specialityBox.Text);
			}
			else
			{
				RecordForEditing.FirstName = nameFirstBox.Text;
				RecordForEditing.LastName = nameLastBox.Text;
				RecordForEditing.Patronymic = patronymicBox.Text;
				RecordForEditing.Speciality = specialityBox.Text;
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

				nameFirstBox.Text = RecordForEditing.FirstName;
				nameLastBox.Text = RecordForEditing.LastName;
				patronymicBox.Text = RecordForEditing.Patronymic;
				specialityBox.Text = RecordForEditing.Speciality;
			}
		}
    }
}
