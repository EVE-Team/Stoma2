namespace Stoma2
{
	partial class ValidatedTextBox
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtText = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtText
			// 
			this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtText.Location = new System.Drawing.Point(0, 0);
			this.txtText.Margin = new System.Windows.Forms.Padding(5);
			this.txtText.Name = "txtText";
			this.txtText.Size = new System.Drawing.Size(185, 13);
			this.txtText.TabIndex = 0;
			this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
			this.txtText.Leave += new System.EventHandler(this.txtText_Leave);
			// 
			// ValidatedTextBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.txtText);
			this.Name = "ValidatedTextBox";
			this.Size = new System.Drawing.Size(187, 34);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ValidatedTextBox_Paint);
			this.Resize += new System.EventHandler(this.ValidatedTextBox_Resize);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtText;
	}
}
