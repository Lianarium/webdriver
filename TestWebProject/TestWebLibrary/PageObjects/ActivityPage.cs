using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebLibrary.PageObjects
{
	class ActivityPage
	{
		private IWebDriver driver;
		private string baseUrl = "http://icerow.com/activity";
		 

		public ActivityPage(IWebDriver driver)
		{
			this.driver = driver;
			this.driver.Manage().Window.Maximize();
			PageFactory.InitElements(driver, this);
		}

		public void GoToActivityPage()
		{
			driver.Navigate().GoToUrl(baseUrl);
		}


	}
}
