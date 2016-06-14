using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;


namespace Stoma2
{
	public partial class Treatment : Form
	{
        //русская локализация Times New Roman
        private static BaseFont baseFont = BaseFont.CreateFont(@"TIMCYR.TTF", System.Text.Encoding.GetEncoding(1251).BodyName, true);
        private iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 11f, iTextSharp.text.Font.NORMAL);
        private iTextSharp.text.Font font1 = new iTextSharp.text.Font(baseFont, 11f, iTextSharp.text.Font.NORMAL);
        private iTextSharp.text.Font font2 = new iTextSharp.text.Font(baseFont, 12f, iTextSharp.text.Font.BOLD);
        private iTextSharp.text.Font font3 = new iTextSharp.text.Font(baseFont, 6f, iTextSharp.text.Font.BOLD);

        private float minimumRowHeight = 15;
        private ContextMenu appointmentMenu;

        private ClientRecord clientRecord;

		public Treatment()
		{
			InitializeComponent();
            appointmentMenu = new ContextMenu();
            MenuItem appointmentMenuEdit = new MenuItem("Редактировать");
            MenuItem appointmentMenuDelete = new MenuItem("Удалить");
            appointmentMenuEdit.Click += new EventHandler(appointmentMenuEdit_Click);
            appointmentMenuDelete.Click += new EventHandler(appointmentMenuDelete_Click);

            appointmentMenu.MenuItems.Add(appointmentMenuEdit);
            appointmentMenu.MenuItems.Add(appointmentMenuDelete);

            appointmentListView.ContextMenu = appointmentMenu;
		}

        public void SetClient(ClientRecord clientRecord)
        {
            this.clientRecord = clientRecord;

            //----------

            if (clientRecord != null)
            {
                patientFIO.Text = clientRecord.GetFullName();
            }
            else
            {
                patientFIO.Text = "";
            }

            //----------

            UpdateAppointmentList();
            btnAddAppointment.Enabled = (clientRecord != null);
        }

		public bool IsClientAssigned()
		{
			return clientRecord != null;
		}

        private void UpdateAppointmentList()
        {
            appointmentListView.Items.Clear();

            if (clientRecord != null)
            {
                foreach (AppointmentRecord rec in StomaDB.GetAppointments(clientRecord))
                {
                    var item = new ListViewItem(new string[] {
                       DateUtils.ToDateFormat(rec.Data.Date, DateUtils.EXTERNAL_DATE_FORMAT)
                    });
                    item.Tag = rec;
                    appointmentListView.Items.Add(item);
                }
            }

            appointmentListView_SelectedIndexChanged();
        }

