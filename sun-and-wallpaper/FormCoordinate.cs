using System;
using System.Windows.Forms;

namespace sun_and_wallpaper
{
	public partial class FormCoordinate : Form
	{
		public double lat;
		public double lng;

		public FormCoordinate(double _lat, double _lng)
		{
			InitializeComponent();

			lat = _lat;
			lng = _lng;
			TextLatitude.Text = "" + lat;
			TextLongitude.Text = "" + lng;
		}

		private void ButtonOK_Click(object sender, EventArgs e)
		{
			try
			{
				lat = Convert.ToDouble(TextLatitude.Text);
				lng = Convert.ToDouble(TextLongitude.Text);
				DialogResult = DialogResult.OK;
				Close();
			}
			catch
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
		}
	}
}
