using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stoma2
{
	public partial class SearchBar : UserControl
	{
		public SearchBar()
		{
			InitializeComponent();
			UpdateTooltip();
		}

		private bool m_tooltipActive = true;

		private void UpdateTooltip()
		{
			if (m_tooltipActive)
			{
				txtText.Text = ToolTip;
				txtText.ForeColor = TooltipColor;
			}
			else
			{
				txtText.Text = Text;
				txtText.ForeColor = ForeColor;
			}
		}

		public string Text
		{
			get
			{
				if (m_tooltipActive)
				{
					return "";
				}
				else
				{
					return txtText.Text;
				}
			}

			set
			{
				if (!m_tooltipActive)
				{
					txtText.Text = value;
				}
			}
		}

		private string m_tooltip = "Tooltip";
		public string ToolTip
		{
			get { return m_tooltip; }
			set
			{
				m_tooltip = value;
				if (m_tooltipActive)
				{
					txtText.Text = m_tooltip;
				}
			}
		}

		private Color m_tooltipColor = Color.Silver;
		public Color TooltipColor
		{
			get { return m_tooltipColor; }
			set
			{
				m_tooltipColor = value;
				if (m_tooltipActive)
				{
					txtText.ForeColor = m_tooltipColor;
				}
			}
		}

		private void txtText_Enter(object sender, EventArgs e)
		{
			if (m_tooltipActive)
			{
				m_tooltipActive = false;
				txtText.Text = "";
				UpdateTooltip();
			}
		}

		private void txtText_Leave(object sender, EventArgs e)
		{
			if (txtText.Text == "")
			{
				m_tooltipActive = true;
				UpdateTooltip();
			}
		}

		private void SearchBar_Resize(object sender, EventArgs e)
		{
			pictureBox3.Location = new Point(pictureBox3.Location.X,
				(Size.Height / 2) - (pictureBox3.Height / 2));
			txtText.Location = new Point(txtText.Location.X,
				(Size.Height / 2) - (txtText.Height / 2));
		}

		public event EventHandler TextChanged;

		private void txtText_TextChanged(object sender, EventArgs e)
		{
			if (!m_tooltipActive)
			{
				if (this.TextChanged != null)
				{
					TextChanged(this, e);
				}
			}
		}
	}
}
