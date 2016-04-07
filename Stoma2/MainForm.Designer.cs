namespace Stoma2
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lblHeader = new System.Windows.Forms.Label();
			this.lblSidePanel = new System.Windows.Forms.Label();
			this.rbInvite = new System.Windows.Forms.RadioButton();
			this.btnMaximize = new System.Windows.Forms.Button();
			this.rbOther = new System.Windows.Forms.RadioButton();
			this.rbTreatment = new System.Windows.Forms.RadioButton();
			this.rbAppointment = new System.Windows.Forms.RadioButton();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.picIcon = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.pnlContent = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// lblHeader
			// 
			this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(119)))), ((int)(((byte)(168)))));
			this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblHeader.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblHeader.ForeColor = System.Drawing.Color.White;
			this.lblHeader.Location = new System.Drawing.Point(0, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(1016, 42);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "Жемчужина";
			this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblHeader.DoubleClick += new System.EventHandler(this.lblHeader_DoubleClick);
			this.lblHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblHeader_MouseDown);
			// 
			// lblSidePanel
			// 
			this.lblSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(74)))), ((int)(((byte)(73)))));
			this.lblSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblSidePanel.Location = new System.Drawing.Point(0, 42);
			this.lblSidePanel.Name = "lblSidePanel";
			this.lblSidePanel.Size = new System.Drawing.Size(100, 718);
			this.lblSidePanel.TabIndex = 2;
			// 
			// rbInvite
			// 
			this.rbInvite.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbInvite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(74)))), ((int)(((byte)(73)))));
			this.rbInvite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.rbInvite.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.rbInvite.FlatAppearance.BorderSize = 0;
			this.rbInvite.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
			this.rbInvite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.rbInvite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.rbInvite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rbInvite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbInvite.ForeColor = System.Drawing.Color.White;
			this.rbInvite.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.rbInvite.Location = new System.Drawing.Point(0, 242);
			this.rbInvite.Margin = new System.Windows.Forms.Padding(0);
			this.rbInvite.Name = "rbInvite";
			this.rbInvite.Size = new System.Drawing.Size(100, 100);
			this.rbInvite.TabIndex = 20;
			this.rbInvite.Text = "Осмотр";
			this.rbInvite.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.rbInvite.UseVisualStyleBackColor = false;
			this.rbInvite.CheckedChanged += new System.EventHandler(this.rbInvite_CheckedChanged);
			// 
			// btnMaximize
			// 
			this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(119)))), ((int)(((byte)(168)))));
			this.btnMaximize.BackgroundImage = global::Stoma2.Properties.Resources.max2;
			this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnMaximize.FlatAppearance.BorderSize = 0;
			this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(96)))), ((int)(((byte)(153)))));
			this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(101)))), ((int)(((byte)(179)))));
			this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
			this.btnMaximize.Location = new System.Drawing.Point(932, 0);
			this.btnMaximize.Name = "btnMaximize";
			this.btnMaximize.Size = new System.Drawing.Size(42, 42);
			this.btnMaximize.TabIndex = 24;
			this.btnMaximize.UseVisualStyleBackColor = false;
			this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
			// 
			// rbOther
			// 
			this.rbOther.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(74)))), ((int)(((byte)(73)))));
			this.rbOther.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.rbOther.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.rbOther.FlatAppearance.BorderSize = 0;
			this.rbOther.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
			this.rbOther.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.rbOther.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.rbOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rbOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbOther.ForeColor = System.Drawing.Color.White;
			this.rbOther.Image = global::Stoma2.Properties.Resources.navicon;
			this.rbOther.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.rbOther.Location = new System.Drawing.Point(0, 342);
			this.rbOther.Name = "rbOther";
			this.rbOther.Size = new System.Drawing.Size(100, 100);
			this.rbOther.TabIndex = 21;
			this.rbOther.Text = "Прочее";
			this.rbOther.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.rbOther.UseVisualStyleBackColor = false;
			this.rbOther.CheckedChanged += new System.EventHandler(this.rbOther_CheckedChanged);
			// 
			// rbTreatment
			// 
			this.rbTreatment.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbTreatment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(74)))), ((int)(((byte)(73)))));
			this.rbTreatment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.rbTreatment.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.rbTreatment.FlatAppearance.BorderSize = 0;
			this.rbTreatment.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
			this.rbTreatment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.rbTreatment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.rbTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rbTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbTreatment.ForeColor = System.Drawing.Color.White;
			this.rbTreatment.Image = global::Stoma2.Properties.Resources.treatment;
			this.rbTreatment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.rbTreatment.Location = new System.Drawing.Point(0, 142);
			this.rbTreatment.Name = "rbTreatment";
			this.rbTreatment.Size = new System.Drawing.Size(100, 100);
			this.rbTreatment.TabIndex = 19;
			this.rbTreatment.Text = "Лечение";
			this.rbTreatment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.rbTreatment.UseVisualStyleBackColor = false;
			this.rbTreatment.CheckedChanged += new System.EventHandler(this.rbTreatment_CheckedChanged);
			// 
			// rbAppointment
			// 
			this.rbAppointment.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(74)))), ((int)(((byte)(73)))));
			this.rbAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.rbAppointment.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.rbAppointment.Checked = true;
			this.rbAppointment.FlatAppearance.BorderSize = 0;
			this.rbAppointment.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
			this.rbAppointment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.rbAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.rbAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rbAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbAppointment.ForeColor = System.Drawing.Color.White;
			this.rbAppointment.Image = global::Stoma2.Properties.Resources.user_md1;
			this.rbAppointment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.rbAppointment.Location = new System.Drawing.Point(0, 42);
			this.rbAppointment.Name = "rbAppointment";
			this.rbAppointment.Size = new System.Drawing.Size(100, 100);
			this.rbAppointment.TabIndex = 17;
			this.rbAppointment.TabStop = true;
			this.rbAppointment.Text = "Приём";
			this.rbAppointment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.rbAppointment.UseVisualStyleBackColor = false;
			this.rbAppointment.CheckedChanged += new System.EventHandler(this.rbAppointment_CheckedChanged);
			// 
			// btnMinimize
			// 
			this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(119)))), ((int)(((byte)(168)))));
			this.btnMinimize.BackgroundImage = global::Stoma2.Properties.Resources.min2;
			this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(96)))), ((int)(((byte)(153)))));
			this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(101)))), ((int)(((byte)(179)))));
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
			this.btnMinimize.Location = new System.Drawing.Point(890, 0);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(42, 42);
			this.btnMinimize.TabIndex = 4;
			this.btnMinimize.UseVisualStyleBackColor = false;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// picIcon
			// 
			this.picIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(119)))), ((int)(((byte)(168)))));
			this.picIcon.BackgroundImage = global::Stoma2.Properties.Resources.logo;
			this.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.picIcon.Location = new System.Drawing.Point(0, 0);
			this.picIcon.Name = "picIcon";
			this.picIcon.Size = new System.Drawing.Size(42, 42);
			this.picIcon.TabIndex = 3;
			this.picIcon.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(119)))), ((int)(((byte)(168)))));
			this.btnClose.BackgroundImage = global::Stoma2.Properties.Resources.close2;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
			this.btnClose.Location = new System.Drawing.Point(974, 0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(42, 42);
			this.btnClose.TabIndex = 1;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pnlContent
			// 
			this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContent.Location = new System.Drawing.Point(100, 42);
			this.pnlContent.Name = "pnlContent";
			this.pnlContent.Size = new System.Drawing.Size(916, 718);
			this.pnlContent.TabIndex = 25;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.ClientSize = new System.Drawing.Size(1016, 760);
			this.ControlBox = false;
			this.Controls.Add(this.pnlContent);
			this.Controls.Add(this.btnMaximize);
			this.Controls.Add(this.rbOther);
			this.Controls.Add(this.rbInvite);
			this.Controls.Add(this.rbTreatment);
			this.Controls.Add(this.rbAppointment);
			this.Controls.Add(this.btnMinimize);
			this.Controls.Add(this.picIcon);
			this.Controls.Add(this.lblSidePanel);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblHeader);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(900, 700);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblSidePanel;
		private System.Windows.Forms.PictureBox picIcon;
		private System.Windows.Forms.Button btnMinimize;
		private System.Windows.Forms.RadioButton rbAppointment;
		private System.Windows.Forms.RadioButton rbTreatment;
		private System.Windows.Forms.RadioButton rbInvite;
		private System.Windows.Forms.RadioButton rbOther;
		private System.Windows.Forms.Button btnMaximize;
		private System.Windows.Forms.Panel pnlContent;
	}
}

