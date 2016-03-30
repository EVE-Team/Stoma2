namespace Stoma2
{
	partial class Appointment
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label3 = new System.Windows.Forms.Label();
			this.rectangleShape5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.rbFirst = new System.Windows.Forms.RadioButton();
			this.rbSecond = new System.Windows.Forms.RadioButton();
			this.pnlContents = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(186)))), ((int)(((byte)(223)))));
			this.label3.Location = new System.Drawing.Point(21, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(242, 45);
			this.label3.TabIndex = 3;
			this.label3.Text = "Новый приём";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// rectangleShape5
			// 
			this.rectangleShape5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rectangleShape5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
			this.rectangleShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
			this.rectangleShape5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.rectangleShape5.CornerRadius = 5;
			this.rectangleShape5.Enabled = false;
			this.rectangleShape5.Location = new System.Drawing.Point(15, 57);
			this.rectangleShape5.Name = "rectangleShape5";
			this.rectangleShape5.Size = new System.Drawing.Size(783, 43);
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape5});
			this.shapeContainer1.Size = new System.Drawing.Size(811, 433);
			this.shapeContainer1.TabIndex = 4;
			this.shapeContainer1.TabStop = false;
			// 
			// rbFirst
			// 
			this.rbFirst.AutoSize = true;
			this.rbFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
			this.rbFirst.Checked = true;
			this.rbFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rbFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbFirst.Location = new System.Drawing.Point(26, 65);
			this.rbFirst.Name = "rbFirst";
			this.rbFirst.Size = new System.Drawing.Size(129, 28);
			this.rbFirst.TabIndex = 5;
			this.rbFirst.TabStop = true;
			this.rbFirst.Text = "Первичный";
			this.rbFirst.UseVisualStyleBackColor = false;
			this.rbFirst.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// rbSecond
			// 
			this.rbSecond.AutoSize = true;
			this.rbSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
			this.rbSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rbSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbSecond.Location = new System.Drawing.Point(161, 65);
			this.rbSecond.Name = "rbSecond";
			this.rbSecond.Size = new System.Drawing.Size(129, 28);
			this.rbSecond.TabIndex = 6;
			this.rbSecond.Text = "Повторный";
			this.rbSecond.UseVisualStyleBackColor = false;
			this.rbSecond.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// pnlContents
			// 
			this.pnlContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlContents.Location = new System.Drawing.Point(15, 105);
			this.pnlContents.Name = "pnlContents";
			this.pnlContents.Size = new System.Drawing.Size(796, 328);
			this.pnlContents.TabIndex = 7;
			// 
			// Appointment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(811, 433);
			this.Controls.Add(this.pnlContents);
			this.Controls.Add(this.rbSecond);
			this.Controls.Add(this.rbFirst);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.shapeContainer1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Appointment";
			this.Text = "Appointment";
			this.Load += new System.EventHandler(this.Appointment_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape5;
		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private System.Windows.Forms.RadioButton rbFirst;
		private System.Windows.Forms.RadioButton rbSecond;
		private System.Windows.Forms.Panel pnlContents;

	}
}