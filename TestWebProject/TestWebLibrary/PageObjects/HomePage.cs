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
using TestWebLibrary.Utils;

namespace TestWebProject 
{
	public class HomePage : BasePage
	{
		private IWebDriver driver;
		private By projectselement = By.ClassName("projects");
		private By newprojectelement = By.LinkText("New project");
		private By viewallissueselement = By.LinkText("View all issues");
		private By overallactivityelement = By.LinkText("Overall activity");
		private By homepagetitleframe = By.Id("content");

		public HomePage(IWebDriver driver)
		{
			this.driver = driver;
			this.driver.Manage().Window.Maximize();
			PageFactory.InitElements(driver, this);
		}

		 

		public void ClickprojectsLink()
		{
			isElementVisible(this.driver, projectselement);
			this.driver.FindElement(projectselement).Click();
		}

		public void CreateNewProject()
		{
			isElementVisible(this.driver, newprojectelement);
			this.driver.FindElement(newprojectelement).Click();
		}

		public void ViewAllIssues()
		{
			isElementVisible(this.driver, viewallissueselement);
			this.driver.FindElement(viewallissueselement).Click();
		}

		public void ViewOverallactivity()
		{
			isElementVisible(this.driver, overallactivityelement);
			this.driver.FindElement(overallactivityelement).Click();
		}

		public void ValidateHomePage()
		{

			Assert.AreEqual(this.driver.FindElement(homepagetitleframe).Text, "Home");
		}


		 
	}
}
 
