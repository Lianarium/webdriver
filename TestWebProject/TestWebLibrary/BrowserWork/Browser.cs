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

namespace TestWebLibrary.BrowserWork
{
	public class Browser
	{

	    private static Browser currentInstance;
	    private static IWebDriver driver;
	    public static BrowserFactory.BrowserType CurrentBrowser;
	    public static int ImplicitWait;
	    public static double TimeoutForElement;
	    
	    private Browser()
	    {
	        InitParameters();
	        driver = BrowserFactory.GetDriver(CurrentBrowser, ImplicitWait);

	    }

	    private static void InitParameters()
	    {
	        ImplicitWait = Convert.ToInt32(ConfigManager.ImplicitWait);
	        TimeoutForElement = Convert.ToDouble(ConfigManager.ElementTimeout);
	         
	       
	    }

	    public static Browser Instance => currentInstance ?? (currentInstance = new Browser());

	    public static IWebDriver GetDriver()
	    {
	        return driver;

	    }

	    public static void WindowMaximize()
	    {
            driver.Manage().Window.Maximize();
	    }

	    public static void NavigateTo(string url)
	    {
	        driver.Navigate().GoToUrl(url);
	    }

       
	    public static void Quit()
	    {
             driver.Quit();
	         currentInstance = null;
	    }
    }
}
