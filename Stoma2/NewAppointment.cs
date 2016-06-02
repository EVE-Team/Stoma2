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
	public partial class NewAppointment : Form
	{
        public ClientRecord clientRecord = null;
        public AppointmentRecord EditRecord = null; 

        public NewAppointment()
		{
			InitializeComponent();
			Utils.SetFontForTextBoxes(this);
			txtTooth.ValidationType = ValidatedTextBox.EValidationType.Tooth;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			// validation
			if (cmbDiagnosis.Text == "")
			{
				cmbDiagnosisBorder = Color.Red;
				Refresh();
			}

			if (!txtTooth.Validate() ||
				cmbDiagnosis.Text == "" ||
				doctorCategory.SelectedIndex < 0)
			{
				Utils.ShowInvalidDataWarning(this);
				return;
			}
			//

			if (EditRecord == null)
            {
                AppointmentFields newRecord = new AppointmentFields();
                FormDataToFields(newRecord);
                newRecord.Date = DateUtils.GetCurrentTimestamp();
                newRecord.ClientId = clientRecord.ID;
                newRecord.Create();

				StomaDB.MarkAsInvited(clientRecord.ID);
            }
            else
            {
                FormDataToFields(EditRecord.Data);
                EditRecord.Save();
            }                   
			Close();
		}

		class DoctorItem : object
		{
			public DoctorItem(DoctorRecord rec)
			{
				m_rec = rec;
				Text = rec.GetFullName();
			}

			public string Text { get; set; }

			public DoctorRecord Record { get { return m_rec; } }
			private DoctorRecord m_rec;

			public override string ToString()
			{
				return Text;
			}
		}

        private void NewAppointment_Load(object sender, EventArgs e)
        {
			Int64 doctorId = EditRecord != null ? EditRecord.Data.DoctorId : -1;

			var doctors = new List<DoctorItem>();
			bool doctorAdded = false;
            foreach (DoctorRecord rec in StomaDB.GetDoctors())
            {
				doctors.Add(new DoctorItem(rec));
				if (doctorId == rec.ID)
				{
					doctorAdded = true;
				}
            }
			
			if (doctorId != -1 && !doctorAdded)
			{
				doctors.Add(new DoctorItem(StomaDB.Instance.GetDoctorById(doctorId)));
			}

			doctors.Sort(Comparer<DoctorItem>.Create((i1, i2) => i1.Text.CompareTo(i2.Text)));

			foreach (var item in doctors)
			{
				doctorCategory.Items.Add(item);
				if (item.Record.ID == doctorId)
				{
					doctorCategory.SelectedIndex = doctorCategory.Items.Count - 1;
				}
			}

			if (EditRecord != null)
			{
				this.Text = "Редактирование приема";
				btnAdd.Text = "Сохранить";
				btnAdd.Size = new Size(133, 41);

				cmbDiagnosis.Text = EditRecord.Data.Diagnosis;
				txtTooth.Text = EditRecord.Data.Tooth.ToString();
			}
			else
			{
				if (doctorCategory.Items.Count > 0)
				{
					doctorCategory.SelectedIndex = 0;
				}
			}
        }

        private void FormDataToFields(AppointmentFields fields)
        {            
            fields.Diagnosis = cmbDiagnosis.Text;
            fields.Tooth = Int64.Parse(txtTooth.Text);
			fields.DoctorId = (doctorCategory.SelectedItem as DoctorItem).Record.ID;
        }

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			Color borderColor = doctorCategory.Items.Count > 0 ? Color.Green : Color.Red;
			e.Graphics.DrawRectangle(new Pen(borderColor),
				new Rectangle(doctorCategory.Location.X - 1 - pictureBox1.Location.X,
					doctorCategory.Location.Y - 1 - pictureBox1.Location.Y,
				doctorCategory.Size.Width + 1, doctorCategory.Size.Height + 1));
		}

		private Color cmbDiagnosisBorder = Color.DarkGray;
		private void UpdateCmbDiagnosis()
		{
			cmbDiagnosisBorder = cmbDiagnosis.Text == "" ? Color.Red : Color.Green;
			Refresh();
		}

		private void cmbDiagnosis_TextUpdate(object sender, EventArgs e)
		{
			UpdateCmbDiagnosis();
		}

		private void NewAppointment_Paint(object sender, PaintEventArgs e)
		{
			Utils.DrawBorderAroundControl(e.Graphics, cmbDiagnosis, cmbDiagnosisBorder);
		}

		private void cmbDiagnosis_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateCmbDiagnosis();
		}
	}
}
