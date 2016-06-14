namespace Stoma2
{
	partial class Patient
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
			this.pnlPatientInfo = new System.Windows.Forms.Panel();
			this.patientListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.toTreatmentBtn = new System.Windows.Forms.Button();
			this.searchBox = new Stoma2.SearchBar();
			this.SuspendLayout();
			// 
			// pnlPatientInfo
			// 
			this.pnlPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlPatientInfo.AutoScroll = true;
			this.pnlPatientInfo.AutoSize = true;
			this.pnlPatientInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlPatientInfo.Location = new System.Drawing.Point(401, 66);
			this.pnlPatientInfo.Name = "pnlPatientInfo";
			this.pnlPatientInfo.Size = new System.Drawing.Size(391, 397);
			this.pnlPatientInfo.TabIndex = 21;
			// 
			// patientListView
			// 
			this.patientListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.patientListView.BackColor = System.Drawing.Color.White;
			this.patientListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.patientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});

			this.patientListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.patientListView.FullRowSelect = true;
			this.patientListView.HideSelection = false;
			this.patientListView.Location = new System.Drawing.Point(10, 66);
			this.patientListView.MultiSelect = false;
			this.patientListView.Name = "patientListView";
			this.patientListView.Size = new System.Drawing.Size(381, 287);
			this.patientListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.patientListView.TabIndex = 20;
			this.patientListView.UseCompatibleStateImageBehavior = false;
			this.patientListView.View = System.Windows.Forms.View.Details;
			this.patientListView.SelectedIndexChanged += new System.EventHandler(this.patientListView_SelectedIndexChanged);
			this.patientListView.DoubleClick += new System.EventHandler(this.patientListView_DoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Фамилия";
			this.columnHeader1.Width = 170;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Имя";
			this.columnHeader2.Width = 135;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Отчество";
			this.columnHeader3.Width = 170;
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
			this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
			this.btnEdit.FlatAppearance.BorderSize = 2;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnEdit.ForeColor = System.Drawing.Color.White;
			this.btnEdit.Image = global::Stoma2.Properties.Resources.pencil;
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdit.Location = new System.Drawing.Point(10, 402);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(158, 37);
			this.btnEdit.TabIndex = 40;
			this.btnEdit.Text = "Редактировать";
			this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
			this.btnDelete.FlatAppearance.BorderSize = 2;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Image = global::Stoma2.Properties.Resources.trash;
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(10, 445);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(158, 37);
			this.btnDelete.TabIndex = 41;
			this.btnDelete.Text = "Удалить";
			this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(211)))), ((int)(((byte)(124)))));
			this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnAdd.FlatAppearance.BorderSize = 2;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Image = global::Stoma2.Properties.Resources.plus;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(10, 359);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(158, 37);
			this.btnAdd.TabIndex = 73;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
			this.button1.FlatAppearance.BorderSize = 2;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Image = global::Stoma2.Properties.Resources.pencil;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(10, 382);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(158, 37);
			this.button1.TabIndex = 40;
			this.button1.Text = "Редактировать";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// toTreatmentBtn
			// 
			this.toTreatmentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.toTreatmentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
			this.toTreatmentBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
			this.toTreatmentBtn.FlatAppearance.BorderSize = 2;
			this.toTreatmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.toTreatmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toTreatmentBtn.ForeColor = System.Drawing.Color.White;
			this.toTreatmentBtn.Image = global::Stoma2.Properties.Resources.arrow2;
			this.toTreatmentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toTreatmentBtn.Location = new System.Drawing.Point(261, 359);
			this.toTreatmentBtn.Name = "toTreatmentBtn";
			this.toTreatmentBtn.Size = new System.Drawing.Size(130, 52);
			this.toTreatmentBtn.TabIndex = 74;
			this.toTreatmentBtn.Text = "Перейти к лечению";
			this.toTreatmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toTreatmentBtn.UseVisualStyleBackColor = false;
			this.toTreatmentBtn.Click += new System.EventHandler(this.toTreatmentBtn_Click);
			// 
			// searchBox
			// 
			this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchBox.BackColor = System.Drawing.Color.White;
			this.searchBox.Location = new System.Drawing.Point(10, 12);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(782, 48);
			this.searchBox.TabIndex = 75;
			this.searchBox.ToolTip = "Введите ФИО для поиска пациента";
			this.searchBox.TooltipColor = System.Drawing.Color.Silver;
			// 
			// Patient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(804, 494);
			this.Controls.Add(this.searchBox);
			this.Controls.Add(this.toTreatmentBtn);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.pnlPatientInfo);
			this.Controls.Add(this.patientListView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Patient";
			this.Text = "Patient";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlPatientInfo;
		private System.Windows.Forms.ListView patientListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button toTreatmentBtn;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private SearchBar searchBox;
	}
}