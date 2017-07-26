using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace sun_and_wallpaper
{
	public class Sun
	{
		public struct SunTime
		{
			public DateTime sunrise;
			public DateTime sunset;
		}

		private struct SunResponse
		{
			public SunTime results;
			public string status;
		}

		public static SunTime GetSunTime(double lat, double lng)
		{
			DateTime now = DateTime.Now;
			string uri = "https://api.sunrise-sunset.org/json?lat=" + lat + "&lng=" + lng + "&date=" + string.Format("{0:yyyy-MM-dd}", now) + "&formatted=0";
			WebRequest request = WebRequest.Create(uri);
			Stream stream = request.GetResponse().GetResponseStream();
			StreamReader reader = new StreamReader(stream);
			string res = reader.ReadToEnd();

			SunResponse parsed = JsonConvert.DeserializeObject<SunResponse>(res);
			return parsed.results;
		}
	}
}
