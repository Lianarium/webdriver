using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebLibrary.PageObjects
{
	public class ActivityPage 
	{
		private IWebDriver driver;
		private string baseUrl = "http://icerow.com/activity";
		 
         
		public void GoToActivityPage()
		{
			driver.Navigate().GoToUrl(baseUrl);
		}


	}
}
