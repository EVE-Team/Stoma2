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
			this.visitListView = new System.Windows.Forms.ListView();
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.searchBox = new System.Windows.Forms.TextBox();
			this.rectangleShape6 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.btnGoToTreatment = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.SuspendLayout();
			// 
			// visitListView
			// 
			this.visitListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.visitListView.BackColor = System.Drawing.Color.White;
			this.visitListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.visitListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader15,
            this.columnHeader16});
			this.visitListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.visitListView.FullRowSelect = true;
			this.visitListView.HideSelection = false;
			this.visitListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
			this.visitListView.Location = new System.Drawing.Point(10, 72);
			this.visitListView.Name = "visitListView";
			this.visitListView.Size = new System.Drawing.Size(701, 337);
			this.visitListView.TabIndex = 20;
			this.visitListView.UseCompatibleStateImageBehavior = false;
			this.visitListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Дата визита";
			this.columnHeader10.Width = 113;
			// 
			// columnHeader15
			// 
			this.columnHeader15.Text = "Врач";
			this.columnHeader15.Width = 154;
			// 
			// columnHeader16
			// 
			this.columnHeader16.Text = "Диагноз";
			this.columnHeader16.Width = 154;
			// 
			// searchBox
			// 
			this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.searchBox.ForeColor = System.Drawing.Color.Silver;
			this.searchBox.Location = new System.Drawing.Point(53, 26);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(819, 15);
			this.searchBox.TabIndex = 32;
			this.searchBox.Text = "ФИО пациента";
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
			this.rectangleShape6.Size = new System.Drawing.Size(871, 46);
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape6});
			this.shapeContainer1.Size = new System.Drawing.Size(892, 421);
			this.shapeContainer1.TabIndex = 33;
			this.shapeContainer1.TabStop = false;
			// 
			// btnGoToTreatment
			// 
			this.btnGoToTreatment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGoToTreatment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
			this.btnGoToTreatment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
			this.btnGoToTreatment.FlatAppearance.BorderSize = 2;
			this.btnGoToTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGoToTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnGoToTreatment.ForeColor = System.Drawing.Color.White;
			this.btnGoToTreatment.Image = global::Stoma2.Properties.Resources.arrow2;
			this.btnGoToTreatment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGoToTreatment.Location = new System.Drawing.Point(721, 207);
			this.btnGoToTreatment.Name = "btnGoToTreatment";
			this.btnGoToTreatment.Size = new System.Drawing.Size(161, 77);
			this.btnGoToTreatment.TabIndex = 75;
			this.btnGoToTreatment.Text = "Перейти к выполненым работам";
			this.btnGoToTreatment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGoToTreatment.UseVisualStyleBackColor = false;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(211)))), ((int)(((byte)(124)))));
			this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Image = global::Stoma2.Properties.Resources.plus;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(721, 72);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(161, 37);
			this.btnAdd.TabIndex = 74;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
			this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
			this.btnEdit.FlatAppearance.BorderSize = 2;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnEdit.ForeColor = System.Drawing.Color.White;
			this.btnEdit.Image = global::Stoma2.Properties.Resources.pencil;
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdit.Location = new System.Drawing.Point(721, 118);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(161, 37);
			this.btnEdit.TabIndex = 72;
			this.btnEdit.Text = "Редактировать";
			this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEdit.UseVisualStyleBackColor = false;
			// 
			// btnRemove
			// 
			this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
			this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
			this.btnRemove.FlatAppearance.BorderSize = 2;
			this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnRemove.ForeColor = System.Drawing.Color.White;
			this.btnRemove.Image = global::Stoma2.Properties.Resources.trash;
			this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemove.Location = new System.Drawing.Point(721, 164);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(161, 37);
			this.btnRemove.TabIndex = 73;
			this.btnRemove.Text = "Удалить";
			this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRemove.UseVisualStyleBackColor = false;
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
			this.ClientSize = new System.Drawing.Size(892, 421);
			this.Controls.Add(this.btnGoToTreatment);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.searchBox);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.visitListView);
			this.Controls.Add(this.shapeContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Visit";
			this.Text = "Visits";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView visitListView;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader15;
		private System.Windows.Forms.ColumnHeader columnHeader16;
		private System.Windows.Forms.TextBox searchBox;
		private System.Windows.Forms.PictureBox pictureBox5;
		private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape6;
		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnGoToTreatment;
	}
}