using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Stoma2
{
	public partial class Treatment : Form
	{
        private ClientRecord clientRecord = null;

		public Treatment()
		{
			InitializeComponent();
            OnClientUpdate();
		}

        public void SetClient(ClientRecord clientRecord)
        {
            this.clientRecord = clientRecord;
            OnClientUpdate();
        }

        private void OnClientUpdate()
        {
            if (clientRecord != null)
            {
                patientFIO.Text = clientRecord.GetFullName();
            }
            else
            {
                patientFIO.Text = "вообще хз кого";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
		{
            var form = new NewTreatment(null);
			form.ShowDialog(this);
		}

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            var form = new NewAppointment(clientRecord);
            form.ShowDialog(this);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedRow = appointmentListView.SelectedItems;
            if (selectedRow.Count == 0)
            {
                MessageBox.Show("Выберите дату приема из списка.", "Ошибка");
                return;
            }

            ListView.ListViewItemCollection workList = visitListView.Items;
            if (workList.Count == 0)
            {
                MessageBox.Show("Выберите дату приема из списка.", "Ошибка");
                return;
            }

            //Здесь укажите свой путь до файла
            object filePath = "C:\\Users\\EugeneDolgushev\\Documents\\GitHub\\Stoma2\\Stoma2\\bin\\Debug\\Example.docx";
            object falseValue = false;
            object trueValue = true;
            object missing = Type.Missing;

			Word.Application winApp;

			try
			{
				winApp = new Word.Application();
			}
			catch (System.Runtime.InteropServices.COMException)
			{
				MessageBox.Show(this, "Для работы данной функции необходимо наличие Microsoft Word", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

            Word.Document wordApp = new Word.Document();
            wordApp = winApp.Documents.Open(ref filePath, ref missing, ref trueValue,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing);

            Word.Table wordTable = winApp.ActiveDocument.Tables[1];

            for (int i = 0; i < visitListView.Items.Count; ++i)
            {
                wordTable.Rows.Add();
            }

            for (int i = 0; i < visitListView.Items.Count; ++i)
            {
                if (i == 0)
                {
                    ListViewItem t = visitListView.Items[i];
                    ListViewItem.ListViewSubItemCollection subt = t.SubItems;
                    Word.Row currentRow = wordTable.Rows[i+2];
                    for (int j = 1; j < currentRow.Cells.Count + 1; ++j)
                    {
                        if (j == 1)
                        {
                            currentRow.Cells[j].Range.Text = toothtextBox.Text.ToString();
                            continue;
                        } else if (j == 2)
                        {
                            currentRow.Cells[j].Range.Text = diagnosisTextBox.Text.ToString();
                            continue;
                        } else if (j == 3)
                        {
                            ListViewItem.ListViewSubItem r = subt[j - 3];
                            string wrest = r.Text;
                            currentRow.Cells[j].Range.Text = r.Text;
                            Console.Write(wrest);
                        } else if (j == 4)
                        {
                            ListViewItem.ListViewSubItem r = subt[j - 3];
                            ListViewItem.ListViewSubItem r1 = subt[j - 2];
                            string wrest = r.Text + r1.Text;
                            currentRow.Cells[j].Range.Text = r.Text + " * " + r1.Text;
                        } else if (j == 5)
                        {
                            ListViewItem.ListViewSubItem r1 = subt[j - 2];
                            string wrest = r1.Text;
                            currentRow.Cells[j].Range.Text = r1.Text;
                        }
                    }
                }
                else
                {
                    ListViewItem t = visitListView.Items[i];
                    ListViewItem.ListViewSubItemCollection subt = t.SubItems;
                    Word.Row currentRow = wordTable.Rows[i + 2];

                    for (int j = 3; j < currentRow.Cells.Count + 1; ++j)
                    {
                        if (j == 3)
                        {
                            ListViewItem.ListViewSubItem r = subt[j - 3];
                            string wrest = r.Text;
                            currentRow.Cells[j].Range.Text = r.Text;
                            Console.Write(wrest);
                        } else if (j == 4)
                        {
                            ListViewItem.ListViewSubItem r = subt[j - 3];
                            ListViewItem.ListViewSubItem r1 = subt[j - 2];
                            string wrest = r.Text + r1.Text;
                            currentRow.Cells[j].Range.Text = r.Text + " * " + r1.Text;
                        } else if (j == 5)
                        {
                            ListViewItem.ListViewSubItem r1 = subt[j - 2];
                            string wrest = r1.Text;
                            currentRow.Cells[j].Range.Text = r1.Text;
                        }
                    }
                }
            }
            winApp.Visible = true;
        }
	}
}
