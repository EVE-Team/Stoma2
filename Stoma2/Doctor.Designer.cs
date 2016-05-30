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
			this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.doctorListView = new System.Windows.Forms.ListView();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.addBtn = new System.Windows.Forms.Button();
			this.editBtn = new System.Windows.Forms.Button();
			this.delBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
			this.rectangleShape4.Size = new System.Drawing.Size(611, 44);
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape4});
			this.shapeContainer1.Size = new System.Drawing.Size(823, 493);
			this.shapeContainer1.TabIndex = 0;
			this.shapeContainer1.TabStop = false;
			// 
			// searchBox
			// 
			this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.searchBox.ForeColor = System.Drawing.Color.Silver;
			this.searchBox.Location = new System.Drawing.Point(57, 25);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(509, 15);
			this.searchBox.TabIndex = 23;
			this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
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
			// doctorListView
			// 
			this.doctorListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.doctorListView.BackColor = System.Drawing.Color.White;
			this.doctorListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.doctorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2});
			this.doctorListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.doctorListView.FullRowSelect = true;
			this.doctorListView.HideSelection = false;
			this.doctorListView.Location = new System.Drawing.Point(13, 63);
			this.doctorListView.MultiSelect = false;
			this.doctorListView.Name = "doctorListView";
			this.doctorListView.Size = new System.Drawing.Size(612, 418);
			this.doctorListView.TabIndex = 22;
			this.doctorListView.UseCompatibleStateImageBehavior = false;
			this.doctorListView.View = System.Windows.Forms.View.Details;
			this.doctorListView.SelectedIndexChanged += new System.EventHandler(this.doctorListView_SelectedIndexChanged);
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Фамилия";
			this.columnHeader3.Width = 103;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Имя";
			this.columnHeader6.Width = 112;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Отчество";
			this.columnHeader1.Width = 82;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Специальность";
			this.columnHeader2.Width = 117;
			// 
			// addBtn
			// 
			this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(211)))), ((int)(((byte)(124)))));
			this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.addBtn.ForeColor = System.Drawing.Color.White;
			this.addBtn.Image = global::Stoma2.Properties.Resources.plus;
			this.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addBtn.Location = new System.Drawing.Point(640, 10);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(171, 37);
			this.addBtn.TabIndex = 29;
			this.addBtn.Text = "Добавить";
			this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.addBtn.UseVisualStyleBackColor = false;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// editBtn
			// 
			this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
			this.editBtn.Enabled = false;
			this.editBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
			this.editBtn.FlatAppearance.BorderSize = 2;
			this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.editBtn.ForeColor = System.Drawing.Color.White;
			this.editBtn.Image = global::Stoma2.Properties.Resources.pencil;
			this.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.editBtn.Location = new System.Drawing.Point(640, 53);
			this.editBtn.Name = "editBtn";
			this.editBtn.Size = new System.Drawing.Size(171, 37);
			this.editBtn.TabIndex = 42;
			this.editBtn.Text = "Редактировать";
			this.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.editBtn.UseVisualStyleBackColor = false;
			this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
			// 
			// delBtn
			// 
			this.delBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.delBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
			this.delBtn.Enabled = false;
			this.delBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
			this.delBtn.FlatAppearance.BorderSize = 2;
			this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.delBtn.ForeColor = System.Drawing.Color.White;
			this.delBtn.Image = global::Stoma2.Properties.Resources.trash;
			this.delBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.delBtn.Location = new System.Drawing.Point(640, 96);
			this.delBtn.Name = "delBtn";
			this.delBtn.Size = new System.Drawing.Size(171, 37);
			this.delBtn.TabIndex = 43;
			this.delBtn.Text = "Удалить ";
			this.delBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.delBtn.UseVisualStyleBackColor = false;
			this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
			// 
			// Doctor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(823, 493);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.editBtn);
			this.Controls.Add(this.delBtn);
			this.Controls.Add(this.searchBox);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.doctorListView);
			this.Controls.Add(this.shapeContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Doctor";
			this.Text = "Doctor";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private System.Windows.Forms.TextBox searchBox;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ListView doctorListView;
		private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
		private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
	}
}