namespace Stoma2
{
	partial class Invite
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Скаков",
            "Михаил"}, -1);
			this.lblNumberOfPatient = new System.Windows.Forms.Label();
			this.patientListView = new System.Windows.Forms.ListView();
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.btnMarkAsInvited = new System.Windows.Forms.Button();
			this.pnlPatientInfo = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// lblNumberOfPatient
			// 
			this.lblNumberOfPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNumberOfPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
			this.lblNumberOfPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblNumberOfPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(186)))), ((int)(((byte)(223)))));
			this.lblNumberOfPatient.Location = new System.Drawing.Point(20, 8);
			this.lblNumberOfPatient.Name = "lblNumberOfPatient";
			this.lblNumberOfPatient.Size = new System.Drawing.Size(754, 43);
			this.lblNumberOfPatient.TabIndex = 7;
			this.lblNumberOfPatient.Text = "3 пациента ожидают повторного приглашения";
			this.lblNumberOfPatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// patientListView
			// 
			this.patientListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.patientListView.BackColor = System.Drawing.Color.White;
			this.patientListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.patientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader27,
            this.columnHeader1,
            this.columnHeader2});
			this.patientListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.patientListView.FullRowSelect = true;
			this.patientListView.HideSelection = false;
			this.patientListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
			this.patientListView.Location = new System.Drawing.Point(12, 65);
			this.patientListView.Name = "patientListView";
			this.patientListView.Size = new System.Drawing.Size(374, 396);
			this.patientListView.TabIndex = 6;
			this.patientListView.UseCompatibleStateImageBehavior = false;
			this.patientListView.View = System.Windows.Forms.View.Details;
			this.patientListView.SelectedIndexChanged += new System.EventHandler(this.patientListView_SelectedIndexChanged);
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Фамилия";
			this.columnHeader7.Width = 100;
			// 
			// columnHeader27
			// 
			this.columnHeader27.Text = "Имя";
			this.columnHeader27.Width = 100;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Отчество";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Телефон";
			this.columnHeader2.Width = 120;
			// 
			// rectangleShape3
			// 
			this.rectangleShape3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rectangleShape3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
			this.rectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
			this.rectangleShape3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.rectangleShape3.CornerRadius = 5;
			this.rectangleShape3.Enabled = false;
			this.rectangleShape3.Location = new System.Drawing.Point(13, 4);
			this.rectangleShape3.Name = "rectangleShape3";
			this.rectangleShape3.Size = new System.Drawing.Size(767, 50);
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3});
			this.shapeContainer1.Size = new System.Drawing.Size(795, 516);
			this.shapeContainer1.TabIndex = 9;
			this.shapeContainer1.TabStop = false;
			// 
			// btnMarkAsInvited
			// 
			this.btnMarkAsInvited.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnMarkAsInvited.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(211)))), ((int)(((byte)(124)))));
			this.btnMarkAsInvited.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMarkAsInvited.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnMarkAsInvited.ForeColor = System.Drawing.Color.White;
			this.btnMarkAsInvited.Image = global::Stoma2.Properties.Resources.check__;
			this.btnMarkAsInvited.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMarkAsInvited.Location = new System.Drawing.Point(12, 467);
			this.btnMarkAsInvited.Name = "btnMarkAsInvited";
			this.btnMarkAsInvited.Size = new System.Drawing.Size(265, 37);
			this.btnMarkAsInvited.TabIndex = 26;
			this.btnMarkAsInvited.Text = "Отметить как приглашенного";
			this.btnMarkAsInvited.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnMarkAsInvited.UseVisualStyleBackColor = false;
			this.btnMarkAsInvited.Click += new System.EventHandler(this.btnMarkAsInvited_Click);
			// 
			// pnlPatientInfo
			// 
			this.pnlPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlPatientInfo.AutoSize = true;
			this.pnlPatientInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlPatientInfo.Location = new System.Drawing.Point(392, 65);
			this.pnlPatientInfo.Name = "pnlPatientInfo";
			this.pnlPatientInfo.Size = new System.Drawing.Size(391, 397);
			this.pnlPatientInfo.TabIndex = 8;
			// 
			// Invite
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(795, 516);
			this.Controls.Add(this.btnMarkAsInvited);
			this.Controls.Add(this.pnlPatientInfo);
			this.Controls.Add(this.lblNumberOfPatient);
			this.Controls.Add(this.patientListView);
			this.Controls.Add(this.shapeContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Invite";
			this.Text = "Invite";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNumberOfPatient;
		private System.Windows.Forms.ListView patientListView;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader27;
		private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private System.Windows.Forms.Button btnMarkAsInvited;
		private System.Windows.Forms.Panel pnlPatientInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
	}
}