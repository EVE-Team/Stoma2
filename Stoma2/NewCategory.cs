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
    public partial class NewCategory : Form
    {
        public NewCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryFields f = new CategoryFields();
            f.Name = textBox1.Text;
            f.Create();
            Close();
        }
    }
}
