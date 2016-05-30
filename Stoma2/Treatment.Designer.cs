namespace Stoma2
{
	partial class Treatment
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
            "Пломба \"светового отверждения\" \"Витример\"",
            "1200",
            "1",
            "1200"}, -1);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Отбеливание \"Opalescence Boost\"",
            "400",
            "1",
            "400"}, -1);
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Анестезия \"Артикаин\"",
            "150",
            "1",
            "150"}, -1);
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("25.06.2016");
			this.rectangleShape6 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.costLabel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.treatmentListView = new System.Windows.Forms.ListView();
			this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.toothtextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.diagnosisTextBox = new System.Windows.Forms.TextBox();
			this.doctorTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.appointmentListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnAddAppointment = new System.Windows.Forms.Button();
			this.patientLabel = new System.Windows.Forms.Label();
			this.patientFIO = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// rectangleShape6
			// 
			this.rectangleShape6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.rectangleShape6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
			this.rectangleShape6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.rectangleShape6.CornerRadius = 3;
			this.rectangleShape6.Enabled = false;
			this.rectangleShape6.Location = new System.Drawing.Point(5, 5);
			this.rectangleShape6.Name = "rectangleShape6";
			this.rectangleShape6.Size = new System.Drawing.Size(285, 46);
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape6});
			this.shapeContainer1.Size = new System.Drawing.Size(1063, 553);
			this.shapeContainer1.TabIndex = 28;
			this.shapeContainer1.TabStop = false;
			// 
			// costLabel
			// 
			this.costLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.costLabel.Location = new System.Drawing.Point(562, 435);
			this.costLabel.Name = "costLabel";
			this.costLabel.Size = new System.Drawing.Size(179, 20);
			this.costLabel.TabIndex = 40;
			this.costLabel.Text = "1750 рублей";
			this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(558, 407);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(183, 19);
			this.label6.TabIndex = 38;
			this.label6.Text = "Общая стоимость:";
			// 
			// treatmentListView
			// 
			this.treatmentListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treatmentListView.BackColor = System.Drawing.Color.White;
			this.treatmentListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.treatmentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24});
			this.treatmentListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.treatmentListView.FullRowSelect = true;
			this.treatmentListView.HideSelection = false;
			this.treatmentListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
			this.treatmentListView.Location = new System.Drawing.Point(11, 59);
			this.treatmentListView.MultiSelect = false;
			this.treatmentListView.Name = "treatmentListView";
			this.treatmentListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.treatmentListView.Size = new System.Drawing.Size(739, 334);
			this.treatmentListView.TabIndex = 36;
			this.treatmentListView.UseCompatibleStateImageBehavior = false;
			this.treatmentListView.View = System.Windows.Forms.View.Details;
			this.treatmentListView.SelectedIndexChanged += new System.EventHandler(this.treatmentListView_SelectedIndexChanged);
			this.treatmentListView.Resize += new System.EventHandler(this.treatmentListView_Resize);
			// 
			// columnHeader21
			// 
			this.columnHeader21.Text = "Название услуги";
			this.columnHeader21.Width = 321;
			// 
			// columnHeader22
			// 
			this.columnHeader22.Text = "Стоимость";
			this.columnHeader22.Width = 88;
			// 
			// columnHeader23
			// 
			this.columnHeader23.Text = "Количество";
			this.columnHeader23.Width = 94;
			// 
			// columnHeader24
			// 
			this.columnHeader24.Text = "Итого";
			this.columnHeader24.Width = 56;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.toothtextBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.diagnosisTextBox);
			this.groupBox1.Controls.Add(this.doctorTextBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBox1.Location = new System.Drawing.Point(5, 384);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
			this.groupBox1.Size = new System.Drawing.Size(286, 156);
			this.groupBox1.TabIndex = 42;
			this.groupBox1.TabStop = false;
			// 
			// toothtextBox
			// 
			this.toothtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.toothtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.toothtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.toothtextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toothtextBox.Location = new System.Drawing.Point(12, 125);
			this.toothtextBox.Multiline = true;
			this.toothtextBox.Name = "toothtextBox";
			this.toothtextBox.ReadOnly = true;
			this.toothtextBox.Size = new System.Drawing.Size(262, 20);
			this.toothtextBox.TabIndex = 46;
			this.toothtextBox.Text = "25";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(9, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 16);
			this.label3.TabIndex = 45;
			this.label3.Text = "№ зуба:";
			// 
			// diagnosisTextBox
			// 
			this.diagnosisTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.diagnosisTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.diagnosisTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.diagnosisTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.diagnosisTextBox.Location = new System.Drawing.Point(12, 76);
			this.diagnosisTextBox.Multiline = true;
			this.diagnosisTextBox.Name = "diagnosisTextBox";
			this.diagnosisTextBox.ReadOnly = true;
			this.diagnosisTextBox.Size = new System.Drawing.Size(262, 20);
			this.diagnosisTextBox.TabIndex = 44;
			this.diagnosisTextBox.Text = "Кариес";
			// 
			// doctorTextBox
			// 
			this.doctorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.doctorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.doctorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.doctorTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.doctorTextBox.Location = new System.Drawing.Point(12, 28);
			this.doctorTextBox.Multiline = true;
			this.doctorTextBox.Name = "doctorTextBox";
			this.doctorTextBox.ReadOnly = true;
			this.doctorTextBox.Size = new System.Drawing.Size(262, 22);
			this.doctorTextBox.TabIndex = 43;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(9, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 16);
			this.label2.TabIndex = 40;
			this.label2.Text = "Диагноз:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 16);
			this.label1.TabIndex = 39;
			this.label1.Text = "Врач:";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.btnAdd);
			this.groupBox2.Controls.Add(this.costLabel);
			this.groupBox2.Controls.Add(this.btnEdit);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.btnDelete);
			this.groupBox2.Controls.Add(this.treatmentListView);
			this.groupBox2.Controls.Add(this.btnPrint);
			this.groupBox2.Location = new System.Drawing.Point(298, 1);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
			this.groupBox2.Size = new System.Drawing.Size(756, 539);
			this.groupBox2.TabIndex = 43;
			this.groupBox2.TabStop = false;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(211)))), ((int)(((byte)(124)))));
			this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Image = global::Stoma2.Properties.Resources.plus;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(11, 403);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(166, 37);
			this.btnAdd.TabIndex = 71;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
			this.btnEdit.Location = new System.Drawing.Point(11, 446);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(166, 37);
			this.btnEdit.TabIndex = 37;
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
			this.btnDelete.Location = new System.Drawing.Point(11, 489);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(166, 37);
			this.btnDelete.TabIndex = 39;
			this.btnDelete.Text = "Удалить";
			this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.btnPrint.FlatAppearance.BorderSize = 2;
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPrint.Image = global::Stoma2.Properties.Resources.print_bw;
			this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPrint.Location = new System.Drawing.Point(11, 12);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(183, 37);
			this.btnPrint.TabIndex = 27;
			this.btnPrint.Text = "Печать акта работ";
			this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPrint.UseVisualStyleBackColor = false;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// appointmentListView
			// 
			this.appointmentListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.appointmentListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.appointmentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.appointmentListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.appointmentListView.HideSelection = false;
			this.appointmentListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
			this.appointmentListView.Location = new System.Drawing.Point(5, 60);
			this.appointmentListView.MultiSelect = false;
			this.appointmentListView.Name = "appointmentListView";
			this.appointmentListView.Size = new System.Drawing.Size(286, 278);
			this.appointmentListView.TabIndex = 44;
			this.appointmentListView.UseCompatibleStateImageBehavior = false;
			this.appointmentListView.View = System.Windows.Forms.View.Details;
			this.appointmentListView.SelectedIndexChanged += new System.EventHandler(this.appointmentListView_SelectedIndexChanged);
			this.appointmentListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.appointmentListView_MouseUp);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Дата приема";
			this.columnHeader1.Width = 277;
			// 
			// btnAddAppointment
			// 
			this.btnAddAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(211)))), ((int)(((byte)(124)))));
			this.btnAddAppointment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAddAppointment.ForeColor = System.Drawing.Color.White;
			this.btnAddAppointment.Image = global::Stoma2.Properties.Resources.plus;
			this.btnAddAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddAppointment.Location = new System.Drawing.Point(5, 344);
			this.btnAddAppointment.Name = "btnAddAppointment";
			this.btnAddAppointment.Size = new System.Drawing.Size(286, 37);
			this.btnAddAppointment.TabIndex = 72;
			this.btnAddAppointment.Text = "Добавить прием";
			this.btnAddAppointment.UseVisualStyleBackColor = false;
			this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
			// 
			// patientLabel
			// 
			this.patientLabel.AutoSize = true;
			this.patientLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.patientLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.patientLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.patientLabel.Location = new System.Drawing.Point(14, 9);
			this.patientLabel.Name = "patientLabel";
			this.patientLabel.Size = new System.Drawing.Size(89, 16);
			this.patientLabel.TabIndex = 73;
			this.patientLabel.Text = "Лечение для:";
			// 
			// patientFIO
			// 
			this.patientFIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.patientFIO.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.patientFIO.Location = new System.Drawing.Point(14, 30);
			this.patientFIO.Name = "patientFIO";
			this.patientFIO.Size = new System.Drawing.Size(270, 20);
			this.patientFIO.TabIndex = 74;
			// 
			// Treatment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1063, 553);
			this.Controls.Add(this.patientFIO);
			this.Controls.Add(this.patientLabel);
			this.Controls.Add(this.btnAddAppointment);
			this.Controls.Add(this.appointmentListView);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.shapeContainer1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Treatment";
			this.Text = "Treatment";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPrint;
		private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape6;
		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private System.Windows.Forms.Label costLabel;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListView treatmentListView;
		private System.Windows.Forms.ColumnHeader columnHeader21;
		private System.Windows.Forms.ColumnHeader columnHeader22;
		private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView appointmentListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.TextBox diagnosisTextBox;
		private System.Windows.Forms.TextBox doctorTextBox;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.TextBox toothtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label patientLabel;
		private System.Windows.Forms.Label patientFIO;
	}
}