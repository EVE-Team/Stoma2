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
            if (rec.Data.Birthday != string.Empty)
            {
                birthdayTextBox.Text = rec.Data.Birthday.Substring(0, 10);
            }           
            phoneTextBox.Text = rec.Data.Phone;

            addressTextBox.Text = rec.Data.AddressSubject + ", " +
                rec.Data.AddressCity + ", " +
                rec.Data.AddressStreet + ", " +
                rec.Data.AddressBuilding + ", " +
                rec.Data.AddressApartment;

            workplaceTextBox.Text = rec.Data.Workplace;
            positionTextBox.Text = rec.Data.Position;
            lastInviteTextBox.Text = rec.Data.LastInvite;
            notesTextBox.Text = rec.Data.Notes;
        }
	}
}
