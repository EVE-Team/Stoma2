using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stoma2
{
    class Utils
    {
        public static Control SetupForm(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            return form;
        }

        public static void SetPanelForm(Panel panel, Control form)
        {
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

        public static Control GetPanelForm(Panel panel)
        {
            if (panel.Controls.Count != 1)
                throw new Exception("Unexpected control count");
            return panel.Controls[0];
        }
    }
}
