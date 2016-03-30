using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stoma2
{
	static class Program
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

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
