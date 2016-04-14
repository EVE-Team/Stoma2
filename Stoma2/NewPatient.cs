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
	public partial class NewPatient : Form
	{
		public NewPatient()
		{
			InitializeComponent();
		}

		private void FirstAppointment_Load(object sender, EventArgs e)
		{
			// Setting up Expander control
			Expander expander = new Expander();
			expander.Size = pnlExtra.Size;
			expander.Location = pnlExtra.Location;
			expander.BorderStyle = BorderStyle.FixedSingle;

			ExpanderHelper.CreateLabelHeader(expander, "Дополнительная информация",
				SystemColors.ActiveBorder, Properties.Resources.Collapse, Properties.Resources.Expand);

			pnlExtra.Location = new Point(0, 0);
			expander.Content = pnlExtra;
			Controls.Remove(pnlExtra);

			expander.Collapse();

			this.Controls.Add(expander);
			//

			// Filling date combo boxes
			for (int i = DateTime.Now.Year; i >= 1920; i--)
			{
				cmbYear.Items.Add(i.ToString());
			}

			for (int i = 1; i <= 31; i++)
			{
				cmbDay.Items.Add(i.ToString());
			}
			//
		}

		private void button8_Click(object sender, EventArgs e)
		{
            Dictionary<string, string> clientData = new Dictionary<string, string>();
            clientData["name_first"] = nameFirstBox.Text;
            clientData["name_last"] = nameLastBox.Text;
            clientData["name_patronymic"] = patronymicBox.Text;
            //clientData["birthday"] = ;
            clientData["address_subject"] = addressSubjectBox.Text;
            clientData["address_city"] = addressCityBox.Text;
            clientData["address_street"] = addressStreetBox.Text;
            clientData["address_building"] = addressBuildingBox.Text;
            clientData["address_apartment"] = addressApartmentBox.Text;
            clientData["workplace"] = workplaceBox.Text;
            clientData["position"] = positionBox.Text;
            clientData["phone"] = phoneBox.Text;
            clientData["notes"] = notesBox.Text;
            StomaDB.Instance.AddClient(clientData);

			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