        private void appointmentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            appointmentListView_SelectedIndexChanged();
        }

        private void appointmentListView_SelectedIndexChanged()
        {
            if (appointmentListView.SelectedItems.Count == 0)
            {
                doctorTextBox.Clear();
                diagnosisTextBox.Clear();
                toothtextBox.Clear();

                btnAdd.Enabled = false;
                btnPrint.Enabled = false;
            }
            else
            {
                AppointmentRecord rec = (AppointmentRecord) appointmentListView.SelectedItems[0].Tag;
                doctorTextBox.Text = rec.doctorData.GetFullName();
                diagnosisTextBox.Text = rec.Data.Diagnosis;
                toothtextBox.Text = rec.Data.Tooth.ToString();

                btnAdd.Enabled = true;
                btnPrint.Enabled = true;
            }

            UpdateTreatmentList();
        }

        private void UpdateTreatmentList()
        {
            treatmentListView.Items.Clear();
            costLabel.Text = "";

            if (appointmentListView.SelectedItems.Count == 1)
            {
                AppointmentRecord apRec = (AppointmentRecord)appointmentListView.SelectedItems[0].Tag;
                Int64 totalPrice = 0;

                foreach (TreatmentRecord rec in StomaDB.GetTreatments(apRec))
                {
                    string serviceName = rec.Data.NotesToService.Length > 0 ? 
                        rec.serviceData.Name + '(' + rec.Data.NotesToService + ')' : rec.serviceData.Name;
                    var item = new ListViewItem(new string[] {
                        serviceName,
                        rec.serviceData.Price.ToString(),
					    rec.Data.Count.ToString(),
                        rec.GetTotalPrice().ToString()
                    });
                    item.Tag = rec;
                    treatmentListView.Items.Add(item);
                    totalPrice += rec.GetTotalPrice();
                }

                costLabel.Text = totalPrice + " рублей";
            }

            treatmentListView_SelectedIndexChanged();
        }

        private void treatmentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            treatmentListView_SelectedIndexChanged();
        }

        private void treatmentListView_SelectedIndexChanged()
        {
            if (treatmentListView.SelectedItems.Count == 0)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
		{
            var form = new NewTreatment();
            form.appointment = (AppointmentRecord) appointmentListView.SelectedItems[0].Tag;
            form.ShowDialog(this);
            UpdateTreatmentList();
		}

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var form = new NewTreatment();
            form.editRecord = (TreatmentRecord) treatmentListView.SelectedItems[0].Tag;
            form.ShowDialog(this);
            UpdateTreatmentList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TreatmentRecord rec = (TreatmentRecord) treatmentListView.SelectedItems[0].Tag;
            rec.Delete();
            UpdateTreatmentList();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            var form = new NewAppointment();
            form.clientRecord = clientRecord;
            form.ShowDialog(this);
            UpdateAppointmentList();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (appointmentListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите дату приема из списка.", "Ошибка");
                return;
            }

            if (treatmentListView.Items.Count == 0)
            {
                if (MessageBox.Show("Вы действительно хотите распечатать пустой прием?",
                "Печать", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }

            Document document = new Document(PageSize.A4, 10f, 10f, 0f, 0f);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("result.pdf", FileMode.Create));

            document.Open();

            Paragraph header = new Paragraph("Акт об оказании стоматологических услуг от "
                + DateUtils.ToDateFormat(DateUtils.GetCurrentTimestamp(), DateUtils.WITHOUT_TIME_DATE_FORMAT) + " г.", font);
            header.Alignment = Element.ALIGN_CENTER;

            document.Add(header);

            Paragraph empty = new Paragraph("\n");

            iTextSharp.text.Image gif = iTextSharp.text.Image.GetInstance("newMainInfo2.png");
            gif.Alignment = Element.ALIGN_CENTER;
            document.Add(gif);
            Paragraph empty1 = new Paragraph("\n", font3);
            document.Add(empty1);

            PdfPTable treatmentInformationTable = new PdfPTable(5);

            treatmentInformationTable.HorizontalAlignment = Element.ALIGN_CENTER;

            CreateTreatmentInformationTable(treatmentInformationTable, "Дата приема: ", 1);
            CreateTreatmentInformationTable(treatmentInformationTable, appointmentListView.SelectedItems[0].SubItems[0].Text, 4);
            CreateTreatmentInformationTable(treatmentInformationTable, "Пациент: ", 1);
            CreateTreatmentInformationTable(treatmentInformationTable, patientFIO.Text.ToString(), 4);
            CreateTreatmentInformationTable(treatmentInformationTable, "Врач: ", 1);
            CreateTreatmentInformationTable(treatmentInformationTable, doctorTextBox.Text.ToString(), 4);

            if (diagnosisTextBox.Text.ToString() != "")
            {
                CreateTreatmentInformationTable(treatmentInformationTable, "Диагноз: ", 1);
                CreateTreatmentInformationTable(treatmentInformationTable, diagnosisTextBox.Text.ToString(), 4);
            }

            CreateTreatmentInformationTable(treatmentInformationTable, "Зуб: ", 1);
            CreateTreatmentInformationTable(treatmentInformationTable, toothtextBox.Text.ToString(), 4);

            document.Add(treatmentInformationTable);

            document.Add(empty);

            PdfPTable treatmentTable = new PdfPTable(4);
            treatmentTable.HorizontalAlignment = Element.ALIGN_CENTER;
            treatmentTable.TotalWidth = 460f;
            treatmentTable.LockedWidth = true;

            float[] widths = new float[] { 60, 12, 8, 9 };
            treatmentTable.SetWidths(widths);

            CreateTreatmentTableHeader(treatmentTable);
            CreateTreatmentTableBase(treatmentTable);

            document.Add(treatmentTable);

            Paragraph underline = new Paragraph("_____________________________________________________________________");
            underline.Alignment = Element.ALIGN_CENTER;
            document.Add(underline);
            document.Add(empty);

            Paragraph footer = new Paragraph("С лечением согласен, с возможными осложнениями ознакомлен: _____________ ", font);
            footer.Alignment = Element.ALIGN_CENTER;

            document.Add(footer);

            document.Close();
            writer.Close();
			System.Diagnostics.Process.Start("result.pdf");
        }

        private void CreateTreatmentInformationTable(PdfPTable treatmentInformationTable, string cellValue, int colspan)
        {
            PdfPCell cell = new PdfPCell(new Phrase(cellValue, font1));
            cell.PaddingBottom = 5f;
            cell.MinimumHeight = minimumRowHeight;
            cell.BorderWidth = 0.1f;
            cell.Colspan = colspan;
            treatmentInformationTable.AddCell(cell);
        }

        private void CreateTreatmentTableHeader(PdfPTable treatmentTable)
        {
            CreateTreatmentTableHeaderCell(treatmentTable, "Услуга", 0);
            CreateTreatmentTableHeaderCell(treatmentTable, "Цена за ед.", 0);
            CreateTreatmentTableHeaderCell(treatmentTable, "Кол-во", 0);
            CreateTreatmentTableHeaderCell(treatmentTable, "Сумма", 0);
        }

        private void CreateTreatmentTableHeaderCell(PdfPTable treatmentTable, string cellValue, int colspan)
        {
            PdfPCell treatmentTableHeader = new PdfPCell(new Phrase(cellValue, font));
            treatmentTableHeader.BorderWidth = 0.1f;
            treatmentTableHeader.MinimumHeight = minimumRowHeight;
            treatmentTableHeader.Colspan = colspan;
            treatmentTableHeader.PaddingBottom = 5f;
            treatmentTable.AddCell(treatmentTableHeader);
        }

        private void CreateTreatmentTableBase(PdfPTable treatmentTable)
        {
            for (int i = 0; i < treatmentListView.Items.Count; ++i)
            {
                for (int j = 0; j < treatmentListView.Items[i].SubItems.Count; ++j)
                {
                    var treatmentItem = treatmentListView.Items[i].SubItems[j];
                    if (j == 0)
                    {
                        CreateTreatmentTableBaseCell(treatmentTable, treatmentItem.Text, 0);
                        continue;
                    }
                    if (j == 1)
                    {
                        CreateTreatmentTableBaseCell(treatmentTable, treatmentItem.Text, 0);
                        continue;
                    }
                    else
                    {
                        CreateTreatmentTableBaseCell(treatmentTable, treatmentItem.Text, 0);
                    }
                }
            }

            PdfPCell treatmentTableBaseCell = new PdfPCell(new Phrase("\nК оплате: " + costLabel.Text, font1));
            treatmentTableBaseCell.BorderWidth = 0.1f;
            treatmentTableBaseCell.MinimumHeight = minimumRowHeight;
            treatmentTableBaseCell.PaddingBottom = 5f;
            treatmentTableBaseCell.Colspan = 4;
            treatmentTableBaseCell.HorizontalAlignment = 2;
            treatmentTable.AddCell(treatmentTableBaseCell);
        }

        private void CreateTreatmentTableBaseCell(PdfPTable treatmentTable, string cellValue, int colspan)
        {
            PdfPCell treatmentTableBaseCell = new PdfPCell(new Phrase(cellValue, font1));
            treatmentTableBaseCell.BorderWidth = 0.1f;
            treatmentTableBaseCell.MinimumHeight = minimumRowHeight;
            treatmentTableBaseCell.PaddingBottom = 5f;
            treatmentTableBaseCell.Colspan = colspan;
            treatmentTable.AddCell(treatmentTableBaseCell);
        }

        private void appointmentListView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var selectedRow = appointmentListView.SelectedItems;
                if (selectedRow.Count == 0)
                {
                    appointmentListView.ContextMenu = null;
                    return;
                }
                appointmentListView.ContextMenu = appointmentMenu;
                appointmentListView.ContextMenu.Show(appointmentListView, new Point(e.X, e.Y));
            }
        }

        private void appointmentMenuDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Вы действительно хотите удалить прием " +
                "(вместе с ним удалятся все работы)?",
                "Удаление приема", MessageBoxButtons.YesNo,
				MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                AppointmentRecord rec = (AppointmentRecord)appointmentListView.SelectedItems[0].Tag;
                rec.Delete();
                UpdateAppointmentList();
            }
        }

        private void appointmentMenuEdit_Click(object sender, EventArgs e)
        {
            var form = new NewAppointment();
            form.EditRecord = (AppointmentRecord)appointmentListView.SelectedItems[0].Tag;
            form.ShowDialog(this);
            UpdateAppointmentList();           
        }

		private void treatmentListView_Resize(object sender, EventArgs e)
		{
			treatmentListView.Columns[0].Width = treatmentListView.Width -
				treatmentListView.Columns[1].Width -
				treatmentListView.Columns[2].Width -
				treatmentListView.Columns[3].Width - 5;
		}

        private void btnEditAppointment_Click(object sender, EventArgs e)
        {
            appointmentMenuEdit_Click(sender, e);
        }

        private void btnDelAppointment_Click(object sender, EventArgs e)
        {
            appointmentMenuDelete_Click(sender, e);
        }
	}
}
