using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebLibrary.Browser
{
	class Browser
	{
		 
		private static IWebDriver driver;

		public static IWebDriver Driver
		{
			get
			{
				if (driver == null)
					throw new NullReferenceException("No browser instance exists");
				return driver;
			}
			private set
			{
				driver = value;
			}
		}

		public static void InitBrowser(string configvalue)
		{
			{ 
			}
		}

		public static void OpenUrl(string urlconfig)
		{
			 
		}

		public static void CloseDriver()
		{
			 
		}
	}
}
