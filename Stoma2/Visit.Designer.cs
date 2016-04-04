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
			this.textBox18 = new System.Windows.Forms.TextBox();
			this.rectangleShape6 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.button5 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
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
			this.listView4.Location = new System.Drawing.Point(10, 72);
			this.listView4.Name = "listView4";
			this.listView4.Size = new System.Drawing.Size(660, 277);
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
			// textBox18
			// 
			this.textBox18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox18.ForeColor = System.Drawing.Color.Silver;
			this.textBox18.Location = new System.Drawing.Point(53, 22);
			this.textBox18.Name = "textBox18";
			this.textBox18.Size = new System.Drawing.Size(778, 22);
			this.textBox18.TabIndex = 32;
			this.textBox18.Text = "ФИО пациента";
			// 
			// rectangleShape6
			// 
			this.rectangleShape6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rectangleShape6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.rectangleShape6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
			this.rectangleShape6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.rectangleShape6.CornerRadius = 3;
			this.rectangleShape6.Enabled = false;
			this.rectangleShape6.Location = new System.Drawing.Point(10, 10);
			this.rectangleShape6.Name = "rectangleShape6";
			this.rectangleShape6.Size = new System.Drawing.Size(830, 46);
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape6});
			this.shapeContainer1.Size = new System.Drawing.Size(851, 361);
			this.shapeContainer1.TabIndex = 33;
			this.shapeContainer1.TabStop = false;
			// 
			// button5
			// 
			this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
			this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
			this.button5.FlatAppearance.BorderSize = 2;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button5.ForeColor = System.Drawing.Color.White;
			this.button5.Image = global::Stoma2.Properties.Resources.arrow2;
			this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.Location = new System.Drawing.Point(680, 207);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(161, 77);
			this.button5.TabIndex = 75;
			this.button5.Text = "Перейти к выполненым работам";
			this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button5.UseVisualStyleBackColor = false;
			// 
			// button8
			// 
			this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(211)))), ((int)(((byte)(124)))));
			this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button8.ForeColor = System.Drawing.Color.White;
			this.button8.Image = global::Stoma2.Properties.Resources.plus;
			this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button8.Location = new System.Drawing.Point(680, 72);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(161, 37);
			this.button8.TabIndex = 74;
			this.button8.Text = "Добавить";
			this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button8.UseVisualStyleBackColor = false;
			// 
			// button7
			// 
			this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
			this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
			this.button7.FlatAppearance.BorderSize = 2;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button7.ForeColor = System.Drawing.Color.White;
			this.button7.Image = global::Stoma2.Properties.Resources.pencil;
			this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button7.Location = new System.Drawing.Point(680, 118);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(161, 37);
			this.button7.TabIndex = 72;
			this.button7.Text = "Редактировать";
			this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button7.UseVisualStyleBackColor = false;
			// 
			// button9
			// 
			this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
			this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
			this.button9.FlatAppearance.BorderSize = 2;
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button9.ForeColor = System.Drawing.Color.White;
			this.button9.Image = global::Stoma2.Properties.Resources.trash;
			this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button9.Location = new System.Drawing.Point(680, 164);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(161, 37);
			this.button9.TabIndex = 73;
			this.button9.Text = "Удалить";
			this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button9.UseVisualStyleBackColor = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.pictureBox5.BackgroundImage = global::Stoma2.Properties.Resources.search;
			this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox5.Location = new System.Drawing.Point(20, 19);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(27, 29);
			this.pictureBox5.TabIndex = 31;
			this.pictureBox5.TabStop = false;
			// 
			// Visit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(851, 361);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.textBox18);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.listView4);
			this.Controls.Add(this.shapeContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Visit";
			this.Text = "Visits";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView4;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader15;
		private System.Windows.Forms.ColumnHeader columnHeader16;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.PictureBox pictureBox5;
		private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape6;
		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button5;
	}
}