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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Михаил Галустян",
            "15"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Гарик Харламов",
            "12"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Тимур Батурдинов",
            "10"}, -1);
            this.reportListView = new System.Windows.Forms.ListView();
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.copyToClipboardBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
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
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.reportListView.Location = new System.Drawing.Point(12, 12);
            this.reportListView.Name = "reportListView";
            this.reportListView.Size = new System.Drawing.Size(692, 271);
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
            // MonthlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(877, 295);
            this.Controls.Add(this.copyToClipboardBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.reportListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonthlyReport";
            this.Text = "MonthlyReport";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MonthlyReport_Paint);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView reportListView;
		private System.Windows.Forms.ColumnHeader columnHeader18;
		private System.Windows.Forms.ColumnHeader columnHeader19;
		private System.Windows.Forms.Button printBtn;
		private System.Windows.Forms.Button copyToClipboardBtn;
	}
}