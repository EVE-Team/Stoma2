﻿using System;
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
	public partial class Invite : Form
	{
		public Invite()
		{
			InitializeComponent();

            Utils.SetPanelForm(pnlPatientInfo, Utils.SetupForm(new PatientInfo()));
		}
	}
}
