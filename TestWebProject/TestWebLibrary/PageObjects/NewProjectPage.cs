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
	class NewProjectPage : BasePage
	{
		private IWebDriver driver;
		private string baseUrl = "http://icerow.com/projects/new";
		private static readonly  By namefield = By.Id("project_name");
		private By identifierfield = By.Id("project_name");
		private By createbutton;
		private By createandcontinuebutton;

		public NewProjectPage():base(namefield,"New Project Page")
		{
			 
		}

		public void GoToNewProjectPage()
		{
			driver.Navigate().GoToUrl(baseUrl);
		}

		public void EnterProjectName()
		{
			isElementVisible(this.driver, namefield);
			this.driver.FindElement(namefield).Click();
			this.driver.FindElement(namefield).SendKeys("Project1");//remove harcode!
		}

		public void EnterProjectIdentifier()
		{
			isElementVisible(this.driver, identifierfield);
			this.driver.FindElement(identifierfield).Click();
			this.driver.FindElement(identifierfield).SendKeys("some_identifier");//remove harcode!
		}


		public void Create()
		{
			isElementVisible(this.driver, createbutton);
			this.driver.FindElement(createbutton).Click();
		}

		public void CreateAndContinue()
		{
			isElementVisible(this.driver, createandcontinuebutton);
			this.driver.FindElement(createandcontinuebutton).Click();
		}

		 

		 
	}
}
