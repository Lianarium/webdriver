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
	public class BrowserFactory
	{

		public static Browser GetBrowser(BrowserType type)
		{
			Browser browser = null;
			switch (type)
			{
				case BrowserType.Chrome:
				{
					var service = ChromeDriverService.CreateDefaultService();
					var option = new ChromeOptions();
					option.AddArgument("disable-infobars");
					 
					break;

				}
				case BrowserType.Firefox:
				{
					var service = FirefoxDriverService.CreateDefaultService();
					var option = new FirefoxOptions();
					driver = new FirefoxDriver(service);
					break;
				}

			}

			return driver;
		}
	}
}
