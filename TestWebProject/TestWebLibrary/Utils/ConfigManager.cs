using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestWebLibrary.Utils
{
 

    public class ConfigManager
	{
		public static string configUrl => GetConfigvalue("startURL");
		public static string configBrowser => GetConfigvalue("browser");
		public static string configLogin => GetConfigvalue("login");
		public static string configPassword => GetConfigvalue("password");


		private static string GetConfigvalue(string key)
		 {
			  return ConfigurationSettings.AppSettings[key];
		 }
	}
}
