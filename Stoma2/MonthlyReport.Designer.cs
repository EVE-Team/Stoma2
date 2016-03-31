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
			this.listView6 = new System.Windows.Forms.ListView();
			this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// listView6
			// 
			this.listView6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView6.BackColor = System.Drawing.Color.White;
			this.listView6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView6.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader18,
            this.columnHeader19});
			this.listView6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listView6.FullRowSelect = true;
			this.listView6.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
			this.listView6.Location = new System.Drawing.Point(12, 12);
			this.listView6.Name = "listView6";
			this.listView6.Size = new System.Drawing.Size(643, 335);
			this.listView6.TabIndex = 5;
			this.listView6.UseCompatibleStateImageBehavior = false;
			this.listView6.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader18
			// 
			this.columnHeader18.Text = "ФИО";
			this.columnHeader18.Width = 286;
			// 
			// columnHeader19
			// 
			this.columnHeader19.Text = "Кол-во уникальных посетителей";
			this.columnHeader19.Width = 321;
			// 
			// MonthlyReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(667, 359);
			this.Controls.Add(this.listView6);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MonthlyReport";
			this.Text = "MonthlyReport";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView6;
		private System.Windows.Forms.ColumnHeader columnHeader18;
		private System.Windows.Forms.ColumnHeader columnHeader19;
	}
}