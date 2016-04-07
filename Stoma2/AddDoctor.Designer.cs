namespace Stoma2
{
    partial class AddDoctor
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
			this.textBox22 = new System.Windows.Forms.TextBox();
			this.textBox21 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnApply = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox22
			// 
			this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox22.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox22.Location = new System.Drawing.Point(109, 80);
			this.textBox22.Name = "textBox22";
			this.textBox22.Size = new System.Drawing.Size(254, 23);
			this.textBox22.TabIndex = 71;
			// 
			// textBox21
			// 
			this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox21.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox21.Location = new System.Drawing.Point(109, 42);
			this.textBox21.Name = "textBox21";
			this.textBox21.Size = new System.Drawing.Size(254, 23);
			this.textBox21.TabIndex = 70;
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
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.ForeColor = System.Drawing.Color.Gray;
			this.textBox3.Location = new System.Drawing.Point(109, 4);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(254, 23);
			this.textBox3.TabIndex = 66;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(109, 118);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(254, 23);
			this.textBox1.TabIndex = 73;
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
			this.btnApply.Location = new System.Drawing.Point(225, 168);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(138, 41);
			this.btnApply.TabIndex = 74;
			this.btnApply.Text = "Добавить";
			this.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnApply.UseVisualStyleBackColor = false;
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			// 
			// AddDoctor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(369, 218);
			this.Controls.Add(this.btnApply);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox22);
			this.Controls.Add(this.textBox21);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "AddDoctor";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Новый врач";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnApply;
    }
}