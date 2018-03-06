using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TestWebLibrary.Utils;

namespace TestWebLibrary.BrowserWork
{
	public class BrowserManager
	{
	    private static BrowserType type;

		public static string GetBrowser()
		{
		    if (type.ToString() == "Chrome" || type.ToString() == "Firefox")
		        return type.ToString();
		    else
		        return ConfigManager.ConfigBrowser;
		}
	}
}
