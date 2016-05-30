namespace Stoma2
{
	partial class Other
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbDoctorReport = new System.Windows.Forms.RadioButton();
			this.rbBackup = new System.Windows.Forms.RadioButton();
			this.rbVisits = new System.Windows.Forms.RadioButton();
			this.rbDoctors = new System.Windows.Forms.RadioButton();
			this.rbPriceList = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pnlContent = new System.Windows.Forms.Panel();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this.rbDoctorReport);
			this.groupBox1.Controls.Add(this.rbBackup);
			this.groupBox1.Controls.Add(this.rbVisits);
			this.groupBox1.Controls.Add(this.rbDoctors);
			this.groupBox1.Controls.Add(this.rbPriceList);
			this.groupBox1.Location = new System.Drawing.Point(5, 0);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
			this.groupBox1.Size = new System.Drawing.Size(191, 528);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			// 
			// rbDoctorReport
			// 
			this.rbDoctorReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rbDoctorReport.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbDoctorReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(74)))), ((int)(((byte)(73)))));
			this.rbDoctorReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.rbDoctorReport.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.rbDoctorReport.FlatAppearance.BorderSize = 0;
			this.rbDoctorReport.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
			this.rbDoctorReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.rbDoctorReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.rbDoctorReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rbDoctorReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbDoctorReport.ForeColor = System.Drawing.Color.White;
			this.rbDoctorReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.rbDoctorReport.Location = new System.Drawing.Point(10, 151);
			this.rbDoctorReport.Name = "rbDoctorReport";
			this.rbDoctorReport.Size = new System.Drawing.Size(169, 38);
			this.rbDoctorReport.TabIndex = 22;
			this.rbDoctorReport.Text = "Отчет по врачам";
			this.rbDoctorReport.UseVisualStyleBackColor = false;
			this.rbDoctorReport.CheckedChanged += new System.EventHandler(this.rbDoctorReport_CheckedChanged);
			// 
			// rbBackup
			// 
			this.rbBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rbBackup.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(74)))), ((int)(((byte)(73)))));
			this.rbBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.rbBackup.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.rbBackup.FlatAppearance.BorderSize = 0;
			this.rbBackup.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
			this.rbBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.rbBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.rbBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rbBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbBackup.ForeColor = System.Drawing.Color.White;
			this.rbBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.rbBackup.Location = new System.Drawing.Point(10, 195);
			this.rbBackup.Name = "rbBackup";
			this.rbBackup.Size = new System.Drawing.Size(169, 61);
			this.rbBackup.TabIndex = 21;
			this.rbBackup.Text = "Резервное копирование";
			this.rbBackup.UseVisualStyleBackColor = false;
			this.rbBackup.CheckedChanged += new System.EventHandler(this.rbBackup_CheckedChanged);
			// 
			// rbVisits
			// 
			this.rbVisits.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbVisits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(74)))), ((int)(((byte)(73)))));
			this.rbVisits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.rbVisits.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.rbVisits.FlatAppearance.BorderSize = 0;
			this.rbVisits.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
			this.rbVisits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.rbVisits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.rbVisits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rbVisits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbVisits.ForeColor = System.Drawing.Color.White;
			this.rbVisits.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.rbVisits.Location = new System.Drawing.Point(10, 107);
			this.rbVisits.Name = "rbVisits";
			this.rbVisits.Size = new System.Drawing.Size(169, 38);
			this.rbVisits.TabIndex = 23;
			this.rbVisits.Text = "Приёмы";
			this.rbVisits.UseVisualStyleBackColor = false;
			this.rbVisits.CheckedChanged += new System.EventHandler(this.rbVisits_CheckedChanged);
			// 
			// rbDoctors
			// 
			this.rbDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rbDoctors.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbDoctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(74)))), ((int)(((byte)(73)))));
			this.rbDoctors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.rbDoctors.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.rbDoctors.FlatAppearance.BorderSize = 0;
			this.rbDoctors.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
			this.rbDoctors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.rbDoctors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.rbDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rbDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbDoctors.ForeColor = System.Drawing.Color.White;
			this.rbDoctors.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.rbDoctors.Location = new System.Drawing.Point(10, 63);
			this.rbDoctors.Name = "rbDoctors";
			this.rbDoctors.Size = new System.Drawing.Size(169, 38);
			this.rbDoctors.TabIndex = 20;
			this.rbDoctors.Text = "Врачи";
			this.rbDoctors.UseVisualStyleBackColor = false;
			this.rbDoctors.CheckedChanged += new System.EventHandler(this.rbDoctors_CheckedChanged);
			// 
			// rbPriceList
			// 
			this.rbPriceList.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbPriceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(74)))), ((int)(((byte)(73)))));
			this.rbPriceList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.rbPriceList.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.rbPriceList.Checked = true;
			this.rbPriceList.FlatAppearance.BorderSize = 0;
			this.rbPriceList.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
			this.rbPriceList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.rbPriceList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.rbPriceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rbPriceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbPriceList.ForeColor = System.Drawing.Color.White;
			this.rbPriceList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.rbPriceList.Location = new System.Drawing.Point(10, 19);
			this.rbPriceList.Name = "rbPriceList";
			this.rbPriceList.Size = new System.Drawing.Size(169, 38);
			this.rbPriceList.TabIndex = 18;
			this.rbPriceList.TabStop = true;
			this.rbPriceList.Text = "Прайс-лист";
			this.rbPriceList.UseVisualStyleBackColor = false;
			this.rbPriceList.CheckedChanged += new System.EventHandler(this.rbPriceList_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.pnlContent);
			this.groupBox2.Location = new System.Drawing.Point(203, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(504, 528);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			// 
			// pnlContent
			// 
			this.pnlContent.BackColor = System.Drawing.Color.White;
			this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContent.Location = new System.Drawing.Point(3, 16);
			this.pnlContent.Name = "pnlContent";
			this.pnlContent.Size = new System.Drawing.Size(498, 509);
			this.pnlContent.TabIndex = 10;
			// 
			// Other
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(719, 537);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Other";
			this.Text = "Other";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbDoctorReport;
		private System.Windows.Forms.RadioButton rbBackup;
		private System.Windows.Forms.RadioButton rbDoctors;
		private System.Windows.Forms.RadioButton rbPriceList;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel pnlContent;
		private System.Windows.Forms.RadioButton rbVisits;
	}
}