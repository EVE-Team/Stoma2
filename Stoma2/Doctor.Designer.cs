namespace Stoma2
{
	partial class Doctor
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
            "Бастраков",
            "Сергей"}, -1);
			this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox49 = new System.Windows.Forms.TextBox();
			this.textBox50 = new System.Windows.Forms.TextBox();
			this.label53 = new System.Windows.Forms.Label();
			this.label54 = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// rectangleShape4
			// 
			this.rectangleShape4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rectangleShape4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.rectangleShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
			this.rectangleShape4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.rectangleShape4.CornerRadius = 3;
			this.rectangleShape4.Enabled = false;
			this.rectangleShape4.Location = new System.Drawing.Point(13, 10);
			this.rectangleShape4.Name = "rectangleShape4";
			this.rectangleShape4.Size = new System.Drawing.Size(662, 44);
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape4});
			this.shapeContainer1.Size = new System.Drawing.Size(888, 437);
			this.shapeContainer1.TabIndex = 0;
			this.shapeContainer1.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.ForeColor = System.Drawing.Color.Silver;
			this.textBox1.Location = new System.Drawing.Point(57, 22);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(607, 22);
			this.textBox1.TabIndex = 23;
			this.textBox1.Text = "Поиск врачей";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.pictureBox2.BackgroundImage = global::Stoma2.Properties.Resources.search;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox2.Location = new System.Drawing.Point(24, 18);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(27, 29);
			this.pictureBox2.TabIndex = 24;
			this.pictureBox2.TabStop = false;
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.BackColor = System.Drawing.Color.White;
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader6});
			this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listView1.FullRowSelect = true;
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
			this.listView1.Location = new System.Drawing.Point(13, 63);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(664, 284);
			this.listView1.TabIndex = 22;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Фамилия";
			this.columnHeader3.Width = 159;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Имя";
			this.columnHeader6.Width = 112;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.textBox49);
			this.panel1.Controls.Add(this.textBox50);
			this.panel1.Controls.Add(this.label53);
			this.panel1.Controls.Add(this.label54);
			this.panel1.Location = new System.Drawing.Point(13, 355);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(664, 72);
			this.panel1.TabIndex = 28;
			// 
			// textBox49
			// 
			this.textBox49.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.textBox49.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox49.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox49.Location = new System.Drawing.Point(139, 40);
			this.textBox49.Name = "textBox49";
			this.textBox49.ReadOnly = true;
			this.textBox49.Size = new System.Drawing.Size(512, 20);
			this.textBox49.TabIndex = 15;
			this.textBox49.Text = "Ортопед";
			// 
			// textBox50
			// 
			this.textBox50.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.textBox50.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox50.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox50.Location = new System.Drawing.Point(139, 9);
			this.textBox50.Name = "textBox50";
			this.textBox50.ReadOnly = true;
			this.textBox50.Size = new System.Drawing.Size(512, 20);
			this.textBox50.TabIndex = 14;
			this.textBox50.Text = "Бастраков Сергей Геннадьевич";
			// 
			// label53
			// 
			this.label53.AutoSize = true;
			this.label53.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label53.Location = new System.Drawing.Point(8, 40);
			this.label53.Name = "label53";
			this.label53.Size = new System.Drawing.Size(120, 19);
			this.label53.TabIndex = 13;
			this.label53.Text = "Специальность";
			this.label53.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label54
			// 
			this.label54.AutoSize = true;
			this.label54.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label54.Location = new System.Drawing.Point(84, 9);
			this.label54.Name = "label54";
			this.label54.Size = new System.Drawing.Size(44, 19);
			this.label54.TabIndex = 12;
			this.label54.Text = "ФИО";
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(211)))), ((int)(((byte)(124)))));
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button8.ForeColor = System.Drawing.Color.White;
			this.button8.Image = global::Stoma2.Properties.Resources.plus;
			this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button8.Location = new System.Drawing.Point(11, 19);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(171, 37);
			this.button8.TabIndex = 29;
			this.button8.Text = "Добавить";
			this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button8.UseVisualStyleBackColor = false;
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
			this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
			this.button7.FlatAppearance.BorderSize = 2;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button7.ForeColor = System.Drawing.Color.White;
			this.button7.Image = global::Stoma2.Properties.Resources.pencil;
			this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button7.Location = new System.Drawing.Point(11, 70);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(171, 37);
			this.button7.TabIndex = 42;
			this.button7.Text = "Редактировать";
			this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button7.UseVisualStyleBackColor = false;
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
			this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
			this.button9.FlatAppearance.BorderSize = 2;
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button9.ForeColor = System.Drawing.Color.White;
			this.button9.Image = global::Stoma2.Properties.Resources.trash;
			this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button9.Location = new System.Drawing.Point(11, 121);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(171, 37);
			this.button9.TabIndex = 43;
			this.button9.Text = "Удалить ";
			this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button9.UseVisualStyleBackColor = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.button8);
			this.groupBox2.Controls.Add(this.button7);
			this.groupBox2.Controls.Add(this.button9);
			this.groupBox2.Location = new System.Drawing.Point(683, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(193, 172);
			this.groupBox2.TabIndex = 44;
			this.groupBox2.TabStop = false;
			// 
			// Doctor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(888, 437);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.shapeContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Doctor";
			this.Text = "Doctor";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox49;
        private System.Windows.Forms.TextBox textBox50;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}