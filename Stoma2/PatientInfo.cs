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
            phoneTextBox.Text = rec.Phone;

            addressTextBox.Text = rec.AddressSubject + ", " +
                rec.AddressCity + ", " +
                rec.AddressStreet + ", " +
                rec.AddressBuilding + ", " +
                rec.AddressApartment;

            workplaceTextBox.Text = rec.Workplace;
            positionTextBox.Text = rec.Position;
            lastInviteTextBox.Text = rec.LastInvite;
            notesTextBox.Text = rec.Notes;
        }
	}
}
