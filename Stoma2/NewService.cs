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
    public partial class NewService : Form
    {
        private Int64 id;

        public NewService(Int64 id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ServiceListFields f = new ServiceListFields();
            f.Name = textBox1.Text;
            f.Price = Convert.ToInt64(numericUpDown1.Value);
            f.CategoryId = id;
            f.Create();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
