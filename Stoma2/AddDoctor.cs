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
    public partial class AddDoctor : Form
    {
        private bool m_baseModified = false;

        public AddDoctor()
        {
            InitializeComponent();
        }

		private void btnApply_Click(object sender, EventArgs e)
		{
            Dictionary<string, string> doctorData = new Dictionary<string, string>();
            doctorData["name_first"] = nameFirstBox.Text;
            doctorData["name_last"] = nameLastBox.Text;
            doctorData["name_patronymic"] = patronymicBox.Text;
            doctorData["speciality"] = specialityBox.Text;
            StomaDB.Instance.AddDoctor(doctorData);

            m_baseModified = true;
            Close();
		}

        public bool BaseModified
        {
            get { return m_baseModified; }
        }
    }
}
