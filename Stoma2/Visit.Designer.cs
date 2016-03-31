namespace Stoma2
{
	partial class Visit
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
            "10.03.2016",
            "Галустян Михаил",
            "Кариес"}, -1);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "11.03.2016",
            "Харламов Гарик",
            "Кариес"}, -1);
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "12.03.2016",
            "Батрудинов Тимур",
            "Острый пульпит"}, -1);
			this.listView4 = new System.Windows.Forms.ListView();
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// listView4
			// 
			this.listView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView4.BackColor = System.Drawing.Color.White;
			this.listView4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader15,
            this.columnHeader16});
			this.listView4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listView4.FullRowSelect = true;
			this.listView4.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
			this.listView4.Location = new System.Drawing.Point(22, 21);
			this.listView4.Name = "listView4";
			this.listView4.Size = new System.Drawing.Size(659, 392);
			this.listView4.TabIndex = 20;
			this.listView4.UseCompatibleStateImageBehavior = false;
			this.listView4.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Дата визита";
			this.columnHeader10.Width = 168;
			// 
			// columnHeader15
			// 
			this.columnHeader15.Text = "Врач";
			this.columnHeader15.Width = 196;
			// 
			// columnHeader16
			// 
			this.columnHeader16.Text = "Диагноз";
			this.columnHeader16.Width = 199;
			// 
			// Visits
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(702, 435);
			this.Controls.Add(this.listView4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Visits";
			this.Text = "Visits";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView4;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader15;
		private System.Windows.Forms.ColumnHeader columnHeader16;
	}
}