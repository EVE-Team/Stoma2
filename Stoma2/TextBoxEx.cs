using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Stoma2
{
	public partial class TextBoxEx : System.Windows.Forms.TextBox
	{
		public TextBoxEx()
		{
			InitializeComponent();

			Text = ToolTip;
			TextColor = ForeColor;
			ForeColor = ToolTipColor;

			this.GotFocus += TextBoxEx_GotFocus;
			this.LostFocus += TextBoxEx_LostFocus;
		}

		void TextBoxEx_LostFocus(object sender, EventArgs e)
		{
			if (Text == "")
			{
				Text = ToolTip;
				TextColor = ForeColor;
				ForeColor = ToolTipColor;
			}
		}

		void TextBoxEx_GotFocus(object sender, EventArgs e)
		{
			if (Text == ToolTip)
			{
				Text = "";
				ForeColor = TextColor;
			}
		}

		public TextBoxEx(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}

		[Description("Placeholder text that is displayed when textbox is empty"), Category("Appearance")] 
		public string ToolTip
		{
			get { return ToolTip_; }
			set
			{
				if (Text == ToolTip_)
				{
					Text = value;
				}
				ToolTip_ = value;
			}
		}
		private string ToolTip_ = "";

		[Description("Tool tip color"), Category("Appearance")] 
		public Color ToolTipColor
		{
			get { return ToolTipColor_; }
			set
			{
				ToolTipColor_ = value;
				if (Text == ToolTip)
				{
					ForeColor = ToolTipColor;
				}
			}
		}
		private Color ToolTipColor_ = Color.FromArgb(250, 250, 250);

		private Color TextColor = Color.FromArgb(0, 0, 0);
	}
}
