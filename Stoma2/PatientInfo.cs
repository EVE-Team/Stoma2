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

        public void SetInfo(int id)
        {
            var data = StomaDB.Instance.GetClientReader(id);

            nameTextBox.Text = data["name_last"].ToString() + " " +
                data["name_first"].ToString() + " " +
                data["name_patronymic"].ToString();

            //birthdayTextBox
            phoneTextBox.Text = data["phone"].ToString();

            addressTextBox.Text = data["address_subject"].ToString() + ", " +
                data["address_city"].ToString() + ", " +
                data["address_street"].ToString() + ", " +
                data["address_building"].ToString() + ", " +
                data["address_apartment"].ToString();

            workplaceTextBox.Text = data["workplace"].ToString();
            positionTextBox.Text = data["position"].ToString();
            lastInviteTextBox.Text = data["last_invite"].ToString();
            notesTextBox.Text = data["notes"].ToString();
        }
	}
}
