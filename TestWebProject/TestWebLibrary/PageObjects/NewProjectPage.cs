using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebLibrary.PageObjects
{
	class NewProjectPage
	{
		private IWebDriver driver;
		private string baseUrl = "http://icerow.com/projects/new";
		private By namefield = By.Id("project_name");
		private By identifierfield = By.Id("project_name");
		private By createbutton;
		private By createandcontinuebutton;

		public NewProjectPage(IWebDriver driver)
		{
			this.driver = driver;
			this.driver.Manage().Window.Maximize();
			PageFactory.InitElements(driver, this);
		}

		public void GoToNewProjectPage()
		{
			driver.Navigate().GoToUrl(baseUrl);
		}

		public void EnterProjectName()
		{
			isElementVisible(namefield);
			this.driver.FindElement(namefield).Click();
			this.driver.FindElement(namefield).SendKeys("Project1");//remove harcode!
		}

		public void EnterProjectIdentifier()
		{
			isElementVisible(identifierfield);
			this.driver.FindElement(identifierfield).Click();
			this.driver.FindElement(identifierfield).SendKeys("some_identifier");//remove harcode!
		}


		public void Create()
		{
			isElementVisible(createbutton);
			this.driver.FindElement(createbutton).Click();
		}

		public void CreateAndContinue()
		{
			isElementVisible(createandcontinuebutton);
			this.driver.FindElement(createandcontinuebutton).Click();
		}

		 

		public void isElementVisible(By element, int timeoutSecs = 10)
		{
			new WebDriverWait(this.driver, TimeSpan.FromSeconds(timeoutSecs)).Until(ExpectedConditions.ElementIsVisible(element));
		}
	}
}
