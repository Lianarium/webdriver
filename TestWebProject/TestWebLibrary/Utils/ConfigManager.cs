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
		public static string ConfigUrl => GetConfigvalueNoDefault("startURL");
		public static string ConfigBrowser => GetConfigvalue("browser", "Chrome");
		public static string ConfigLogin => GetConfigvalue("login", "alyapine" );
		public static string ConfigPassword => GetConfigvalue("password", "3psdpsdpsd3");
	    public static string ElementTimeout => GetConfigvalue("element_timeout", "30");
	    public static string ImplicitWait => GetConfigvalue("implicit_wait", "30");
	    public static string ProjectName => GetConfigvalueNoDefault("project_name");
	    public static string ProjectIdentifier => GetConfigvalueNoDefault("project_identifier");
	    public static string IssueSubject => GetConfigvalueNoDefault("issue_subject");
		public static string SetUpLogin => GetConfigvalue("setuplogin", "false");
		 
		private static string GetConfigvalue(string key, string defaultvalue)
		 {
			  return ConfigurationSettings.AppSettings[key] ?? defaultvalue;
		 }

	    private static string GetConfigvalueNoDefault(string key)
	    {
	        return ConfigurationSettings.AppSettings[key];
	    }
    }
}
