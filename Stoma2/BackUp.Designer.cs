namespace Stoma2
{
	partial class BackUp
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
			this.backupListView = new System.Windows.Forms.ListView();
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.offloadBtn = new System.Windows.Forms.Button();
			this.restoreBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// backupListView
			// 
			this.backupListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.backupListView.BackColor = System.Drawing.Color.White;
			this.backupListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.backupListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader17});
			this.backupListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.backupListView.FullRowSelect = true;
			this.backupListView.HideSelection = false;
			this.backupListView.Location = new System.Drawing.Point(12, 12);
			this.backupListView.MultiSelect = false;
			this.backupListView.Name = "backupListView";
			this.backupListView.Size = new System.Drawing.Size(596, 432);
			this.backupListView.TabIndex = 6;
			this.backupListView.UseCompatibleStateImageBehavior = false;
			this.backupListView.View = System.Windows.Forms.View.Details;
			this.backupListView.SelectedIndexChanged += new System.EventHandler(this.backupListView_SelectedIndexChanged);
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Дата";
			this.columnHeader9.Width = 120;
			// 
			// columnHeader17
			// 
			this.columnHeader17.Text = "Размер";
			this.columnHeader17.Width = 132;
			// 
			// offloadBtn
			// 
			this.offloadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.offloadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.offloadBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.offloadBtn.FlatAppearance.BorderSize = 2;
			this.offloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.offloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.offloadBtn.Image = global::Stoma2.Properties.Resources.usb;
			this.offloadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.offloadBtn.Location = new System.Drawing.Point(614, 55);
			this.offloadBtn.Name = "offloadBtn";
			this.offloadBtn.Size = new System.Drawing.Size(189, 55);
			this.offloadBtn.TabIndex = 8;
			this.offloadBtn.Text = "Скопировить на внешний носитель";
			this.offloadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.offloadBtn.UseVisualStyleBackColor = false;
			// 
			// restoreBtn
			// 
			this.restoreBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.restoreBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.restoreBtn.Enabled = false;
			this.restoreBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.restoreBtn.FlatAppearance.BorderSize = 2;
			this.restoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.restoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.restoreBtn.Image = global::Stoma2.Properties.Resources.restore_16;
			this.restoreBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.restoreBtn.Location = new System.Drawing.Point(614, 12);
			this.restoreBtn.Name = "restoreBtn";
			this.restoreBtn.Size = new System.Drawing.Size(189, 37);
			this.restoreBtn.TabIndex = 7;
			this.restoreBtn.Text = "Восстановить";
			this.restoreBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.restoreBtn.UseVisualStyleBackColor = false;
			this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
			// 
			// BackUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(815, 456);
			this.Controls.Add(this.offloadBtn);
			this.Controls.Add(this.restoreBtn);
			this.Controls.Add(this.backupListView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "BackUp";
			this.Text = "BackUp";
			this.Load += new System.EventHandler(this.BackUp_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button offloadBtn;
		private System.Windows.Forms.Button restoreBtn;
		private System.Windows.Forms.ListView backupListView;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader17;
	}
}