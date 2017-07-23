namespace sun_and_wallpaper
{
	partial class FormMain
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.noticon = new System.Windows.Forms.NotifyIcon(this.components);
			this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.DayWallpaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.daySetImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.daySetStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dayTiledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dayStretchedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dayCenteredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NightWallpaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nightSetImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nightSetStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nightTiledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nightStretchedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nightCenteredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BarToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.SetCoordinateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BarToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.QuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
			this.Tmr = new System.Windows.Forms.Timer(this.components);
			this.dayImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nightImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// noticon
			// 
			this.noticon.Icon = ((System.Drawing.Icon)(resources.GetObject("noticon.Icon")));
			this.noticon.Text = "Day and Wallpaper";
			this.noticon.Visible = true;
			// 
			// MenuStrip
			// 
			this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DayWallpaperToolStripMenuItem,
            this.NightWallpaperToolStripMenuItem,
            this.BarToolStripMenuItem1,
            this.SetCoordinateToolStripMenuItem,
            this.BarToolStripMenuItem2,
            this.QuitToolStripMenuItem});
			this.MenuStrip.Name = "menu";
			this.MenuStrip.Size = new System.Drawing.Size(191, 112);
			// 
			// DayWallpaperToolStripMenuItem
			// 
			this.DayWallpaperToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayImageToolStripMenuItem,
            this.daySetImageToolStripMenuItem,
            this.daySetStyleToolStripMenuItem});
			this.DayWallpaperToolStripMenuItem.Name = "DayWallpaperToolStripMenuItem";
			this.DayWallpaperToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
			this.DayWallpaperToolStripMenuItem.Text = "Day Wallpaper";
			// 
			// daySetImageToolStripMenuItem
			// 
			this.daySetImageToolStripMenuItem.Name = "daySetImageToolStripMenuItem";
			this.daySetImageToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.daySetImageToolStripMenuItem.Text = "Set Image";
			this.daySetImageToolStripMenuItem.Click += new System.EventHandler(this.DaySetImageToolStripMenuItem_Click);
			// 
			// daySetStyleToolStripMenuItem
			// 
			this.daySetStyleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayTiledToolStripMenuItem,
            this.dayStretchedToolStripMenuItem,
            this.dayCenteredToolStripMenuItem});
			this.daySetStyleToolStripMenuItem.Name = "daySetStyleToolStripMenuItem";
			this.daySetStyleToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.daySetStyleToolStripMenuItem.Text = "Set Style";
			// 
			// dayTiledToolStripMenuItem
			// 
			this.dayTiledToolStripMenuItem.Name = "dayTiledToolStripMenuItem";
			this.dayTiledToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
			this.dayTiledToolStripMenuItem.Text = "Tiled";
			this.dayTiledToolStripMenuItem.Click += new System.EventHandler(this.DayStyleToolStripMenuItem_Click);
			// 
			// dayStretchedToolStripMenuItem
			// 
			this.dayStretchedToolStripMenuItem.Name = "dayStretchedToolStripMenuItem";
			this.dayStretchedToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
			this.dayStretchedToolStripMenuItem.Text = "Stretched";
			this.dayStretchedToolStripMenuItem.Click += new System.EventHandler(this.DayStyleToolStripMenuItem_Click);
			// 
			// dayCenteredToolStripMenuItem
			// 
			this.dayCenteredToolStripMenuItem.Checked = true;
			this.dayCenteredToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.dayCenteredToolStripMenuItem.Name = "dayCenteredToolStripMenuItem";
			this.dayCenteredToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
			this.dayCenteredToolStripMenuItem.Text = "Centered";
			this.dayCenteredToolStripMenuItem.Click += new System.EventHandler(this.DayStyleToolStripMenuItem_Click);
			// 
			// NightWallpaperToolStripMenuItem
			// 
			this.NightWallpaperToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nightImageToolStripMenuItem,
            this.nightSetImageToolStripMenuItem,
            this.nightSetStyleToolStripMenuItem});
			this.NightWallpaperToolStripMenuItem.Name = "NightWallpaperToolStripMenuItem";
			this.NightWallpaperToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
			this.NightWallpaperToolStripMenuItem.Text = "Night Wallpaper";
			// 
			// nightSetImageToolStripMenuItem
			// 
			this.nightSetImageToolStripMenuItem.Name = "nightSetImageToolStripMenuItem";
			this.nightSetImageToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.nightSetImageToolStripMenuItem.Text = "Set Image";
			this.nightSetImageToolStripMenuItem.Click += new System.EventHandler(this.NightSetImageToolStripMenuItem_Click);
			// 
			// nightSetStyleToolStripMenuItem
			// 
			this.nightSetStyleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nightTiledToolStripMenuItem,
            this.nightStretchedToolStripMenuItem,
            this.nightCenteredToolStripMenuItem});
			this.nightSetStyleToolStripMenuItem.Name = "nightSetStyleToolStripMenuItem";
			this.nightSetStyleToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.nightSetStyleToolStripMenuItem.Text = "Set Style";
			// 
			// nightTiledToolStripMenuItem
			// 
			this.nightTiledToolStripMenuItem.Name = "nightTiledToolStripMenuItem";
			this.nightTiledToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.nightTiledToolStripMenuItem.Text = "Tiled";
			this.nightTiledToolStripMenuItem.Click += new System.EventHandler(this.NightStyleToolStripMenuItem_Click);
			// 
			// nightStretchedToolStripMenuItem
			// 
			this.nightStretchedToolStripMenuItem.Name = "nightStretchedToolStripMenuItem";
			this.nightStretchedToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.nightStretchedToolStripMenuItem.Text = "Stretched";
			this.nightStretchedToolStripMenuItem.Click += new System.EventHandler(this.NightStyleToolStripMenuItem_Click);
			// 
			// nightCenteredToolStripMenuItem
			// 
			this.nightCenteredToolStripMenuItem.Checked = true;
			this.nightCenteredToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.nightCenteredToolStripMenuItem.Name = "nightCenteredToolStripMenuItem";
			this.nightCenteredToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.nightCenteredToolStripMenuItem.Text = "Centered";
			this.nightCenteredToolStripMenuItem.Click += new System.EventHandler(this.NightStyleToolStripMenuItem_Click);
			// 
			// BarToolStripMenuItem1
			// 
			this.BarToolStripMenuItem1.Name = "BarToolStripMenuItem1";
			this.BarToolStripMenuItem1.Size = new System.Drawing.Size(187, 6);
			// 
			// SetCoordinateToolStripMenuItem
			// 
			this.SetCoordinateToolStripMenuItem.Name = "SetCoordinateToolStripMenuItem";
			this.SetCoordinateToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
			this.SetCoordinateToolStripMenuItem.Text = "Set Coordinate";
			this.SetCoordinateToolStripMenuItem.Click += new System.EventHandler(this.SetCoordinateToolStripMenuItem_Click);
			// 
			// BarToolStripMenuItem2
			// 
			this.BarToolStripMenuItem2.Name = "BarToolStripMenuItem2";
			this.BarToolStripMenuItem2.Size = new System.Drawing.Size(187, 6);
			// 
			// QuitToolStripMenuItem
			// 
			this.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
			this.QuitToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
			this.QuitToolStripMenuItem.Text = "Quit";
			this.QuitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
			// 
			// OpenDialog
			// 
			this.OpenDialog.RestoreDirectory = true;
			// 
			// Tmr
			// 
			this.Tmr.Enabled = true;
			this.Tmr.Interval = 60000;
			this.Tmr.Tick += new System.EventHandler(this.Tmr_Tick);
			// 
			// dayImageToolStripMenuItem
			// 
			this.dayImageToolStripMenuItem.Enabled = false;
			this.dayImageToolStripMenuItem.Name = "dayImageToolStripMenuItem";
			this.dayImageToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.dayImageToolStripMenuItem.Text = "image";
			// 
			// nightImageToolStripMenuItem
			// 
			this.nightImageToolStripMenuItem.Enabled = false;
			this.nightImageToolStripMenuItem.Name = "nightImageToolStripMenuItem";
			this.nightImageToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.nightImageToolStripMenuItem.Text = "image";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 253);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMain";
			this.Text = "Day and Wallpaper";
			this.MenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NotifyIcon noticon;
		private System.Windows.Forms.ContextMenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripSeparator BarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem QuitToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog OpenDialog;
		private System.Windows.Forms.ToolStripMenuItem DayWallpaperToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem daySetImageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem daySetStyleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dayTiledToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dayCenteredToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dayStretchedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem NightWallpaperToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nightSetImageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nightSetStyleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nightTiledToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nightCenteredToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nightStretchedToolStripMenuItem;
		private System.Windows.Forms.Timer Tmr;
		private System.Windows.Forms.ToolStripMenuItem SetCoordinateToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator BarToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem dayImageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nightImageToolStripMenuItem;
	}
}

