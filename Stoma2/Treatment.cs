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
	public partial class Treatment : Form
	{
		public Treatment()
		{
			InitializeComponent();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			var form = new NewTreatment();
			form.ShowDialog(this);
		}
	}
}
