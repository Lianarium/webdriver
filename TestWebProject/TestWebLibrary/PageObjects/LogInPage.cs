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
using NUnit.Framework;
using TestWebLibrary.PageObjects;

namespace TestWebProject
{
	 
	public class LogInPage 
	{
		private IWebDriver driver;
		private string baseUrl = ConfigurationSettings.AppSettings["startURL"];
		private By loginfield = By.Id("username");
		private By passwordfield = By.Id("password");
		private By loginbutton = By.Name("login");
		private By projectselement = By.ClassName("projects");
		private By newprojectelement = By.LinkText("New project");
		

		public LogInPage(IWebDriver driver) 
		{
			 
			this.driver = driver;
			this.driver.Manage().Window.Maximize();
			PageFactory.InitElements(driver, this);
		}


	
		public void GoToLogInPage()
		{
			driver.Navigate().GoToUrl(baseUrl);
		}

		public void FillLoginField(string login)
		{
			isElementVisible(loginfield);
			this.driver.FindElement(loginfield).Click(); 
			this.driver.FindElement(loginfield).SendKeys("alyapine");//remove harcode!
		}

		public void FillPasswordField(string password)
		{
			isElementVisible(passwordfield);
			this.driver.FindElement(passwordfield).Click(); 
			this.driver.FindElement(passwordfield).SendKeys("3psdpsdpsd3");//remove harcode!
		}

		public void ClickToLogIn()
		{
			isElementVisible(loginbutton);
			this.driver.FindElement(loginbutton).Click();
		 
		}

		

		public void isElementVisible(By element, int timeoutSecs = 10)
		{
			new WebDriverWait(this.driver, TimeSpan.FromSeconds(timeoutSecs)).Until(ExpectedConditions.ElementIsVisible(element));
		}
	}
}
