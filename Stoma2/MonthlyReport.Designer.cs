namespace Stoma2
{
	partial class MonthlyReport
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Михаил Галустян",
            "15"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Гарик Харламов",
            "12"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Тимур Батурдинов",
            "10"}, -1);
            this.reportListView = new System.Windows.Forms.ListView();
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.copyToClipboardBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthReport = new System.Windows.Forms.RadioButton();
            this.yearReport = new System.Windows.Forms.RadioButton();
            this.changingReport = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportListView
            // 
            this.reportListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportListView.BackColor = System.Drawing.Color.White;
            this.reportListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader18,
            this.columnHeader19});
            this.reportListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportListView.FullRowSelect = true;
            this.reportListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.reportListView.Location = new System.Drawing.Point(12, 12);
            this.reportListView.Name = "reportListView";
            this.reportListView.Size = new System.Drawing.Size(605, 482);
            this.reportListView.TabIndex = 5;
            this.reportListView.UseCompatibleStateImageBehavior = false;
            this.reportListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "ФИО";
            this.columnHeader18.Width = 157;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Кол-во уникальных посетителей";
            this.columnHeader19.Width = 237;
            // 
            // copyToClipboardBtn
            // 
            this.copyToClipboardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyToClipboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.copyToClipboardBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.copyToClipboardBtn.FlatAppearance.BorderSize = 2;
            this.copyToClipboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyToClipboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyToClipboardBtn.Image = global::Stoma2.Properties.Resources.copy;
            this.copyToClipboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyToClipboardBtn.Location = new System.Drawing.Point(710, 59);
            this.copyToClipboardBtn.Name = "copyToClipboardBtn";
            this.copyToClipboardBtn.Size = new System.Drawing.Size(155, 56);
            this.copyToClipboardBtn.TabIndex = 29;
            this.copyToClipboardBtn.Text = "Скопировать в буфер обмена";
            this.copyToClipboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.copyToClipboardBtn.UseVisualStyleBackColor = false;
            // 
            // printBtn
            // 
            this.printBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.printBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.printBtn.FlatAppearance.BorderSize = 2;
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printBtn.Image = global::Stoma2.Properties.Resources.print_bw;
            this.printBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printBtn.Location = new System.Drawing.Point(710, 12);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(155, 37);
            this.printBtn.TabIndex = 28;
            this.printBtn.Text = "Печать";
            this.printBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printBtn.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(623, 198);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 22);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.changingReport);
            this.panel1.Controls.Add(this.yearReport);
            this.panel1.Controls.Add(this.monthReport);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(623, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 71);
            this.panel1.TabIndex = 31;
            // 
            // monthReport
            // 
            this.monthReport.AutoSize = true;
            this.monthReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthReport.Location = new System.Drawing.Point(4, 3);
            this.monthReport.Name = "monthReport";
            this.monthReport.Size = new System.Drawing.Size(127, 20);
            this.monthReport.TabIndex = 0;
            this.monthReport.TabStop = true;
            this.monthReport.Text = "Отчет за месяц";
            this.monthReport.UseVisualStyleBackColor = true;
            // 
            // yearReport
            // 
            this.yearReport.AutoSize = true;
            this.yearReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearReport.Location = new System.Drawing.Point(4, 26);
            this.yearReport.Name = "yearReport";
            this.yearReport.Size = new System.Drawing.Size(110, 20);
            this.yearReport.TabIndex = 1;
            this.yearReport.TabStop = true;
            this.yearReport.Text = "Отчет за год";
            this.yearReport.UseVisualStyleBackColor = true;
            // 
            // changingReport
            // 
            this.changingReport.AutoSize = true;
            this.changingReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changingReport.Location = new System.Drawing.Point(4, 49);
            this.changingReport.Name = "changingReport";
            this.changingReport.Size = new System.Drawing.Size(235, 20);
            this.changingReport.TabIndex = 2;
            this.changingReport.TabStop = true;
            this.changingReport.Text = "Отчет за произвольный период";
            this.changingReport.UseVisualStyleBackColor = true;
            this.changingReport.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Location = new System.Drawing.Point(623, 226);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(242, 22);
            this.dateTimePicker2.TabIndex = 32;
            this.dateTimePicker2.Visible = false;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(211)))), ((int)(((byte)(124)))));
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(623, 254);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(242, 37);
            this.btnReport.TabIndex = 73;
            this.btnReport.Text = "Получить отчет";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // MonthlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(877, 506);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.copyToClipboardBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.reportListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonthlyReport";
            this.Text = "MonthlyReport";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MonthlyReport_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView reportListView;
		private System.Windows.Forms.ColumnHeader columnHeader18;
		private System.Windows.Forms.ColumnHeader columnHeader19;
		private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button copyToClipboardBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton changingReport;
        private System.Windows.Forms.RadioButton yearReport;
        private System.Windows.Forms.RadioButton monthReport;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnReport;
	}
}