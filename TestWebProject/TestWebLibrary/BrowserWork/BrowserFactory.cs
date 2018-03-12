using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TestWebLibrary.Utils;

namespace TestWebLibrary.BrowserWork
{
	public class BrowserFactory : IBrowser
	{
	    private static BrowserType type;
		 
		public static  string GetBrowserName()
		{
		    if (type.ToString() == "Chrome" || type.ToString() == "Firefox")
		        return type.ToString();
		    else
		        return ConfigManager.ConfigBrowser;
		}

	    public void InitParameters()
	    {
	        throw new NotImplementedException();
	    }

	    public IWebDriver GetDriver()
	    {
	        throw new NotImplementedException();
	    }

	    Browser IBrowser.GetBrowser()
	    {
	        return GetBrowser();
	    }

	    public void WindowMaximize()
	    {
	        throw new NotImplementedException();
	    }

	    public void NavigateTo()
	    {
	        throw new NotImplementedException();
	    }

	    public void Quit()
	    {
	        throw new NotImplementedException();
	    }

	    public static Browser GetBrowser()
		{
			return Browser.Instance;
		}
	}
}
