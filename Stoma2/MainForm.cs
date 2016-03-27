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

		public MainForm()
		{
			InitializeComponent();

			var bitmap = new Bitmap(100, 100);
			using (var graphics = Graphics.FromImage(bitmap))
			{
				var icon = Stoma2.Properties.Resources.bell;
				graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
				graphics.DrawImage(icon, (radioButton5.Width - icon.Width) / 2, 10, 64, 64);
				var notification = new Rectangle(60, 50, 25, 25);
				graphics.FillEllipse(new SolidBrush(Color.White), notification);
				graphics.DrawEllipse(new Pen(Color.Black, 2), notification);
				graphics.DrawString("3", radioButton5.Font, new SolidBrush(Color.Black),
					new Point(notification.Location.X + 5, notification.Location.Y + 1));
			}
			radioButton5.BackgroundImage = bitmap;
			radioButton5.BackgroundImageLayout = ImageLayout.Tile;

			panel6.Location = panel12.Location;
            panel5.Size = new Size(601, 300);
            panel11.Size = new Size(601, 75);
            panel12.Size = new Size(601, 156);
			panel6.Size = new Size(601, 260);
			
			panel1.Dock = DockStyle.Fill;
			panel2.Dock = DockStyle.Fill;
			panel3.Dock = DockStyle.Fill;
			panel4.Dock = DockStyle.Fill;
			pnlRemainder.Dock = DockStyle.Fill;
			pnlVisits.Dock = DockStyle.Fill;
			panel7.Dock = DockStyle.Fill;
			panel9.Dock = DockStyle.Fill;
			panel10.Dock = DockStyle.Fill;

			var ToolTip = new System.Windows.Forms.ToolTip();
			ToolTip.BackColor = System.Drawing.Color.AntiqueWhite;
			ToolTip.SetToolTip(this.radioButton3, "Добавить новый визит");
			ToolTip.SetToolTip(this.radioButton5, "Напоминания о повторном осмотре");
			ToolTip.SetToolTip(this.radioButton4, "Оказанные за визит услуги");
			ToolTip.SetToolTip(this.radioButton6, "Дополнительные возможности");

			ToolTip.SetToolTip(this.button2, "Свернуть");
			ToolTip.SetToolTip(this.button1, "Закрыть");

			radioButton3_MouseDown(null, null);

            this.Size = new Size(900, 720);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			
		}

		private void button4_Click(object sender, EventArgs e)
		{
			
		}

		private void button5_Click(object sender, EventArgs e)
		{
			
		}

		private void panel4_Paint(object sender, PaintEventArgs e)
		{

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			panel5.Visible = true;
            panel11.Visible = true;
            panel12.Visible = true;
			panel6.Visible = false;

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			panel6.Visible = true;
			panel5.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
		}

		private void panel6_Paint(object sender, PaintEventArgs e)
		{

		}

		private void HidePanels()
		{
			panel4.Visible = false;
			pnlRemainder.Visible = false;
			pnlVisits.Visible = false;
			panel7.Visible = false;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void button10_Click(object sender, EventArgs e)
		{
			label5.Visible = true;
			button6.Visible = true;
		}

		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{

		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton3_MouseDown(object sender, MouseEventArgs e)
		{
			HidePanels();
			panel4.Visible = true;
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			
		}

		private void radioButton5_MouseDown(object sender, MouseEventArgs e)
		{
			HidePanels();
			pnlRemainder.Visible = true;
		}

		private void radioButton4_MouseDown(object sender, MouseEventArgs e)
		{
			HidePanels();
			pnlVisits.Visible = true;
		}

		private void radioButton6_MouseDown(object sender, MouseEventArgs e)
		{
			HidePanels();
			panel7.Visible = true;
		}

		private void radioButton7_CheckedChanged(object sender, EventArgs e)
		{
			
		}

		private void HidePanels2()
		{
			panel3.Visible = false;
			panel2.Visible = false;
			panel1.Visible = false;
			panel9.Visible = false;
			panel10.Visible = false;
		}

		private void radioButton7_MouseDown(object sender, MouseEventArgs e)
		{
			HidePanels2();
			panel3.Visible = true;
		}

		private void radioButton8_MouseDown(object sender, MouseEventArgs e)
		{
			HidePanels2();
			panel2.Visible = true;
		}

		private void radioButton9_MouseDown(object sender, MouseEventArgs e)
		{
			HidePanels2();
			panel1.Visible = true;
		}

		private void radioButton10_MouseDown(object sender, MouseEventArgs e)
		{
			HidePanels2();
			panel9.Visible = true;
		}

		private void radioButton11_MouseDown(object sender, MouseEventArgs e)
		{
			HidePanels2();
			panel10.Visible = true;
		}
	}
}
