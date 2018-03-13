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
	public class Browser : IBrowser
	{

	    private static Browser currentInstance;
	    private static IWebDriver driver;
	    public static  string CurrentBrowser;
	    public static int ImplicitWait;
	    public static double TimeoutForElement;
	     
	    private Browser()
	    {
	        InitParameters();
	        CurrentBrowser = BrowserFactory.GetBrowserName();
	        driver = DriverFactory.GetDriver(CurrentBrowser, ImplicitWait);

	    }


	    public void InitParameters()
	    {
	        ImplicitWait = Convert.ToInt32(ConfigManager.ImplicitWait);
	        TimeoutForElement = Convert.ToDouble(ConfigManager.ElementTimeout);
	    }

	    IWebDriver IBrowser.GetDriver()
	    {
	        return GetDriver();
	    }


	   public  void  WindowMaximize()
	    {
			driver.Manage().Window.Maximize();
		}

	    public void NavigateTo(string url)
	    {
			driver.Navigate().GoToUrl(url);
		}

	    void IBrowser.Quit()
	    {
			driver.Quit();
		    currentInstance = null;
		}


	    public static Browser Instance => currentInstance ?? (currentInstance = new Browser());
 

	   public static IWebDriver GetDriver()//waat 
	    {
	        return driver;
	    }	  
    }
}
