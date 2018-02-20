using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TestWebProject
{
	public class HomePage
	{
		private IWebDriver driver;
		private string baseUrl;
		private string configValue = ConfigurationSettings.AppSettings["browser"];

		[TestInitialize]
		public void SetUp()
		{
			this.driver = driver;

			if ("ff".Equals(this.configValue))
			{
				var service = FirefoxDriverService.CreateDefaultService();
				this.driver = new FirefoxDriver(service);
			}


			else
			{
				ChromeOptions option = new ChromeOptions();
				option.AddArgument("disable-infobars");
				this.driver = new ChromeDriver(option);


			}

			this.baseUrl = "http://icerow.com/";
			this.driver.Navigate().GoToUrl(baseUrl);
			this.driver.Manage().Window.Maximize();
		}
	}
}
