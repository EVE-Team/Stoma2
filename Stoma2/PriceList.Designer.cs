namespace Stoma2
{
	partial class PriceList
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
            "Анестезия",
            "150 р"}, -1);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Удаление зуба",
            "300 р"}, -1);
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Протезирование",
            "500 р"}, -1);
			this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.listView8 = new System.Windows.Forms.ListView();
			this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.button12 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// lineShape4
			// 
			this.lineShape4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lineShape4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.lineShape4.Enabled = false;
			this.lineShape4.Name = "lineShape4";
			this.lineShape4.X1 = 696;
			this.lineShape4.X2 = 810;
			this.lineShape4.Y1 = 103;
			this.lineShape4.Y2 = 103;
			// 
			// lineShape3
			// 
			this.lineShape3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lineShape3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.lineShape3.Enabled = false;
			this.lineShape3.Name = "lineShape3";
			this.lineShape3.X1 = 13;
			this.lineShape3.X2 = 685;
			this.lineShape3.Y1 = 103;
			this.lineShape3.Y2 = 103;
			// 
			// rectangleShape1
			// 
			this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
			this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.rectangleShape1.CornerRadius = 3;
			this.rectangleShape1.Enabled = false;
			this.rectangleShape1.Location = new System.Drawing.Point(13, 13);
			this.rectangleShape1.Name = "rectangleShape1";
			this.rectangleShape1.Size = new System.Drawing.Size(854, 45);
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1,
            this.lineShape3,
            this.lineShape4});
			this.shapeContainer1.Size = new System.Drawing.Size(878, 490);
			this.shapeContainer1.TabIndex = 0;
			this.shapeContainer1.TabStop = false;
			// 
			// listView8
			// 
			this.listView8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView8.BackColor = System.Drawing.Color.White;
			this.listView8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView8.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader25,
            this.columnHeader26});
			this.listView8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listView8.FullRowSelect = true;
			this.listView8.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
			this.listView8.Location = new System.Drawing.Point(13, 118);
			this.listView8.Name = "listView8";
			this.listView8.Size = new System.Drawing.Size(680, 360);
			this.listView8.TabIndex = 39;
			this.listView8.UseCompatibleStateImageBehavior = false;
			this.listView8.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader25
			// 
			this.columnHeader25.Text = "Название услуги";
			this.columnHeader25.Width = 175;
			// 
			// columnHeader26
			// 
			this.columnHeader26.Text = "Цена";
			this.columnHeader26.Width = 95;
			// 
			// textBox14
			// 
			this.textBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox14.BackColor = System.Drawing.Color.White;
			this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox14.ForeColor = System.Drawing.Color.Silver;
			this.textBox14.Location = new System.Drawing.Point(699, 73);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(125, 22);
			this.textBox14.TabIndex = 37;
			this.textBox14.Text = "Цена";
			// 
			// textBox12
			// 
			this.textBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox12.BackColor = System.Drawing.Color.White;
			this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox12.ForeColor = System.Drawing.Color.Silver;
			this.textBox12.Location = new System.Drawing.Point(13, 73);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(680, 22);
			this.textBox12.TabIndex = 36;
			this.textBox12.Text = "Введите название услуги";
			// 
			// textBox11
			// 
			this.textBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox11.ForeColor = System.Drawing.Color.Silver;
			this.textBox11.Location = new System.Drawing.Point(52, 24);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(802, 22);
			this.textBox11.TabIndex = 34;
			this.textBox11.Text = "Введите слово для поиска по категории";
			// 
			// button12
			// 
			this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
			this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
			this.button12.FlatAppearance.BorderSize = 2;
			this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button12.ForeColor = System.Drawing.Color.White;
			this.button12.Image = global::Stoma2.Properties.Resources.trash;
			this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button12.Location = new System.Drawing.Point(705, 165);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(161, 37);
			this.button12.TabIndex = 41;
			this.button12.Text = "Удалить";
			this.button12.UseVisualStyleBackColor = false;
			// 
			// button14
			// 
			this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
			this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
			this.button14.FlatAppearance.BorderSize = 2;
			this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button14.ForeColor = System.Drawing.Color.White;
			this.button14.Image = global::Stoma2.Properties.Resources.pencil;
			this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button14.Location = new System.Drawing.Point(705, 118);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(161, 37);
			this.button14.TabIndex = 40;
			this.button14.Text = "Редактировать";
			this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button14.UseVisualStyleBackColor = false;
			// 
			// button11
			// 
			this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button11.BackColor = System.Drawing.Color.White;
			this.button11.BackgroundImage = global::Stoma2.Properties.Resources.plus_s;
			this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button11.Location = new System.Drawing.Point(830, 67);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(36, 36);
			this.button11.TabIndex = 38;
			this.button11.UseVisualStyleBackColor = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.pictureBox4.BackgroundImage = global::Stoma2.Properties.Resources.search;
			this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox4.Location = new System.Drawing.Point(19, 21);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(27, 29);
			this.pictureBox4.TabIndex = 35;
			this.pictureBox4.TabStop = false;
			// 
			// PriceList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(878, 490);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.listView8);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.textBox14);
			this.Controls.Add(this.textBox12);
			this.Controls.Add(this.textBox11);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.shapeContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "PriceList";
			this.Text = "PriceList";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
		private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
		private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.ListView listView8;
		private System.Windows.Forms.ColumnHeader columnHeader25;
		private System.Windows.Forms.ColumnHeader columnHeader26;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.PictureBox pictureBox4;
	}
}