using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Stoma2
{
	public partial class MainForm : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd,
						 int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		// Panel forms
        Control patientForm = Utils.SetupForm(new Patient());
        Control treatmentForm = Utils.SetupForm(new Treatment());
        Control inviteForm = Utils.SetupForm(new Invite());
        Control otherForm = Utils.SetupForm(new Other());
		//

		public MainForm()
		{
			InitializeComponent();

			// Draw invite count
			var bitmap = new Bitmap(100, 100);
			using (var graphics = Graphics.FromImage(bitmap))
			{
				var icon = Stoma2.Properties.Resources.bell;
				graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
				graphics.DrawImage(icon, (rbInvite.Width - icon.Width) / 2, 10, 64, 64);
				var notification = new Rectangle(60, 50, 25, 25);
				graphics.FillEllipse(new SolidBrush(Color.White), notification);
				graphics.DrawEllipse(new Pen(Color.Black, 2), notification);
				graphics.DrawString("3", rbInvite.Font, new SolidBrush(Color.Black),
					new Point(notification.Location.X + 5, notification.Location.Y + 1));
			}
			rbInvite.BackgroundImage = bitmap;
			rbInvite.BackgroundImageLayout = ImageLayout.Tile;
			//

			// Set tool tips
			var ToolTip = new System.Windows.Forms.ToolTip();
			ToolTip.BackColor = System.Drawing.Color.AntiqueWhite;
			ToolTip.SetToolTip(this.rbAppointment, "Добавить новый приём");
			ToolTip.SetToolTip(this.rbInvite, "Напоминания о повторном осмотре");
			ToolTip.SetToolTip(this.rbTreatment, "Оказанные за приём услуги");
			ToolTip.SetToolTip(this.rbOther, "Дополнительные возможности");
			ToolTip.SetToolTip(this.btnMinimize, "Свернуть");
			ToolTip.SetToolTip(this.btnMaximize, "Развернуть на весь экран");
			ToolTip.SetToolTip(this.btnClose, "Закрыть");
			//

			// New appointment selected by default
			rbAppointment_CheckedChanged(null, null);
		}

		private void rbOther_CheckedChanged(object sender, EventArgs e)
		{
            Utils.SetPanelForm(pnlContent, otherForm);
		}

		private void rbInvite_CheckedChanged(object sender, EventArgs e)
		{
            Utils.SetPanelForm(pnlContent, inviteForm);
		}

		private void rbAppointment_CheckedChanged(object sender, EventArgs e)
		{
            Utils.SetPanelForm(pnlContent, patientForm);
		}

		public void goToNewAppointment()
		{
			rbAppointment.Checked = true;
		}

		private void rbTreatment_CheckedChanged(object sender, EventArgs e)
		{
            Utils.SetPanelForm(pnlContent, treatmentForm);
		}

		private void btnMaximize_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Maximized)
			{
				WindowState = FormWindowState.Normal;
			}
			else
			{
				WindowState = FormWindowState.Maximized;
			}
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void lblHeader_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void lblHeader_DoubleClick(object sender, EventArgs e)
		{
			btnMaximize_Click(sender, e);
		}

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StomaDB.Instance.Dispose();
        }
	}
}
