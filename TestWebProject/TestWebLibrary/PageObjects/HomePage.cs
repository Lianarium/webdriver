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
using OpenQA.Selenium.Support.PageObjects;

namespace TestWebProject
{
	public class HomePage
	{
		private IWebDriver driver;
		private string baseUrl;
		private string configValue = ConfigurationSettings.AppSettings["browser"];//exclude!
		private By projectselement = By.ClassName("projects");
		private By newprojectelement = By.LinkText("New project");

		public HomePage(IWebDriver driver)
		{
			this.driver = driver;
			this.driver.Manage().Window.Maximize();
			PageFactory.InitElements(driver, this);
		}

	}
}
 
