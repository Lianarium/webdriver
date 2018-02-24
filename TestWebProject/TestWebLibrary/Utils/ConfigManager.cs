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
		public static string ConfigUrl => GetConfigvalue("startURL");
		public static string ConfigBrowser => GetConfigvalue("browser");
		public static string ConfigLogin => GetConfigvalue("login");
		public static string ConfigPassword => GetConfigvalue("password");
	    public static string ElementTimeout => GetConfigvalue("element_timeout");
	    public static string ImplicitWait => GetConfigvalue("implicit_wait");

        private static string GetConfigvalue(string key)
		 {
			  return ConfigurationSettings.AppSettings[key];
		 }
	}
}
