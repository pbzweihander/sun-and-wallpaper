namespace sun_and_wallpaper
{
	partial class FormCoordinate
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCoordinate));
			this.TextLatitude = new System.Windows.Forms.TextBox();
			this.TextLongitude = new System.Windows.Forms.TextBox();
			this.LabelLatitude = new System.Windows.Forms.Label();
			this.LabelLongitude = new System.Windows.Forms.Label();
			this.ButtonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TextLatitude
			// 
			this.TextLatitude.Location = new System.Drawing.Point(128, 28);
			this.TextLatitude.Name = "TextLatitude";
			this.TextLatitude.Size = new System.Drawing.Size(100, 25);
			this.TextLatitude.TabIndex = 0;
			// 
			// TextLongitude
			// 
			this.TextLongitude.Location = new System.Drawing.Point(128, 59);
			this.TextLongitude.Name = "TextLongitude";
			this.TextLongitude.Size = new System.Drawing.Size(100, 25);
			this.TextLongitude.TabIndex = 1;
			// 
			// LabelLatitude
			// 
			this.LabelLatitude.Location = new System.Drawing.Point(22, 28);
			this.LabelLatitude.Name = "LabelLatitude";
			this.LabelLatitude.Size = new System.Drawing.Size(100, 25);
			this.LabelLatitude.TabIndex = 1;
			this.LabelLatitude.Text = "Latitude";
			this.LabelLatitude.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LabelLongitude
			// 
			this.LabelLongitude.Location = new System.Drawing.Point(22, 59);
			this.LabelLongitude.Name = "LabelLongitude";
			this.LabelLongitude.Size = new System.Drawing.Size(100, 25);
			this.LabelLongitude.TabIndex = 1;
			this.LabelLongitude.Text = "Longitude";
			this.LabelLongitude.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ButtonOK
			// 
			this.ButtonOK.Location = new System.Drawing.Point(234, 27);
			this.ButtonOK.Name = "ButtonOK";
			this.ButtonOK.Size = new System.Drawing.Size(90, 57);
			this.ButtonOK.TabIndex = 2;
			this.ButtonOK.Text = "OK";
			this.ButtonOK.UseVisualStyleBackColor = true;
			this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
			// 
			// FormCoordinate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 113);
			this.Controls.Add(this.ButtonOK);
			this.Controls.Add(this.LabelLongitude);
			this.Controls.Add(this.LabelLatitude);
			this.Controls.Add(this.TextLongitude);
			this.Controls.Add(this.TextLatitude);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCoordinate";
			this.Text = "Set Your Coordinate";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextLatitude;
		private System.Windows.Forms.TextBox TextLongitude;
		private System.Windows.Forms.Label LabelLatitude;
		private System.Windows.Forms.Label LabelLongitude;
		private System.Windows.Forms.Button ButtonOK;
	}
}