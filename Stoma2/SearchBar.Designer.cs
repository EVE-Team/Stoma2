namespace Stoma2
{
	partial class SearchBar
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtText = new System.Windows.Forms.TextBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// txtText
			// 
			this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtText.Location = new System.Drawing.Point(36, 12);
			this.txtText.Name = "txtText";
			this.txtText.Size = new System.Drawing.Size(739, 16);
			this.txtText.TabIndex = 0;
			this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
			this.txtText.Enter += new System.EventHandler(this.txtText_Enter);
			this.txtText.Leave += new System.EventHandler(this.txtText_Leave);
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.pictureBox3.BackgroundImage = global::Stoma2.Properties.Resources.search;
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox3.Location = new System.Drawing.Point(3, 5);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(27, 29);
			this.pictureBox3.TabIndex = 20;
			this.pictureBox3.TabStop = false;
			// 
			// rectangleShape2
			// 
			this.rectangleShape2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rectangleShape2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
			this.rectangleShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.rectangleShape2.CornerRadius = 3;
			this.rectangleShape2.Enabled = false;
			this.rectangleShape2.Location = new System.Drawing.Point(1, 1);
			this.rectangleShape2.Name = "rectangleShape2";
			this.rectangleShape2.Size = new System.Drawing.Size(777, 37);
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2});
			this.shapeContainer1.Size = new System.Drawing.Size(781, 41);
			this.shapeContainer1.TabIndex = 21;
			this.shapeContainer1.TabStop = false;
			// 
			// SearchBar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.txtText);
			this.Controls.Add(this.shapeContainer1);
			this.Name = "SearchBar";
			this.Size = new System.Drawing.Size(781, 41);
			this.Resize += new System.EventHandler(this.SearchBar_Resize);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtText;
		private System.Windows.Forms.PictureBox pictureBox3;
		private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
	}
}
