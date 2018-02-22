using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebLibrary.PageObjects
{
	public class BasePage
	{
		private IWebDriver driver;

		public BasePage( )
		{
			 
		}

		public void isElementVisible(By element, int timeoutSecs = 10)
		{
			new WebDriverWait(this.driver, TimeSpan.FromSeconds(timeoutSecs)).Until(ExpectedConditions.ElementIsVisible(element));
		}
	}
}
