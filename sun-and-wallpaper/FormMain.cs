using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Linq;
using System.IO;

namespace sun_and_wallpaper
{
	public partial class FormMain : Form
	{
		private string day_wallpaper = "";
		private string night_wallpaper = "";
		private Wallpaper.Style day_style = Wallpaper.Style.Centered;
		private Wallpaper.Style night_style = Wallpaper.Style.Centered;

		private double lat = 37.532600;
		private double lng = 127.024612;

		private RegistryKey settings;

		public FormMain()
		{
			InitializeComponent();

			WindowState = FormWindowState.Minimized;
			Visible = false;
			ShowInTaskbar = false;
			noticon.Visible = true;
			noticon.ContextMenuStrip = MenuStrip;

			settings = Registry.CurrentUser.OpenSubKey("Sun and Wallpaper", true);
			if (settings == null)
			{
				Registry.CurrentUser.CreateSubKey("Sun and Wallpaper");
				settings = Registry.CurrentUser.OpenSubKey("Sun and Wallpaper", true);
			}
			GetSettings();
			SetMenuChecked();
		}

		private void SetSettings()
		{
			settings.SetValue("Day Wallpaper", day_wallpaper);
			settings.SetValue("Night Wallpaper", night_wallpaper);
			switch (day_style)
			{
				case Wallpaper.Style.Centered:
					settings.SetValue("Day Wallpaper Style", "Centered");
					break;
				case Wallpaper.Style.Tiled:
					settings.SetValue("Day Wallpaper Style", "Tiled");
					break;
				case Wallpaper.Style.Stretched:
					settings.SetValue("Day Wallpaper Style", "Stretched");
					break;
			}
			switch (night_style)
			{
				case Wallpaper.Style.Centered:
					settings.SetValue("Night Wallpaper Style", "Centered");
					break;
				case Wallpaper.Style.Tiled:
					settings.SetValue("Night Wallpaper Style", "Tiled");
					break;
				case Wallpaper.Style.Stretched:
					settings.SetValue("Night Wallpaper Style", "Stretched");
					break;
			}
			settings.SetValue("Latitude", lat);
			settings.SetValue("Longitude", lng);
		}

		private void GetSettings()
		{
			day_wallpaper = (settings.GetValue("Day Wallpaper") ?? "").ToString();
			night_wallpaper = (settings.GetValue("Night Wallpaper") ?? "").ToString();
			dayImageToolStripMenuItem.Text = day_wallpaper.Split('\\').Last();
			nightImageToolStripMenuItem.Text = night_wallpaper.Split('\\').Last();
			switch ((settings.GetValue("Day Wallpaper Style") ?? "").ToString())
			{
				case "Centered":
					day_style = Wallpaper.Style.Centered;
					break;
				case "Tiled":
					day_style = Wallpaper.Style.Tiled;
					break;
				case "Stretched":
					day_style = Wallpaper.Style.Stretched;
					break;
				default:
					day_style = Wallpaper.Style.Centered;
					break;
			}
			switch ((settings.GetValue("Night Wallpaper Style") ?? "").ToString())
			{
				case "Centered":
					night_style = Wallpaper.Style.Centered;
					break;
				case "Tiled":
					night_style = Wallpaper.Style.Tiled;
					break;
				case "Stretched":
					night_style = Wallpaper.Style.Stretched;
					break;
				default:
					night_style = Wallpaper.Style.Centered;
					break;
			}
			lat = Convert.ToDouble(settings.GetValue("Latitude") ?? 37.532600);
			lng = Convert.ToDouble(settings.GetValue("Longitude") ?? 127.024612);
		}

		private void SetMenuChecked()
		{
			dayCenteredToolStripMenuItem.Checked = false;
			dayTiledToolStripMenuItem.Checked = false;
			dayStretchedToolStripMenuItem.Checked = false;
			switch (day_style)
			{
				case Wallpaper.Style.Centered:
					dayCenteredToolStripMenuItem.Checked = true;
					break;
				case Wallpaper.Style.Tiled:
					dayTiledToolStripMenuItem.Checked = true;
					break;
				case Wallpaper.Style.Stretched:
					dayStretchedToolStripMenuItem.Checked = true;
					break;
			}
			nightCenteredToolStripMenuItem.Checked = false;
			nightTiledToolStripMenuItem.Checked = false;
			nightStretchedToolStripMenuItem.Checked = false;
			switch (night_style)
			{
				case Wallpaper.Style.Centered:
					nightCenteredToolStripMenuItem.Checked = true;
					break;
				case Wallpaper.Style.Tiled:
					nightTiledToolStripMenuItem.Checked = true;
					break;
				case Wallpaper.Style.Stretched:
					nightStretchedToolStripMenuItem.Checked = true;
					break;
			}
		}

		private void GetMenuChecked()
		{
			if (dayCenteredToolStripMenuItem.Checked)
				day_style = Wallpaper.Style.Centered;
			else if (dayTiledToolStripMenuItem.Checked)
				day_style = Wallpaper.Style.Tiled;
			else
				day_style = Wallpaper.Style.Stretched;

			if (nightCenteredToolStripMenuItem.Checked)
				night_style = Wallpaper.Style.Centered;
			else if (nightTiledToolStripMenuItem.Checked)
				night_style = Wallpaper.Style.Tiled;
			else
				night_style = Wallpaper.Style.Stretched;
		}

		private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void DaySetImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (OpenDialog.ShowDialog() == DialogResult.OK)
			{
				day_wallpaper = OpenDialog.FileName;
				dayImageToolStripMenuItem.Text = day_wallpaper.Split('\\').Last();
				SetSettings();
			}
		}

		private void NightSetImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (OpenDialog.ShowDialog() == DialogResult.OK)
			{
				night_wallpaper = OpenDialog.FileName;
				nightImageToolStripMenuItem.Text = night_wallpaper.Split('\\').Last();
				SetSettings();
			}
		}

		private void CheckTime()
		{
			Sun.SunTime suntime = Sun.GetSunTime(lat, lng);
			DateTime now = DateTime.Now;
			string path = "";
			Wallpaper.Style style = Wallpaper.Style.Centered;

			if (now > suntime.sunrise && now < suntime.sunset)
			{
				path = day_wallpaper;
				style = day_style;
			}
			else
			{
				path = night_wallpaper;
				style = night_style;
			}

			if (File.Exists(path))
				Wallpaper.Set(path, style);
		}

		private void SetCoordinateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormCoordinate form = new FormCoordinate(lat, lng);
			if (form.ShowDialog() == DialogResult.OK)
			{
				lat = form.lat;
				lng = form.lng;
				CheckTime();
			}
		}

		private void DayStyleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!(sender as ToolStripMenuItem).Checked)
			{
				dayCenteredToolStripMenuItem.Checked = false;
				dayTiledToolStripMenuItem.Checked = false;
				dayStretchedToolStripMenuItem.Checked = false;
				(sender as ToolStripMenuItem).Checked = true;
				GetMenuChecked();
				SetSettings();
			}
		}

		private void NightStyleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!(sender as ToolStripMenuItem).Checked)
			{
				nightCenteredToolStripMenuItem.Checked = false;
				nightTiledToolStripMenuItem.Checked = false;
				nightStretchedToolStripMenuItem.Checked = false;
				(sender as ToolStripMenuItem).Checked = true;
				GetMenuChecked();
				SetSettings();
			}
		}

		private void Tmr_Tick(object sender, EventArgs e)
		{
			CheckTime();
		}
	}
}
