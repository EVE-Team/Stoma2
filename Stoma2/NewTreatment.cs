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
	public partial class NewTreatment : Form
	{
		public NewTreatment()
		{
			InitializeComponent();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void NewTreatment_Load(object sender, EventArgs e)
		{

		}

		private void NewTreatment_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(cbCategory.Location.X - 1, cbCategory.Location.Y - 1,
				cbCategory.Size.Width + 1, cbCategory.Size.Height + 1));
		}
	}
}
