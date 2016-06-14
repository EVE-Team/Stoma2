namespace Stoma2
{
    partial class NewDoctor
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.specialityBox = new Stoma2.ValidatedTextBox();
            this.patronymicBox = new Stoma2.ValidatedTextBox();
            this.nameFirstBox = new Stoma2.ValidatedTextBox();
            this.nameLastBox = new Stoma2.ValidatedTextBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(36, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 69;
            this.label10.Text = "Отчество";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(68, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 16);
            this.label9.TabIndex = 68;
            this.label9.Text = "Имя";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(38, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 67;
            this.label8.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "Специальность";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(211)))), ((int)(((byte)(124)))));
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Image = global::Stoma2.Properties.Resources.plus;
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(12, 165);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(138, 41);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Добавить";
            this.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::Stoma2.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(245, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 39);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // specialityBox
            // 
            this.specialityBox.BackColor = System.Drawing.Color.White;
            this.specialityBox.BorderColor = System.Drawing.Color.DarkGray;
            this.specialityBox.BorderWidth = 2;
            this.specialityBox.Location = new System.Drawing.Point(109, 118);
            this.specialityBox.Name = "specialityBox";
            this.specialityBox.Size = new System.Drawing.Size(254, 23);
            this.specialityBox.TabIndex = 3;
            // 
            // patronymicBox
            // 
            this.patronymicBox.BackColor = System.Drawing.Color.White;
            this.patronymicBox.BorderColor = System.Drawing.Color.DarkGray;
            this.patronymicBox.BorderWidth = 2;
            this.patronymicBox.Location = new System.Drawing.Point(109, 80);
            this.patronymicBox.Name = "patronymicBox";
            this.patronymicBox.Size = new System.Drawing.Size(254, 23);
            this.patronymicBox.TabIndex = 2;
            // 
            // nameFirstBox
            // 
            this.nameFirstBox.BackColor = System.Drawing.Color.White;
            this.nameFirstBox.BorderColor = System.Drawing.Color.DarkGray;
            this.nameFirstBox.BorderWidth = 2;
            this.nameFirstBox.Location = new System.Drawing.Point(109, 42);
            this.nameFirstBox.Name = "nameFirstBox";
            this.nameFirstBox.Size = new System.Drawing.Size(254, 23);
            this.nameFirstBox.TabIndex = 1;
            // 
            // nameLastBox
            // 
            this.nameLastBox.BackColor = System.Drawing.Color.White;
            this.nameLastBox.BorderColor = System.Drawing.Color.DarkGray;
            this.nameLastBox.BorderWidth = 2;
            this.nameLastBox.Location = new System.Drawing.Point(109, 4);
            this.nameLastBox.Name = "nameLastBox";
            this.nameLastBox.Size = new System.Drawing.Size(254, 23);
            this.nameLastBox.TabIndex = 0;
            // 
            // NewDoctor
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(369, 218);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.specialityBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patronymicBox);
            this.Controls.Add(this.nameFirstBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nameLastBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NewDoctor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый врач";
            this.Load += new System.EventHandler(this.NewDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private ValidatedTextBox patronymicBox;
		private ValidatedTextBox nameFirstBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
		private ValidatedTextBox nameLastBox;
		private ValidatedTextBox specialityBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.Button btnCancel;
    }
}