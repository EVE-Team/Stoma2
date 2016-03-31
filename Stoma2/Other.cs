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
	public partial class Other : Form
	{
		public Other()
		{
			InitializeComponent();

			panel1.Dock = DockStyle.Fill;
			panel2.Dock = DockStyle.Fill;
			panel3.Dock = DockStyle.Fill;
			panel9.Dock = DockStyle.Fill;
			panel10.Dock = DockStyle.Fill;
		}

		private void HidePanels2()
		{
			panel3.Visible = false;
			panel2.Visible = false;
			panel1.Visible = false;
			panel9.Visible = false;
			panel10.Visible = false;
		}

		private void radioButton7_CheckedChanged(object sender, EventArgs e)
		{
			HidePanels2();
			panel3.Visible = true;
		}

		private void radioButton8_CheckedChanged(object sender, EventArgs e)
		{
			HidePanels2();
			panel2.Visible = true;
		}

		private void radioButton9_CheckedChanged(object sender, EventArgs e)
		{
			HidePanels2();
			panel1.Visible = true;
		}

		private void radioButton11_CheckedChanged(object sender, EventArgs e)
		{
			HidePanels2();
			panel10.Visible = true;
		}

		private void radioButton10_CheckedChanged(object sender, EventArgs e)
		{
			HidePanels2();
			panel9.Visible = true;
		}

		private void button10_Click(object sender, EventArgs e)
		{
			label5.Visible = true;
			button6.Visible = true;
		}

	}
}
