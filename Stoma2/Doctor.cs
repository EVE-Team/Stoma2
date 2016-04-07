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
	public partial class Doctor : Form
	{
		public Doctor()
		{
			InitializeComponent();
		}

        private void button8_Click(object sender, EventArgs e)
        {
            AddDoctor form = new AddDoctor();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddDoctor form = new AddDoctor();
            form.Text = "Редактировать доктора";
			form.btnApply.Text = "Сохранить";
            form.ShowDialog();
        }
	}
}
