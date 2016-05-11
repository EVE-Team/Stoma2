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
	public partial class PatientInfo : Form
	{
		public PatientInfo()
		{
			InitializeComponent();
		}

        public void ClearInfo()
        {
            nameTextBox.Clear();
            birthdayTextBox.Clear();
            phoneTextBox.Clear();
            addressTextBox.Clear();
            workplaceTextBox.Clear();
            positionTextBox.Clear();
            lastInviteTextBox.Clear();
            notesTextBox.Clear();
        }

        public void SetInfo(ClientRecord rec)
        {
            nameTextBox.Text = rec.GetFullName();

            //birthdayTextBox
            phoneTextBox.Text = rec.data.Phone;

            addressTextBox.Text = rec.data.AddressSubject + ", " +
                rec.data.AddressCity + ", " +
                rec.data.AddressStreet + ", " +
                rec.data.AddressBuilding + ", " +
                rec.data.AddressApartment;

            workplaceTextBox.Text = rec.data.Workplace;
            positionTextBox.Text = rec.data.Position;
            lastInviteTextBox.Text = rec.data.LastInvite;
            notesTextBox.Text = rec.data.Notes;
        }
	}
}
