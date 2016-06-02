namespace Stoma2
{
	partial class NewAppointment
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
			this.label32 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.doctorCategory = new System.Windows.Forms.ComboBox();
			this.cmbDiagnosis = new System.Windows.Forms.ComboBox();
			this.txtTooth = new Stoma2.ValidatedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label32.Location = new System.Drawing.Point(77, 215);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(63, 16);
			this.label32.TabIndex = 39;
			this.label32.Text = "Диагноз";
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label31.Location = new System.Drawing.Point(99, 175);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(41, 16);
			this.label31.TabIndex = 38;
			this.label31.Text = "Врач";
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(211)))), ((int)(((byte)(124)))));
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Image = global::Stoma2.Properties.Resources.plus;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(12, 290);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(179, 41);
			this.btnAdd.TabIndex = 35;
			this.btnAdd.Text = "Добавить прием";
			this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
			this.btnCancel.FlatAppearance.BorderSize = 2;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Image = global::Stoma2.Properties.Resources.cancel;
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new System.Drawing.Point(383, 294);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(118, 37);
			this.btnCancel.TabIndex = 74;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::Stoma2.Properties.Resources.Teeth;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(9, -25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(510, 232);
			this.pictureBox1.TabIndex = 78;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(54, 255);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 16);
			this.label1.TabIndex = 79;
			this.label1.Text = "Номер зуба";
			// 
			// doctorCategory
			// 
			this.doctorCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.doctorCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.doctorCategory.FormattingEnabled = true;
			this.doctorCategory.Location = new System.Drawing.Point(147, 175);
			this.doctorCategory.Name = "doctorCategory";
			this.doctorCategory.Size = new System.Drawing.Size(277, 21);
			this.doctorCategory.TabIndex = 81;
			// 
			// cmbDiagnosis
			// 
			this.cmbDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbDiagnosis.FormattingEnabled = true;
			this.cmbDiagnosis.Items.AddRange(new object[] {
            "Поверхностный кариес",
            "Глубокий кариес",
            "Средний кариес",
            "Периодонтит",
            "Пульпит"});
			this.cmbDiagnosis.Location = new System.Drawing.Point(147, 213);
			this.cmbDiagnosis.Name = "cmbDiagnosis";
			this.cmbDiagnosis.Size = new System.Drawing.Size(277, 21);
			this.cmbDiagnosis.TabIndex = 82;
			this.cmbDiagnosis.SelectedIndexChanged += new System.EventHandler(this.cmbDiagnosis_SelectedIndexChanged);
			this.cmbDiagnosis.TextUpdate += new System.EventHandler(this.cmbDiagnosis_TextUpdate);
			// 
			// txtTooth
			// 
			this.txtTooth.BackColor = System.Drawing.Color.White;
			this.txtTooth.BorderColor = System.Drawing.Color.DarkGray;
			this.txtTooth.BorderWidth = 1;
			this.txtTooth.Location = new System.Drawing.Point(147, 253);
			this.txtTooth.Name = "txtTooth";
			this.txtTooth.Size = new System.Drawing.Size(277, 23);
			this.txtTooth.TabIndex = 80;
			// 
			// NewAppointment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(513, 341);
			this.Controls.Add(this.cmbDiagnosis);
			this.Controls.Add(this.doctorCategory);
			this.Controls.Add(this.txtTooth);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.label32);
			this.Controls.Add(this.label31);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.pictureBox1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "NewAppointment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Новый прием";
			this.Load += new System.EventHandler(this.NewAppointment_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.NewAppointment_Paint);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private ValidatedTextBox txtTooth;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox doctorCategory;
        private System.Windows.Forms.ComboBox cmbDiagnosis;


	}
}