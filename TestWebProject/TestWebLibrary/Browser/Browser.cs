using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using TestWebLibrary.Utils;

namespace TestWebLibrary.Browser
{
	public class Browser
	{

	    private static Browser currentInstance;
	    private static IWebDriver driver;
	    public static BrowserFactory.BrowserType CurrentBrowser;
	    public static int ImplicitWait;
	    public static double TimeoutForElement;
	    private static string configbrowser;

	    private Browser()
	    {
	        InitParameters();
	        driver = BrowserFactory.GetDriver(CurrentBrowser, ImplicitWait);

	    }

	    private static void InitParameters()
	    {
	        ImplicitWait = Convert.ToInt32(ConfigManager.ImplicitWait);
	        TimeoutForElement = Convert.ToDouble(ConfigManager.ElementTimeout);
	        configbrowser = ConfigManager.ConfigBrowser;
	        Enum.TryParse(configbrowser, out CurrentBrowser);
	    }

	    public static Browser Instance => currentInstance ?? (currentInstance = new Browser());
	}
}
